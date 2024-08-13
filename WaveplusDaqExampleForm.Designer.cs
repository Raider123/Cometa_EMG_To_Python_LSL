namespace Waveplus.DaqExample
{
    partial class WaveplusDaqExampleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (_daqSystem != null)) _daqSystem.Dispose();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaveplusDaqExampleForm));
            this.DeviceStatusLabel = new System.Windows.Forms.Label();
            this.DeviceStatusTextBox = new System.Windows.Forms.TextBox();
            this.FirmwareVersionButton = new System.Windows.Forms.Button();
            this.CaptionAndSensorsConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigureCaptureAndSensorsButton = new System.Windows.Forms.Button();
            this.AcquiredScanLabel = new System.Windows.Forms.Label();
            this.AcquiredSamplesPerChannelTextBox = new System.Windows.Forms.TextBox();
            this.StartCaptureButton = new System.Windows.Forms.Button();
            this.StopCaptureButton = new System.Windows.Forms.Button();
            this.HardwareVersionButton = new System.Windows.Forms.Button();
            this.DeviceGroupBox = new System.Windows.Forms.GroupBox();
            this.SoftwareVersionLabel = new System.Windows.Forms.Label();
            this.SwVersionTextBox = new System.Windows.Forms.TextBox();
            this.SoftwareVersionButton = new System.Windows.Forms.Button();
            this.InstalledFootSwSensorsLabel = new System.Windows.Forms.Label();
            this.InstalledFootSwSensorsTextBox = new System.Windows.Forms.TextBox();
            this.GetInstalledFootSwSensorsButton = new System.Windows.Forms.Button();
            this.InstalledSensorsLabel = new System.Windows.Forms.Label();
            this.InstalledSensorsTextBox = new System.Windows.Forms.TextBox();
            this.GetInstalledSensorsButton = new System.Windows.Forms.Button();
            this.ErrorMessageTextBox = new System.Windows.Forms.TextBox();
            this.HardwareVersionLabel = new System.Windows.Forms.Label();
            this.FirmwareVersionLabel = new System.Windows.Forms.Label();
            this.FwVersionTextBox = new System.Windows.Forms.TextBox();
            this.ErrorCodeLabel = new System.Windows.Forms.Label();
            this.HwVersionTextBox = new System.Windows.Forms.TextBox();
            this.CaptureGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBoxDataAvailableEventPeriod = new System.Windows.Forms.ComboBox();
            this.labelDataAvailableEventPeriod = new System.Windows.Forms.Label();
            this.CalibrateImuSensorOffsetButton = new System.Windows.Forms.Button();
            this.GenerateStopTriggerButton = new System.Windows.Forms.Button();
            this.GenerateStartTriggerButton = new System.Windows.Forms.Button();
            this.StopTriggerScanTextBox = new System.Windows.Forms.TextBox();
            this.StopTriggerScanLabel = new System.Windows.Forms.Label();
            this.StartTriggerScanTextBox = new System.Windows.Forms.TextBox();
            this.StartTriggerScanLabel = new System.Windows.Forms.Label();
            this.StopTriggerDetectedCheckBox = new System.Windows.Forms.CheckBox();
            this.StartTriggerDetectedCheckBox = new System.Windows.Forms.CheckBox();
            this.DetectAccelerometerOffsetButton = new System.Windows.Forms.Button();
            this.SensorSelectionLabel = new System.Windows.Forms.Label();
            this.SensorSelectionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.FswALabel = new System.Windows.Forms.Label();
            this.FswBLabel = new System.Windows.Forms.Label();
            this.FswABatteryLevelProgressBar = new System.Windows.Forms.ProgressBar();
            this.FswBBatteryLevelProgressBar = new System.Windows.Forms.ProgressBar();
            this.SensorStateGroupBox = new System.Windows.Forms.GroupBox();
            this.SensorStatePanel = new System.Windows.Forms.Panel();
            this.ChangeMasterRFChannelGroupBox = new System.Windows.Forms.GroupBox();
            this.ChangeMasterRFChannelCurrentLabel = new System.Windows.Forms.Label();
            this.ChangeMasterRFChannelNewLabel = new System.Windows.Forms.Label();
            this.ChangeMasterRFChannelReadDeviceCurrentButton = new System.Windows.Forms.Button();
            this.ChangeMasterRFChannelCurrentTextBox = new System.Windows.Forms.TextBox();
            this.ChangeMasterRFChannelNewComboBox = new System.Windows.Forms.ComboBox();
            this.ChangeMasterRFChannelChangeDeviceButton = new System.Windows.Forms.Button();
            this.ChangeMasterRFChannelChangeSensorButton = new System.Windows.Forms.Button();
            this.SensorMemoryGroupBox = new System.Windows.Forms.GroupBox();
            this.MemoryStartSelectiveImportingButton = new System.Windows.Forms.Button();
            this.ImportedTrialsTextBox = new System.Windows.Forms.TextBox();
            this.ImportedTrialsNumberLabel = new System.Windows.Forms.Label();
            this.ImportedSamplesPerChannelTextBox = new System.Windows.Forms.TextBox();
            this.ImportedSamplesPerChannelLabel = new System.Windows.Forms.Label();
            this.MemoryStopImportingButton = new System.Windows.Forms.Button();
            this.MemoryImportingProgressBar = new System.Windows.Forms.ProgressBar();
            this.MemoryClearButton = new System.Windows.Forms.Button();
            this.MemoryStartImportingButton = new System.Windows.Forms.Button();
            this.MemoryAvailableTimeLabel = new System.Windows.Forms.Label();
            this.MemoryUsedSpaceLabel = new System.Windows.Forms.Label();
            this.MemoryTrialsNumberLabel = new System.Windows.Forms.Label();
            this.MemoryAvailableTimeTextBox = new System.Windows.Forms.TextBox();
            this.MemoryUsedSpaceTextBox = new System.Windows.Forms.TextBox();
            this.MemoryTrialsNumberTextBox = new System.Windows.Forms.TextBox();
            this.GetMemoryStatusButton = new System.Windows.Forms.Button();
            this.RemoteRecordingGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoteRecordingPanel = new System.Windows.Forms.Panel();
            this.StopRemoteRecordingButton = new System.Windows.Forms.Button();
            this.StartRemoteRecordingButton = new System.Windows.Forms.Button();
            this.MemoryModeEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.CaptionAndSensorsConfigurationGroupBox.SuspendLayout();
            this.DeviceGroupBox.SuspendLayout();
            this.CaptureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SensorSelectionNumericUpDown)).BeginInit();
            this.SensorStateGroupBox.SuspendLayout();
            this.ChangeMasterRFChannelGroupBox.SuspendLayout();
            this.SensorMemoryGroupBox.SuspendLayout();
            this.RemoteRecordingGroupBox.SuspendLayout();
            this.RemoteRecordingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeviceStatusLabel
            // 
            this.DeviceStatusLabel.AutoSize = true;
            this.DeviceStatusLabel.Location = new System.Drawing.Point(8, 193);
            this.DeviceStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeviceStatusLabel.Name = "DeviceStatusLabel";
            this.DeviceStatusLabel.Size = new System.Drawing.Size(44, 16);
            this.DeviceStatusLabel.TabIndex = 1;
            this.DeviceStatusLabel.Text = "Status";
            this.DeviceStatusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DeviceStatusTextBox
            // 
            this.DeviceStatusTextBox.Location = new System.Drawing.Point(131, 190);
            this.DeviceStatusTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DeviceStatusTextBox.Name = "DeviceStatusTextBox";
            this.DeviceStatusTextBox.ReadOnly = true;
            this.DeviceStatusTextBox.Size = new System.Drawing.Size(224, 22);
            this.DeviceStatusTextBox.TabIndex = 2;
            // 
            // FirmwareVersionButton
            // 
            this.FirmwareVersionButton.Location = new System.Drawing.Point(200, 16);
            this.FirmwareVersionButton.Margin = new System.Windows.Forms.Padding(4);
            this.FirmwareVersionButton.Name = "FirmwareVersionButton";
            this.FirmwareVersionButton.Size = new System.Drawing.Size(156, 26);
            this.FirmwareVersionButton.TabIndex = 4;
            this.FirmwareVersionButton.Text = "Get";
            this.FirmwareVersionButton.UseVisualStyleBackColor = true;
            this.FirmwareVersionButton.Click += new System.EventHandler(this.FirmwareVersionButton_Click);
            // 
            // CaptionAndSensorsConfigurationGroupBox
            // 
            this.CaptionAndSensorsConfigurationGroupBox.Controls.Add(this.ConfigureCaptureAndSensorsButton);
            this.CaptionAndSensorsConfigurationGroupBox.Location = new System.Drawing.Point(463, 287);
            this.CaptionAndSensorsConfigurationGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.CaptionAndSensorsConfigurationGroupBox.Name = "CaptionAndSensorsConfigurationGroupBox";
            this.CaptionAndSensorsConfigurationGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.CaptionAndSensorsConfigurationGroupBox.Size = new System.Drawing.Size(364, 71);
            this.CaptionAndSensorsConfigurationGroupBox.TabIndex = 7;
            this.CaptionAndSensorsConfigurationGroupBox.TabStop = false;
            this.CaptionAndSensorsConfigurationGroupBox.Text = "Capture and Sensors Configuration";
            // 
            // ConfigureCaptureAndSensorsButton
            // 
            this.ConfigureCaptureAndSensorsButton.Location = new System.Drawing.Point(131, 27);
            this.ConfigureCaptureAndSensorsButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConfigureCaptureAndSensorsButton.Name = "ConfigureCaptureAndSensorsButton";
            this.ConfigureCaptureAndSensorsButton.Size = new System.Drawing.Size(225, 26);
            this.ConfigureCaptureAndSensorsButton.TabIndex = 10;
            this.ConfigureCaptureAndSensorsButton.Text = "Configure Capture and Sensors";
            this.ConfigureCaptureAndSensorsButton.UseVisualStyleBackColor = true;
            this.ConfigureCaptureAndSensorsButton.Click += new System.EventHandler(this.BtnConfigureCaptureAndSensors_Click);
            // 
            // AcquiredScanLabel
            // 
            this.AcquiredScanLabel.Location = new System.Drawing.Point(8, 22);
            this.AcquiredScanLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AcquiredScanLabel.Name = "AcquiredScanLabel";
            this.AcquiredScanLabel.Size = new System.Drawing.Size(239, 16);
            this.AcquiredScanLabel.TabIndex = 14;
            this.AcquiredScanLabel.Text = "Acquired Samples per Channel";
            // 
            // AcquiredSamplesPerChannelTextBox
            // 
            this.AcquiredSamplesPerChannelTextBox.Location = new System.Drawing.Point(8, 46);
            this.AcquiredSamplesPerChannelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AcquiredSamplesPerChannelTextBox.Name = "AcquiredSamplesPerChannelTextBox";
            this.AcquiredSamplesPerChannelTextBox.ReadOnly = true;
            this.AcquiredSamplesPerChannelTextBox.Size = new System.Drawing.Size(237, 22);
            this.AcquiredSamplesPerChannelTextBox.TabIndex = 12;
            // 
            // StartCaptureButton
            // 
            this.StartCaptureButton.BackColor = System.Drawing.SystemColors.Control;
            this.StartCaptureButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartCaptureButton.Location = new System.Drawing.Point(8, 145);
            this.StartCaptureButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartCaptureButton.Name = "StartCaptureButton";
            this.StartCaptureButton.Size = new System.Drawing.Size(239, 26);
            this.StartCaptureButton.TabIndex = 0;
            this.StartCaptureButton.Text = "Start Capture";
            this.StartCaptureButton.UseVisualStyleBackColor = true;
            this.StartCaptureButton.Click += new System.EventHandler(this.StartCaptureButton_Click);
            // 
            // StopCaptureButton
            // 
            this.StopCaptureButton.Location = new System.Drawing.Point(8, 183);
            this.StopCaptureButton.Margin = new System.Windows.Forms.Padding(4);
            this.StopCaptureButton.Name = "StopCaptureButton";
            this.StopCaptureButton.Size = new System.Drawing.Size(239, 26);
            this.StopCaptureButton.TabIndex = 1;
            this.StopCaptureButton.Text = "Stop Capture";
            this.StopCaptureButton.UseVisualStyleBackColor = true;
            this.StopCaptureButton.Click += new System.EventHandler(this.StopCaptureButton_Click);
            // 
            // HardwareVersionButton
            // 
            this.HardwareVersionButton.Location = new System.Drawing.Point(200, 50);
            this.HardwareVersionButton.Margin = new System.Windows.Forms.Padding(4);
            this.HardwareVersionButton.Name = "HardwareVersionButton";
            this.HardwareVersionButton.Size = new System.Drawing.Size(156, 26);
            this.HardwareVersionButton.TabIndex = 10;
            this.HardwareVersionButton.Text = "Get";
            this.HardwareVersionButton.UseVisualStyleBackColor = true;
            this.HardwareVersionButton.Click += new System.EventHandler(this.HardwareVersionButton_Click);
            // 
            // DeviceGroupBox
            // 
            this.DeviceGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.DeviceGroupBox.Controls.Add(this.SoftwareVersionLabel);
            this.DeviceGroupBox.Controls.Add(this.SwVersionTextBox);
            this.DeviceGroupBox.Controls.Add(this.SoftwareVersionButton);
            this.DeviceGroupBox.Controls.Add(this.InstalledFootSwSensorsLabel);
            this.DeviceGroupBox.Controls.Add(this.InstalledFootSwSensorsTextBox);
            this.DeviceGroupBox.Controls.Add(this.GetInstalledFootSwSensorsButton);
            this.DeviceGroupBox.Controls.Add(this.InstalledSensorsLabel);
            this.DeviceGroupBox.Controls.Add(this.InstalledSensorsTextBox);
            this.DeviceGroupBox.Controls.Add(this.GetInstalledSensorsButton);
            this.DeviceGroupBox.Controls.Add(this.ErrorMessageTextBox);
            this.DeviceGroupBox.Controls.Add(this.HardwareVersionLabel);
            this.DeviceGroupBox.Controls.Add(this.FirmwareVersionLabel);
            this.DeviceGroupBox.Controls.Add(this.FwVersionTextBox);
            this.DeviceGroupBox.Controls.Add(this.ErrorCodeLabel);
            this.DeviceGroupBox.Controls.Add(this.HwVersionTextBox);
            this.DeviceGroupBox.Controls.Add(this.DeviceStatusTextBox);
            this.DeviceGroupBox.Controls.Add(this.FirmwareVersionButton);
            this.DeviceGroupBox.Controls.Add(this.HardwareVersionButton);
            this.DeviceGroupBox.Controls.Add(this.DeviceStatusLabel);
            this.DeviceGroupBox.Location = new System.Drawing.Point(463, 15);
            this.DeviceGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.DeviceGroupBox.Name = "DeviceGroupBox";
            this.DeviceGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.DeviceGroupBox.Size = new System.Drawing.Size(364, 265);
            this.DeviceGroupBox.TabIndex = 13;
            this.DeviceGroupBox.TabStop = false;
            this.DeviceGroupBox.Text = "Device";
            // 
            // SoftwareVersionLabel
            // 
            this.SoftwareVersionLabel.AutoSize = true;
            this.SoftwareVersionLabel.Location = new System.Drawing.Point(8, 89);
            this.SoftwareVersionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SoftwareVersionLabel.Name = "SoftwareVersionLabel";
            this.SoftwareVersionLabel.Size = new System.Drawing.Size(106, 16);
            this.SoftwareVersionLabel.TabIndex = 73;
            this.SoftwareVersionLabel.Text = "DAQ Sw Version";
            // 
            // SwVersionTextBox
            // 
            this.SwVersionTextBox.AcceptsReturn = true;
            this.SwVersionTextBox.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.SwVersionTextBox.Location = new System.Drawing.Point(131, 85);
            this.SwVersionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SwVersionTextBox.Name = "SwVersionTextBox";
            this.SwVersionTextBox.ReadOnly = true;
            this.SwVersionTextBox.Size = new System.Drawing.Size(60, 22);
            this.SwVersionTextBox.TabIndex = 72;
            // 
            // SoftwareVersionButton
            // 
            this.SoftwareVersionButton.Location = new System.Drawing.Point(200, 85);
            this.SoftwareVersionButton.Margin = new System.Windows.Forms.Padding(4);
            this.SoftwareVersionButton.Name = "SoftwareVersionButton";
            this.SoftwareVersionButton.Size = new System.Drawing.Size(156, 26);
            this.SoftwareVersionButton.TabIndex = 71;
            this.SoftwareVersionButton.Text = "Get";
            this.SoftwareVersionButton.UseVisualStyleBackColor = true;
            this.SoftwareVersionButton.Click += new System.EventHandler(this.SoftwareVersionButton_Click);
            // 
            // InstalledFootSwSensorsLabel
            // 
            this.InstalledFootSwSensorsLabel.AutoSize = true;
            this.InstalledFootSwSensorsLabel.Location = new System.Drawing.Point(8, 155);
            this.InstalledFootSwSensorsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InstalledFootSwSensorsLabel.Name = "InstalledFootSwSensorsLabel";
            this.InstalledFootSwSensorsLabel.Size = new System.Drawing.Size(86, 16);
            this.InstalledFootSwSensorsLabel.TabIndex = 70;
            this.InstalledFootSwSensorsLabel.Text = "FSw Sensors";
            // 
            // InstalledFootSwSensorsTextBox
            // 
            this.InstalledFootSwSensorsTextBox.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.InstalledFootSwSensorsTextBox.Location = new System.Drawing.Point(131, 151);
            this.InstalledFootSwSensorsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.InstalledFootSwSensorsTextBox.Name = "InstalledFootSwSensorsTextBox";
            this.InstalledFootSwSensorsTextBox.ReadOnly = true;
            this.InstalledFootSwSensorsTextBox.Size = new System.Drawing.Size(60, 22);
            this.InstalledFootSwSensorsTextBox.TabIndex = 69;
            // 
            // GetInstalledFootSwSensorsButton
            // 
            this.GetInstalledFootSwSensorsButton.Location = new System.Drawing.Point(200, 151);
            this.GetInstalledFootSwSensorsButton.Margin = new System.Windows.Forms.Padding(4);
            this.GetInstalledFootSwSensorsButton.Name = "GetInstalledFootSwSensorsButton";
            this.GetInstalledFootSwSensorsButton.Size = new System.Drawing.Size(156, 26);
            this.GetInstalledFootSwSensorsButton.TabIndex = 68;
            this.GetInstalledFootSwSensorsButton.Text = "Get";
            this.GetInstalledFootSwSensorsButton.UseVisualStyleBackColor = true;
            this.GetInstalledFootSwSensorsButton.Click += new System.EventHandler(this.GetInstalledFootSwSensorsButton_Click);
            // 
            // InstalledSensorsLabel
            // 
            this.InstalledSensorsLabel.AutoSize = true;
            this.InstalledSensorsLabel.Location = new System.Drawing.Point(8, 123);
            this.InstalledSensorsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InstalledSensorsLabel.Name = "InstalledSensorsLabel";
            this.InstalledSensorsLabel.Size = new System.Drawing.Size(57, 16);
            this.InstalledSensorsLabel.TabIndex = 67;
            this.InstalledSensorsLabel.Text = "Sensors";
            // 
            // InstalledSensorsTextBox
            // 
            this.InstalledSensorsTextBox.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.InstalledSensorsTextBox.Location = new System.Drawing.Point(131, 119);
            this.InstalledSensorsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.InstalledSensorsTextBox.Name = "InstalledSensorsTextBox";
            this.InstalledSensorsTextBox.ReadOnly = true;
            this.InstalledSensorsTextBox.Size = new System.Drawing.Size(60, 22);
            this.InstalledSensorsTextBox.TabIndex = 66;
            // 
            // GetInstalledSensorsButton
            // 
            this.GetInstalledSensorsButton.Location = new System.Drawing.Point(200, 119);
            this.GetInstalledSensorsButton.Margin = new System.Windows.Forms.Padding(4);
            this.GetInstalledSensorsButton.Name = "GetInstalledSensorsButton";
            this.GetInstalledSensorsButton.Size = new System.Drawing.Size(156, 26);
            this.GetInstalledSensorsButton.TabIndex = 65;
            this.GetInstalledSensorsButton.Text = "Get";
            this.GetInstalledSensorsButton.UseVisualStyleBackColor = true;
            this.GetInstalledSensorsButton.Click += new System.EventHandler(this.GetInstalledSensorsButton_Click);
            // 
            // ErrorMessageTextBox
            // 
            this.ErrorMessageTextBox.Location = new System.Drawing.Point(131, 222);
            this.ErrorMessageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ErrorMessageTextBox.Name = "ErrorMessageTextBox";
            this.ErrorMessageTextBox.ReadOnly = true;
            this.ErrorMessageTextBox.Size = new System.Drawing.Size(224, 22);
            this.ErrorMessageTextBox.TabIndex = 64;
            // 
            // HardwareVersionLabel
            // 
            this.HardwareVersionLabel.AutoSize = true;
            this.HardwareVersionLabel.Location = new System.Drawing.Point(8, 54);
            this.HardwareVersionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HardwareVersionLabel.Name = "HardwareVersionLabel";
            this.HardwareVersionLabel.Size = new System.Drawing.Size(75, 16);
            this.HardwareVersionLabel.TabIndex = 63;
            this.HardwareVersionLabel.Text = "Hw Version";
            // 
            // FirmwareVersionLabel
            // 
            this.FirmwareVersionLabel.AutoSize = true;
            this.FirmwareVersionLabel.Location = new System.Drawing.Point(8, 22);
            this.FirmwareVersionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirmwareVersionLabel.Name = "FirmwareVersionLabel";
            this.FirmwareVersionLabel.Size = new System.Drawing.Size(73, 16);
            this.FirmwareVersionLabel.TabIndex = 62;
            this.FirmwareVersionLabel.Text = "Fw Version";
            // 
            // FwVersionTextBox
            // 
            this.FwVersionTextBox.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.FwVersionTextBox.Location = new System.Drawing.Point(131, 18);
            this.FwVersionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FwVersionTextBox.Name = "FwVersionTextBox";
            this.FwVersionTextBox.ReadOnly = true;
            this.FwVersionTextBox.Size = new System.Drawing.Size(60, 22);
            this.FwVersionTextBox.TabIndex = 36;
            // 
            // ErrorCodeLabel
            // 
            this.ErrorCodeLabel.AutoSize = true;
            this.ErrorCodeLabel.Location = new System.Drawing.Point(8, 225);
            this.ErrorCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorCodeLabel.Name = "ErrorCodeLabel";
            this.ErrorCodeLabel.Size = new System.Drawing.Size(36, 16);
            this.ErrorCodeLabel.TabIndex = 29;
            this.ErrorCodeLabel.Text = "Error";
            // 
            // HwVersionTextBox
            // 
            this.HwVersionTextBox.AcceptsReturn = true;
            this.HwVersionTextBox.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.HwVersionTextBox.Location = new System.Drawing.Point(131, 50);
            this.HwVersionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.HwVersionTextBox.Name = "HwVersionTextBox";
            this.HwVersionTextBox.ReadOnly = true;
            this.HwVersionTextBox.Size = new System.Drawing.Size(60, 22);
            this.HwVersionTextBox.TabIndex = 22;
            // 
            // CaptureGroupBox
            // 
            this.CaptureGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.CaptureGroupBox.Controls.Add(this.comboBoxDataAvailableEventPeriod);
            this.CaptureGroupBox.Controls.Add(this.labelDataAvailableEventPeriod);
            this.CaptureGroupBox.Controls.Add(this.CalibrateImuSensorOffsetButton);
            this.CaptureGroupBox.Controls.Add(this.GenerateStopTriggerButton);
            this.CaptureGroupBox.Controls.Add(this.GenerateStartTriggerButton);
            this.CaptureGroupBox.Controls.Add(this.StopTriggerScanTextBox);
            this.CaptureGroupBox.Controls.Add(this.StopTriggerScanLabel);
            this.CaptureGroupBox.Controls.Add(this.StartTriggerScanTextBox);
            this.CaptureGroupBox.Controls.Add(this.StartTriggerScanLabel);
            this.CaptureGroupBox.Controls.Add(this.StopTriggerDetectedCheckBox);
            this.CaptureGroupBox.Controls.Add(this.StartTriggerDetectedCheckBox);
            this.CaptureGroupBox.Controls.Add(this.DetectAccelerometerOffsetButton);
            this.CaptureGroupBox.Controls.Add(this.SensorSelectionLabel);
            this.CaptureGroupBox.Controls.Add(this.SensorSelectionNumericUpDown);
            this.CaptureGroupBox.Controls.Add(this.AcquiredScanLabel);
            this.CaptureGroupBox.Controls.Add(this.AcquiredSamplesPerChannelTextBox);
            this.CaptureGroupBox.Controls.Add(this.StartCaptureButton);
            this.CaptureGroupBox.Controls.Add(this.StopCaptureButton);
            this.CaptureGroupBox.Location = new System.Drawing.Point(200, 15);
            this.CaptureGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.CaptureGroupBox.Name = "CaptureGroupBox";
            this.CaptureGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.CaptureGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CaptureGroupBox.Size = new System.Drawing.Size(255, 512);
            this.CaptureGroupBox.TabIndex = 14;
            this.CaptureGroupBox.TabStop = false;
            this.CaptureGroupBox.Text = "Capture";
            this.CaptureGroupBox.Enter += new System.EventHandler(this.CaptureGroupBox_Enter);
            // 
            // comboBoxDataAvailableEventPeriod
            // 
            this.comboBoxDataAvailableEventPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataAvailableEventPeriod.FormattingEnabled = true;
            this.comboBoxDataAvailableEventPeriod.Location = new System.Drawing.Point(8, 107);
            this.comboBoxDataAvailableEventPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDataAvailableEventPeriod.Name = "comboBoxDataAvailableEventPeriod";
            this.comboBoxDataAvailableEventPeriod.Size = new System.Drawing.Size(237, 24);
            this.comboBoxDataAvailableEventPeriod.TabIndex = 49;
            // 
            // labelDataAvailableEventPeriod
            // 
            this.labelDataAvailableEventPeriod.Location = new System.Drawing.Point(8, 81);
            this.labelDataAvailableEventPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataAvailableEventPeriod.Name = "labelDataAvailableEventPeriod";
            this.labelDataAvailableEventPeriod.Size = new System.Drawing.Size(219, 18);
            this.labelDataAvailableEventPeriod.TabIndex = 48;
            this.labelDataAvailableEventPeriod.Text = "Data Available Event Period";
            // 
            // CalibrateImuSensorOffsetButton
            // 
            this.CalibrateImuSensorOffsetButton.Location = new System.Drawing.Point(8, 447);
            this.CalibrateImuSensorOffsetButton.Margin = new System.Windows.Forms.Padding(4);
            this.CalibrateImuSensorOffsetButton.Name = "CalibrateImuSensorOffsetButton";
            this.CalibrateImuSensorOffsetButton.Size = new System.Drawing.Size(239, 26);
            this.CalibrateImuSensorOffsetButton.TabIndex = 29;
            this.CalibrateImuSensorOffsetButton.Text = "Calibrate Inertial Sensor Offset";
            this.CalibrateImuSensorOffsetButton.UseVisualStyleBackColor = true;
            this.CalibrateImuSensorOffsetButton.Click += new System.EventHandler(this.CalibrateImuSensorOffsetButton_Click);
            // 
            // GenerateStopTriggerButton
            // 
            this.GenerateStopTriggerButton.Location = new System.Drawing.Point(133, 313);
            this.GenerateStopTriggerButton.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateStopTriggerButton.Name = "GenerateStopTriggerButton";
            this.GenerateStopTriggerButton.Size = new System.Drawing.Size(113, 26);
            this.GenerateStopTriggerButton.TabIndex = 28;
            this.GenerateStopTriggerButton.Text = "Sw Stop Trg";
            this.GenerateStopTriggerButton.UseVisualStyleBackColor = true;
            this.GenerateStopTriggerButton.Click += new System.EventHandler(this.GenerateStopTriggerButton_Click);
            // 
            // GenerateStartTriggerButton
            // 
            this.GenerateStartTriggerButton.Location = new System.Drawing.Point(8, 313);
            this.GenerateStartTriggerButton.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateStartTriggerButton.Name = "GenerateStartTriggerButton";
            this.GenerateStartTriggerButton.Size = new System.Drawing.Size(113, 26);
            this.GenerateStartTriggerButton.TabIndex = 27;
            this.GenerateStartTriggerButton.Text = "Sw Start Trg";
            this.GenerateStartTriggerButton.UseVisualStyleBackColor = true;
            this.GenerateStartTriggerButton.Click += new System.EventHandler(this.GenerateStartTriggerButton_Click);
            // 
            // StopTriggerScanTextBox
            // 
            this.StopTriggerScanTextBox.Location = new System.Drawing.Point(164, 277);
            this.StopTriggerScanTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StopTriggerScanTextBox.Name = "StopTriggerScanTextBox";
            this.StopTriggerScanTextBox.ReadOnly = true;
            this.StopTriggerScanTextBox.Size = new System.Drawing.Size(81, 22);
            this.StopTriggerScanTextBox.TabIndex = 26;
            // 
            // StopTriggerScanLabel
            // 
            this.StopTriggerScanLabel.AutoSize = true;
            this.StopTriggerScanLabel.Location = new System.Drawing.Point(113, 281);
            this.StopTriggerScanLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StopTriggerScanLabel.Name = "StopTriggerScanLabel";
            this.StopTriggerScanLabel.Size = new System.Drawing.Size(38, 16);
            this.StopTriggerScanLabel.TabIndex = 25;
            this.StopTriggerScanLabel.Text = "Scan";
            this.StopTriggerScanLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StartTriggerScanTextBox
            // 
            this.StartTriggerScanTextBox.AcceptsReturn = true;
            this.StartTriggerScanTextBox.Location = new System.Drawing.Point(164, 245);
            this.StartTriggerScanTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StartTriggerScanTextBox.Name = "StartTriggerScanTextBox";
            this.StartTriggerScanTextBox.ReadOnly = true;
            this.StartTriggerScanTextBox.Size = new System.Drawing.Size(81, 22);
            this.StartTriggerScanTextBox.TabIndex = 24;
            // 
            // StartTriggerScanLabel
            // 
            this.StartTriggerScanLabel.AutoSize = true;
            this.StartTriggerScanLabel.Location = new System.Drawing.Point(113, 249);
            this.StartTriggerScanLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartTriggerScanLabel.Name = "StartTriggerScanLabel";
            this.StartTriggerScanLabel.Size = new System.Drawing.Size(38, 16);
            this.StartTriggerScanLabel.TabIndex = 23;
            this.StartTriggerScanLabel.Text = "Scan";
            this.StartTriggerScanLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StopTriggerDetectedCheckBox
            // 
            this.StopTriggerDetectedCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StopTriggerDetectedCheckBox.Enabled = false;
            this.StopTriggerDetectedCheckBox.Location = new System.Drawing.Point(8, 276);
            this.StopTriggerDetectedCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.StopTriggerDetectedCheckBox.Name = "StopTriggerDetectedCheckBox";
            this.StopTriggerDetectedCheckBox.Size = new System.Drawing.Size(92, 27);
            this.StopTriggerDetectedCheckBox.TabIndex = 22;
            this.StopTriggerDetectedCheckBox.Text = "Stop Trig";
            this.StopTriggerDetectedCheckBox.UseVisualStyleBackColor = true;
            // 
            // StartTriggerDetectedCheckBox
            // 
            this.StartTriggerDetectedCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StartTriggerDetectedCheckBox.Enabled = false;
            this.StartTriggerDetectedCheckBox.Location = new System.Drawing.Point(8, 244);
            this.StartTriggerDetectedCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.StartTriggerDetectedCheckBox.Name = "StartTriggerDetectedCheckBox";
            this.StartTriggerDetectedCheckBox.Size = new System.Drawing.Size(92, 27);
            this.StartTriggerDetectedCheckBox.TabIndex = 21;
            this.StartTriggerDetectedCheckBox.Text = "Start Trig";
            this.StartTriggerDetectedCheckBox.UseVisualStyleBackColor = true;
            // 
            // DetectAccelerometerOffsetButton
            // 
            this.DetectAccelerometerOffsetButton.Location = new System.Drawing.Point(8, 407);
            this.DetectAccelerometerOffsetButton.Margin = new System.Windows.Forms.Padding(4);
            this.DetectAccelerometerOffsetButton.Name = "DetectAccelerometerOffsetButton";
            this.DetectAccelerometerOffsetButton.Size = new System.Drawing.Size(239, 26);
            this.DetectAccelerometerOffsetButton.TabIndex = 20;
            this.DetectAccelerometerOffsetButton.Text = "Detect Accelerometer Offset";
            this.DetectAccelerometerOffsetButton.UseVisualStyleBackColor = true;
            this.DetectAccelerometerOffsetButton.Click += new System.EventHandler(this.DetectAccelerometerOffsetButton_Click);
            // 
            // SensorSelectionLabel
            // 
            this.SensorSelectionLabel.Location = new System.Drawing.Point(8, 375);
            this.SensorSelectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SensorSelectionLabel.Name = "SensorSelectionLabel";
            this.SensorSelectionLabel.Size = new System.Drawing.Size(148, 21);
            this.SensorSelectionLabel.TabIndex = 19;
            this.SensorSelectionLabel.Text = "Sensor";
            this.SensorSelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SensorSelectionNumericUpDown
            // 
            this.SensorSelectionNumericUpDown.Location = new System.Drawing.Point(184, 375);
            this.SensorSelectionNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.SensorSelectionNumericUpDown.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.SensorSelectionNumericUpDown.Name = "SensorSelectionNumericUpDown";
            this.SensorSelectionNumericUpDown.Size = new System.Drawing.Size(63, 22);
            this.SensorSelectionNumericUpDown.TabIndex = 18;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 21);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // FswALabel
            // 
            this.FswALabel.Location = new System.Drawing.Point(16, 455);
            this.FswALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FswALabel.Name = "FswALabel";
            this.FswALabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FswALabel.Size = new System.Drawing.Size(25, 16);
            this.FswALabel.TabIndex = 0;
            this.FswALabel.Text = "A";
            // 
            // FswBLabel
            // 
            this.FswBLabel.Location = new System.Drawing.Point(16, 480);
            this.FswBLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FswBLabel.Name = "FswBLabel";
            this.FswBLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FswBLabel.Size = new System.Drawing.Size(25, 16);
            this.FswBLabel.TabIndex = 3;
            this.FswBLabel.Text = "B";
            // 
            // FswABatteryLevelProgressBar
            // 
            this.FswABatteryLevelProgressBar.Location = new System.Drawing.Point(49, 458);
            this.FswABatteryLevelProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.FswABatteryLevelProgressBar.Maximum = 3;
            this.FswABatteryLevelProgressBar.Name = "FswABatteryLevelProgressBar";
            this.FswABatteryLevelProgressBar.Size = new System.Drawing.Size(45, 12);
            this.FswABatteryLevelProgressBar.Step = 1;
            this.FswABatteryLevelProgressBar.TabIndex = 4;
            // 
            // FswBBatteryLevelProgressBar
            // 
            this.FswBBatteryLevelProgressBar.Location = new System.Drawing.Point(49, 482);
            this.FswBBatteryLevelProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.FswBBatteryLevelProgressBar.Maximum = 3;
            this.FswBBatteryLevelProgressBar.Name = "FswBBatteryLevelProgressBar";
            this.FswBBatteryLevelProgressBar.RightToLeftLayout = true;
            this.FswBBatteryLevelProgressBar.Size = new System.Drawing.Size(45, 12);
            this.FswBBatteryLevelProgressBar.Step = 1;
            this.FswBBatteryLevelProgressBar.TabIndex = 5;
            // 
            // SensorStateGroupBox
            // 
            this.SensorStateGroupBox.Controls.Add(this.FswBBatteryLevelProgressBar);
            this.SensorStateGroupBox.Controls.Add(this.FswABatteryLevelProgressBar);
            this.SensorStateGroupBox.Controls.Add(this.FswBLabel);
            this.SensorStateGroupBox.Controls.Add(this.FswALabel);
            this.SensorStateGroupBox.Controls.Add(this.SensorStatePanel);
            this.SensorStateGroupBox.Location = new System.Drawing.Point(16, 15);
            this.SensorStateGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.SensorStateGroupBox.Name = "SensorStateGroupBox";
            this.SensorStateGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.SensorStateGroupBox.Size = new System.Drawing.Size(176, 512);
            this.SensorStateGroupBox.TabIndex = 19;
            this.SensorStateGroupBox.TabStop = false;
            this.SensorStateGroupBox.Text = "Sensors Battery Level";
            // 
            // SensorStatePanel
            // 
            this.SensorStatePanel.AutoScroll = true;
            this.SensorStatePanel.Location = new System.Drawing.Point(8, 22);
            this.SensorStatePanel.Margin = new System.Windows.Forms.Padding(4);
            this.SensorStatePanel.Name = "SensorStatePanel";
            this.SensorStatePanel.Size = new System.Drawing.Size(160, 415);
            this.SensorStatePanel.TabIndex = 6;
            // 
            // ChangeMasterRFChannelGroupBox
            // 
            this.ChangeMasterRFChannelGroupBox.Controls.Add(this.ChangeMasterRFChannelCurrentLabel);
            this.ChangeMasterRFChannelGroupBox.Controls.Add(this.ChangeMasterRFChannelNewLabel);
            this.ChangeMasterRFChannelGroupBox.Controls.Add(this.ChangeMasterRFChannelReadDeviceCurrentButton);
            this.ChangeMasterRFChannelGroupBox.Controls.Add(this.ChangeMasterRFChannelCurrentTextBox);
            this.ChangeMasterRFChannelGroupBox.Controls.Add(this.ChangeMasterRFChannelNewComboBox);
            this.ChangeMasterRFChannelGroupBox.Controls.Add(this.ChangeMasterRFChannelChangeDeviceButton);
            this.ChangeMasterRFChannelGroupBox.Controls.Add(this.ChangeMasterRFChannelChangeSensorButton);
            this.ChangeMasterRFChannelGroupBox.Location = new System.Drawing.Point(463, 366);
            this.ChangeMasterRFChannelGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeMasterRFChannelGroupBox.Name = "ChangeMasterRFChannelGroupBox";
            this.ChangeMasterRFChannelGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ChangeMasterRFChannelGroupBox.Size = new System.Drawing.Size(364, 161);
            this.ChangeMasterRFChannelGroupBox.TabIndex = 20;
            this.ChangeMasterRFChannelGroupBox.TabStop = false;
            this.ChangeMasterRFChannelGroupBox.Text = "Change Master Device/Sensors RF Channel";
            // 
            // ChangeMasterRFChannelCurrentLabel
            // 
            this.ChangeMasterRFChannelCurrentLabel.Location = new System.Drawing.Point(8, 27);
            this.ChangeMasterRFChannelCurrentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChangeMasterRFChannelCurrentLabel.Name = "ChangeMasterRFChannelCurrentLabel";
            this.ChangeMasterRFChannelCurrentLabel.Size = new System.Drawing.Size(109, 18);
            this.ChangeMasterRFChannelCurrentLabel.TabIndex = 73;
            this.ChangeMasterRFChannelCurrentLabel.Text = "Device Current";
            this.ChangeMasterRFChannelCurrentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChangeMasterRFChannelNewLabel
            // 
            this.ChangeMasterRFChannelNewLabel.Location = new System.Drawing.Point(8, 60);
            this.ChangeMasterRFChannelNewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChangeMasterRFChannelNewLabel.Name = "ChangeMasterRFChannelNewLabel";
            this.ChangeMasterRFChannelNewLabel.Size = new System.Drawing.Size(109, 18);
            this.ChangeMasterRFChannelNewLabel.TabIndex = 72;
            this.ChangeMasterRFChannelNewLabel.Text = "New";
            this.ChangeMasterRFChannelNewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChangeMasterRFChannelReadDeviceCurrentButton
            // 
            this.ChangeMasterRFChannelReadDeviceCurrentButton.Location = new System.Drawing.Point(272, 22);
            this.ChangeMasterRFChannelReadDeviceCurrentButton.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeMasterRFChannelReadDeviceCurrentButton.Name = "ChangeMasterRFChannelReadDeviceCurrentButton";
            this.ChangeMasterRFChannelReadDeviceCurrentButton.Size = new System.Drawing.Size(84, 26);
            this.ChangeMasterRFChannelReadDeviceCurrentButton.TabIndex = 71;
            this.ChangeMasterRFChannelReadDeviceCurrentButton.Text = "Get";
            this.ChangeMasterRFChannelReadDeviceCurrentButton.UseVisualStyleBackColor = true;
            this.ChangeMasterRFChannelReadDeviceCurrentButton.Click += new System.EventHandler(this.ChangeRFChannelReadDeviceCurrentButton_Click);
            // 
            // ChangeMasterRFChannelCurrentTextBox
            // 
            this.ChangeMasterRFChannelCurrentTextBox.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.ChangeMasterRFChannelCurrentTextBox.Location = new System.Drawing.Point(131, 25);
            this.ChangeMasterRFChannelCurrentTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeMasterRFChannelCurrentTextBox.Name = "ChangeMasterRFChannelCurrentTextBox";
            this.ChangeMasterRFChannelCurrentTextBox.ReadOnly = true;
            this.ChangeMasterRFChannelCurrentTextBox.Size = new System.Drawing.Size(132, 22);
            this.ChangeMasterRFChannelCurrentTextBox.TabIndex = 70;
            // 
            // ChangeMasterRFChannelNewComboBox
            // 
            this.ChangeMasterRFChannelNewComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChangeMasterRFChannelNewComboBox.FormattingEnabled = true;
            this.ChangeMasterRFChannelNewComboBox.Location = new System.Drawing.Point(131, 58);
            this.ChangeMasterRFChannelNewComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeMasterRFChannelNewComboBox.Name = "ChangeMasterRFChannelNewComboBox";
            this.ChangeMasterRFChannelNewComboBox.Size = new System.Drawing.Size(132, 24);
            this.ChangeMasterRFChannelNewComboBox.TabIndex = 50;
            // 
            // ChangeMasterRFChannelChangeDeviceButton
            // 
            this.ChangeMasterRFChannelChangeDeviceButton.Location = new System.Drawing.Point(131, 91);
            this.ChangeMasterRFChannelChangeDeviceButton.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeMasterRFChannelChangeDeviceButton.Name = "ChangeMasterRFChannelChangeDeviceButton";
            this.ChangeMasterRFChannelChangeDeviceButton.Size = new System.Drawing.Size(133, 26);
            this.ChangeMasterRFChannelChangeDeviceButton.TabIndex = 7;
            this.ChangeMasterRFChannelChangeDeviceButton.Text = "Change Device";
            this.ChangeMasterRFChannelChangeDeviceButton.UseVisualStyleBackColor = true;
            this.ChangeMasterRFChannelChangeDeviceButton.Click += new System.EventHandler(this.ChangeMasterRFChannelChangeDeviceButton_Click);
            // 
            // ChangeMasterRFChannelChangeSensorButton
            // 
            this.ChangeMasterRFChannelChangeSensorButton.Location = new System.Drawing.Point(131, 126);
            this.ChangeMasterRFChannelChangeSensorButton.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeMasterRFChannelChangeSensorButton.Name = "ChangeMasterRFChannelChangeSensorButton";
            this.ChangeMasterRFChannelChangeSensorButton.Size = new System.Drawing.Size(133, 26);
            this.ChangeMasterRFChannelChangeSensorButton.TabIndex = 4;
            this.ChangeMasterRFChannelChangeSensorButton.Text = "Change Sensors";
            this.ChangeMasterRFChannelChangeSensorButton.UseVisualStyleBackColor = true;
            this.ChangeMasterRFChannelChangeSensorButton.Click += new System.EventHandler(this.ChangeRFChannelChangeSensorsButton_Click);
            // 
            // SensorMemoryGroupBox
            // 
            this.SensorMemoryGroupBox.Controls.Add(this.MemoryStartSelectiveImportingButton);
            this.SensorMemoryGroupBox.Controls.Add(this.ImportedTrialsTextBox);
            this.SensorMemoryGroupBox.Controls.Add(this.ImportedTrialsNumberLabel);
            this.SensorMemoryGroupBox.Controls.Add(this.ImportedSamplesPerChannelTextBox);
            this.SensorMemoryGroupBox.Controls.Add(this.ImportedSamplesPerChannelLabel);
            this.SensorMemoryGroupBox.Controls.Add(this.MemoryStopImportingButton);
            this.SensorMemoryGroupBox.Controls.Add(this.MemoryImportingProgressBar);
            this.SensorMemoryGroupBox.Controls.Add(this.MemoryClearButton);
            this.SensorMemoryGroupBox.Controls.Add(this.MemoryStartImportingButton);
            this.SensorMemoryGroupBox.Controls.Add(this.MemoryAvailableTimeLabel);
            this.SensorMemoryGroupBox.Controls.Add(this.MemoryUsedSpaceLabel);
            this.SensorMemoryGroupBox.Controls.Add(this.MemoryTrialsNumberLabel);
            this.SensorMemoryGroupBox.Controls.Add(this.MemoryAvailableTimeTextBox);
            this.SensorMemoryGroupBox.Controls.Add(this.MemoryUsedSpaceTextBox);
            this.SensorMemoryGroupBox.Controls.Add(this.MemoryTrialsNumberTextBox);
            this.SensorMemoryGroupBox.Controls.Add(this.GetMemoryStatusButton);
            this.SensorMemoryGroupBox.Location = new System.Drawing.Point(835, 15);
            this.SensorMemoryGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.SensorMemoryGroupBox.Name = "SensorMemoryGroupBox";
            this.SensorMemoryGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.SensorMemoryGroupBox.Size = new System.Drawing.Size(476, 343);
            this.SensorMemoryGroupBox.TabIndex = 21;
            this.SensorMemoryGroupBox.TabStop = false;
            this.SensorMemoryGroupBox.Text = "Import from Sensor Memory";
            this.SensorMemoryGroupBox.Enter += new System.EventHandler(this.SensorMemoryGroupBox_Enter);
            // 
            // MemoryStartSelectiveImportingButton
            // 
            this.MemoryStartSelectiveImportingButton.Location = new System.Drawing.Point(28, 188);
            this.MemoryStartSelectiveImportingButton.Margin = new System.Windows.Forms.Padding(4);
            this.MemoryStartSelectiveImportingButton.Name = "MemoryStartSelectiveImportingButton";
            this.MemoryStartSelectiveImportingButton.Size = new System.Drawing.Size(184, 26);
            this.MemoryStartSelectiveImportingButton.TabIndex = 52;
            this.MemoryStartSelectiveImportingButton.Text = "Start Selective Importing";
            this.MemoryStartSelectiveImportingButton.UseVisualStyleBackColor = true;
            this.MemoryStartSelectiveImportingButton.Click += new System.EventHandler(this.MemoryStartSelectiveImportingButton_Click);
            // 
            // ImportedTrialsTextBox
            // 
            this.ImportedTrialsTextBox.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.ImportedTrialsTextBox.Location = new System.Drawing.Point(237, 299);
            this.ImportedTrialsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ImportedTrialsTextBox.Name = "ImportedTrialsTextBox";
            this.ImportedTrialsTextBox.ReadOnly = true;
            this.ImportedTrialsTextBox.Size = new System.Drawing.Size(211, 22);
            this.ImportedTrialsTextBox.TabIndex = 50;
            // 
            // ImportedTrialsNumberLabel
            // 
            this.ImportedTrialsNumberLabel.Location = new System.Drawing.Point(233, 279);
            this.ImportedTrialsNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImportedTrialsNumberLabel.Name = "ImportedTrialsNumberLabel";
            this.ImportedTrialsNumberLabel.Size = new System.Drawing.Size(212, 16);
            this.ImportedTrialsNumberLabel.TabIndex = 49;
            this.ImportedTrialsNumberLabel.Text = "Imported Trials Number";
            this.ImportedTrialsNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImportedSamplesPerChannelTextBox
            // 
            this.ImportedSamplesPerChannelTextBox.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.ImportedSamplesPerChannelTextBox.Location = new System.Drawing.Point(237, 250);
            this.ImportedSamplesPerChannelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ImportedSamplesPerChannelTextBox.Name = "ImportedSamplesPerChannelTextBox";
            this.ImportedSamplesPerChannelTextBox.ReadOnly = true;
            this.ImportedSamplesPerChannelTextBox.Size = new System.Drawing.Size(211, 22);
            this.ImportedSamplesPerChannelTextBox.TabIndex = 48;
            // 
            // ImportedSamplesPerChannelLabel
            // 
            this.ImportedSamplesPerChannelLabel.Location = new System.Drawing.Point(237, 230);
            this.ImportedSamplesPerChannelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImportedSamplesPerChannelLabel.Name = "ImportedSamplesPerChannelLabel";
            this.ImportedSamplesPerChannelLabel.Size = new System.Drawing.Size(212, 16);
            this.ImportedSamplesPerChannelLabel.TabIndex = 47;
            this.ImportedSamplesPerChannelLabel.Text = "Imported Samples per Channel";
            this.ImportedSamplesPerChannelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MemoryStopImportingButton
            // 
            this.MemoryStopImportingButton.Location = new System.Drawing.Point(28, 299);
            this.MemoryStopImportingButton.Margin = new System.Windows.Forms.Padding(4);
            this.MemoryStopImportingButton.Name = "MemoryStopImportingButton";
            this.MemoryStopImportingButton.Size = new System.Drawing.Size(184, 26);
            this.MemoryStopImportingButton.TabIndex = 46;
            this.MemoryStopImportingButton.Text = "Stop Importing";
            this.MemoryStopImportingButton.UseVisualStyleBackColor = true;
            this.MemoryStopImportingButton.Click += new System.EventHandler(this.MemoryStopImportingButton_Click);
            // 
            // MemoryImportingProgressBar
            // 
            this.MemoryImportingProgressBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MemoryImportingProgressBar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MemoryImportingProgressBar.Location = new System.Drawing.Point(237, 204);
            this.MemoryImportingProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.MemoryImportingProgressBar.Name = "MemoryImportingProgressBar";
            this.MemoryImportingProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MemoryImportingProgressBar.Size = new System.Drawing.Size(212, 10);
            this.MemoryImportingProgressBar.TabIndex = 45;
            // 
            // MemoryClearButton
            // 
            this.MemoryClearButton.Location = new System.Drawing.Point(28, 107);
            this.MemoryClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.MemoryClearButton.Name = "MemoryClearButton";
            this.MemoryClearButton.Size = new System.Drawing.Size(184, 26);
            this.MemoryClearButton.TabIndex = 44;
            this.MemoryClearButton.Text = "Clear Memory";
            this.MemoryClearButton.UseVisualStyleBackColor = true;
            this.MemoryClearButton.Click += new System.EventHandler(this.MemoryClearButton_Click);
            // 
            // MemoryStartImportingButton
            // 
            this.MemoryStartImportingButton.Location = new System.Drawing.Point(28, 250);
            this.MemoryStartImportingButton.Margin = new System.Windows.Forms.Padding(4);
            this.MemoryStartImportingButton.Name = "MemoryStartImportingButton";
            this.MemoryStartImportingButton.Size = new System.Drawing.Size(184, 26);
            this.MemoryStartImportingButton.TabIndex = 43;
            this.MemoryStartImportingButton.Text = "Start Importing";
            this.MemoryStartImportingButton.UseVisualStyleBackColor = true;
            this.MemoryStartImportingButton.Click += new System.EventHandler(this.MemoryStartImportingButton_Click);
            // 
            // MemoryAvailableTimeLabel
            // 
            this.MemoryAvailableTimeLabel.Location = new System.Drawing.Point(311, 137);
            this.MemoryAvailableTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MemoryAvailableTimeLabel.Name = "MemoryAvailableTimeLabel";
            this.MemoryAvailableTimeLabel.Size = new System.Drawing.Size(139, 23);
            this.MemoryAvailableTimeLabel.TabIndex = 42;
            this.MemoryAvailableTimeLabel.Text = "Available Time [m]";
            this.MemoryAvailableTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MemoryUsedSpaceLabel
            // 
            this.MemoryUsedSpaceLabel.Location = new System.Drawing.Point(315, 81);
            this.MemoryUsedSpaceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MemoryUsedSpaceLabel.Name = "MemoryUsedSpaceLabel";
            this.MemoryUsedSpaceLabel.Size = new System.Drawing.Size(135, 23);
            this.MemoryUsedSpaceLabel.TabIndex = 41;
            this.MemoryUsedSpaceLabel.Text = "Used Space [%]";
            this.MemoryUsedSpaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MemoryTrialsNumberLabel
            // 
            this.MemoryTrialsNumberLabel.Location = new System.Drawing.Point(315, 25);
            this.MemoryTrialsNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MemoryTrialsNumberLabel.Name = "MemoryTrialsNumberLabel";
            this.MemoryTrialsNumberLabel.Size = new System.Drawing.Size(135, 23);
            this.MemoryTrialsNumberLabel.TabIndex = 40;
            this.MemoryTrialsNumberLabel.Text = "Trials Number";
            this.MemoryTrialsNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MemoryAvailableTimeTextBox
            // 
            this.MemoryAvailableTimeTextBox.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.MemoryAvailableTimeTextBox.Location = new System.Drawing.Point(315, 164);
            this.MemoryAvailableTimeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MemoryAvailableTimeTextBox.Name = "MemoryAvailableTimeTextBox";
            this.MemoryAvailableTimeTextBox.ReadOnly = true;
            this.MemoryAvailableTimeTextBox.Size = new System.Drawing.Size(133, 22);
            this.MemoryAvailableTimeTextBox.TabIndex = 39;
            // 
            // MemoryUsedSpaceTextBox
            // 
            this.MemoryUsedSpaceTextBox.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.MemoryUsedSpaceTextBox.Location = new System.Drawing.Point(315, 108);
            this.MemoryUsedSpaceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MemoryUsedSpaceTextBox.Name = "MemoryUsedSpaceTextBox";
            this.MemoryUsedSpaceTextBox.ReadOnly = true;
            this.MemoryUsedSpaceTextBox.Size = new System.Drawing.Size(133, 22);
            this.MemoryUsedSpaceTextBox.TabIndex = 38;
            // 
            // MemoryTrialsNumberTextBox
            // 
            this.MemoryTrialsNumberTextBox.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.MemoryTrialsNumberTextBox.Location = new System.Drawing.Point(315, 52);
            this.MemoryTrialsNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MemoryTrialsNumberTextBox.Name = "MemoryTrialsNumberTextBox";
            this.MemoryTrialsNumberTextBox.ReadOnly = true;
            this.MemoryTrialsNumberTextBox.Size = new System.Drawing.Size(133, 22);
            this.MemoryTrialsNumberTextBox.TabIndex = 37;
            // 
            // GetMemoryStatusButton
            // 
            this.GetMemoryStatusButton.Location = new System.Drawing.Point(28, 50);
            this.GetMemoryStatusButton.Margin = new System.Windows.Forms.Padding(4);
            this.GetMemoryStatusButton.Name = "GetMemoryStatusButton";
            this.GetMemoryStatusButton.Size = new System.Drawing.Size(184, 26);
            this.GetMemoryStatusButton.TabIndex = 0;
            this.GetMemoryStatusButton.Text = "Get Memory Status";
            this.GetMemoryStatusButton.UseVisualStyleBackColor = true;
            this.GetMemoryStatusButton.Click += new System.EventHandler(this.GetMemoryStatusButton_Click);
            // 
            // RemoteRecordingGroupBox
            // 
            this.RemoteRecordingGroupBox.Controls.Add(this.RemoteRecordingPanel);
            this.RemoteRecordingGroupBox.Controls.Add(this.MemoryModeEnableCheckBox);
            this.RemoteRecordingGroupBox.Location = new System.Drawing.Point(835, 366);
            this.RemoteRecordingGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.RemoteRecordingGroupBox.Name = "RemoteRecordingGroupBox";
            this.RemoteRecordingGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.RemoteRecordingGroupBox.Size = new System.Drawing.Size(476, 161);
            this.RemoteRecordingGroupBox.TabIndex = 22;
            this.RemoteRecordingGroupBox.TabStop = false;
            this.RemoteRecordingGroupBox.Text = "Remote Recording";
            // 
            // RemoteRecordingPanel
            // 
            this.RemoteRecordingPanel.Controls.Add(this.StopRemoteRecordingButton);
            this.RemoteRecordingPanel.Controls.Add(this.StartRemoteRecordingButton);
            this.RemoteRecordingPanel.Enabled = false;
            this.RemoteRecordingPanel.Location = new System.Drawing.Point(8, 57);
            this.RemoteRecordingPanel.Margin = new System.Windows.Forms.Padding(4);
            this.RemoteRecordingPanel.Name = "RemoteRecordingPanel";
            this.RemoteRecordingPanel.Size = new System.Drawing.Size(460, 92);
            this.RemoteRecordingPanel.TabIndex = 1;
            // 
            // StopRemoteRecordingButton
            // 
            this.StopRemoteRecordingButton.Location = new System.Drawing.Point(257, 34);
            this.StopRemoteRecordingButton.Margin = new System.Windows.Forms.Padding(4);
            this.StopRemoteRecordingButton.Name = "StopRemoteRecordingButton";
            this.StopRemoteRecordingButton.Size = new System.Drawing.Size(184, 26);
            this.StopRemoteRecordingButton.TabIndex = 1;
            this.StopRemoteRecordingButton.Text = "Remote Stop Recording";
            this.StopRemoteRecordingButton.UseVisualStyleBackColor = true;
            this.StopRemoteRecordingButton.Click += new System.EventHandler(this.StopRemoteRecordingButton_Click);
            // 
            // StartRemoteRecordingButton
            // 
            this.StartRemoteRecordingButton.Location = new System.Drawing.Point(20, 34);
            this.StartRemoteRecordingButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartRemoteRecordingButton.Name = "StartRemoteRecordingButton";
            this.StartRemoteRecordingButton.Size = new System.Drawing.Size(184, 26);
            this.StartRemoteRecordingButton.TabIndex = 0;
            this.StartRemoteRecordingButton.Text = "Remote Start Recording";
            this.StartRemoteRecordingButton.UseVisualStyleBackColor = true;
            this.StartRemoteRecordingButton.Click += new System.EventHandler(this.StartRemoteRecordingButton_Click);
            // 
            // MemoryModeEnableCheckBox
            // 
            this.MemoryModeEnableCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MemoryModeEnableCheckBox.Location = new System.Drawing.Point(27, 25);
            this.MemoryModeEnableCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.MemoryModeEnableCheckBox.Name = "MemoryModeEnableCheckBox";
            this.MemoryModeEnableCheckBox.Size = new System.Drawing.Size(185, 26);
            this.MemoryModeEnableCheckBox.TabIndex = 0;
            this.MemoryModeEnableCheckBox.Text = "Enable Memory Mode";
            this.MemoryModeEnableCheckBox.UseVisualStyleBackColor = true;
            this.MemoryModeEnableCheckBox.CheckedChanged += new System.EventHandler(this.MemoryModeEnableCheckBox_CheckedChanged);
            // 
            // WaveplusDaqExampleForm
            // 
            this.AcceptButton = this.ConfigureCaptureAndSensorsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 540);
            this.Controls.Add(this.RemoteRecordingGroupBox);
            this.Controls.Add(this.SensorMemoryGroupBox);
            this.Controls.Add(this.ChangeMasterRFChannelGroupBox);
            this.Controls.Add(this.CaptureGroupBox);
            this.Controls.Add(this.DeviceGroupBox);
            this.Controls.Add(this.CaptionAndSensorsConfigurationGroupBox);
            this.Controls.Add(this.SensorStateGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(1000, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "WaveplusDaqExampleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Waveplus Daq Overview";
            this.CaptionAndSensorsConfigurationGroupBox.ResumeLayout(false);
            this.DeviceGroupBox.ResumeLayout(false);
            this.DeviceGroupBox.PerformLayout();
            this.CaptureGroupBox.ResumeLayout(false);
            this.CaptureGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SensorSelectionNumericUpDown)).EndInit();
            this.SensorStateGroupBox.ResumeLayout(false);
            this.ChangeMasterRFChannelGroupBox.ResumeLayout(false);
            this.ChangeMasterRFChannelGroupBox.PerformLayout();
            this.SensorMemoryGroupBox.ResumeLayout(false);
            this.SensorMemoryGroupBox.PerformLayout();
            this.RemoteRecordingGroupBox.ResumeLayout(false);
            this.RemoteRecordingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DeviceStatusLabel;
        private System.Windows.Forms.TextBox DeviceStatusTextBox;
        private System.Windows.Forms.Button FirmwareVersionButton;
        private System.Windows.Forms.GroupBox CaptionAndSensorsConfigurationGroupBox;
        private System.Windows.Forms.Button StopCaptureButton;
        private System.Windows.Forms.Button StartCaptureButton;
        private System.Windows.Forms.Label AcquiredScanLabel;
        private System.Windows.Forms.TextBox AcquiredSamplesPerChannelTextBox;
        private System.Windows.Forms.Button HardwareVersionButton;
        private System.Windows.Forms.GroupBox DeviceGroupBox;
        private System.Windows.Forms.GroupBox CaptureGroupBox;
        private System.Windows.Forms.TextBox HwVersionTextBox;
        private System.Windows.Forms.Label ErrorCodeLabel;
        private System.Windows.Forms.TextBox FwVersionTextBox;
        private System.Windows.Forms.Label HardwareVersionLabel;
        private System.Windows.Forms.Label FirmwareVersionLabel;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button ConfigureCaptureAndSensorsButton;
        private System.Windows.Forms.TextBox ErrorMessageTextBox;
        private System.Windows.Forms.Label InstalledSensorsLabel;
        private System.Windows.Forms.TextBox InstalledSensorsTextBox;
        private System.Windows.Forms.Button GetInstalledSensorsButton;
        private System.Windows.Forms.Label InstalledFootSwSensorsLabel;
        private System.Windows.Forms.TextBox InstalledFootSwSensorsTextBox;
        private System.Windows.Forms.Button GetInstalledFootSwSensorsButton;
        private System.Windows.Forms.NumericUpDown SensorSelectionNumericUpDown;
        private System.Windows.Forms.Label SensorSelectionLabel;
        private System.Windows.Forms.Button DetectAccelerometerOffsetButton;
        private System.Windows.Forms.TextBox StopTriggerScanTextBox;
        private System.Windows.Forms.Label StopTriggerScanLabel;
        private System.Windows.Forms.TextBox StartTriggerScanTextBox;
        private System.Windows.Forms.Label StartTriggerScanLabel;
        private System.Windows.Forms.CheckBox StopTriggerDetectedCheckBox;
        private System.Windows.Forms.CheckBox StartTriggerDetectedCheckBox;
        private System.Windows.Forms.Button GenerateStopTriggerButton;
        private System.Windows.Forms.Button GenerateStartTriggerButton;
        private System.Windows.Forms.Label FswALabel;
        private System.Windows.Forms.Label FswBLabel;
        private System.Windows.Forms.ProgressBar FswABatteryLevelProgressBar;
        private System.Windows.Forms.ProgressBar FswBBatteryLevelProgressBar;
        private System.Windows.Forms.GroupBox SensorStateGroupBox;
        private System.Windows.Forms.Panel SensorStatePanel;
        private System.Windows.Forms.Button CalibrateImuSensorOffsetButton;
        private System.Windows.Forms.Label SoftwareVersionLabel;
        private System.Windows.Forms.TextBox SwVersionTextBox;
        private System.Windows.Forms.Button SoftwareVersionButton;
        private System.Windows.Forms.Label labelDataAvailableEventPeriod;
        private System.Windows.Forms.ComboBox comboBoxDataAvailableEventPeriod;
        private System.Windows.Forms.GroupBox ChangeMasterRFChannelGroupBox;
        private System.Windows.Forms.Button ChangeMasterRFChannelChangeSensorButton;
        private System.Windows.Forms.Label ChangeMasterRFChannelCurrentLabel;
        private System.Windows.Forms.Label ChangeMasterRFChannelNewLabel;
        private System.Windows.Forms.Button ChangeMasterRFChannelReadDeviceCurrentButton;
        private System.Windows.Forms.TextBox ChangeMasterRFChannelCurrentTextBox;
        private System.Windows.Forms.ComboBox ChangeMasterRFChannelNewComboBox;
        private System.Windows.Forms.Button ChangeMasterRFChannelChangeDeviceButton;
        private System.Windows.Forms.GroupBox SensorMemoryGroupBox;
        private System.Windows.Forms.GroupBox RemoteRecordingGroupBox;
        private System.Windows.Forms.CheckBox MemoryModeEnableCheckBox;
        private System.Windows.Forms.Panel RemoteRecordingPanel;
        private System.Windows.Forms.Button StartRemoteRecordingButton;
        private System.Windows.Forms.Button StopRemoteRecordingButton;
        private System.Windows.Forms.Button GetMemoryStatusButton;
        private System.Windows.Forms.TextBox MemoryAvailableTimeTextBox;
        private System.Windows.Forms.TextBox MemoryUsedSpaceTextBox;
        private System.Windows.Forms.TextBox MemoryTrialsNumberTextBox;
        private System.Windows.Forms.Label MemoryAvailableTimeLabel;
        private System.Windows.Forms.Label MemoryUsedSpaceLabel;
        private System.Windows.Forms.Label MemoryTrialsNumberLabel;
        private System.Windows.Forms.Button MemoryClearButton;
        private System.Windows.Forms.Button MemoryStartImportingButton;
        private System.Windows.Forms.ProgressBar MemoryImportingProgressBar;
        private System.Windows.Forms.Button MemoryStopImportingButton;
        private System.Windows.Forms.Label ImportedSamplesPerChannelLabel;
        private System.Windows.Forms.TextBox ImportedSamplesPerChannelTextBox;
        private System.Windows.Forms.Label ImportedTrialsNumberLabel;
        private System.Windows.Forms.TextBox ImportedTrialsTextBox;
        private System.Windows.Forms.Button MemoryStartSelectiveImportingButton;
    }
}