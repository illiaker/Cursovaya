namespace AdminView
{
    partial class CriminalInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriminalInfo));
            this.CriminalImage = new System.Windows.Forms.PictureBox();
            this.ChooseCriminalImage = new System.Windows.Forms.OpenFileDialog();
            this.OpenImage = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aliasBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.NumericUpDown();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nationalityBox = new System.Windows.Forms.ComboBox();
            this.birthdayBox = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.houseBox = new System.Windows.Forms.TextBox();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lastHouseBox = new System.Windows.Forms.TextBox();
            this.lastStreetBox = new System.Windows.Forms.TextBox();
            this.lastcityBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.countryWhereWantedBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.chooseButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.canselButton = new System.Windows.Forms.Button();
            this.ganglabel = new System.Windows.Forms.LinkLabel();
            this.professionBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.IdLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CriminalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CriminalImage
            // 
            this.CriminalImage.Image = ((System.Drawing.Image)(resources.GetObject("CriminalImage.Image")));
            this.CriminalImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("CriminalImage.InitialImage")));
            this.CriminalImage.Location = new System.Drawing.Point(12, 12);
            this.CriminalImage.Name = "CriminalImage";
            this.CriminalImage.Size = new System.Drawing.Size(150, 150);
            this.CriminalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CriminalImage.TabIndex = 0;
            this.CriminalImage.TabStop = false;
            // 
            // ChooseCriminalImage
            // 
            this.ChooseCriminalImage.FileName = "Criminal Image";
            // 
            // OpenImage
            // 
            this.OpenImage.Location = new System.Drawing.Point(35, 168);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(103, 23);
            this.OpenImage.TabIndex = 1;
            this.OpenImage.Text = "Open";
            this.OpenImage.UseVisualStyleBackColor = true;
            this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // nameBox
            // 
            this.nameBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nameBox.Location = new System.Drawing.Point(279, 23);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(122, 20);
            this.nameBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(279, 62);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(122, 20);
            this.surnameBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Alias";
            // 
            // aliasBox
            // 
            this.aliasBox.Location = new System.Drawing.Point(279, 100);
            this.aliasBox.Name = "aliasBox";
            this.aliasBox.Size = new System.Drawing.Size(122, 20);
            this.aliasBox.TabIndex = 7;
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(279, 142);
            this.heightBox.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(122, 20);
            this.heightBox.TabIndex = 8;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(187, 149);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(38, 13);
            this.HeightLabel.TabIndex = 9;
            this.HeightLabel.Text = "Height";
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(279, 183);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(122, 20);
            this.ageBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Age";
            // 
            // genderBox
            // 
            this.genderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.genderBox.Location = new System.Drawing.Point(585, 22);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(121, 21);
            this.genderBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nationality";
            // 
            // nationalityBox
            // 
            this.nationalityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nationalityBox.FormattingEnabled = true;
            this.nationalityBox.Items.AddRange(new object[] {
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
            this.nationalityBox.Location = new System.Drawing.Point(585, 66);
            this.nationalityBox.Name = "nationalityBox";
            this.nationalityBox.Size = new System.Drawing.Size(121, 21);
            this.nationalityBox.TabIndex = 15;
            // 
            // birthdayBox
            // 
            this.birthdayBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdayBox.Location = new System.Drawing.Point(585, 107);
            this.birthdayBox.Name = "birthdayBox";
            this.birthdayBox.Size = new System.Drawing.Size(121, 20);
            this.birthdayBox.TabIndex = 16;
            this.birthdayBox.ValueChanged += new System.EventHandler(this.birthdayBox_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Birthday";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.houseBox);
            this.groupBox1.Controls.Add(this.streetBox);
            this.groupBox1.Controls.Add(this.cityBox);
            this.groupBox1.Location = new System.Drawing.Point(439, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 163);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adress";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "House Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Street";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "City";
            // 
            // houseBox
            // 
            this.houseBox.Location = new System.Drawing.Point(93, 123);
            this.houseBox.Name = "houseBox";
            this.houseBox.Size = new System.Drawing.Size(100, 20);
            this.houseBox.TabIndex = 2;
            // 
            // streetBox
            // 
            this.streetBox.Location = new System.Drawing.Point(93, 82);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(100, 20);
            this.streetBox.TabIndex = 1;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(93, 41);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(100, 20);
            this.cityBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lastHouseBox);
            this.groupBox2.Controls.Add(this.lastStreetBox);
            this.groupBox2.Controls.Add(this.lastcityBox);
            this.groupBox2.Location = new System.Drawing.Point(659, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 163);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Last Adress";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "House Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Street";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "City";
            // 
            // lastHouseBox
            // 
            this.lastHouseBox.Location = new System.Drawing.Point(93, 123);
            this.lastHouseBox.Name = "lastHouseBox";
            this.lastHouseBox.Size = new System.Drawing.Size(100, 20);
            this.lastHouseBox.TabIndex = 2;
            // 
            // lastStreetBox
            // 
            this.lastStreetBox.Location = new System.Drawing.Point(93, 82);
            this.lastStreetBox.Name = "lastStreetBox";
            this.lastStreetBox.Size = new System.Drawing.Size(100, 20);
            this.lastStreetBox.TabIndex = 1;
            // 
            // lastcityBox
            // 
            this.lastcityBox.Location = new System.Drawing.Point(93, 41);
            this.lastcityBox.Name = "lastcityBox";
            this.lastcityBox.Size = new System.Drawing.Size(100, 20);
            this.lastcityBox.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(179, 370);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 26);
            this.label15.TabIndex = 23;
            this.label15.Text = "Country where\r\n   wanted\r\n";
            // 
            // countryWhereWantedBox
            // 
            this.countryWhereWantedBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryWhereWantedBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.countryWhereWantedBox.FormattingEnabled = true;
            this.countryWhereWantedBox.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua & Deps",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Central African Rep",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Congo {Democratic Rep}",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland {Republic}",
            "Israel",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea North",
            "Korea South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar, {Burma}",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "St Kitts & Nevis",
            "St Lucia",
            "Saint Vincent & the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome & Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad & Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.countryWhereWantedBox.Location = new System.Drawing.Point(282, 375);
            this.countryWhereWantedBox.Name = "countryWhereWantedBox";
            this.countryWhereWantedBox.Size = new System.Drawing.Size(122, 21);
            this.countryWhereWantedBox.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(182, 411);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Criminal Gang";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(279, 339);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 26;
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(430, 401);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(75, 23);
            this.chooseButton.TabIndex = 27;
            this.chooseButton.Text = "Chose";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(598, 412);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 28;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // canselButton
            // 
            this.canselButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.canselButton.Location = new System.Drawing.Point(752, 411);
            this.canselButton.Name = "canselButton";
            this.canselButton.Size = new System.Drawing.Size(75, 23);
            this.canselButton.TabIndex = 29;
            this.canselButton.Text = "Cancel";
            this.canselButton.UseVisualStyleBackColor = true;
            // 
            // ganglabel
            // 
            this.ganglabel.AutoSize = true;
            this.ganglabel.Location = new System.Drawing.Point(317, 411);
            this.ganglabel.Name = "ganglabel";
            this.ganglabel.Size = new System.Drawing.Size(33, 13);
            this.ganglabel.TabIndex = 30;
            this.ganglabel.TabStop = true;
            this.ganglabel.Text = "None";
            this.ganglabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ganglabel_LinkClicked);
            // 
            // professionBox
            // 
            this.professionBox.Location = new System.Drawing.Point(6, 19);
            this.professionBox.Name = "professionBox";
            this.professionBox.Size = new System.Drawing.Size(245, 102);
            this.professionBox.TabIndex = 31;
            this.professionBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.professionBox);
            this.groupBox3.Location = new System.Drawing.Point(176, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 127);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Description";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(451, 339);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(22, 13);
            this.label.TabIndex = 33;
            this.label.Text = "Id: ";
            // 
            // IdLable
            // 
            this.IdLable.AutoSize = true;
            this.IdLable.Location = new System.Drawing.Point(486, 339);
            this.IdLable.Name = "IdLable";
            this.IdLable.Size = new System.Drawing.Size(0, 13);
            this.IdLable.TabIndex = 34;
            // 
            // CriminalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(883, 452);
            this.Controls.Add(this.IdLable);
            this.Controls.Add(this.label);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ganglabel);
            this.Controls.Add(this.canselButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.countryWhereWantedBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CriminalImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.birthdayBox);
            this.Controls.Add(this.nationalityBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.aliasBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.OpenImage);
            this.Name = "CriminalInfo";
            this.RightToLeftLayout = true;
            this.Text = "CriminalInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CriminalInfo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.CriminalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CriminalImage;
        private System.Windows.Forms.OpenFileDialog ChooseCriminalImage;
        private System.Windows.Forms.Button OpenImage;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aliasBox;
        private System.Windows.Forms.NumericUpDown heightBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.NumericUpDown ageBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox nationalityBox;
        private System.Windows.Forms.DateTimePicker birthdayBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox houseBox;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox lastHouseBox;
        private System.Windows.Forms.TextBox lastStreetBox;
        private System.Windows.Forms.TextBox lastcityBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox countryWhereWantedBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button canselButton;
        private System.Windows.Forms.LinkLabel ganglabel;
        private System.Windows.Forms.RichTextBox professionBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label IdLable;
    }
}