using System;
using System.Windows.Forms;
using Waveplus.DaqSys;
using Waveplus.DaqSysInterface;

namespace Waveplus.DaqExample
{
    public partial class CaptureAndSensorConfigForm : Form
    {
        private readonly IDaqSystem _daqSystem;

        public CaptureAndSensorConfigForm(IDaqSystem daqSystem)
        {
            _daqSystem = daqSystem;
            InitializeComponent();
            // Set sampling rate range
            comboBoxSamplingRate.Items.AddRange(Enum.GetNames(typeof(SamplingRate)));
            // Set IMU acquisition type range
            comboBoxImuAcqType.Items.AddRange((Enum.GetNames(typeof(ImuAcqType))));

            numericUpDownSensorSelection.Maximum = 0;
            if ((_daqSystem.State == DeviceState.Idle) || (_daqSystem.State == DeviceState.InitializingError))
            {
                // Get installed sensor number and capture/sensors configuration 
                GetCaptureConfiguration();
                GetInstalledSensorNumber();
            }
        }

        public void Device_StateChanged(object sender, DeviceStateChangedEventArgs e)
        {
            if (InvokeRequired)
            {
                MethodInvoker invoke = () => Device_StateChanged(sender, e);
                Invoke(invoke);
                return;
            }
            // Update controls state
            ControlsState(e.State);
        }

        private void ControlsState(DeviceState state)
        {
            // Update GUI controls state according to the new device state
            switch (state)
            {
                case DeviceState.Idle:
                    // Get installed sensor number and capture/sensors configuration 
                    GetCaptureConfiguration();
                    GetInstalledSensorNumber();

                    groupBoxSensorConfig.Enabled = true;
                    groupBoxCaptureConfiguration.Enabled = true;
                    groupBoxFootSwSensorConfig.Enabled = true;
                    buttonTurnAllLedsOff.Enabled = true;
                    break;

                case DeviceState.CommunicationError:
                    groupBoxSensorConfig.Enabled = false;
                    groupBoxCaptureConfiguration.Enabled = false;
                    groupBoxFootSwSensorConfig.Enabled = false;
                    buttonTurnAllLedsOff.Enabled = false;
                    break;

                case DeviceState.InitializingError:
                    // Get installed sensor number and capture/sensors configuration 
                    GetInstalledSensorNumber();
                    GetCaptureConfiguration();

                    groupBoxSensorConfig.Enabled = false;
                    groupBoxCaptureConfiguration.Enabled = false;
                    groupBoxFootSwSensorConfig.Enabled = false;
                    buttonTurnAllLedsOff.Enabled = false;
                    break;
                
                case DeviceState.Initializing:
                    groupBoxSensorConfig.Enabled = false;
                    groupBoxCaptureConfiguration.Enabled = false;
                    groupBoxFootSwSensorConfig.Enabled = false;
                    buttonTurnAllLedsOff.Enabled = false;
                    break;

                case DeviceState.UpdatingFirmware:
                    groupBoxSensorConfig.Enabled = false;
                    groupBoxCaptureConfiguration.Enabled = false;
                    groupBoxFootSwSensorConfig.Enabled = false;
                    buttonTurnAllLedsOff.Enabled = false;
                    break;

                case DeviceState.Capturing:
                    groupBoxSensorConfig.Enabled = false;
                    groupBoxCaptureConfiguration.Enabled = false;
                    groupBoxFootSwSensorConfig.Enabled = false;
                    buttonTurnAllLedsOff.Enabled = false;
                    break;

                case DeviceState.NotConnected:
                    numericUpDownSensorSelection.Maximum = 0;
                    groupBoxSensorConfig.Enabled = false;
                    groupBoxCaptureConfiguration.Enabled = false;
                    groupBoxFootSwSensorConfig.Enabled = false;
                    buttonTurnAllLedsOff.Enabled = false;
                    break;
            }
        }

        private void buttonEnable_Click(object sender, EventArgs e)
        {
            try
            {
                // Enable(turn on) the selected sensor
                _daqSystem.EnableSensor((int)numericUpDownSensorSelection.Value);
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }

        private void buttonDisable_Click(object sender, EventArgs e)
        {
            try
            {
                // Disable(turn off) the selected sensor
                _daqSystem.DisableSensor((int)numericUpDownSensorSelection.Value);
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }

        private void buttonCheckImpedance_Click(object sender, EventArgs e)
        {
            try
            {
                // Check all sensors electrode impedance
                var reportStr = "";
                var sensorCheckreport = _daqSystem.CheckElectrodeImpedance(0);
                
                // Show the check report
                for (var i = _daqSystem.InstalledSensors -1; i >= 0; i--)
                {
                    switch (sensorCheckreport[i])
                    {
                        case SensorCheckReport.Failed:
                            reportStr = reportStr + " F";
                            break;

                        case SensorCheckReport.Passed:
                            reportStr = reportStr + " P";
                            break;

                        case SensorCheckReport.NotExecuted:
                            reportStr = reportStr + " N";
                            break;
                    }
                }
                textBoxImpedanceCheckReport.Text = reportStr;
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }

        private void buttonConfigureCapture_Click(object sender, EventArgs e)
        {
            try
            {
                // Configure capture
                ICaptureConfiguration configuration = new CaptureConfiguration
                                                          {
                                                              // Sampling rate
                                                              SamplingRate = ((SamplingRate)Enum.Parse(typeof (SamplingRate), comboBoxSamplingRate.SelectedIndex.ToString())),
                                                              // Trigger
                                                              ExternalTriggerEnabled = checkBoxTriggerEnabled.Checked,
                                                              ExternalTriggerActiveLevel = (int)numericUpDownCapturingEnabledTriggerLevel.Value,
                                                              // FootSw A transducers 
                                                              FootSwATransducerEnabled =
                                                              {  
                                                                    T_A = checkBoxFswATransducerAEnabled.Checked,
                                                                    T_1 = checkBoxFswATransducer1Enabled.Checked,
                                                                    T_5 = checkBoxFswATransducer5Enabled.Checked,
                                                                    T_T = checkBoxFswATransducerTEnabled.Checked,
                                                              },
                                                              FootSwATransducerThreshold =
                                                              {
                                                                    T_A = (double)numericUpDownFswAThreshold_A.Value,
                                                                    T_1 = (double)numericUpDownFswAThreshold_1.Value,
                                                                    T_5 = (double)numericUpDownFswAThreshold_5.Value,
                                                                    T_T = (double)numericUpDownFswAThreshold_T.Value,
                                                              },
                                                              // FootSw B transducers 
                                                              FootSwBTransducerEnabled =
                                                              {
                                                                    T_A = checkBoxFswBTransducerAEnabled.Checked,
                                                                    T_1 = checkBoxFswBTransducer1Enabled.Checked,
                                                                    T_5 = checkBoxFswBTransducer5Enabled.Checked,
                                                                    T_T = checkBoxFswBTransducerTEnabled.Checked,
                                                              },
                                                              FootSwBTransducerThreshold =
                                                              {
                                                                    T_A = (double)numericUpDownFswBThreshold_A.Value,
                                                                    T_1 = (double)numericUpDownFswBThreshold_1.Value,
                                                                    T_5 = (double)numericUpDownFswBThreshold_5.Value,
                                                                    T_T = (double)numericUpDownFswBThreshold_T.Value,
                                                              }
                                                          };
                // FootSw protocol 
                if(radioButtonFswProtocolFullFoot.Checked)
                    configuration.FootSwProtocol = FootSwProtocol.FullFoot;
                if (radioButtonFswProtocolHalfFoot.Checked)
                    configuration.FootSwProtocol = FootSwProtocol.HalfFoot;
                if (radioButtonFswProtocolQuarterFoot.Checked)
                    configuration.FootSwProtocol = FootSwProtocol.QuarterFoot; 
                // IMU acquisition type
                configuration.IMU_AcqType = ((ImuAcqType)Enum.Parse(typeof(ImuAcqType), comboBoxImuAcqType.SelectedIndex.ToString()));

                // Configure Daq system
                _daqSystem.ConfigureCapture(configuration);
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }

        private void buttonGetCaptureConfiguration_Click(object sender, EventArgs e)
        {
            // Get capture configuration
            GetCaptureConfiguration();       
        }

        private void GetCaptureConfiguration()
        {
            try
            {
                // Get capture configuration
                var configuration = _daqSystem.CaptureConfiguration();
                if (configuration != null)
                {
                    // Sampling rate
                    comboBoxSamplingRate.SelectedIndex = comboBoxSamplingRate.FindStringExact(configuration.SamplingRate.ToString());
                    // Trigger
                    checkBoxTriggerEnabled.Checked = configuration.ExternalTriggerEnabled;
                    numericUpDownCapturingEnabledTriggerLevel.Value = configuration.ExternalTriggerActiveLevel;
                    // FootSw A transducers 
                    numericUpDownFswAThreshold_A.Value = (decimal)configuration.FootSwATransducerThreshold.T_A;
                    numericUpDownFswAThreshold_1.Value = (decimal)configuration.FootSwATransducerThreshold.T_1;
                    numericUpDownFswAThreshold_5.Value = (decimal)configuration.FootSwATransducerThreshold.T_5;
                    numericUpDownFswAThreshold_T.Value = (decimal)configuration.FootSwATransducerThreshold.T_T;
                    checkBoxFswATransducerAEnabled.Checked = configuration.FootSwATransducerEnabled.T_A;
                    checkBoxFswATransducer1Enabled.Checked = configuration.FootSwATransducerEnabled.T_1;
                    checkBoxFswATransducer5Enabled.Checked = configuration.FootSwATransducerEnabled.T_5;
                    checkBoxFswATransducerTEnabled.Checked = configuration.FootSwATransducerEnabled.T_T;
                    // FootSw B transducers 
                    numericUpDownFswBThreshold_A.Value = (decimal)configuration.FootSwBTransducerThreshold.T_A;
                    numericUpDownFswBThreshold_1.Value = (decimal)configuration.FootSwBTransducerThreshold.T_1;
                    numericUpDownFswBThreshold_5.Value = (decimal)configuration.FootSwBTransducerThreshold.T_5;
                    numericUpDownFswBThreshold_T.Value = (decimal)configuration.FootSwBTransducerThreshold.T_T;
                    checkBoxFswBTransducerAEnabled.Checked = configuration.FootSwBTransducerEnabled.T_A;
                    checkBoxFswBTransducer1Enabled.Checked = configuration.FootSwBTransducerEnabled.T_1;
                    checkBoxFswBTransducer5Enabled.Checked = configuration.FootSwBTransducerEnabled.T_5;
                    checkBoxFswBTransducerTEnabled.Checked = configuration.FootSwBTransducerEnabled.T_T;
                    // FootSw protocol 
                    if (configuration.FootSwProtocol == FootSwProtocol.FullFoot)
                        radioButtonFswProtocolFullFoot.Checked = true;
                    if (configuration.FootSwProtocol == FootSwProtocol.HalfFoot)
                        radioButtonFswProtocolHalfFoot.Checked = true;
                    if (configuration.FootSwProtocol == FootSwProtocol.QuarterFoot)
                        radioButtonFswProtocolQuarterFoot.Checked = true;

                    // IMU acquisition type
                    comboBoxImuAcqType.SelectedIndex = comboBoxImuAcqType.FindStringExact(configuration.IMU_AcqType.ToString());
                }
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }

        private void GetInstalledSensorNumber()
        {
            try
            {
                // Get installed sensors number
                numericUpDownSensorSelection.Maximum = _daqSystem.InstalledSensors;
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }

        private void buttonTurnLedOn_Click(object sender, EventArgs e)
        {
            try
            {
                // Turn the selected sensor LED on
                _daqSystem.TurnSensorLedOn((int)numericUpDownSensorSelection.Value);
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }

        private void buttonTurnAllLedsOn_Click(object sender, EventArgs e)
        {
            try
            {
                // Turn all the sensors and footSw sensors LEDs on
                _daqSystem.TurnAllSensorLedsOn();
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }

        }

        private void buttonTurnAllLedsOff_Click(object sender, EventArgs e)
        {
            try
            {
                // Turn all the sensors and footSw sensors LEDs off
                _daqSystem.TurnAllSensorLedsOff();
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }

        private void buttonEnableFootSw_Click(object sender, EventArgs e)
        {
            try
            {
                // Enable (turn on) all the footSw sensors
                _daqSystem.EnableFootSwSensors();
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }

        private void buttonDisableFootSw_Click(object sender, EventArgs e)
        {
            try
            {
                // Disable (turn off) all the footSw sensors
                _daqSystem.DisableFootSwSensors();
            }
            catch (Exception _exception)
            {
                // Show exception message
                MessageBox.Show(_exception.Message);
            }
        }
    }
}