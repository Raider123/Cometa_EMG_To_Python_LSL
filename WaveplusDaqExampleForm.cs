
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Waveplus.DaqSys;
using Waveplus.DaqSys.Definitions;
using Waveplus.DaqSysInterface;
using WaveplusLab.Shared.Definitions;

namespace Waveplus.DaqExample
{
    public partial class WaveplusDaqExampleForm : Form
    {
        internal readonly IDaqSystem _daqSystem;
        private bool _isFirstIdleState;
        private int _acquiredSamplesPerChannel;
        private int _importedTrials;
        private CaptureAndSensorConfigForm _captureAndSensorsConfigForm;
        private int _installedSensor;

        readonly Label [] _sensorNumberLabels;
        readonly ProgressBar[] _sensorBatteryLevelBars;

        public WaveplusDaqExampleForm()
        {
            InitializeComponent();

            _isFirstIdleState = true;
            _installedSensor = 0;
            // Create sensor status controls
            _sensorNumberLabels = new Label[DeviceConstant.MAX_SENSORS_NUM];
            _sensorBatteryLevelBars = new ProgressBar[DeviceConstant.MAX_SENSORS_NUM];

            // Create sensor battery level status controls
            const int startY = 5;
            const int deltaY = 20;
            for (var a = 0; a < DeviceConstant.MAX_SENSORS_NUM; a++)
            {
                SensorStatePanel.Controls.Add(_sensorNumberLabels[a] = new Label
                {
                    Visible = true,
                    AutoSize = false,
                    Size = new Size(19, 13),
                    Location = new Point(6, startY + a * deltaY),
                    Text = (a + 1).ToString(),
                    Enabled = true
                });
                SensorStatePanel.Controls.Add(_sensorBatteryLevelBars[a] = new ProgressBar
                {
                    Visible = true,
                    AutoSize = false,
                    Size = new Size(34, 10),
                    Location = new Point(31, startY + 2 + a * deltaY),
                    Text = (a + 1).ToString(),
                    Maximum = 3,
                    Step = 1,
                    ForeColor = Color.LimeGreen,
                    Value = 0,
                    Enabled = true
                });
            }
            // Set DataAvailableEvent period
            comboBoxDataAvailableEventPeriod.Items.AddRange((Enum.GetNames(typeof(DataAvailableEventPeriod))));
            // DataAvailableEvent period
            comboBoxDataAvailableEventPeriod.SelectedIndex = comboBoxDataAvailableEventPeriod.FindStringExact(DataAvailableEventPeriod.ms_10.ToString());
            // Add RF channel items
            ChangeMasterRFChannelNewComboBox.Items.AddRange((Enum.GetNames(typeof(RFChannel))));
            // Select RF channel
            ChangeMasterRFChannelNewComboBox.SelectedIndex = ChangeMasterRFChannelNewComboBox.FindStringExact(RFChannel.RFChannel_0.ToString());
           
            try
            {
                // Create _daqSystem object and assign the event handlers
                _daqSystem = new DaqSystem();
                _daqSystem.StateChanged += Device_StateChanged;
                _daqSystem.DataAvailable += Capture_DataAvailable;
                _daqSystem.SensorMemoryDataAvailable += SensorMemory_DataAvailable; 
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
            finally
            {
                // Show device state
                ShowDeviceState(_daqSystem.State);
                DisplayErrorOccurred(_daqSystem.InitialError);
            }


        }

        private void DaqToolForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Remove the event handlers from _daqSystem object and dispose it
            _daqSystem.StateChanged -= Device_StateChanged;
            _daqSystem.DataAvailable -= Capture_DataAvailable;
            _daqSystem.SensorMemoryDataAvailable -= SensorMemory_DataAvailable;
            Application.DoEvents();
            _daqSystem.Dispose();
        }

        void Device_StateChanged(object sender, DeviceStateChangedEventArgs e)
        {
            if (InvokeRequired)
            {
                MethodInvoker invoke = () => Device_StateChanged(sender, e);
                Invoke(invoke);
                return;
            }
            // Show the new device state
            ShowDeviceState(e.State);
        }


        protected string ShowDeviceState(DeviceState newState)
        {
            // Update the GUI state according to the new device state
            switch (newState)
            {
                case DeviceState.Idle:
                    //Capture controls
                    StartCaptureButton.Enabled = true;
                    StopCaptureButton.Enabled = false;
                    CaptureGroupBox.Enabled = true;
                    GenerateStartTriggerButton.Enabled = false;
                    GenerateStopTriggerButton.Enabled = false;
                    CaptureGroupBox.Enabled = true;
                    //Capture and Sensors configuration controls
                    CaptionAndSensorsConfigurationGroupBox.Enabled = true;
                    //Device controls
                    DeviceGroupBox.Enabled = true;
                    if (_isFirstIdleState)
                    {
                        // Every time the device is connected 
                        getInstalledSensors();
                        getInstalledFootSwSensors();
                        getHardwareVersion();
                        getFirmwareVersion();
                        getSoftwareVersion();
                        getMasterDeviceRFChannel();
                        // Remote recording enable button
                        MemoryModeEnableCheckBox.Checked = false;
                        _isFirstIdleState = false;
                    }
                    // Change RF channel controls
                    ChangeMasterRFChannelGroupBox.Enabled = true;
                    //Importing from memory controls
                    MemoryStartImportingButton.Enabled = true;
                    MemoryStopImportingButton.Enabled = false;
                    GetMemoryStatusButton.Enabled = true;
                    MemoryClearButton.Enabled = true;
                    SensorMemoryGroupBox.Enabled = true;
                    // Remote recording group
                    RemoteRecordingGroupBox.Enabled = true;
                    break;
                case DeviceState.Capturing:
                    //Capture controls
                    StartCaptureButton.Enabled = false;
                    StopCaptureButton.Enabled = true;
                    CaptureGroupBox.Enabled = true;
                    GenerateStartTriggerButton.Enabled = true;
                    GenerateStopTriggerButton.Enabled = true;
                    CaptureGroupBox.Enabled = true;
                    //Capture configuration controls
                    CaptionAndSensorsConfigurationGroupBox.Enabled = false;
                    //Device controls
                    DeviceGroupBox.Enabled = false;
                    // Change RF channel controls
                    ChangeMasterRFChannelGroupBox.Enabled = false;
                    // Sensor memory controls
                    SensorMemoryGroupBox.Enabled = false;
                    // Remote recording group
                    RemoteRecordingGroupBox.Enabled = false;
                    break;

                case DeviceState.ReadingSensorMemory:
                    //Importing from memory controls
                    MemoryStartImportingButton.Enabled = false;
                    MemoryStopImportingButton.Enabled = true;
                    GetMemoryStatusButton.Enabled = false;
                    MemoryClearButton.Enabled = false;
                    SensorMemoryGroupBox.Enabled = true;
                    // Capture controls
                    CaptureGroupBox.Enabled = false;
                    //Capture configuration controls
                    CaptionAndSensorsConfigurationGroupBox.Enabled = false;
                    //Device controls
                    DeviceGroupBox.Enabled = false;
                    // Change RF channel controls
                    ChangeMasterRFChannelGroupBox.Enabled = false;
                    // Capture controls
                    CaptureGroupBox.Enabled = false;
                    // Remote recording group
                    RemoteRecordingGroupBox.Enabled = false;
                    break;

                case DeviceState.NotConnected:
                    //Capture controls
                    CaptureGroupBox.Enabled = false;
                    //Capture configuration controls
                    CaptionAndSensorsConfigurationGroupBox.Enabled = false;
                    //Device controls
                    DeviceGroupBox.Enabled = false;
                    _isFirstIdleState = true;
                    _installedSensor = 0;
                    //Reset the controls
                    FwVersionTextBox.Text = "";
                    HwVersionTextBox.Text = "";
                    ErrorMessageTextBox.Text = "";
                    InstalledSensorsTextBox.Text = "";
                    InstalledFootSwSensorsTextBox.Text = "";
                    ChangeMasterRFChannelCurrentTextBox.Text = "";
                    // Change RF channel controls
                    ChangeMasterRFChannelGroupBox.Enabled = false;
                    // Sensor memory controls
                    SensorMemoryGroupBox.Enabled = false;
                    // Remote recording group
                    RemoteRecordingGroupBox.Enabled = false;
                    break;
                case DeviceState.CommunicationError:
                    //Capture controls
                    CaptureGroupBox.Enabled = false;
                    //Capture configuration controls
                    CaptionAndSensorsConfigurationGroupBox.Enabled = false;
                    //Device controls
                    DeviceGroupBox.Enabled = false;
                    // Change RF channel controls
                    ChangeMasterRFChannelGroupBox.Enabled = false;
                    // Sensor memory controls
                    SensorMemoryGroupBox.Enabled = false;
                    // Remote recording group
                    RemoteRecordingGroupBox.Enabled = false;
                    break;
                case DeviceState.InitializingError:
                    //Capture controls
                    CaptureGroupBox.Enabled = false;
                    //Capture configuration controls
                    CaptionAndSensorsConfigurationGroupBox.Enabled = false;
                    //Device controls
                    DeviceGroupBox.Enabled = true;
                    //Get hardware, firmware and software versions
                    getHardwareVersion();
                    getFirmwareVersion();
                    getSoftwareVersion();
                    // Change RF channel controls
                    ChangeMasterRFChannelGroupBox.Enabled = false;
                    // Sensor memory controls
                    SensorMemoryGroupBox.Enabled = false;
                    // Remote recording group
                    RemoteRecordingGroupBox.Enabled = false;
                    break;
                case DeviceState.UpdatingFirmware:
                    //Capture controls
                    CaptureGroupBox.Enabled = false;
                    //Capture configuration controls
                    CaptionAndSensorsConfigurationGroupBox.Enabled = false;
                    //Device controls
                    DeviceGroupBox.Enabled = false;
                    // Change RF channel controls
                    ChangeMasterRFChannelGroupBox.Enabled = false;
                    // Sensor memory controls
                    SensorMemoryGroupBox.Enabled = false;
                    // Remote recording group
                    RemoteRecordingGroupBox.Enabled = false;
                    break;
                case DeviceState.Initializing:
                    //Capture controls
                    CaptureGroupBox.Enabled = false;
                    //Capture configuration controls
                    CaptionAndSensorsConfigurationGroupBox.Enabled = false;
                    //Device controls
                    DeviceGroupBox.Enabled = false;
                    // Change RF channel controls
                    ChangeMasterRFChannelGroupBox.Enabled = false;
                    // Sensor memory controls
                    SensorMemoryGroupBox.Enabled = false;
                    // Remote recording group
                    RemoteRecordingGroupBox.Enabled = false;
                    break;
            }
            return DeviceStatusTextBox.Text = newState.ToString();
        }

        private void DisplayErrorOccurred(DeviceError error)
        {
            // Display device error code
            ErrorMessageTextBox.Text = error.ToString();
        }

        void Capture_DataAvailable(object sender, DataAvailableEventArgs e)
        {
            if (InvokeRequired)
            {
                MethodInvoker invoke = () => Capture_DataAvailable(sender, e);
                Invoke(invoke);
                return;
            }

            // The following data are available:

            // Scansion number:
            // e.ScanNumber             Samples per channel (data-scansion number)

            // Data buffers:
            // e.Samples                EMG samples
            // e.AccelerometerSamples   Accelerometer samples or IMU Accelerometer samples (available if it is an IMU raw data or IMU mixed data acquisition)
            // e.GyroscopeSamples       Gyroscope samples (available if it is an IMU raw data or IMU mixed data acquisition)
            // e.MagnetometerSamples    Magnetometer samples (available if it is an IMU raw data or IMU mixed data acquisition)
            // e.ImuSamples             Quaternions (available if it is an IMU fused data or IMU mixed data acquisition)
            // e.FootSwSamples          Foot-Sw samples
            // e.FootSwRawSamples       Foot-Sw raw samples
             
            // All the buffers store the same number of data-scansion
            // A sample in the buffer is significative if the corresponding sensor is enabled and the sensor type is properly configured

            // Triggers:
            //  e.StartTriggerDetected  True if start trigger was detected    
            //  e.StartTriggerScan      Number of the scansion corresponding to the start trigger detection   
            //  e.StopTriggerDetected   True if stop trigger was detected  
            //  e.StopTriggerScan       Number of the scansion corresponding to the stop trigger detection  
            
            // States:
            //  e.SensorStates          Sensor state (battery level). It is not available for inertial sensor if fused data capturing is enabled
            //  e.FootSwSensorStates    FootSw sensor state (battery level)

            // Show acquired samples per channel
            _acquiredSamplesPerChannel += e.ScanNumber;
            AcquiredSamplesPerChannelTextBox.Text = _acquiredSamplesPerChannel.ToString();

            // Show triggers status
            if (e.StartTriggerDetected)
            {
                StartTriggerDetectedCheckBox.Checked = true;
                StartTriggerScanTextBox.Text = e.StartTriggerScan.ToString();
            }
            if (e.StopTriggerDetected)
            {

                StopTriggerDetectedCheckBox.Checked = true;
                StopTriggerScanTextBox.Text = e.StopTriggerScan.ToString();
            }

            byte state;
            // Show the sensors state (battery level)
            for (var c = 0; c < _installedSensor; c++)
            {
                // The battery level is not available for IMU sensors if fused-data acquisition is enabled
                state = (byte)(e.SensorStates[c, 0] & 0x03);
                _sensorBatteryLevelBars[c].Value = state;
            }

            // Show the FootSw sensors state (battery level)
            state = (byte)(e.FootSwSensorStates[0, 0] & 0x03);
            FswABatteryLevelProgressBar.Value = state;
            state = (byte)(e.FootSwSensorStates[1, 0] & 0x03);
            FswBBatteryLevelProgressBar.Value = state;

            // Method by Raid Dokhan
            store_emg_samples(e);
        }

 

        // Store the values of all emg_channels
        public double[] rec_emg_samples = new double[DeviceConstant.MAX_SENSORS_NUM];
        public void store_emg_samples(DataAvailableEventArgs e)
        {
            // The samples are expressed in [uV] unit

            //Experimental (multiple Sensors)
            for (var c = 0; c < 16; c++)
            {
                rec_emg_samples[c] = e.Samples[c, e.ScanNumber - 1];
            }
        }

        public void SensorMemory_DataAvailable(object sender, SensorMemoryDataAvailableEventArgs e)
        {
            if (InvokeRequired)
            {
                MethodInvoker invoke = () => SensorMemory_DataAvailable(sender, e);
                Invoke(invoke);
                return;
            }

            // The following data are available:

            // Scansion number:
            // e.SamplesNumber                  Samples per channel (data-scansion number)

            // Data buffers:
            // e.Samples                        EMG samples
            // e.AccelerometerSamples           Accelerometer samples or IMU Accelerometer samples (available if it is an IMU raw data or IMU mixed data acquisition)
            // e.GyroscopeSamples               Gyroscope samples (available if it is an IMU raw data or IMU mixed data acquisition)
            // e.MagnetometerSamples            Magnetometer samples (available if it is an IMU raw data or IMU mixed data acquisition)
            // e.ImuSamples                     Quaternions (available if it is an IMU fused data or IMU mixed data acquisition)
            // e.FootSwSamples                  Foot-Sw samples
            // e.FootSwRawSamples               Foot-Sw raw samples

            // All the buffers store the same number of data-scansion
            // A sample in the buffer is significative if the corresponding sensor is enabled and the sensor type is properly configured

            // e.SavedTrialsNumber              Number of trials saved in the sensor memory
            // e.TransferredSamplesInPercent    Imported samples in percent
            // e.TrialEnd                       True if all the samples of the current trial have been imported

            // States:
            //  e.SensorStates                  Sensor state (battery level). It is not available for inertial sensor if fused data capturing is enabled
            //  e.FootSwSensorStates            FootSw sensor state (battery level)

            // Show acquired samples per channel
            _acquiredSamplesPerChannel += e.SamplesNumber;
            ImportedSamplesPerChannelTextBox.Text = _acquiredSamplesPerChannel.ToString();

            // Show importing process progress
            MemoryImportingProgressBar.Value = e.TransferredSamplesInPercent <= MemoryImportingProgressBar.Maximum ? e.TransferredSamplesInPercent : MemoryImportingProgressBar.Maximum;

            // Check if the current trial has been completely imported
            if (e.TrialEnd)
            {
                _importedTrials++;
                ImportedTrialsTextBox.Text = _importedTrials.ToString();
            }

            // Show the sensors state (battery level)
            byte state;
            for (var c = 0; c < _installedSensor; c++)
            {
                // The battery level is not available for IMU sensors if fused-data acquisition is enabled
                state = (byte)(e.SensorStates[c, 0] & 0x03);
                _sensorBatteryLevelBars[c].Value = state;
            }

            // Show the FootSw sensors state (battery level)
            state = (byte)(e.FootSwSensorStates[0, 0] & 0x03);
            FswABatteryLevelProgressBar.Value = state;
            state = (byte)(e.FootSwSensorStates[1, 0] & 0x03);
            FswBBatteryLevelProgressBar.Value = state;
        }

        private void getFirmwareVersion()
        {
            try
            {
                var versionList = _daqSystem.FirmwareVersion;
                // Clear firmware version controls
                FwVersionTextBox.Text = "";
                // Get device firmware version
                foreach (var version in versionList)
                {
                    FwVersionTextBox.Text = FwVersionTextBox.Text + version.Major + "." + version.Minor + "    ";
                }
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }

        private void getHardwareVersion()
        {
            try
            {
                var versionList = _daqSystem.HardwareVersion;
                // Clear Hw version controls
                HwVersionTextBox.Text = "";
                // Get device Hw version
                foreach (var version in versionList)
                {
                    HwVersionTextBox.Text = HwVersionTextBox.Text + version.Major + "." + version.Minor + "    ";
                }
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }

        private void getSoftwareVersion()
        {
            try
            {
                var version = _daqSystem.SoftwareVersion;
                // Get device Sw version
                SwVersionTextBox.Text = version.Major + "." + version.Minor + "." + version.Build + "." + version.Revision;
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }

        private void getInstalledSensors()
        {
            try
            {
                // Get installed sensors number
                _installedSensor = _daqSystem.InstalledSensors;
                InstalledSensorsTextBox.Text = _installedSensor.ToString();

                // Set sensors state controls visibility
                for (var c = 0; c < DeviceConstant.MAX_SENSORS_NUM; c++)
                {
                    _sensorBatteryLevelBars[c].Visible = c < _installedSensor;
                    _sensorNumberLabels[c].Visible = c < _installedSensor;
                }
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }

        private void getInstalledFootSwSensors()
        {
            try
            {
                // Get installed footSw sensors number
                InstalledFootSwSensorsTextBox.Text = _daqSystem.InstalledFootSwSensors.ToString();
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }

        private void BtnConfigureCaptureAndSensors_Click(object sender, EventArgs e)
        {
            try
            {
                // Create and show the "Capture and Sensors Configuration" form
                _captureAndSensorsConfigForm = new CaptureAndSensorConfigForm(_daqSystem);
                _daqSystem.StateChanged += _captureAndSensorsConfigForm.Device_StateChanged;
                _captureAndSensorsConfigForm.Show();
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }

        public void StartCaptureButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Configure sensor 1 as Inertial sensor (accelerometer full scale = 8g; gyroscope full scale = 2000dps)
                ISensorConfiguration sensorConfiguration = new SensorConfiguration
                {
                    SensorType = SensorType.INERTIAL_SENSOR,
                    AccelerometerFullScale = AccelerometerFullScale.g_8,
                    GyroscopeFullScale = GyroscopeFullScale.dps_2000
                };
                _daqSystem.ConfigureSensor(sensorConfiguration, 1);

                // Configure sensors 2, 3 and from 4 to _installedSensor as EMG sensors (accelerometer full scale = 2g)
                sensorConfiguration.SensorType = SensorType.EMG_SENSOR;
                sensorConfiguration.AccelerometerFullScale = AccelerometerFullScale.g_2;
                _daqSystem.ConfigureSensor(sensorConfiguration, 2);
                _daqSystem.ConfigureSensor(sensorConfiguration, 3);
                for (var c = 4; c <= _installedSensor; c++)
                    _daqSystem.ConfigureSensor(sensorConfiguration, c);

                StartTriggerDetectedCheckBox.Checked = false;
                StartTriggerScanTextBox.Text = "";
                StopTriggerDetectedCheckBox.Checked = false;
                StopTriggerScanTextBox.Text = "";
                _acquiredSamplesPerChannel = 0;

                // Get DataAvailableEvent period
                var dataAvailableEventPeriod = ((DataAvailableEventPeriod)Enum.Parse(typeof(DataAvailableEventPeriod), comboBoxDataAvailableEventPeriod.SelectedIndex.ToString()));
                // Start data acquisition
                _daqSystem.StartCapturing(dataAvailableEventPeriod);
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }


        public void StopCaptureButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Stop data capture process
                _daqSystem.StopCapturing();
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }

        private void GenerateStartTriggerButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Generate start trigger by software 
                _daqSystem.GenerateInternalStartTrigger();
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }

        private void GenerateStopTriggerButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Generate stop trigger by software 
                _daqSystem.GenerateInternalStopTrigger();
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }

        private void DetectAccelerometerOffsetButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Detect and hardware-compensate the selected accelerometer offset
                _daqSystem.DetectAccelerometerOffset((int)SensorSelectionNumericUpDown.Value);
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }

        private void FirmwareVersionButton_Click(object sender, EventArgs e)
        {
            // Get device firmware version
            getFirmwareVersion();
        }

        private void HardwareVersionButton_Click(object sender, EventArgs e)
        {
            // Get device hardware version
            getHardwareVersion();
        }

        private void SoftwareVersionButton_Click(object sender, EventArgs e)
        {
            // Get Daq software version
            getSoftwareVersion();
        }

        private void GetInstalledSensorsButton_Click(object sender, EventArgs e)
        {
            // Get the device installed sensors number
            getInstalledSensors();
        }

        private void GetInstalledFootSwSensorsButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get installed sensors number
                InstalledSensorsTextBox.Text = _daqSystem.InstalledSensors.ToString();
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }

        private void CalibrateImuSensorOffsetButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Calibrate the selected Imu sensor offset
                _daqSystem.CalibrateSensorImuOffset((int)SensorSelectionNumericUpDown.Value);
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }

        private void ChangeRFChannelReadDeviceCurrentButton_Click(object sender, EventArgs e)
        {
            // Get master device RF channel
            getMasterDeviceRFChannel();
        }

        private void getMasterDeviceRFChannel()
        {
            // Get master device RF channel
            var rfChannel = _daqSystem.DeviceRFChannel(0);
            ChangeMasterRFChannelCurrentTextBox.Text = rfChannel.ToString();
        }
        private void ChangeRFChannelChangeSensorsButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                // Set RF channel of all the master device sensors
                var rfChannel = ((RFChannel)Enum.Parse(typeof(RFChannel), ChangeMasterRFChannelNewComboBox.SelectedIndex.ToString()));
                _daqSystem.ChangeSensorsRFChannel(rfChannel, 0);
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }

        private void ChangeMasterRFChannelChangeDeviceButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                // Set RF channel of RX master device
                var rfChannel = ((RFChannel)Enum.Parse(typeof(RFChannel), ChangeMasterRFChannelNewComboBox.SelectedIndex.ToString()));
                _daqSystem.ChangeDeviceRFChannel(rfChannel, 0);
                // The Receiver must be restarted 
                MessageBox.Show("Restart the Receiver for the changes to take effect");
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void MemoryModeEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if(MemoryModeEnableCheckBox.Checked)
                {
                    CaptureGroupBox.Enabled = false;
                    SensorMemoryGroupBox.Enabled = false;
                    Application.DoEvents();
                    // Put the sensors and the receiver in memory mode
                    _daqSystem.EnableSensorMemoryMode();
                    RemoteRecordingPanel.Enabled = true;
                }
                else
                {
                    CaptureGroupBox.Enabled = true;
                    SensorMemoryGroupBox.Enabled = true;
                    RemoteRecordingPanel.Enabled = false;
                    Application.DoEvents();
                    // Disable sensor memory mode
                    _daqSystem.DisableSensorMemoryMode();
                    Thread.Sleep(3000);
                }
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void StartRemoteRecordingButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_daqSystem.State != DeviceState.NotConnected)
                {
                    Cursor = Cursors.WaitCursor;
                    // Start sensor memory recording
                    _daqSystem.StartSensorMemoryRecording(1);
                    Cursor = Cursors.Default;
                    Thread.Sleep(200);
                }
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void StopRemoteRecordingButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_daqSystem.State != DeviceState.NotConnected)
                {
                    Cursor = Cursors.WaitCursor;
                    // Stop sensor memory recording
                    _daqSystem.StopSensorMemoryRecording();
                    Cursor = Cursors.Default;
                    Thread.Sleep(200);
                }
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void GetMemoryStatusButton_Click(object sender, EventArgs e)
        {
            if (_daqSystem.State != DeviceState.NotConnected)
            {
                // Get and show sensor memory status
                var sensorMemoryStatus = _daqSystem.SensorsMemoryStatus();
                if (sensorMemoryStatus != null)
                {
                    MemoryTrialsNumberTextBox.Text = sensorMemoryStatus.SavedTrialsNumber.ToString();
                    MemoryUsedSpaceTextBox.Text = sensorMemoryStatus.UsedMemorySpaceInPercent.ToString();
                    MemoryAvailableTimeTextBox.Text = (sensorMemoryStatus.ResidualRecTime_sec / 60).ToString();
                }
            }
        }

        private void MemoryClearButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_daqSystem.State != DeviceState.NotConnected)
                {
                    Cursor = Cursors.WaitCursor;
                    // Clear all sensors memory
                    _daqSystem.ClearSensorMemory(0);
                }
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void MemoryStopImportingButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                // Stop sensor memory reading
                if (_daqSystem.State == DeviceState.ReadingSensorMemory)
                {
                    _daqSystem.StopSensorMemoryReading();
                }
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void MemoryStartImportingButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Configure sensor 1 as Inertial sensor (accelerometer full scale = 8g; gyroscope full scale = 2000dps)
                ISensorConfiguration sensorConfiguration = new SensorConfiguration
                {
                    SensorType = SensorType.INERTIAL_SENSOR,
                    AccelerometerFullScale = AccelerometerFullScale.g_8,
                    GyroscopeFullScale = GyroscopeFullScale.dps_2000
                };
                _daqSystem.ConfigureSensor(sensorConfiguration, 1);

                // Configure sensors 2, 3 and from 4 to _installedSensor as EMG sensors (accelerometer full scale = 2g)
                sensorConfiguration.SensorType = SensorType.EMG_SENSOR;
                sensorConfiguration.AccelerometerFullScale = AccelerometerFullScale.g_2;
                _daqSystem.ConfigureSensor(sensorConfiguration, 2);
                _daqSystem.ConfigureSensor(sensorConfiguration, 3);
                for (var c = 4; c <= _installedSensor; c++)
                    _daqSystem.ConfigureSensor(sensorConfiguration, c);

                _acquiredSamplesPerChannel = 0;
                _importedTrials = 0;
                ImportedTrialsTextBox.Text = "0";
                ImportedSamplesPerChannelTextBox.Text = "0";
                MemoryImportingProgressBar.Value = 0;
                Cursor = Cursors.WaitCursor;
                // Start sensor memory reading
                if (_daqSystem.State == DeviceState.Idle)
                {
                    _daqSystem.StartSensorMemoryReading();
                }
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void MemoryStartSelectiveImportingButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Configure sensor 1 as Inertial sensor (accelerometer full scale = 8g; gyroscope full scale = 2000dps)
                ISensorConfiguration sensorConfiguration = new SensorConfiguration
                {
                    SensorType = SensorType.INERTIAL_SENSOR,
                    AccelerometerFullScale = AccelerometerFullScale.g_8,
                    GyroscopeFullScale = GyroscopeFullScale.dps_2000
                };
                _daqSystem.ConfigureSensor(sensorConfiguration, 1);

                // Configure sensors 2, 3 and from 4 to _installedSensor as EMG sensors (accelerometer full scale = 2g)
                sensorConfiguration.SensorType = SensorType.EMG_SENSOR;
                sensorConfiguration.AccelerometerFullScale = AccelerometerFullScale.g_2;
                _daqSystem.ConfigureSensor(sensorConfiguration, 2);
                _daqSystem.ConfigureSensor(sensorConfiguration, 3);
                for (var c = 4; c <= _installedSensor; c++)
                    _daqSystem.ConfigureSensor(sensorConfiguration, c);

                _acquiredSamplesPerChannel = 0;
                _importedTrials = 0;
                ImportedTrialsTextBox.Text = "0";
                ImportedSamplesPerChannelTextBox.Text = "0";
                MemoryImportingProgressBar.Value = 0;
                Cursor = Cursors.WaitCursor;
                // Start sensor memory reading
                if (_daqSystem.State == DeviceState.Idle)
                {
                    // Start trial 1 memory selective importing
                    _daqSystem.StartSensorSelectiveMemoryReading(1);
                }
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void CaptureGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void SensorMemoryGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}