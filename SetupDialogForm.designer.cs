
namespace ASCOM.MyCloudPWS
{
    partial class SetupDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupDialogForm));
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.picASCOM = new System.Windows.Forms.PictureBox();
            this.labelComPort = new System.Windows.Forms.Label();
            this.chkTrace = new System.Windows.Forms.CheckBox();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.textBoxDriverId = new System.Windows.Forms.Label();
            this.buttonConnectDriverId = new System.Windows.Forms.Button();
            this.buttonChooseDriverId = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageApiKey = new System.Windows.Forms.TabPage();
            this.labelSignatureWLL = new System.Windows.Forms.Label();
            this.textBoxApiSecretWLL = new System.Windows.Forms.TextBox();
            this.button1ObtainKeyWLL = new System.Windows.Forms.Button();
            this.labelTextWLL = new System.Windows.Forms.Label();
            this.labelApiUrlWLL = new System.Windows.Forms.Label();
            this.textBoxApiUrlWLL = new System.Windows.Forms.TextBox();
            this.labelApiKeyWLL = new System.Windows.Forms.Label();
            this.textBoxApiKeyWLL = new System.Windows.Forms.TextBox();
            this.buttonObtainKeyWCWU = new System.Windows.Forms.Button();
            this.buttonObtainKeyOWM = new System.Windows.Forms.Button();
            this.labelTextInterval = new System.Windows.Forms.Label();
            this.labelInterval = new System.Windows.Forms.Label();
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.labelTextTypeOptions = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.labelTextOWM3 = new System.Windows.Forms.Label();
            this.labelApiUrlOWM3 = new System.Windows.Forms.Label();
            this.textBoxApiUrlOWM3 = new System.Windows.Forms.TextBox();
            this.labelTextOWM = new System.Windows.Forms.Label();
            this.labelTextWCWU = new System.Windows.Forms.Label();
            this.labelApiUrlOWM = new System.Windows.Forms.Label();
            this.textBoxApiUrlOWM = new System.Windows.Forms.TextBox();
            this.labelApiKeyOWM = new System.Windows.Forms.Label();
            this.textBoxApiKeyOWM = new System.Windows.Forms.TextBox();
            this.labelFormatOptions = new System.Windows.Forms.Label();
            this.labelFormat = new System.Windows.Forms.Label();
            this.textBoxFormat = new System.Windows.Forms.TextBox();
            this.labelUnitOptions = new System.Windows.Forms.Label();
            this.labelUnits = new System.Windows.Forms.Label();
            this.textBoxUnits = new System.Windows.Forms.TextBox();
            this.labelApiUrlWCWU = new System.Windows.Forms.Label();
            this.textBoxApiUrlWCWU = new System.Windows.Forms.TextBox();
            this.labelApiKeyWCWU = new System.Windows.Forms.Label();
            this.textBoxApiKeyWCWU = new System.Windows.Forms.TextBox();
            this.labelApiText = new System.Windows.Forms.Label();
            this.tabPageSelectSite = new System.Windows.Forms.TabPage();
            this.textBoxStationIdWLL = new System.Windows.Forms.TextBox();
            this.radioButtonStationIdWLL = new System.Windows.Forms.RadioButton();
            this.labelStationIdWLL = new System.Windows.Forms.Label();
            this.buttonFindLocations = new System.Windows.Forms.Button();
            this.textBoxStationIdOWM3 = new System.Windows.Forms.TextBox();
            this.radioButtonStationIdOWM3 = new System.Windows.Forms.RadioButton();
            this.labelStationIdOWM3 = new System.Windows.Forms.Label();
            this.textBoxCityId = new System.Windows.Forms.TextBox();
            this.radioButtonCityId = new System.Windows.Forms.RadioButton();
            this.labelCityId = new System.Windows.Forms.Label();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.radioButtonZipCode = new System.Windows.Forms.RadioButton();
            this.labelZip = new System.Windows.Forms.Label();
            this.textBoxStationIdWCWU = new System.Windows.Forms.TextBox();
            this.radioButtonStationIdWCWU = new System.Windows.Forms.RadioButton();
            this.labelStationIdWCWU = new System.Windows.Forms.Label();
            this.textBoxCityName = new System.Windows.Forms.TextBox();
            this.radioButtonLatLong = new System.Windows.Forms.RadioButton();
            this.radioButtonCityName = new System.Windows.Forms.RadioButton();
            this.textBoxSiteElevation = new System.Windows.Forms.TextBox();
            this.labelSiteElevation = new System.Windows.Forms.Label();
            this.textBoxSiteLatitude = new System.Windows.Forms.TextBox();
            this.labelSiteLatitude = new System.Windows.Forms.Label();
            this.labelCityName = new System.Windows.Forms.Label();
            this.textBoxSiteLongitude = new System.Windows.Forms.TextBox();
            this.labelSiteLongitude = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDriverId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picASCOM)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageApiKey.SuspendLayout();
            this.tabPageSelectSite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Location = new System.Drawing.Point(1145, 551);
            this.cmdOK.Margin = new System.Windows.Forms.Padding(4);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(79, 30);
            this.cmdOK.TabIndex = 0;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(1145, 590);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(79, 31);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // LabelHeader
            // 
            this.LabelHeader.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelHeader.Location = new System.Drawing.Point(16, 11);
            this.LabelHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(473, 26);
            this.LabelHeader.TabIndex = 2;
            this.LabelHeader.Text = "This is my note to construct your driver\'s setup dialog here.";
            // 
            // picASCOM
            // 
            this.picASCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picASCOM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picASCOM.Image = global::ASCOM.MyCloudPWS.Properties.Resources.ASCOM;
            this.picASCOM.Location = new System.Drawing.Point(1155, 11);
            this.picASCOM.Margin = new System.Windows.Forms.Padding(4);
            this.picASCOM.Name = "picASCOM";
            this.picASCOM.Size = new System.Drawing.Size(48, 56);
            this.picASCOM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picASCOM.TabIndex = 3;
            this.picASCOM.TabStop = false;
            this.picASCOM.Click += new System.EventHandler(this.BrowseToAscom);
            this.picASCOM.DoubleClick += new System.EventHandler(this.BrowseToAscom);
            // 
            // labelComPort
            // 
            this.labelComPort.AutoSize = true;
            this.labelComPort.Location = new System.Drawing.Point(871, 599);
            this.labelComPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(77, 17);
            this.labelComPort.TabIndex = 5;
            this.labelComPort.Text = "Comm Port";
            this.labelComPort.Visible = false;
            // 
            // chkTrace
            // 
            this.chkTrace.AutoSize = true;
            this.chkTrace.Location = new System.Drawing.Point(1049, 599);
            this.chkTrace.Margin = new System.Windows.Forms.Padding(4);
            this.chkTrace.Name = "chkTrace";
            this.chkTrace.Size = new System.Drawing.Size(87, 21);
            this.chkTrace.TabIndex = 6;
            this.chkTrace.Text = "Trace on";
            this.chkTrace.UseVisualStyleBackColor = true;
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(951, 596);
            this.comboBoxComPort.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(89, 24);
            this.comboBoxComPort.TabIndex = 7;
            this.comboBoxComPort.Visible = false;
            // 
            // textBoxDriverId
            // 
            this.textBoxDriverId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDriverId.Location = new System.Drawing.Point(71, 596);
            this.textBoxDriverId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textBoxDriverId.Name = "textBoxDriverId";
            this.textBoxDriverId.Size = new System.Drawing.Size(597, 25);
            this.textBoxDriverId.TabIndex = 10;
            this.textBoxDriverId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonConnectDriverId
            // 
            this.buttonConnectDriverId.Location = new System.Drawing.Point(773, 594);
            this.buttonConnectDriverId.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnectDriverId.Name = "buttonConnectDriverId";
            this.buttonConnectDriverId.Size = new System.Drawing.Size(96, 28);
            this.buttonConnectDriverId.TabIndex = 9;
            this.buttonConnectDriverId.Text = "Connect";
            this.buttonConnectDriverId.UseVisualStyleBackColor = true;
            this.buttonConnectDriverId.Visible = false;
            // 
            // buttonChooseDriverId
            // 
            this.buttonChooseDriverId.Location = new System.Drawing.Point(672, 594);
            this.buttonChooseDriverId.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChooseDriverId.Name = "buttonChooseDriverId";
            this.buttonChooseDriverId.Size = new System.Drawing.Size(96, 28);
            this.buttonChooseDriverId.TabIndex = 8;
            this.buttonChooseDriverId.Text = "Choose";
            this.buttonChooseDriverId.UseVisualStyleBackColor = true;
            this.buttonChooseDriverId.Visible = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageApiKey);
            this.tabControl.Controls.Add(this.tabPageSelectSite);
            this.tabControl.Location = new System.Drawing.Point(8, 87);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1138, 508);
            this.tabControl.TabIndex = 20;
            // 
            // tabPageApiKey
            // 
            this.tabPageApiKey.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageApiKey.Controls.Add(this.labelSignatureWLL);
            this.tabPageApiKey.Controls.Add(this.textBoxApiSecretWLL);
            this.tabPageApiKey.Controls.Add(this.button1ObtainKeyWLL);
            this.tabPageApiKey.Controls.Add(this.labelTextWLL);
            this.tabPageApiKey.Controls.Add(this.labelApiUrlWLL);
            this.tabPageApiKey.Controls.Add(this.textBoxApiUrlWLL);
            this.tabPageApiKey.Controls.Add(this.labelApiKeyWLL);
            this.tabPageApiKey.Controls.Add(this.textBoxApiKeyWLL);
            this.tabPageApiKey.Controls.Add(this.buttonObtainKeyWCWU);
            this.tabPageApiKey.Controls.Add(this.buttonObtainKeyOWM);
            this.tabPageApiKey.Controls.Add(this.labelTextInterval);
            this.tabPageApiKey.Controls.Add(this.labelInterval);
            this.tabPageApiKey.Controls.Add(this.textBoxInterval);
            this.tabPageApiKey.Controls.Add(this.labelTextTypeOptions);
            this.tabPageApiKey.Controls.Add(this.labelType);
            this.tabPageApiKey.Controls.Add(this.textBoxType);
            this.tabPageApiKey.Controls.Add(this.labelTextOWM3);
            this.tabPageApiKey.Controls.Add(this.labelApiUrlOWM3);
            this.tabPageApiKey.Controls.Add(this.textBoxApiUrlOWM3);
            this.tabPageApiKey.Controls.Add(this.labelTextOWM);
            this.tabPageApiKey.Controls.Add(this.labelTextWCWU);
            this.tabPageApiKey.Controls.Add(this.labelApiUrlOWM);
            this.tabPageApiKey.Controls.Add(this.textBoxApiUrlOWM);
            this.tabPageApiKey.Controls.Add(this.labelApiKeyOWM);
            this.tabPageApiKey.Controls.Add(this.textBoxApiKeyOWM);
            this.tabPageApiKey.Controls.Add(this.labelFormatOptions);
            this.tabPageApiKey.Controls.Add(this.labelFormat);
            this.tabPageApiKey.Controls.Add(this.textBoxFormat);
            this.tabPageApiKey.Controls.Add(this.labelUnitOptions);
            this.tabPageApiKey.Controls.Add(this.labelUnits);
            this.tabPageApiKey.Controls.Add(this.textBoxUnits);
            this.tabPageApiKey.Controls.Add(this.labelApiUrlWCWU);
            this.tabPageApiKey.Controls.Add(this.textBoxApiUrlWCWU);
            this.tabPageApiKey.Controls.Add(this.labelApiKeyWCWU);
            this.tabPageApiKey.Controls.Add(this.textBoxApiKeyWCWU);
            this.tabPageApiKey.Controls.Add(this.labelApiText);
            this.tabPageApiKey.Location = new System.Drawing.Point(4, 25);
            this.tabPageApiKey.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageApiKey.Name = "tabPageApiKey";
            this.tabPageApiKey.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageApiKey.Size = new System.Drawing.Size(1130, 479);
            this.tabPageApiKey.TabIndex = 0;
            this.tabPageApiKey.Text = "API Info: Keys, URLs, & DataTypes";
            this.tabPageApiKey.Click += new System.EventHandler(this.tabPageApiKey_Click);
            // 
            // labelSignatureWLL
            // 
            this.labelSignatureWLL.AutoSize = true;
            this.labelSignatureWLL.Location = new System.Drawing.Point(459, 361);
            this.labelSignatureWLL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSignatureWLL.Name = "labelSignatureWLL";
            this.labelSignatureWLL.Size = new System.Drawing.Size(107, 17);
            this.labelSignatureWLL.TabIndex = 58;
            this.labelSignatureWLL.Text = "WLL API Secret";
            // 
            // textBoxApiSecretWLL
            // 
            this.textBoxApiSecretWLL.Location = new System.Drawing.Point(572, 358);
            this.textBoxApiSecretWLL.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxApiSecretWLL.Name = "textBoxApiSecretWLL";
            this.textBoxApiSecretWLL.Size = new System.Drawing.Size(312, 22);
            this.textBoxApiSecretWLL.TabIndex = 57;
            // 
            // button1ObtainKeyWLL
            // 
            this.button1ObtainKeyWLL.Location = new System.Drawing.Point(889, 355);
            this.button1ObtainKeyWLL.Margin = new System.Windows.Forms.Padding(4);
            this.button1ObtainKeyWLL.Name = "button1ObtainKeyWLL";
            this.button1ObtainKeyWLL.Size = new System.Drawing.Size(234, 28);
            this.button1ObtainKeyWLL.TabIndex = 56;
            this.button1ObtainKeyWLL.Text = "Obtain WLL Accnt / Key / Secret";
            this.button1ObtainKeyWLL.UseVisualStyleBackColor = true;
            this.button1ObtainKeyWLL.Click += new System.EventHandler(this.buttonObtainKeyWLL_Click);
            // 
            // labelTextWLL
            // 
            this.labelTextWLL.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTextWLL.Location = new System.Drawing.Point(5, 324);
            this.labelTextWLL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTextWLL.Name = "labelTextWLL";
            this.labelTextWLL.Size = new System.Drawing.Size(1121, 26);
            this.labelTextWLL.TabIndex = 55;
            this.labelTextWLL.Text = "WeatherLink Live (Personal Weather Stations):                                    " +
    "               Use a default API URL = \"https://api.weatherlink.com/v2/current\"";
            // 
            // labelApiUrlWLL
            // 
            this.labelApiUrlWLL.AutoSize = true;
            this.labelApiUrlWLL.Location = new System.Drawing.Point(35, 392);
            this.labelApiUrlWLL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApiUrlWLL.Name = "labelApiUrlWLL";
            this.labelApiUrlWLL.Size = new System.Drawing.Size(94, 17);
            this.labelApiUrlWLL.TabIndex = 54;
            this.labelApiUrlWLL.Text = "WLL API URL";
            // 
            // textBoxApiUrlWLL
            // 
            this.textBoxApiUrlWLL.Location = new System.Drawing.Point(143, 389);
            this.textBoxApiUrlWLL.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxApiUrlWLL.Name = "textBoxApiUrlWLL";
            this.textBoxApiUrlWLL.Size = new System.Drawing.Size(983, 22);
            this.textBoxApiUrlWLL.TabIndex = 53;
            // 
            // labelApiKeyWLL
            // 
            this.labelApiKeyWLL.AutoSize = true;
            this.labelApiKeyWLL.Location = new System.Drawing.Point(41, 360);
            this.labelApiKeyWLL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApiKeyWLL.Name = "labelApiKeyWLL";
            this.labelApiKeyWLL.Size = new System.Drawing.Size(90, 17);
            this.labelApiKeyWLL.TabIndex = 52;
            this.labelApiKeyWLL.Text = "WLL API Key";
            this.labelApiKeyWLL.Click += new System.EventHandler(this.labelApiKeyWLL_Click);
            // 
            // textBoxApiKeyWLL
            // 
            this.textBoxApiKeyWLL.Location = new System.Drawing.Point(143, 357);
            this.textBoxApiKeyWLL.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxApiKeyWLL.Name = "textBoxApiKeyWLL";
            this.textBoxApiKeyWLL.Size = new System.Drawing.Size(312, 22);
            this.textBoxApiKeyWLL.TabIndex = 51;
            this.textBoxApiKeyWLL.TextChanged += new System.EventHandler(this.textBoxApiKeyWLL_TextChanged);
            // 
            // buttonObtainKeyWCWU
            // 
            this.buttonObtainKeyWCWU.Location = new System.Drawing.Point(463, 70);
            this.buttonObtainKeyWCWU.Margin = new System.Windows.Forms.Padding(4);
            this.buttonObtainKeyWCWU.Name = "buttonObtainKeyWCWU";
            this.buttonObtainKeyWCWU.Size = new System.Drawing.Size(221, 28);
            this.buttonObtainKeyWCWU.TabIndex = 50;
            this.buttonObtainKeyWCWU.Text = "Obtain WCWU Account / Key";
            this.buttonObtainKeyWCWU.UseVisualStyleBackColor = true;
            this.buttonObtainKeyWCWU.Click += new System.EventHandler(this.buttonObtainKeyWCWU_Click);
            // 
            // buttonObtainKeyOWM
            // 
            this.buttonObtainKeyOWM.Location = new System.Drawing.Point(463, 170);
            this.buttonObtainKeyOWM.Margin = new System.Windows.Forms.Padding(4);
            this.buttonObtainKeyOWM.Name = "buttonObtainKeyOWM";
            this.buttonObtainKeyOWM.Size = new System.Drawing.Size(221, 28);
            this.buttonObtainKeyOWM.TabIndex = 23;
            this.buttonObtainKeyOWM.Text = "Obtain OWM Account / Key";
            this.buttonObtainKeyOWM.UseVisualStyleBackColor = true;
            this.buttonObtainKeyOWM.Click += new System.EventHandler(this.buttonObtainKeyOWM_Click);
            // 
            // labelTextInterval
            // 
            this.labelTextInterval.Location = new System.Drawing.Point(137, 452);
            this.labelTextInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTextInterval.Name = "labelTextInterval";
            this.labelTextInterval.Size = new System.Drawing.Size(333, 22);
            this.labelTextInterval.TabIndex = 49;
            this.labelTextInterval.Text = "Update Time Interval (minutes), also used in averaging";
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(8, 452);
            this.labelInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(54, 17);
            this.labelInterval.TabIndex = 48;
            this.labelInterval.Text = "Interval";
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Location = new System.Drawing.Point(75, 450);
            this.textBoxInterval.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(61, 22);
            this.textBoxInterval.TabIndex = 47;
            // 
            // labelTextTypeOptions
            // 
            this.labelTextTypeOptions.Location = new System.Drawing.Point(137, 420);
            this.labelTextTypeOptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTextTypeOptions.Name = "labelTextTypeOptions";
            this.labelTextTypeOptions.Size = new System.Drawing.Size(333, 22);
            this.labelTextTypeOptions.TabIndex = 46;
            this.labelTextTypeOptions.Text = "Time Increments (m, h, d) only used for OWM3 API calls";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(15, 420);
            this.labelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(40, 17);
            this.labelType.TabIndex = 45;
            this.labelType.Text = "Type";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(75, 418);
            this.textBoxType.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(61, 22);
            this.textBoxType.TabIndex = 44;
            // 
            // labelTextOWM3
            // 
            this.labelTextOWM3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTextOWM3.Location = new System.Drawing.Point(4, 242);
            this.labelTextOWM3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTextOWM3.Name = "labelTextOWM3";
            this.labelTextOWM3.Size = new System.Drawing.Size(1122, 25);
            this.labelTextOWM3.TabIndex = 43;
            this.labelTextOWM3.Text = "OpenWeatherMap v3.0 (Personal Weather Stations):                                 " +
    "         Use a default API URL = \"https://api.openweathermap.org/data/3.0/measur" +
    "ements\" ";
            // 
            // labelApiUrlOWM3
            // 
            this.labelApiUrlOWM3.AutoSize = true;
            this.labelApiUrlOWM3.Location = new System.Drawing.Point(2, 274);
            this.labelApiUrlOWM3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApiUrlOWM3.Name = "labelApiUrlOWM3";
            this.labelApiUrlOWM3.Size = new System.Drawing.Size(131, 17);
            this.labelApiUrlOWM3.TabIndex = 42;
            this.labelApiUrlOWM3.Text = "OWM v3.0 API URL";
            // 
            // textBoxApiUrlOWM3
            // 
            this.textBoxApiUrlOWM3.Location = new System.Drawing.Point(143, 271);
            this.textBoxApiUrlOWM3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxApiUrlOWM3.Name = "textBoxApiUrlOWM3";
            this.textBoxApiUrlOWM3.Size = new System.Drawing.Size(983, 22);
            this.textBoxApiUrlOWM3.TabIndex = 41;
            // 
            // labelTextOWM
            // 
            this.labelTextOWM.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTextOWM.Location = new System.Drawing.Point(7, 144);
            this.labelTextOWM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTextOWM.Name = "labelTextOWM";
            this.labelTextOWM.Size = new System.Drawing.Size(1119, 26);
            this.labelTextOWM.TabIndex = 40;
            this.labelTextOWM.Text = "OpenWeatherMap v2.5 (curated stations w/advanced AI weather predictions):   Use a" +
    " default API URL = \"https://api.openweathermap.org/data/2.5/weather\" ";
            // 
            // labelTextWCWU
            // 
            this.labelTextWCWU.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTextWCWU.Location = new System.Drawing.Point(7, 47);
            this.labelTextWCWU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTextWCWU.Name = "labelTextWCWU";
            this.labelTextWCWU.Size = new System.Drawing.Size(1119, 22);
            this.labelTextWCWU.TabIndex = 39;
            this.labelTextWCWU.Text = "WeatherChannel/WeatherUnderground (Personal Weather Stations):                 Us" +
    "e a default API URL = \"https://api.weather.com/v2/pws/observations/current\"";
            // 
            // labelApiUrlOWM
            // 
            this.labelApiUrlOWM.AutoSize = true;
            this.labelApiUrlOWM.Location = new System.Drawing.Point(5, 210);
            this.labelApiUrlOWM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApiUrlOWM.Name = "labelApiUrlOWM";
            this.labelApiUrlOWM.Size = new System.Drawing.Size(127, 17);
            this.labelApiUrlOWM.TabIndex = 38;
            this.labelApiUrlOWM.Text = "OWM v2.5API URL";
            this.labelApiUrlOWM.Click += new System.EventHandler(this.labelApiUrlOWM_Click);
            // 
            // textBoxApiUrlOWM
            // 
            this.textBoxApiUrlOWM.Location = new System.Drawing.Point(143, 207);
            this.textBoxApiUrlOWM.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxApiUrlOWM.Name = "textBoxApiUrlOWM";
            this.textBoxApiUrlOWM.Size = new System.Drawing.Size(983, 22);
            this.textBoxApiUrlOWM.TabIndex = 37;
            this.textBoxApiUrlOWM.TextChanged += new System.EventHandler(this.textBoxApiUrlOWM_TextChanged);
            // 
            // labelApiKeyOWM
            // 
            this.labelApiKeyOWM.AutoSize = true;
            this.labelApiKeyOWM.Location = new System.Drawing.Point(33, 177);
            this.labelApiKeyOWM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApiKeyOWM.Name = "labelApiKeyOWM";
            this.labelApiKeyOWM.Size = new System.Drawing.Size(96, 17);
            this.labelApiKeyOWM.TabIndex = 36;
            this.labelApiKeyOWM.Text = "OWM API Key";
            // 
            // textBoxApiKeyOWM
            // 
            this.textBoxApiKeyOWM.Location = new System.Drawing.Point(143, 174);
            this.textBoxApiKeyOWM.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxApiKeyOWM.Name = "textBoxApiKeyOWM";
            this.textBoxApiKeyOWM.Size = new System.Drawing.Size(312, 22);
            this.textBoxApiKeyOWM.TabIndex = 35;
            // 
            // labelFormatOptions
            // 
            this.labelFormatOptions.Location = new System.Drawing.Point(609, 452);
            this.labelFormatOptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFormatOptions.Name = "labelFormatOptions";
            this.labelFormatOptions.Size = new System.Drawing.Size(508, 22);
            this.labelFormatOptions.TabIndex = 34;
            this.labelFormatOptions.Text = "Data return format (json or xml) only used for WCWU API calls";
            this.labelFormatOptions.Visible = false;
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Location = new System.Drawing.Point(477, 451);
            this.labelFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(52, 17);
            this.labelFormat.TabIndex = 33;
            this.labelFormat.Text = "Format";
            this.labelFormat.Visible = false;
            // 
            // textBoxFormat
            // 
            this.textBoxFormat.Location = new System.Drawing.Point(545, 451);
            this.textBoxFormat.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFormat.Name = "textBoxFormat";
            this.textBoxFormat.Size = new System.Drawing.Size(61, 22);
            this.textBoxFormat.TabIndex = 32;
            this.textBoxFormat.Visible = false;
            // 
            // labelUnitOptions
            // 
            this.labelUnitOptions.Location = new System.Drawing.Point(616, 418);
            this.labelUnitOptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnitOptions.Name = "labelUnitOptions";
            this.labelUnitOptions.Size = new System.Drawing.Size(512, 22);
            this.labelUnitOptions.TabIndex = 31;
            this.labelUnitOptions.Text = "Units (e = English (Imperial), m=Metric, h=Hybrid (UK)) only used for WCWU API ca" +
    "lls";
            this.labelUnitOptions.Visible = false;
            this.labelUnitOptions.Click += new System.EventHandler(this.labelUnitOptions_Click);
            // 
            // labelUnits
            // 
            this.labelUnits.AutoSize = true;
            this.labelUnits.Location = new System.Drawing.Point(485, 417);
            this.labelUnits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnits.Name = "labelUnits";
            this.labelUnits.Size = new System.Drawing.Size(40, 17);
            this.labelUnits.TabIndex = 30;
            this.labelUnits.Text = "Units";
            this.labelUnits.Visible = false;
            // 
            // textBoxUnits
            // 
            this.textBoxUnits.Location = new System.Drawing.Point(552, 416);
            this.textBoxUnits.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUnits.Name = "textBoxUnits";
            this.textBoxUnits.Size = new System.Drawing.Size(61, 22);
            this.textBoxUnits.TabIndex = 29;
            this.textBoxUnits.Visible = false;
            // 
            // labelApiUrlWCWU
            // 
            this.labelApiUrlWCWU.AutoSize = true;
            this.labelApiUrlWCWU.Location = new System.Drawing.Point(21, 106);
            this.labelApiUrlWCWU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApiUrlWCWU.Name = "labelApiUrlWCWU";
            this.labelApiUrlWCWU.Size = new System.Drawing.Size(110, 17);
            this.labelApiUrlWCWU.TabIndex = 28;
            this.labelApiUrlWCWU.Text = "WCWU API URL";
            // 
            // textBoxApiUrlWCWU
            // 
            this.textBoxApiUrlWCWU.Location = new System.Drawing.Point(143, 103);
            this.textBoxApiUrlWCWU.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxApiUrlWCWU.Name = "textBoxApiUrlWCWU";
            this.textBoxApiUrlWCWU.Size = new System.Drawing.Size(983, 22);
            this.textBoxApiUrlWCWU.TabIndex = 27;
            // 
            // labelApiKeyWCWU
            // 
            this.labelApiKeyWCWU.AutoSize = true;
            this.labelApiKeyWCWU.Location = new System.Drawing.Point(23, 76);
            this.labelApiKeyWCWU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApiKeyWCWU.Name = "labelApiKeyWCWU";
            this.labelApiKeyWCWU.Size = new System.Drawing.Size(106, 17);
            this.labelApiKeyWCWU.TabIndex = 26;
            this.labelApiKeyWCWU.Text = "WCWU API Key";
            // 
            // textBoxApiKeyWCWU
            // 
            this.textBoxApiKeyWCWU.Location = new System.Drawing.Point(143, 73);
            this.textBoxApiKeyWCWU.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxApiKeyWCWU.Name = "textBoxApiKeyWCWU";
            this.textBoxApiKeyWCWU.Size = new System.Drawing.Size(312, 22);
            this.textBoxApiKeyWCWU.TabIndex = 25;
            // 
            // labelApiText
            // 
            this.labelApiText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApiText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelApiText.Location = new System.Drawing.Point(8, 4);
            this.labelApiText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApiText.Name = "labelApiText";
            this.labelApiText.Size = new System.Drawing.Size(1112, 47);
            this.labelApiText.TabIndex = 19;
            this.labelApiText.Text = "You need to obtain an API key from each of the service providers you want to use:" +
    " \r\n(e.g. openWeatherMap (OWM/OWM3), WeatherChannel/Weather Underground (WCWU), a" +
    "nd/or WeatherLink Live (WLL)).\r\n";
            // 
            // tabPageSelectSite
            // 
            this.tabPageSelectSite.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSelectSite.Controls.Add(this.textBoxStationIdWLL);
            this.tabPageSelectSite.Controls.Add(this.radioButtonStationIdWLL);
            this.tabPageSelectSite.Controls.Add(this.labelStationIdWLL);
            this.tabPageSelectSite.Controls.Add(this.buttonFindLocations);
            this.tabPageSelectSite.Controls.Add(this.textBoxStationIdOWM3);
            this.tabPageSelectSite.Controls.Add(this.radioButtonStationIdOWM3);
            this.tabPageSelectSite.Controls.Add(this.labelStationIdOWM3);
            this.tabPageSelectSite.Controls.Add(this.textBoxCityId);
            this.tabPageSelectSite.Controls.Add(this.radioButtonCityId);
            this.tabPageSelectSite.Controls.Add(this.labelCityId);
            this.tabPageSelectSite.Controls.Add(this.textBoxZipCode);
            this.tabPageSelectSite.Controls.Add(this.radioButtonZipCode);
            this.tabPageSelectSite.Controls.Add(this.labelZip);
            this.tabPageSelectSite.Controls.Add(this.textBoxStationIdWCWU);
            this.tabPageSelectSite.Controls.Add(this.radioButtonStationIdWCWU);
            this.tabPageSelectSite.Controls.Add(this.labelStationIdWCWU);
            this.tabPageSelectSite.Controls.Add(this.textBoxCityName);
            this.tabPageSelectSite.Controls.Add(this.radioButtonLatLong);
            this.tabPageSelectSite.Controls.Add(this.radioButtonCityName);
            this.tabPageSelectSite.Controls.Add(this.textBoxSiteElevation);
            this.tabPageSelectSite.Controls.Add(this.labelSiteElevation);
            this.tabPageSelectSite.Controls.Add(this.textBoxSiteLatitude);
            this.tabPageSelectSite.Controls.Add(this.labelSiteLatitude);
            this.tabPageSelectSite.Controls.Add(this.labelCityName);
            this.tabPageSelectSite.Controls.Add(this.textBoxSiteLongitude);
            this.tabPageSelectSite.Controls.Add(this.labelSiteLongitude);
            this.tabPageSelectSite.Controls.Add(this.label3);
            this.tabPageSelectSite.Controls.Add(this.dataGridView);
            this.tabPageSelectSite.Location = new System.Drawing.Point(4, 25);
            this.tabPageSelectSite.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSelectSite.Name = "tabPageSelectSite";
            this.tabPageSelectSite.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageSelectSite.Size = new System.Drawing.Size(1125, 479);
            this.tabPageSelectSite.TabIndex = 1;
            this.tabPageSelectSite.Text = "Site Info: Station, Zip, City, Lat/Lon";
            // 
            // textBoxStationIdWLL
            // 
            this.textBoxStationIdWLL.Location = new System.Drawing.Point(964, 4);
            this.textBoxStationIdWLL.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStationIdWLL.Name = "textBoxStationIdWLL";
            this.textBoxStationIdWLL.Size = new System.Drawing.Size(127, 22);
            this.textBoxStationIdWLL.TabIndex = 46;
            // 
            // radioButtonStationIdWLL
            // 
            this.radioButtonStationIdWLL.AutoSize = true;
            this.radioButtonStationIdWLL.Location = new System.Drawing.Point(1100, 6);
            this.radioButtonStationIdWLL.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonStationIdWLL.Name = "radioButtonStationIdWLL";
            this.radioButtonStationIdWLL.Size = new System.Drawing.Size(17, 16);
            this.radioButtonStationIdWLL.TabIndex = 45;
            this.radioButtonStationIdWLL.TabStop = true;
            this.radioButtonStationIdWLL.UseVisualStyleBackColor = true;
            // 
            // labelStationIdWLL
            // 
            this.labelStationIdWLL.AutoSize = true;
            this.labelStationIdWLL.Location = new System.Drawing.Point(841, 8);
            this.labelStationIdWLL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStationIdWLL.Name = "labelStationIdWLL";
            this.labelStationIdWLL.Size = new System.Drawing.Size(100, 17);
            this.labelStationIdWLL.TabIndex = 44;
            this.labelStationIdWLL.Text = "WLL Station Id";
            // 
            // buttonFindLocations
            // 
            this.buttonFindLocations.Location = new System.Drawing.Point(456, 226);
            this.buttonFindLocations.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFindLocations.Name = "buttonFindLocations";
            this.buttonFindLocations.Size = new System.Drawing.Size(136, 28);
            this.buttonFindLocations.TabIndex = 22;
            this.buttonFindLocations.Text = "Find Locations";
            this.buttonFindLocations.UseVisualStyleBackColor = true;
            this.buttonFindLocations.Click += new System.EventHandler(this.buttonFindLocations_Click);
            // 
            // textBoxStationIdOWM3
            // 
            this.textBoxStationIdOWM3.Location = new System.Drawing.Point(547, 1);
            this.textBoxStationIdOWM3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStationIdOWM3.Name = "textBoxStationIdOWM3";
            this.textBoxStationIdOWM3.Size = new System.Drawing.Size(228, 22);
            this.textBoxStationIdOWM3.TabIndex = 43;
            // 
            // radioButtonStationIdOWM3
            // 
            this.radioButtonStationIdOWM3.AutoSize = true;
            this.radioButtonStationIdOWM3.Location = new System.Drawing.Point(783, 3);
            this.radioButtonStationIdOWM3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonStationIdOWM3.Name = "radioButtonStationIdOWM3";
            this.radioButtonStationIdOWM3.Size = new System.Drawing.Size(17, 16);
            this.radioButtonStationIdOWM3.TabIndex = 42;
            this.radioButtonStationIdOWM3.TabStop = true;
            this.radioButtonStationIdOWM3.UseVisualStyleBackColor = true;
            // 
            // labelStationIdOWM3
            // 
            this.labelStationIdOWM3.AutoSize = true;
            this.labelStationIdOWM3.Location = new System.Drawing.Point(365, 4);
            this.labelStationIdOWM3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStationIdOWM3.Name = "labelStationIdOWM3";
            this.labelStationIdOWM3.Size = new System.Drawing.Size(175, 17);
            this.labelStationIdOWM3.TabIndex = 41;
            this.labelStationIdOWM3.Text = "OWM3 (internal) Station Id";
            // 
            // textBoxCityId
            // 
            this.textBoxCityId.Location = new System.Drawing.Point(647, 64);
            this.textBoxCityId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCityId.Name = "textBoxCityId";
            this.textBoxCityId.Size = new System.Drawing.Size(127, 22);
            this.textBoxCityId.TabIndex = 40;
            // 
            // radioButtonCityId
            // 
            this.radioButtonCityId.AutoSize = true;
            this.radioButtonCityId.Location = new System.Drawing.Point(783, 68);
            this.radioButtonCityId.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCityId.Name = "radioButtonCityId";
            this.radioButtonCityId.Size = new System.Drawing.Size(17, 16);
            this.radioButtonCityId.TabIndex = 39;
            this.radioButtonCityId.TabStop = true;
            this.radioButtonCityId.UseVisualStyleBackColor = true;
            // 
            // labelCityId
            // 
            this.labelCityId.AutoSize = true;
            this.labelCityId.Location = new System.Drawing.Point(591, 68);
            this.labelCityId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCityId.Name = "labelCityId";
            this.labelCityId.Size = new System.Drawing.Size(46, 17);
            this.labelCityId.TabIndex = 38;
            this.labelCityId.Text = "City Id";
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(135, 64);
            this.textBoxZipCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(127, 22);
            this.textBoxZipCode.TabIndex = 37;
            // 
            // radioButtonZipCode
            // 
            this.radioButtonZipCode.AutoSize = true;
            this.radioButtonZipCode.Location = new System.Drawing.Point(271, 68);
            this.radioButtonZipCode.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonZipCode.Name = "radioButtonZipCode";
            this.radioButtonZipCode.Size = new System.Drawing.Size(17, 16);
            this.radioButtonZipCode.TabIndex = 36;
            this.radioButtonZipCode.TabStop = true;
            this.radioButtonZipCode.UseVisualStyleBackColor = true;
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Location = new System.Drawing.Point(55, 68);
            this.labelZip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(65, 17);
            this.labelZip.TabIndex = 35;
            this.labelZip.Text = "Zip Code";
            // 
            // textBoxStationIdWCWU
            // 
            this.textBoxStationIdWCWU.Location = new System.Drawing.Point(134, 2);
            this.textBoxStationIdWCWU.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStationIdWCWU.Name = "textBoxStationIdWCWU";
            this.textBoxStationIdWCWU.Size = new System.Drawing.Size(127, 22);
            this.textBoxStationIdWCWU.TabIndex = 34;
            // 
            // radioButtonStationIdWCWU
            // 
            this.radioButtonStationIdWCWU.AutoSize = true;
            this.radioButtonStationIdWCWU.Location = new System.Drawing.Point(270, 4);
            this.radioButtonStationIdWCWU.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonStationIdWCWU.Name = "radioButtonStationIdWCWU";
            this.radioButtonStationIdWCWU.Size = new System.Drawing.Size(17, 16);
            this.radioButtonStationIdWCWU.TabIndex = 33;
            this.radioButtonStationIdWCWU.TabStop = true;
            this.radioButtonStationIdWCWU.UseVisualStyleBackColor = true;
            // 
            // labelStationIdWCWU
            // 
            this.labelStationIdWCWU.AutoSize = true;
            this.labelStationIdWCWU.Location = new System.Drawing.Point(11, 6);
            this.labelStationIdWCWU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStationIdWCWU.Name = "labelStationIdWCWU";
            this.labelStationIdWCWU.Size = new System.Drawing.Size(116, 17);
            this.labelStationIdWCWU.TabIndex = 32;
            this.labelStationIdWCWU.Text = "WCWU Station Id";
            // 
            // textBoxCityName
            // 
            this.textBoxCityName.Location = new System.Drawing.Point(418, 64);
            this.textBoxCityName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCityName.Name = "textBoxCityName";
            this.textBoxCityName.Size = new System.Drawing.Size(127, 22);
            this.textBoxCityName.TabIndex = 31;
            // 
            // radioButtonLatLong
            // 
            this.radioButtonLatLong.AutoSize = true;
            this.radioButtonLatLong.Location = new System.Drawing.Point(272, 117);
            this.radioButtonLatLong.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonLatLong.Name = "radioButtonLatLong";
            this.radioButtonLatLong.Size = new System.Drawing.Size(17, 16);
            this.radioButtonLatLong.TabIndex = 30;
            this.radioButtonLatLong.TabStop = true;
            this.radioButtonLatLong.UseVisualStyleBackColor = true;
            // 
            // radioButtonCityName
            // 
            this.radioButtonCityName.AutoSize = true;
            this.radioButtonCityName.Location = new System.Drawing.Point(554, 68);
            this.radioButtonCityName.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCityName.Name = "radioButtonCityName";
            this.radioButtonCityName.Size = new System.Drawing.Size(17, 16);
            this.radioButtonCityName.TabIndex = 29;
            this.radioButtonCityName.TabStop = true;
            this.radioButtonCityName.UseVisualStyleBackColor = true;
            // 
            // textBoxSiteElevation
            // 
            this.textBoxSiteElevation.Location = new System.Drawing.Point(420, 113);
            this.textBoxSiteElevation.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSiteElevation.Name = "textBoxSiteElevation";
            this.textBoxSiteElevation.Size = new System.Drawing.Size(57, 22);
            this.textBoxSiteElevation.TabIndex = 28;
            // 
            // labelSiteElevation
            // 
            this.labelSiteElevation.AutoSize = true;
            this.labelSiteElevation.Location = new System.Drawing.Point(298, 117);
            this.labelSiteElevation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSiteElevation.Name = "labelSiteElevation";
            this.labelSiteElevation.Size = new System.Drawing.Size(119, 17);
            this.labelSiteElevation.TabIndex = 27;
            this.labelSiteElevation.Text = "Site Elevation (m)";
            // 
            // textBoxSiteLatitude
            // 
            this.textBoxSiteLatitude.Location = new System.Drawing.Point(136, 100);
            this.textBoxSiteLatitude.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSiteLatitude.Name = "textBoxSiteLatitude";
            this.textBoxSiteLatitude.Size = new System.Drawing.Size(125, 22);
            this.textBoxSiteLatitude.TabIndex = 26;
            // 
            // labelSiteLatitude
            // 
            this.labelSiteLatitude.AutoSize = true;
            this.labelSiteLatitude.Location = new System.Drawing.Point(31, 105);
            this.labelSiteLatitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSiteLatitude.Name = "labelSiteLatitude";
            this.labelSiteLatitude.Size = new System.Drawing.Size(87, 17);
            this.labelSiteLatitude.TabIndex = 25;
            this.labelSiteLatitude.Text = "Site Latitude";
            // 
            // labelCityName
            // 
            this.labelCityName.AutoSize = true;
            this.labelCityName.Location = new System.Drawing.Point(338, 68);
            this.labelCityName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCityName.Name = "labelCityName";
            this.labelCityName.Size = new System.Drawing.Size(72, 17);
            this.labelCityName.TabIndex = 23;
            this.labelCityName.Text = "City Name";
            // 
            // textBoxSiteLongitude
            // 
            this.textBoxSiteLongitude.Location = new System.Drawing.Point(137, 133);
            this.textBoxSiteLongitude.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSiteLongitude.Name = "textBoxSiteLongitude";
            this.textBoxSiteLongitude.Size = new System.Drawing.Size(124, 22);
            this.textBoxSiteLongitude.TabIndex = 21;
            // 
            // labelSiteLongitude
            // 
            this.labelSiteLongitude.AutoSize = true;
            this.labelSiteLongitude.Location = new System.Drawing.Point(31, 137);
            this.labelSiteLongitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSiteLongitude.Name = "labelSiteLongitude";
            this.labelSiteLongitude.Size = new System.Drawing.Size(99, 17);
            this.labelSiteLongitude.TabIndex = 20;
            this.labelSiteLongitude.Text = "Site Longitude";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(730, 43);
            this.label3.TabIndex = 19;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colLat,
            this.colLon});
            this.dataGridView.Location = new System.Drawing.Point(15, 227);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(437, 244);
            this.dataGridView.TabIndex = 18;
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colLat
            // 
            this.colLat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colLat.HeaderText = "Latitude";
            this.colLat.MinimumWidth = 6;
            this.colLat.Name = "colLat";
            this.colLat.ReadOnly = true;
            this.colLat.Width = 88;
            // 
            // colLon
            // 
            this.colLon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colLon.HeaderText = "Longitude";
            this.colLon.MinimumWidth = 6;
            this.colLon.Name = "colLon";
            this.colLon.ReadOnly = true;
            // 
            // labelDriverId
            // 
            this.labelDriverId.AutoSize = true;
            this.labelDriverId.Location = new System.Drawing.Point(5, 599);
            this.labelDriverId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDriverId.Name = "labelDriverId";
            this.labelDriverId.Size = new System.Drawing.Size(61, 17);
            this.labelDriverId.TabIndex = 21;
            this.labelDriverId.Text = "Driver Id";
            // 
            // SetupDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 629);
            this.Controls.Add(this.labelDriverId);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.textBoxDriverId);
            this.Controls.Add(this.buttonConnectDriverId);
            this.Controls.Add(this.buttonChooseDriverId);
            this.Controls.Add(this.comboBoxComPort);
            this.Controls.Add(this.chkTrace);
            this.Controls.Add(this.labelComPort);
            this.Controls.Add(this.picASCOM);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupDialogForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCloudPWS Setup";
            ((System.ComponentModel.ISupportInitialize)(this.picASCOM)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageApiKey.ResumeLayout(false);
            this.tabPageApiKey.PerformLayout();
            this.tabPageSelectSite.ResumeLayout(false);
            this.tabPageSelectSite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.PictureBox picASCOM;
        private System.Windows.Forms.Label labelComPort;
        private System.Windows.Forms.CheckBox chkTrace;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Label textBoxDriverId;
        private System.Windows.Forms.Button buttonConnectDriverId;
        private System.Windows.Forms.Button buttonChooseDriverId;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageApiKey;
        private System.Windows.Forms.Label labelApiUrlWCWU;
        private System.Windows.Forms.TextBox textBoxApiUrlWCWU;
        private System.Windows.Forms.Label labelApiKeyWCWU;
        private System.Windows.Forms.TextBox textBoxApiKeyWCWU;
        private System.Windows.Forms.Button buttonObtainKeyOWM;
        private System.Windows.Forms.Label labelApiText;
        private System.Windows.Forms.TabPage tabPageSelectSite;
        private System.Windows.Forms.TextBox textBoxCityName;
        private System.Windows.Forms.RadioButton radioButtonLatLong;
        private System.Windows.Forms.RadioButton radioButtonCityName;
        private System.Windows.Forms.TextBox textBoxSiteElevation;
        private System.Windows.Forms.Label labelSiteElevation;
        private System.Windows.Forms.TextBox textBoxSiteLatitude;
        private System.Windows.Forms.Label labelSiteLatitude;
        private System.Windows.Forms.Label labelCityName;
        private System.Windows.Forms.Button buttonFindLocations;
        private System.Windows.Forms.TextBox textBoxSiteLongitude;
        private System.Windows.Forms.Label labelSiteLongitude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLon;
        private System.Windows.Forms.TextBox textBoxStationIdWCWU;
        private System.Windows.Forms.RadioButton radioButtonStationIdWCWU;
        private System.Windows.Forms.Label labelStationIdWCWU;
        private System.Windows.Forms.Label labelUnitOptions;
        private System.Windows.Forms.Label labelUnits;
        private System.Windows.Forms.TextBox textBoxUnits;
        private System.Windows.Forms.Label labelDriverId;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.RadioButton radioButtonZipCode;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.Label labelFormatOptions;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.TextBox textBoxFormat;
        private System.Windows.Forms.TextBox textBoxCityId;
        private System.Windows.Forms.RadioButton radioButtonCityId;
        private System.Windows.Forms.Label labelCityId;
        private System.Windows.Forms.Label labelTextWCWU;
        private System.Windows.Forms.Label labelApiUrlOWM;
        private System.Windows.Forms.TextBox textBoxApiUrlOWM;
        private System.Windows.Forms.Label labelApiKeyOWM;
        private System.Windows.Forms.TextBox textBoxApiKeyOWM;
        private System.Windows.Forms.Label labelTextOWM;
        private System.Windows.Forms.Label labelTextOWM3;
        private System.Windows.Forms.Label labelApiUrlOWM3;
        private System.Windows.Forms.TextBox textBoxApiUrlOWM3;
        private System.Windows.Forms.Label labelTextTypeOptions;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxStationIdOWM3;
        private System.Windows.Forms.RadioButton radioButtonStationIdOWM3;
        private System.Windows.Forms.Label labelStationIdOWM3;
        private System.Windows.Forms.Label labelTextInterval;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.Button buttonObtainKeyWCWU;
        private System.Windows.Forms.Button button1ObtainKeyWLL;
        private System.Windows.Forms.Label labelTextWLL;
        private System.Windows.Forms.Label labelApiUrlWLL;
        private System.Windows.Forms.TextBox textBoxApiUrlWLL;
        private System.Windows.Forms.Label labelApiKeyWLL;
        private System.Windows.Forms.TextBox textBoxApiKeyWLL;
        private System.Windows.Forms.TextBox textBoxStationIdWLL;
        private System.Windows.Forms.RadioButton radioButtonStationIdWLL;
        private System.Windows.Forms.Label labelStationIdWLL;
        private System.Windows.Forms.Label labelSignatureWLL;
        private System.Windows.Forms.TextBox textBoxApiSecretWLL;
    }
}