namespace AdminView
{
    partial class ListMenu
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
            this.adminMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criminalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.criminalsDataGridView = new System.Windows.Forms.DataGridView();
            this.listControl = new System.Windows.Forms.TabControl();
            this.criminalsPage = new System.Windows.Forms.TabPage();
            this.gangPage = new System.Windows.Forms.TabPage();
            this.gangGridView = new System.Windows.Forms.DataGridView();
            this.LeaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archivePage = new System.Windows.Forms.TabPage();
            this.archiveDataGridView = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nationalityBox = new System.Windows.Forms.ComboBox();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criminalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageDataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foundationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.featuresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criminalGangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliasDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDayDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.criminalsDataGridView)).BeginInit();
            this.listControl.SuspendLayout();
            this.criminalsPage.SuspendLayout();
            this.gangPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gangGridView)).BeginInit();
            this.archivePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalGangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adminMenuStrip
            // 
            this.adminMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.criminalsToolStripMenuItem,
            this.gangToolStripMenuItem});
            this.adminMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.adminMenuStrip.Name = "adminMenuStrip";
            this.adminMenuStrip.Size = new System.Drawing.Size(851, 24);
            this.adminMenuStrip.TabIndex = 2;
            this.adminMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(90, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // criminalsToolStripMenuItem
            // 
            this.criminalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.moveToListToolStripMenuItem,
            this.deleteToolStripMenuItem1});
            this.criminalsToolStripMenuItem.Name = "criminalsToolStripMenuItem";
            this.criminalsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.criminalsToolStripMenuItem.Text = "Criminals";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.deleteToolStripMenuItem.Text = "Move to archive";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.changeToolStripMenuItem.Text = "Change";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // moveToListToolStripMenuItem
            // 
            this.moveToListToolStripMenuItem.Name = "moveToListToolStripMenuItem";
            this.moveToListToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.moveToListToolStripMenuItem.Text = "Move to list";
            this.moveToListToolStripMenuItem.Click += new System.EventHandler(this.moveToListToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // gangToolStripMenuItem
            // 
            this.gangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.changeToolStripMenuItem1});
            this.gangToolStripMenuItem.Name = "gangToolStripMenuItem";
            this.gangToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.gangToolStripMenuItem.Text = "Gang";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // changeToolStripMenuItem1
            // 
            this.changeToolStripMenuItem1.Name = "changeToolStripMenuItem1";
            this.changeToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.changeToolStripMenuItem1.Text = "Change";
            this.changeToolStripMenuItem1.Click += new System.EventHandler(this.changeToolStripMenuItem1_Click);
            // 
            // criminalsDataGridView
            // 
            this.criminalsDataGridView.AllowUserToAddRows = false;
            this.criminalsDataGridView.AllowUserToDeleteRows = false;
            this.criminalsDataGridView.AllowUserToResizeColumns = false;
            this.criminalsDataGridView.AllowUserToResizeRows = false;
            this.criminalsDataGridView.AutoGenerateColumns = false;
            this.criminalsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.criminalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.criminalsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.txtName,
            this.Surname,
            this.Alias,
            this.dataGridViewTextBoxColumn1,
            this.Gender,
            this.Nationality,
            this.BirthDay});
            this.criminalsDataGridView.DataSource = this.criminalBindingSource;
            this.criminalsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.criminalsDataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.criminalsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.criminalsDataGridView.MultiSelect = false;
            this.criminalsDataGridView.Name = "criminalsDataGridView";
            this.criminalsDataGridView.ReadOnly = true;
            this.criminalsDataGridView.RowHeadersVisible = false;
            this.criminalsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.criminalsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.criminalsDataGridView.Size = new System.Drawing.Size(837, 401);
            this.criminalsDataGridView.TabIndex = 3;
            // 
            // listControl
            // 
            this.listControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listControl.Controls.Add(this.criminalsPage);
            this.listControl.Controls.Add(this.gangPage);
            this.listControl.Controls.Add(this.archivePage);
            this.listControl.Location = new System.Drawing.Point(0, 27);
            this.listControl.Name = "listControl";
            this.listControl.SelectedIndex = 0;
            this.listControl.Size = new System.Drawing.Size(851, 433);
            this.listControl.TabIndex = 4;
            this.listControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // criminalsPage
            // 
            this.criminalsPage.Controls.Add(this.criminalsDataGridView);
            this.criminalsPage.Location = new System.Drawing.Point(4, 22);
            this.criminalsPage.Name = "criminalsPage";
            this.criminalsPage.Padding = new System.Windows.Forms.Padding(3);
            this.criminalsPage.Size = new System.Drawing.Size(843, 407);
            this.criminalsPage.TabIndex = 0;
            this.criminalsPage.Text = "Criminals";
            this.criminalsPage.UseVisualStyleBackColor = true;
            // 
            // gangPage
            // 
            this.gangPage.Controls.Add(this.gangGridView);
            this.gangPage.Location = new System.Drawing.Point(4, 22);
            this.gangPage.Name = "gangPage";
            this.gangPage.Padding = new System.Windows.Forms.Padding(3);
            this.gangPage.Size = new System.Drawing.Size(843, 407);
            this.gangPage.TabIndex = 1;
            this.gangPage.Text = "Gang";
            this.gangPage.UseVisualStyleBackColor = true;
            // 
            // gangGridView
            // 
            this.gangGridView.AllowUserToAddRows = false;
            this.gangGridView.AllowUserToDeleteRows = false;
            this.gangGridView.AutoGenerateColumns = false;
            this.gangGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gangGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gangGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageDataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn7,
            this.LeaderName,
            this.foundationDateDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.featuresDataGridViewTextBoxColumn});
            this.gangGridView.DataSource = this.criminalGangBindingSource;
            this.gangGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gangGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.gangGridView.Location = new System.Drawing.Point(3, 3);
            this.gangGridView.MultiSelect = false;
            this.gangGridView.Name = "gangGridView";
            this.gangGridView.ReadOnly = true;
            this.gangGridView.RowHeadersVisible = false;
            this.gangGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gangGridView.Size = new System.Drawing.Size(837, 401);
            this.gangGridView.TabIndex = 0;
            // 
            // LeaderName
            // 
            this.LeaderName.DataPropertyName = "LeaderName";
            this.LeaderName.HeaderText = "Leader Name";
            this.LeaderName.Name = "LeaderName";
            this.LeaderName.ReadOnly = true;
            // 
            // archivePage
            // 
            this.archivePage.Controls.Add(this.archiveDataGridView);
            this.archivePage.Location = new System.Drawing.Point(4, 22);
            this.archivePage.Name = "archivePage";
            this.archivePage.Size = new System.Drawing.Size(843, 407);
            this.archivePage.TabIndex = 2;
            this.archivePage.Text = "Archive";
            this.archivePage.UseVisualStyleBackColor = true;
            // 
            // archiveDataGridView
            // 
            this.archiveDataGridView.AllowUserToAddRows = false;
            this.archiveDataGridView.AllowUserToDeleteRows = false;
            this.archiveDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.archiveDataGridView.AutoGenerateColumns = false;
            this.archiveDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.archiveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archiveDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageDataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn4,
            this.surnameDataGridViewTextBoxColumn1,
            this.aliasDataGridViewTextBoxColumn1,
            this.Age,
            this.genderDataGridViewTextBoxColumn1,
            this.nationalityDataGridViewTextBoxColumn1,
            this.birthDayDataGridViewTextBoxColumn1});
            this.archiveDataGridView.DataSource = this.archiveBindingSource;
            this.archiveDataGridView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.archiveDataGridView.Location = new System.Drawing.Point(0, 0);
            this.archiveDataGridView.Name = "archiveDataGridView";
            this.archiveDataGridView.ReadOnly = true;
            this.archiveDataGridView.RowHeadersVisible = false;
            this.archiveDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.archiveDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.archiveDataGridView.Size = new System.Drawing.Size(843, 407);
            this.archiveDataGridView.TabIndex = 0;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchBox.Location = new System.Drawing.Point(103, 482);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(132, 20);
            this.searchBox.TabIndex = 5;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nationality";
            // 
            // nationalityBox
            // 
            this.nationalityBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nationalityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nationalityBox.FormattingEnabled = true;
            this.nationalityBox.Items.AddRange(new object[] {
            "",
            "Afghan",
            "Albanian",
            "Algerian",
            "American",
            "Andorran",
            "Angolan",
            "Antiguans",
            "Argentinean",
            "Armenian",
            "Australian",
            "Austrian",
            "Azerbaijani",
            "Bahamian",
            "Bahraini",
            "Bangladeshi",
            "Barbadian",
            "Barbudans",
            "Batswana",
            "Belarusian",
            "Belgian",
            "Belizean",
            "Beninese",
            "Bhutanese",
            "Bolivian",
            "Bosnian",
            "Brazilian",
            "British",
            "Bruneian",
            "Bulgarian",
            "Burkinabe",
            "Burmese",
            "Burundian",
            "Cambodian",
            "Cameroonian",
            "Canadian",
            "Cape Verdean",
            "Central African",
            "Chadian",
            "Chilean",
            "Chinese",
            "Colombian",
            "Comoran",
            "Congolese",
            "Costa Rican",
            "Croatian",
            "Cuban",
            "Cypriot",
            "Czech",
            "Danish",
            "Djibouti",
            "Dominican",
            "Dutch",
            "East Timorese",
            "Ecuadorean",
            "Egyptian",
            "Emirian",
            "Equatorial Guinean",
            "Eritrean",
            "Estonian",
            "Ethiopian",
            "Fijian",
            "Filipino",
            "Finnish",
            "French",
            "Gabonese",
            "Gambian",
            "Georgian",
            "German",
            "Ghanaian",
            "Greek",
            "Grenadian",
            "Guatemalan",
            "Guinea-Bissauan",
            "Guinean",
            "Guyanese",
            "Haitian",
            "Herzegovinian",
            "Honduran",
            "Hungarian",
            "I-Kiribati",
            "Icelander",
            "Indian",
            "Indonesian",
            "Iranian",
            "Iraqi",
            "Irish",
            "Israeli",
            "Italian",
            "Ivorian",
            "Jamaican",
            "Japanese",
            "Jordanian",
            "Kazakhstani",
            "Kenyan",
            "Kittian and Nevisian",
            "Kuwaiti",
            "Kyrgyz",
            "Laotian",
            "Latvian",
            "Lebanese",
            "Liberian",
            "Libyan",
            "Liechtensteiner",
            "Lithuanian",
            "Luxembourger",
            "Macedonian",
            "Malagasy",
            "Malawian",
            "Malaysian",
            "Maldivian",
            "Malian",
            "Maltese",
            "Marshallese",
            "Mauritanian",
            "Mauritian",
            "Mexican",
            "Micronesian",
            "Moldovan",
            "Monacan",
            "Mongolian",
            "Moroccan",
            "Mosotho",
            "Motswana",
            "Mozambican",
            "Namibian",
            "Nauruan",
            "Nepalese",
            "New Zealander",
            "Ni-Vanuatu",
            "Nicaraguan",
            "Nigerian",
            "Nigerien",
            "North Korean",
            "Northern Irish",
            "Norwegian",
            "Omani",
            "Pakistani",
            "Palauan",
            "Panamanian",
            "Papua New Guinean",
            "Paraguayan",
            "Peruvian",
            "Polish",
            "Portuguese",
            "Qatari",
            "Romanian",
            "Russian",
            "Rwandan",
            "Saint Lucian",
            "Salvadoran",
            "Samoan",
            "San Marinese",
            "Sao Tomean",
            "Saudi",
            "Scottish",
            "Senegalese",
            "Serbian",
            "Seychellois",
            "Sierra Leonean",
            "Singaporean",
            "Slovakian",
            "Slovenian",
            "Solomon Islander",
            "Somali",
            "South African",
            "South Korean",
            "Spanish",
            "Sri Lankan",
            "Sudanese",
            "Surinamer",
            "Swazi",
            "Swedish",
            "Swiss",
            "Syrian",
            "Taiwanese",
            "Tajik",
            "Tanzanian",
            "Thai",
            "Togolese",
            "Tongan",
            "Trinidadian or Tobagonian",
            "Tunisian",
            "Turkish",
            "Tuvaluan",
            "Ugandan",
            "Ukrainian",
            "Uruguayan",
            "Uzbekistani",
            "Venezuelan",
            "Vietnamese",
            "Welsh",
            "Yemenite",
            "Zambian",
            "Zimbabwean"});
            this.nationalityBox.Location = new System.Drawing.Point(103, 522);
            this.nationalityBox.Name = "nationalityBox";
            this.nationalityBox.Size = new System.Drawing.Size(132, 21);
            this.nationalityBox.TabIndex = 8;
            this.nationalityBox.SelectedValueChanged += new System.EventHandler(this.nationalityBox_SelectedValueChanged);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showInfoButton.Location = new System.Drawing.Point(277, 482);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(75, 23);
            this.showInfoButton.TabIndex = 9;
            this.showInfoButton.Text = "Show info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // Age
            // 
            this.Age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // criminalBindingSource
            // 
            this.criminalBindingSource.DataSource = typeof(Cursovaya.Model.Criminal);
            this.criminalBindingSource.Sort = "";
            this.criminalBindingSource.CurrentChanged += new System.EventHandler(this.criminalBindingSource_CurrentChanged);
            // 
            // imageDataGridViewImageColumn2
            // 
            this.imageDataGridViewImageColumn2.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn2.HeaderText = "Image";
            this.imageDataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageDataGridViewImageColumn2.Name = "imageDataGridViewImageColumn2";
            this.imageDataGridViewImageColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // foundationDateDataGridViewTextBoxColumn
            // 
            this.foundationDateDataGridViewTextBoxColumn.DataPropertyName = "FoundationDate";
            this.foundationDateDataGridViewTextBoxColumn.HeaderText = "Foundation Date";
            this.foundationDateDataGridViewTextBoxColumn.Name = "foundationDateDataGridViewTextBoxColumn";
            this.foundationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // featuresDataGridViewTextBoxColumn
            // 
            this.featuresDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.featuresDataGridViewTextBoxColumn.DataPropertyName = "Features";
            this.featuresDataGridViewTextBoxColumn.HeaderText = "Features";
            this.featuresDataGridViewTextBoxColumn.Name = "featuresDataGridViewTextBoxColumn";
            this.featuresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // criminalGangBindingSource
            // 
            this.criminalGangBindingSource.DataSource = typeof(Cursovaya.Model.CriminalGang);
            // 
            // imageDataGridViewImageColumn1
            // 
            this.imageDataGridViewImageColumn1.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn1.HeaderText = "Image";
            this.imageDataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageDataGridViewImageColumn1.Name = "imageDataGridViewImageColumn1";
            this.imageDataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            this.surnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // aliasDataGridViewTextBoxColumn1
            // 
            this.aliasDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aliasDataGridViewTextBoxColumn1.DataPropertyName = "Alias";
            this.aliasDataGridViewTextBoxColumn1.HeaderText = "Alias";
            this.aliasDataGridViewTextBoxColumn1.Name = "aliasDataGridViewTextBoxColumn1";
            this.aliasDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn1
            // 
            this.genderDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genderDataGridViewTextBoxColumn1.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn1.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn1.Name = "genderDataGridViewTextBoxColumn1";
            this.genderDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nationalityDataGridViewTextBoxColumn1
            // 
            this.nationalityDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nationalityDataGridViewTextBoxColumn1.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn1.HeaderText = "Nationality";
            this.nationalityDataGridViewTextBoxColumn1.Name = "nationalityDataGridViewTextBoxColumn1";
            this.nationalityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // birthDayDataGridViewTextBoxColumn1
            // 
            this.birthDayDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.birthDayDataGridViewTextBoxColumn1.DataPropertyName = "BirthDay";
            this.birthDayDataGridViewTextBoxColumn1.HeaderText = "BirthDay";
            this.birthDayDataGridViewTextBoxColumn1.Name = "birthDayDataGridViewTextBoxColumn1";
            this.birthDayDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // archiveBindingSource
            // 
            this.archiveBindingSource.DataSource = typeof(Cursovaya.Model.Criminal);
            this.archiveBindingSource.Sort = "";
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtName
            // 
            this.txtName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtName.DataPropertyName = "Name";
            this.txtName.HeaderText = "Name";
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Alias
            // 
            this.Alias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Alias.DataPropertyName = "Alias";
            this.Alias.HeaderText = "Alias";
            this.Alias.Name = "Alias";
            this.Alias.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn1.HeaderText = "Age";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Nationality
            // 
            this.Nationality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nationality.DataPropertyName = "Nationality";
            this.Nationality.HeaderText = "Nationality";
            this.Nationality.Name = "Nationality";
            this.Nationality.ReadOnly = true;
            // 
            // BirthDay
            // 
            this.BirthDay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BirthDay.DataPropertyName = "BirthDay";
            this.BirthDay.HeaderText = "BirthDay";
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.ReadOnly = true;
            // 
            // ListMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 599);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.nationalityBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.listControl);
            this.Controls.Add(this.adminMenuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.adminMenuStrip;
            this.Name = "ListMenu";
            this.Text = "ListMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListMenu_FormClosing);
            this.Load += new System.EventHandler(this.ListMenu_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListMenu_KeyDown);
            this.adminMenuStrip.ResumeLayout(false);
            this.adminMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.criminalsDataGridView)).EndInit();
            this.listControl.ResumeLayout(false);
            this.criminalsPage.ResumeLayout(false);
            this.gangPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gangGridView)).EndInit();
            this.archivePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalGangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip adminMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criminalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.DataGridView criminalsDataGridView;
        private System.Windows.Forms.TabControl listControl;
        private System.Windows.Forms.TabPage criminalsPage;
        private System.Windows.Forms.TabPage gangPage;
        private System.Windows.Forms.TabPage archivePage;
        private System.Windows.Forms.DataGridView archiveDataGridView;
        private System.Windows.Forms.ToolStripMenuItem moveToListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.DataGridView gangGridView;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nationalityBox;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.BindingSource criminalBindingSource;
        private System.Windows.Forms.BindingSource criminalGangBindingSource;
        private System.Windows.Forms.BindingSource archiveBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn foundationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn featuresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliasDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDayDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDay;
    }
}