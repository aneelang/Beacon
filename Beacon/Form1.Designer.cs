namespace Beacon
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.labelAppTitle = new System.Windows.Forms.Label();
            this.labelReadConfiguration = new System.Windows.Forms.Label();
            this.labelWriteConfiguration = new System.Windows.Forms.Label();
            this.groupBoxReadSettings = new System.Windows.Forms.GroupBox();
            this.labelReadDbm = new System.Windows.Forms.Label();
            this.checkReadBoxGoToSleepMode = new System.Windows.Forms.CheckBox();
            this.labelReadTXCount = new System.Windows.Forms.Label();
            this.textBoxReadTXCount = new System.Windows.Forms.TextBox();
            this.textBoxReadMagnetCount = new System.Windows.Forms.TextBox();
            this.labelReadMagnetCount = new System.Windows.Forms.Label();
            this.labelReadPowerLevel = new System.Windows.Forms.Label();
            this.labelReadGoToSleepMode = new System.Windows.Forms.Label();
            this.labelReadMhz = new System.Windows.Forms.Label();
            this.comboBoxReadPowerLevel = new System.Windows.Forms.ComboBox();
            this.comboBoxReadChannel = new System.Windows.Forms.ComboBox();
            this.labelReadChannel = new System.Windows.Forms.Label();
            this.labelReadKbps = new System.Windows.Forms.Label();
            this.comboBoxReadRFBaudRead = new System.Windows.Forms.ComboBox();
            this.labelReadRFBaudRate = new System.Windows.Forms.Label();
            this.labelReadSec = new System.Windows.Forms.Label();
            this.textBoxReadTimeInterval = new System.Windows.Forms.TextBox();
            this.labelReadTimeInterval = new System.Windows.Forms.Label();
            this.textBoxReadTagId = new System.Windows.Forms.TextBox();
            this.labelReadTagId = new System.Windows.Forms.Label();
            this.groupBoxWriteSettings = new System.Windows.Forms.GroupBox();
            this.textBoxWriteTagId = new System.Windows.Forms.TextBox();
            this.labelWriteTagId = new System.Windows.Forms.Label();
            this.labelWriteSec = new System.Windows.Forms.Label();
            this.textBoxWriteTimeInterval = new System.Windows.Forms.TextBox();
            this.labelWriteTimeInterval = new System.Windows.Forms.Label();
            this.labelWriteKbps = new System.Windows.Forms.Label();
            this.comboBoxWriteRFBaudRate = new System.Windows.Forms.ComboBox();
            this.labelWriteRFBaudRate = new System.Windows.Forms.Label();
            this.labelWriteMhz = new System.Windows.Forms.Label();
            this.comboBoxWriteChannel = new System.Windows.Forms.ComboBox();
            this.labelWriteChannel = new System.Windows.Forms.Label();
            this.checkBoxWriteGoToSleepMode = new System.Windows.Forms.CheckBox();
            this.labelWriteGoToSleepMode = new System.Windows.Forms.Label();
            this.labelWriteDbm = new System.Windows.Forms.Label();
            this.labelWritePowerLevel = new System.Windows.Forms.Label();
            this.comboBoxWritePowerLevel = new System.Windows.Forms.ComboBox();
            this.groupBoxPCSetting = new System.Windows.Forms.GroupBox();
            this.labelSerialPort = new System.Windows.Forms.Label();
            this.comboBoxSerialPort = new System.Windows.Forms.ComboBox();
            this.buttonWriteToDevice = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelWriteToDeviceTimeOut = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxReadSettings.SuspendLayout();
            this.groupBoxWriteSettings.SuspendLayout();
            this.groupBoxPCSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAppTitle
            // 
            this.labelAppTitle.AutoSize = true;
            this.labelAppTitle.BackColor = System.Drawing.Color.Cornsilk;
            this.labelAppTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppTitle.Location = new System.Drawing.Point(191, 30);
            this.labelAppTitle.Name = "labelAppTitle";
            this.labelAppTitle.Size = new System.Drawing.Size(303, 29);
            this.labelAppTitle.TabIndex = 0;
            this.labelAppTitle.Text = "RF Tag User Configuration";
            // 
            // labelReadConfiguration
            // 
            this.labelReadConfiguration.AutoSize = true;
            this.labelReadConfiguration.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReadConfiguration.Location = new System.Drawing.Point(61, 114);
            this.labelReadConfiguration.Name = "labelReadConfiguration";
            this.labelReadConfiguration.Size = new System.Drawing.Size(225, 21);
            this.labelReadConfiguration.TabIndex = 1;
            this.labelReadConfiguration.Text = "Read Configuration Settings";
            // 
            // labelWriteConfiguration
            // 
            this.labelWriteConfiguration.AutoSize = true;
            this.labelWriteConfiguration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWriteConfiguration.Location = new System.Drawing.Point(430, 114);
            this.labelWriteConfiguration.Name = "labelWriteConfiguration";
            this.labelWriteConfiguration.Size = new System.Drawing.Size(208, 20);
            this.labelWriteConfiguration.TabIndex = 2;
            this.labelWriteConfiguration.Text = "Write Configuration Settings";
            // 
            // groupBoxReadSettings
            // 
            this.groupBoxReadSettings.Controls.Add(this.labelReadDbm);
            this.groupBoxReadSettings.Controls.Add(this.checkReadBoxGoToSleepMode);
            this.groupBoxReadSettings.Controls.Add(this.labelReadTXCount);
            this.groupBoxReadSettings.Controls.Add(this.textBoxReadTXCount);
            this.groupBoxReadSettings.Controls.Add(this.textBoxReadMagnetCount);
            this.groupBoxReadSettings.Controls.Add(this.labelReadMagnetCount);
            this.groupBoxReadSettings.Controls.Add(this.labelReadPowerLevel);
            this.groupBoxReadSettings.Controls.Add(this.labelReadGoToSleepMode);
            this.groupBoxReadSettings.Controls.Add(this.labelReadMhz);
            this.groupBoxReadSettings.Controls.Add(this.comboBoxReadPowerLevel);
            this.groupBoxReadSettings.Controls.Add(this.comboBoxReadChannel);
            this.groupBoxReadSettings.Controls.Add(this.labelReadChannel);
            this.groupBoxReadSettings.Controls.Add(this.labelReadKbps);
            this.groupBoxReadSettings.Controls.Add(this.comboBoxReadRFBaudRead);
            this.groupBoxReadSettings.Controls.Add(this.labelReadRFBaudRate);
            this.groupBoxReadSettings.Controls.Add(this.labelReadSec);
            this.groupBoxReadSettings.Controls.Add(this.textBoxReadTimeInterval);
            this.groupBoxReadSettings.Controls.Add(this.labelReadTimeInterval);
            this.groupBoxReadSettings.Controls.Add(this.textBoxReadTagId);
            this.groupBoxReadSettings.Controls.Add(this.labelReadTagId);
            this.groupBoxReadSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReadSettings.Location = new System.Drawing.Point(13, 139);
            this.groupBoxReadSettings.Name = "groupBoxReadSettings";
            this.groupBoxReadSettings.Size = new System.Drawing.Size(286, 324);
            this.groupBoxReadSettings.TabIndex = 3;
            this.groupBoxReadSettings.TabStop = false;
            this.groupBoxReadSettings.Text = "Read Settings";
            // 
            // labelReadDbm
            // 
            this.labelReadDbm.AutoSize = true;
            this.labelReadDbm.Location = new System.Drawing.Point(164, 204);
            this.labelReadDbm.Name = "labelReadDbm";
            this.labelReadDbm.Size = new System.Drawing.Size(39, 18);
            this.labelReadDbm.TabIndex = 19;
            this.labelReadDbm.Text = "dBm";
            // 
            // checkReadBoxGoToSleepMode
            // 
            this.checkReadBoxGoToSleepMode.AutoSize = true;
            this.checkReadBoxGoToSleepMode.Location = new System.Drawing.Point(143, 179);
            this.checkReadBoxGoToSleepMode.Name = "checkReadBoxGoToSleepMode";
            this.checkReadBoxGoToSleepMode.Size = new System.Drawing.Size(15, 14);
            this.checkReadBoxGoToSleepMode.TabIndex = 18;
            this.checkReadBoxGoToSleepMode.UseVisualStyleBackColor = true;
            // 
            // labelReadTXCount
            // 
            this.labelReadTXCount.AutoSize = true;
            this.labelReadTXCount.Location = new System.Drawing.Point(6, 277);
            this.labelReadTXCount.Name = "labelReadTXCount";
            this.labelReadTXCount.Size = new System.Drawing.Size(71, 18);
            this.labelReadTXCount.TabIndex = 17;
            this.labelReadTXCount.Text = "TX Count";
            // 
            // textBoxReadTXCount
            // 
            this.textBoxReadTXCount.Location = new System.Drawing.Point(110, 271);
            this.textBoxReadTXCount.Name = "textBoxReadTXCount";
            this.textBoxReadTXCount.Size = new System.Drawing.Size(164, 24);
            this.textBoxReadTXCount.TabIndex = 16;
            // 
            // textBoxReadMagnetCount
            // 
            this.textBoxReadMagnetCount.Location = new System.Drawing.Point(110, 241);
            this.textBoxReadMagnetCount.Name = "textBoxReadMagnetCount";
            this.textBoxReadMagnetCount.Size = new System.Drawing.Size(164, 24);
            this.textBoxReadMagnetCount.TabIndex = 15;
            // 
            // labelReadMagnetCount
            // 
            this.labelReadMagnetCount.AutoSize = true;
            this.labelReadMagnetCount.Location = new System.Drawing.Point(7, 241);
            this.labelReadMagnetCount.Name = "labelReadMagnetCount";
            this.labelReadMagnetCount.Size = new System.Drawing.Size(101, 18);
            this.labelReadMagnetCount.TabIndex = 14;
            this.labelReadMagnetCount.Text = "Magnet Count";
            // 
            // labelReadPowerLevel
            // 
            this.labelReadPowerLevel.AutoSize = true;
            this.labelReadPowerLevel.Location = new System.Drawing.Point(6, 208);
            this.labelReadPowerLevel.Name = "labelReadPowerLevel";
            this.labelReadPowerLevel.Size = new System.Drawing.Size(89, 18);
            this.labelReadPowerLevel.TabIndex = 13;
            this.labelReadPowerLevel.Text = "Power Level";
            // 
            // labelReadGoToSleepMode
            // 
            this.labelReadGoToSleepMode.AutoSize = true;
            this.labelReadGoToSleepMode.Location = new System.Drawing.Point(7, 175);
            this.labelReadGoToSleepMode.Name = "labelReadGoToSleepMode";
            this.labelReadGoToSleepMode.Size = new System.Drawing.Size(134, 18);
            this.labelReadGoToSleepMode.TabIndex = 12;
            this.labelReadGoToSleepMode.Text = "Go To Sleep Mode";
            // 
            // labelReadMhz
            // 
            this.labelReadMhz.AutoSize = true;
            this.labelReadMhz.Location = new System.Drawing.Point(164, 149);
            this.labelReadMhz.Name = "labelReadMhz";
            this.labelReadMhz.Size = new System.Drawing.Size(40, 18);
            this.labelReadMhz.TabIndex = 11;
            this.labelReadMhz.Text = "MHz";
            // 
            // comboBoxReadPowerLevel
            // 
            this.comboBoxReadPowerLevel.FormattingEnabled = true;
            this.comboBoxReadPowerLevel.Location = new System.Drawing.Point(110, 201);
            this.comboBoxReadPowerLevel.Name = "comboBoxReadPowerLevel";
            this.comboBoxReadPowerLevel.Size = new System.Drawing.Size(48, 26);
            this.comboBoxReadPowerLevel.TabIndex = 10;
            // 
            // comboBoxReadChannel
            // 
            this.comboBoxReadChannel.FormattingEnabled = true;
            this.comboBoxReadChannel.Location = new System.Drawing.Point(110, 144);
            this.comboBoxReadChannel.Name = "comboBoxReadChannel";
            this.comboBoxReadChannel.Size = new System.Drawing.Size(48, 26);
            this.comboBoxReadChannel.TabIndex = 9;
            // 
            // labelReadChannel
            // 
            this.labelReadChannel.AutoSize = true;
            this.labelReadChannel.Location = new System.Drawing.Point(7, 144);
            this.labelReadChannel.Name = "labelReadChannel";
            this.labelReadChannel.Size = new System.Drawing.Size(62, 18);
            this.labelReadChannel.TabIndex = 8;
            this.labelReadChannel.Text = "Channel";
            // 
            // labelReadKbps
            // 
            this.labelReadKbps.AutoSize = true;
            this.labelReadKbps.Location = new System.Drawing.Point(164, 112);
            this.labelReadKbps.Name = "labelReadKbps";
            this.labelReadKbps.Size = new System.Drawing.Size(40, 18);
            this.labelReadKbps.TabIndex = 7;
            this.labelReadKbps.Text = "kbps";
            // 
            // comboBoxReadRFBaudRead
            // 
            this.comboBoxReadRFBaudRead.FormattingEnabled = true;
            this.comboBoxReadRFBaudRead.Location = new System.Drawing.Point(110, 109);
            this.comboBoxReadRFBaudRead.Name = "comboBoxReadRFBaudRead";
            this.comboBoxReadRFBaudRead.Size = new System.Drawing.Size(48, 26);
            this.comboBoxReadRFBaudRead.TabIndex = 6;
            // 
            // labelReadRFBaudRate
            // 
            this.labelReadRFBaudRate.AutoSize = true;
            this.labelReadRFBaudRate.Location = new System.Drawing.Point(7, 108);
            this.labelReadRFBaudRate.Name = "labelReadRFBaudRate";
            this.labelReadRFBaudRate.Size = new System.Drawing.Size(101, 18);
            this.labelReadRFBaudRate.TabIndex = 5;
            this.labelReadRFBaudRate.Text = "RF Baud Rate";
            // 
            // labelReadSec
            // 
            this.labelReadSec.AutoSize = true;
            this.labelReadSec.Location = new System.Drawing.Point(164, 75);
            this.labelReadSec.Name = "labelReadSec";
            this.labelReadSec.Size = new System.Drawing.Size(34, 18);
            this.labelReadSec.TabIndex = 4;
            this.labelReadSec.Text = "Sec";
            // 
            // textBoxReadTimeInterval
            // 
            this.textBoxReadTimeInterval.Location = new System.Drawing.Point(110, 68);
            this.textBoxReadTimeInterval.Name = "textBoxReadTimeInterval";
            this.textBoxReadTimeInterval.Size = new System.Drawing.Size(48, 24);
            this.textBoxReadTimeInterval.TabIndex = 3;
            // 
            // labelReadTimeInterval
            // 
            this.labelReadTimeInterval.AutoSize = true;
            this.labelReadTimeInterval.Location = new System.Drawing.Point(7, 71);
            this.labelReadTimeInterval.Name = "labelReadTimeInterval";
            this.labelReadTimeInterval.Size = new System.Drawing.Size(91, 18);
            this.labelReadTimeInterval.TabIndex = 2;
            this.labelReadTimeInterval.Text = "Time Interval";
            // 
            // textBoxReadTagId
            // 
            this.textBoxReadTagId.Location = new System.Drawing.Point(110, 28);
            this.textBoxReadTagId.Name = "textBoxReadTagId";
            this.textBoxReadTagId.Size = new System.Drawing.Size(164, 24);
            this.textBoxReadTagId.TabIndex = 1;
            // 
            // labelReadTagId
            // 
            this.labelReadTagId.AutoSize = true;
            this.labelReadTagId.Location = new System.Drawing.Point(7, 39);
            this.labelReadTagId.Name = "labelReadTagId";
            this.labelReadTagId.Size = new System.Drawing.Size(56, 18);
            this.labelReadTagId.TabIndex = 0;
            this.labelReadTagId.Text = "TAG ID";
            // 
            // groupBoxWriteSettings
            // 
            this.groupBoxWriteSettings.Controls.Add(this.labelWriteDbm);
            this.groupBoxWriteSettings.Controls.Add(this.labelWritePowerLevel);
            this.groupBoxWriteSettings.Controls.Add(this.comboBoxWritePowerLevel);
            this.groupBoxWriteSettings.Controls.Add(this.checkBoxWriteGoToSleepMode);
            this.groupBoxWriteSettings.Controls.Add(this.labelWriteGoToSleepMode);
            this.groupBoxWriteSettings.Controls.Add(this.labelWriteMhz);
            this.groupBoxWriteSettings.Controls.Add(this.comboBoxWriteChannel);
            this.groupBoxWriteSettings.Controls.Add(this.labelWriteChannel);
            this.groupBoxWriteSettings.Controls.Add(this.labelWriteKbps);
            this.groupBoxWriteSettings.Controls.Add(this.comboBoxWriteRFBaudRate);
            this.groupBoxWriteSettings.Controls.Add(this.labelWriteRFBaudRate);
            this.groupBoxWriteSettings.Controls.Add(this.labelWriteSec);
            this.groupBoxWriteSettings.Controls.Add(this.textBoxWriteTimeInterval);
            this.groupBoxWriteSettings.Controls.Add(this.labelWriteTimeInterval);
            this.groupBoxWriteSettings.Controls.Add(this.textBoxWriteTagId);
            this.groupBoxWriteSettings.Controls.Add(this.labelWriteTagId);
            this.groupBoxWriteSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxWriteSettings.Location = new System.Drawing.Point(367, 139);
            this.groupBoxWriteSettings.Name = "groupBoxWriteSettings";
            this.groupBoxWriteSettings.Size = new System.Drawing.Size(286, 324);
            this.groupBoxWriteSettings.TabIndex = 4;
            this.groupBoxWriteSettings.TabStop = false;
            this.groupBoxWriteSettings.Text = "Write Settings";
            // 
            // textBoxWriteTagId
            // 
            this.textBoxWriteTagId.Location = new System.Drawing.Point(113, 39);
            this.textBoxWriteTagId.Name = "textBoxWriteTagId";
            this.textBoxWriteTagId.Size = new System.Drawing.Size(158, 24);
            this.textBoxWriteTagId.TabIndex = 3;
            // 
            // labelWriteTagId
            // 
            this.labelWriteTagId.AutoSize = true;
            this.labelWriteTagId.Location = new System.Drawing.Point(6, 39);
            this.labelWriteTagId.Name = "labelWriteTagId";
            this.labelWriteTagId.Size = new System.Drawing.Size(56, 18);
            this.labelWriteTagId.TabIndex = 2;
            this.labelWriteTagId.Text = "TAG ID";
            // 
            // labelWriteSec
            // 
            this.labelWriteSec.AutoSize = true;
            this.labelWriteSec.Location = new System.Drawing.Point(156, 78);
            this.labelWriteSec.Name = "labelWriteSec";
            this.labelWriteSec.Size = new System.Drawing.Size(34, 18);
            this.labelWriteSec.TabIndex = 7;
            this.labelWriteSec.Text = "Sec";
            // 
            // textBoxWriteTimeInterval
            // 
            this.textBoxWriteTimeInterval.Location = new System.Drawing.Point(113, 72);
            this.textBoxWriteTimeInterval.Name = "textBoxWriteTimeInterval";
            this.textBoxWriteTimeInterval.Size = new System.Drawing.Size(36, 24);
            this.textBoxWriteTimeInterval.TabIndex = 6;
            // 
            // labelWriteTimeInterval
            // 
            this.labelWriteTimeInterval.AutoSize = true;
            this.labelWriteTimeInterval.Location = new System.Drawing.Point(6, 75);
            this.labelWriteTimeInterval.Name = "labelWriteTimeInterval";
            this.labelWriteTimeInterval.Size = new System.Drawing.Size(91, 18);
            this.labelWriteTimeInterval.TabIndex = 5;
            this.labelWriteTimeInterval.Text = "Time Interval";
            // 
            // labelWriteKbps
            // 
            this.labelWriteKbps.AutoSize = true;
            this.labelWriteKbps.Location = new System.Drawing.Point(168, 112);
            this.labelWriteKbps.Name = "labelWriteKbps";
            this.labelWriteKbps.Size = new System.Drawing.Size(40, 18);
            this.labelWriteKbps.TabIndex = 10;
            this.labelWriteKbps.Text = "kbps";
            // 
            // comboBoxWriteRFBaudRate
            // 
            this.comboBoxWriteRFBaudRate.FormattingEnabled = true;
            this.comboBoxWriteRFBaudRate.Location = new System.Drawing.Point(113, 108);
            this.comboBoxWriteRFBaudRate.Name = "comboBoxWriteRFBaudRate";
            this.comboBoxWriteRFBaudRate.Size = new System.Drawing.Size(48, 26);
            this.comboBoxWriteRFBaudRate.TabIndex = 9;
            // 
            // labelWriteRFBaudRate
            // 
            this.labelWriteRFBaudRate.AutoSize = true;
            this.labelWriteRFBaudRate.Location = new System.Drawing.Point(6, 111);
            this.labelWriteRFBaudRate.Name = "labelWriteRFBaudRate";
            this.labelWriteRFBaudRate.Size = new System.Drawing.Size(101, 18);
            this.labelWriteRFBaudRate.TabIndex = 8;
            this.labelWriteRFBaudRate.Text = "RF Baud Rate";
            // 
            // labelWriteMhz
            // 
            this.labelWriteMhz.AutoSize = true;
            this.labelWriteMhz.Location = new System.Drawing.Point(167, 149);
            this.labelWriteMhz.Name = "labelWriteMhz";
            this.labelWriteMhz.Size = new System.Drawing.Size(40, 18);
            this.labelWriteMhz.TabIndex = 14;
            this.labelWriteMhz.Text = "MHz";
            // 
            // comboBoxWriteChannel
            // 
            this.comboBoxWriteChannel.FormattingEnabled = true;
            this.comboBoxWriteChannel.Location = new System.Drawing.Point(113, 144);
            this.comboBoxWriteChannel.Name = "comboBoxWriteChannel";
            this.comboBoxWriteChannel.Size = new System.Drawing.Size(48, 26);
            this.comboBoxWriteChannel.TabIndex = 13;
            // 
            // labelWriteChannel
            // 
            this.labelWriteChannel.AutoSize = true;
            this.labelWriteChannel.Location = new System.Drawing.Point(6, 144);
            this.labelWriteChannel.Name = "labelWriteChannel";
            this.labelWriteChannel.Size = new System.Drawing.Size(62, 18);
            this.labelWriteChannel.TabIndex = 12;
            this.labelWriteChannel.Text = "Channel";
            // 
            // checkBoxWriteGoToSleepMode
            // 
            this.checkBoxWriteGoToSleepMode.AutoSize = true;
            this.checkBoxWriteGoToSleepMode.Location = new System.Drawing.Point(146, 180);
            this.checkBoxWriteGoToSleepMode.Name = "checkBoxWriteGoToSleepMode";
            this.checkBoxWriteGoToSleepMode.Size = new System.Drawing.Size(15, 14);
            this.checkBoxWriteGoToSleepMode.TabIndex = 20;
            this.checkBoxWriteGoToSleepMode.UseVisualStyleBackColor = true;
            // 
            // labelWriteGoToSleepMode
            // 
            this.labelWriteGoToSleepMode.AutoSize = true;
            this.labelWriteGoToSleepMode.Location = new System.Drawing.Point(6, 176);
            this.labelWriteGoToSleepMode.Name = "labelWriteGoToSleepMode";
            this.labelWriteGoToSleepMode.Size = new System.Drawing.Size(134, 18);
            this.labelWriteGoToSleepMode.TabIndex = 19;
            this.labelWriteGoToSleepMode.Text = "Go To Sleep Mode";
            // 
            // labelWriteDbm
            // 
            this.labelWriteDbm.AutoSize = true;
            this.labelWriteDbm.Location = new System.Drawing.Point(167, 208);
            this.labelWriteDbm.Name = "labelWriteDbm";
            this.labelWriteDbm.Size = new System.Drawing.Size(39, 18);
            this.labelWriteDbm.TabIndex = 23;
            this.labelWriteDbm.Text = "dBm";
            // 
            // labelWritePowerLevel
            // 
            this.labelWritePowerLevel.AutoSize = true;
            this.labelWritePowerLevel.Location = new System.Drawing.Point(8, 208);
            this.labelWritePowerLevel.Name = "labelWritePowerLevel";
            this.labelWritePowerLevel.Size = new System.Drawing.Size(89, 18);
            this.labelWritePowerLevel.TabIndex = 22;
            this.labelWritePowerLevel.Text = "Power Level";
            // 
            // comboBoxWritePowerLevel
            // 
            this.comboBoxWritePowerLevel.FormattingEnabled = true;
            this.comboBoxWritePowerLevel.Location = new System.Drawing.Point(113, 201);
            this.comboBoxWritePowerLevel.Name = "comboBoxWritePowerLevel";
            this.comboBoxWritePowerLevel.Size = new System.Drawing.Size(48, 26);
            this.comboBoxWritePowerLevel.TabIndex = 21;
            // 
            // groupBoxPCSetting
            // 
            this.groupBoxPCSetting.Controls.Add(this.comboBoxSerialPort);
            this.groupBoxPCSetting.Controls.Add(this.labelSerialPort);
            this.groupBoxPCSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPCSetting.Location = new System.Drawing.Point(13, 482);
            this.groupBoxPCSetting.Name = "groupBoxPCSetting";
            this.groupBoxPCSetting.Size = new System.Drawing.Size(286, 57);
            this.groupBoxPCSetting.TabIndex = 5;
            this.groupBoxPCSetting.TabStop = false;
            this.groupBoxPCSetting.Text = "PC Setting";
            // 
            // labelSerialPort
            // 
            this.labelSerialPort.AutoSize = true;
            this.labelSerialPort.Location = new System.Drawing.Point(7, 29);
            this.labelSerialPort.Name = "labelSerialPort";
            this.labelSerialPort.Size = new System.Drawing.Size(77, 18);
            this.labelSerialPort.TabIndex = 15;
            this.labelSerialPort.Text = "Serial Port";
            // 
            // comboBoxSerialPort
            // 
            this.comboBoxSerialPort.FormattingEnabled = true;
            this.comboBoxSerialPort.Location = new System.Drawing.Point(110, 21);
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.Size = new System.Drawing.Size(106, 26);
            this.comboBoxSerialPort.TabIndex = 16;
            // 
            // buttonWriteToDevice
            // 
            this.buttonWriteToDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWriteToDevice.Location = new System.Drawing.Point(375, 468);
            this.buttonWriteToDevice.Name = "buttonWriteToDevice";
            this.buttonWriteToDevice.Size = new System.Drawing.Size(99, 42);
            this.buttonWriteToDevice.TabIndex = 6;
            this.buttonWriteToDevice.Text = "Write To Device";
            this.buttonWriteToDevice.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(513, 469);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(99, 42);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // labelWriteToDeviceTimeOut
            // 
            this.labelWriteToDeviceTimeOut.AutoSize = true;
            this.labelWriteToDeviceTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWriteToDeviceTimeOut.Location = new System.Drawing.Point(361, 526);
            this.labelWriteToDeviceTimeOut.Name = "labelWriteToDeviceTimeOut";
            this.labelWriteToDeviceTimeOut.Size = new System.Drawing.Size(214, 18);
            this.labelWriteToDeviceTimeOut.TabIndex = 23;
            this.labelWriteToDeviceTimeOut.Text = "Write to Device Time Out (Sec)";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(493, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 23);
            this.textBox1.TabIndex = 24;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 560);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelWriteToDeviceTimeOut);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonWriteToDevice);
            this.Controls.Add(this.groupBoxPCSetting);
            this.Controls.Add(this.groupBoxWriteSettings);
            this.Controls.Add(this.groupBoxReadSettings);
            this.Controls.Add(this.labelWriteConfiguration);
            this.Controls.Add(this.labelReadConfiguration);
            this.Controls.Add(this.labelAppTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxReadSettings.ResumeLayout(false);
            this.groupBoxReadSettings.PerformLayout();
            this.groupBoxWriteSettings.ResumeLayout(false);
            this.groupBoxWriteSettings.PerformLayout();
            this.groupBoxPCSetting.ResumeLayout(false);
            this.groupBoxPCSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAppTitle;
        private System.Windows.Forms.Label labelReadConfiguration;
        private System.Windows.Forms.Label labelWriteConfiguration;
        private System.Windows.Forms.GroupBox groupBoxReadSettings;
        private System.Windows.Forms.Label labelReadTagId;
        private System.Windows.Forms.GroupBox groupBoxWriteSettings;
        private System.Windows.Forms.Label labelReadTimeInterval;
        private System.Windows.Forms.TextBox textBoxReadTagId;
        private System.Windows.Forms.Label labelReadRFBaudRate;
        private System.Windows.Forms.Label labelReadSec;
        private System.Windows.Forms.TextBox textBoxReadTimeInterval;
        private System.Windows.Forms.Label labelReadDbm;
        private System.Windows.Forms.CheckBox checkReadBoxGoToSleepMode;
        private System.Windows.Forms.Label labelReadTXCount;
        private System.Windows.Forms.TextBox textBoxReadTXCount;
        private System.Windows.Forms.TextBox textBoxReadMagnetCount;
        private System.Windows.Forms.Label labelReadMagnetCount;
        private System.Windows.Forms.Label labelReadPowerLevel;
        private System.Windows.Forms.Label labelReadGoToSleepMode;
        private System.Windows.Forms.Label labelReadMhz;
        private System.Windows.Forms.ComboBox comboBoxReadPowerLevel;
        private System.Windows.Forms.ComboBox comboBoxReadChannel;
        private System.Windows.Forms.Label labelReadChannel;
        private System.Windows.Forms.Label labelReadKbps;
        private System.Windows.Forms.ComboBox comboBoxReadRFBaudRead;
        private System.Windows.Forms.TextBox textBoxWriteTagId;
        private System.Windows.Forms.Label labelWriteTagId;
        private System.Windows.Forms.Label labelWriteDbm;
        private System.Windows.Forms.Label labelWritePowerLevel;
        private System.Windows.Forms.ComboBox comboBoxWritePowerLevel;
        private System.Windows.Forms.CheckBox checkBoxWriteGoToSleepMode;
        private System.Windows.Forms.Label labelWriteGoToSleepMode;
        private System.Windows.Forms.Label labelWriteMhz;
        private System.Windows.Forms.ComboBox comboBoxWriteChannel;
        private System.Windows.Forms.Label labelWriteChannel;
        private System.Windows.Forms.Label labelWriteKbps;
        private System.Windows.Forms.ComboBox comboBoxWriteRFBaudRate;
        private System.Windows.Forms.Label labelWriteRFBaudRate;
        private System.Windows.Forms.Label labelWriteSec;
        private System.Windows.Forms.TextBox textBoxWriteTimeInterval;
        private System.Windows.Forms.Label labelWriteTimeInterval;
        private System.Windows.Forms.GroupBox groupBoxPCSetting;
        private System.Windows.Forms.ComboBox comboBoxSerialPort;
        private System.Windows.Forms.Label labelSerialPort;
        private System.Windows.Forms.Button buttonWriteToDevice;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelWriteToDeviceTimeOut;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

