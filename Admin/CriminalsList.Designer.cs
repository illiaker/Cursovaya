namespace Admin
{
    partial class CriminalsList
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
            this.criminalList = new System.Windows.Forms.DataGridView();
            this.criminalBindingSourse = new System.Windows.Forms.BindingSource(this.components);
            this.SaveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.criminalList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalBindingSourse)).BeginInit();
            this.SuspendLayout();
            // 
            // criminalList
            // 
            this.criminalList.AllowUserToAddRows = false;
            this.criminalList.AllowUserToDeleteRows = false;
            this.criminalList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.criminalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.criminalList.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.criminalList.Location = new System.Drawing.Point(3, 2);
            this.criminalList.Name = "criminalList";
            this.criminalList.ReadOnly = true;
            this.criminalList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.criminalList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.criminalList.Size = new System.Drawing.Size(840, 436);
            this.criminalList.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveButton.Location = new System.Drawing.Point(587, 510);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(700, 510);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(409, 510);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(124, 23);
            this.selectButton.TabIndex = 3;
            this.selectButton.Text = "Add selected";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // CriminalsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 578);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.criminalList);
            this.Name = "CriminalsList";
            this.Text = "ChooseCriminals";
            ((System.ComponentModel.ISupportInitialize)(this.criminalList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalBindingSourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView criminalList;
        private System.Windows.Forms.BindingSource criminalBindingSourse;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button selectButton;
    }
}