﻿namespace AdminView
{
    partial class GangInfo
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.featuresBox = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.countrylabel = new System.Windows.Forms.Label();
            this.leaderLabel = new System.Windows.Forms.Label();
            this.leaderlinkedLabel = new System.Windows.Forms.LinkLabel();
            this.leaderChoseButton = new System.Windows.Forms.Button();
            this.foundationDateLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.foundationtimebox = new System.Windows.Forms.DateTimePicker();
            this.gangImageBox = new System.Windows.Forms.PictureBox();
            this.imageChoseButton = new System.Windows.Forms.Button();
            this.choseimageDialog = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.featuresBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gangImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(208, 34);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // featuresBox
            // 
            this.featuresBox.Controls.Add(this.richTextBox1);
            this.featuresBox.Location = new System.Drawing.Point(547, 23);
            this.featuresBox.Name = "featuresBox";
            this.featuresBox.Size = new System.Drawing.Size(200, 136);
            this.featuresBox.TabIndex = 1;
            this.featuresBox.TabStop = false;
            this.featuresBox.Text = "Features";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(194, 117);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // countrylabel
            // 
            this.countrylabel.AutoSize = true;
            this.countrylabel.Location = new System.Drawing.Point(208, 126);
            this.countrylabel.Name = "countrylabel";
            this.countrylabel.Size = new System.Drawing.Size(43, 13);
            this.countrylabel.TabIndex = 2;
            this.countrylabel.Text = "Country";
            // 
            // leaderLabel
            // 
            this.leaderLabel.AutoSize = true;
            this.leaderLabel.Location = new System.Drawing.Point(211, 179);
            this.leaderLabel.Name = "leaderLabel";
            this.leaderLabel.Size = new System.Drawing.Size(40, 13);
            this.leaderLabel.TabIndex = 3;
            this.leaderLabel.Text = "Leader";
            // 
            // leaderlinkedLabel
            // 
            this.leaderlinkedLabel.AutoSize = true;
            this.leaderlinkedLabel.Location = new System.Drawing.Point(302, 179);
            this.leaderlinkedLabel.Name = "leaderlinkedLabel";
            this.leaderlinkedLabel.Size = new System.Drawing.Size(33, 13);
            this.leaderlinkedLabel.TabIndex = 4;
            this.leaderlinkedLabel.TabStop = true;
            this.leaderlinkedLabel.Text = "None";
            // 
            // leaderChoseButton
            // 
            this.leaderChoseButton.Location = new System.Drawing.Point(229, 209);
            this.leaderChoseButton.Name = "leaderChoseButton";
            this.leaderChoseButton.Size = new System.Drawing.Size(75, 23);
            this.leaderChoseButton.TabIndex = 5;
            this.leaderChoseButton.Text = "Chose";
            this.leaderChoseButton.UseVisualStyleBackColor = true;
            // 
            // foundationDateLabel
            // 
            this.foundationDateLabel.AutoSize = true;
            this.foundationDateLabel.Location = new System.Drawing.Point(208, 77);
            this.foundationDateLabel.Name = "foundationDateLabel";
            this.foundationDateLabel.Size = new System.Drawing.Size(84, 13);
            this.foundationDateLabel.TabIndex = 6;
            this.foundationDateLabel.Text = "Foundation date";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(305, 23);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(138, 20);
            this.nameBox.TabIndex = 7;
            // 
            // foundationtimebox
            // 
            this.foundationtimebox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.foundationtimebox.Location = new System.Drawing.Point(305, 69);
            this.foundationtimebox.Name = "foundationtimebox";
            this.foundationtimebox.Size = new System.Drawing.Size(138, 20);
            this.foundationtimebox.TabIndex = 8;
            // 
            // gangImageBox
            // 
            this.gangImageBox.Location = new System.Drawing.Point(13, 13);
            this.gangImageBox.Name = "gangImageBox";
            this.gangImageBox.Size = new System.Drawing.Size(148, 143);
            this.gangImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gangImageBox.TabIndex = 10;
            this.gangImageBox.TabStop = false;
            // 
            // imageChoseButton
            // 
            this.imageChoseButton.Location = new System.Drawing.Point(45, 168);
            this.imageChoseButton.Name = "imageChoseButton";
            this.imageChoseButton.Size = new System.Drawing.Size(75, 23);
            this.imageChoseButton.TabIndex = 11;
            this.imageChoseButton.Text = "Chose";
            this.imageChoseButton.UseVisualStyleBackColor = true;
            this.imageChoseButton.Click += new System.EventHandler(this.imageChoseButton_Click);
            // 
            // choseimageDialog
            // 
            this.choseimageDialog.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(305, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(547, 208);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(82, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(672, 208);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // GangInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 433);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.imageChoseButton);
            this.Controls.Add(this.gangImageBox);
            this.Controls.Add(this.foundationtimebox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.foundationDateLabel);
            this.Controls.Add(this.leaderChoseButton);
            this.Controls.Add(this.leaderlinkedLabel);
            this.Controls.Add(this.leaderLabel);
            this.Controls.Add(this.countrylabel);
            this.Controls.Add(this.featuresBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "GangInfo";
            this.Text = "GangInfo";
            this.featuresBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gangImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox featuresBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label countrylabel;
        private System.Windows.Forms.Label leaderLabel;
        private System.Windows.Forms.LinkLabel leaderlinkedLabel;
        private System.Windows.Forms.Button leaderChoseButton;
        private System.Windows.Forms.Label foundationDateLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.DateTimePicker foundationtimebox;
        private System.Windows.Forms.PictureBox gangImageBox;
        private System.Windows.Forms.Button imageChoseButton;
        private System.Windows.Forms.OpenFileDialog choseimageDialog;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}