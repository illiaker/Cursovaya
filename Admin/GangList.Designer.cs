namespace Admin
{
    partial class GangList
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
            this.gangGridView = new System.Windows.Forms.DataGridView();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.featuresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foundationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criminalGangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.choseButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gangGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalGangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gangGridView
            // 
            this.gangGridView.AllowUserToAddRows = false;
            this.gangGridView.AllowUserToDeleteRows = false;
            this.gangGridView.AutoGenerateColumns = false;
            this.gangGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gangGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gangGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageDataGridViewImageColumn,
            this.nameDataGridViewTextBoxColumn,
            this.featuresDataGridViewTextBoxColumn,
            this.foundationDateDataGridViewTextBoxColumn,
            this.leaderDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.leaderNameDataGridViewTextBoxColumn});
            this.gangGridView.DataSource = this.criminalGangBindingSource;
            this.gangGridView.Location = new System.Drawing.Point(3, 7);
            this.gangGridView.MultiSelect = false;
            this.gangGridView.Name = "gangGridView";
            this.gangGridView.ReadOnly = true;
            this.gangGridView.RowHeadersVisible = false;
            this.gangGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gangGridView.Size = new System.Drawing.Size(785, 431);
            this.gangGridView.TabIndex = 0;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // featuresDataGridViewTextBoxColumn
            // 
            this.featuresDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.featuresDataGridViewTextBoxColumn.DataPropertyName = "Features";
            this.featuresDataGridViewTextBoxColumn.HeaderText = "Features";
            this.featuresDataGridViewTextBoxColumn.Name = "featuresDataGridViewTextBoxColumn";
            this.featuresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foundationDateDataGridViewTextBoxColumn
            // 
            this.foundationDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.foundationDateDataGridViewTextBoxColumn.DataPropertyName = "FoundationDate";
            this.foundationDateDataGridViewTextBoxColumn.HeaderText = "FoundationDate";
            this.foundationDateDataGridViewTextBoxColumn.Name = "foundationDateDataGridViewTextBoxColumn";
            this.foundationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leaderDataGridViewTextBoxColumn
            // 
            this.leaderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.leaderDataGridViewTextBoxColumn.DataPropertyName = "Leader";
            this.leaderDataGridViewTextBoxColumn.HeaderText = "Leader";
            this.leaderDataGridViewTextBoxColumn.Name = "leaderDataGridViewTextBoxColumn";
            this.leaderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leaderNameDataGridViewTextBoxColumn
            // 
            this.leaderNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.leaderNameDataGridViewTextBoxColumn.DataPropertyName = "LeaderName";
            this.leaderNameDataGridViewTextBoxColumn.HeaderText = "LeaderName";
            this.leaderNameDataGridViewTextBoxColumn.Name = "leaderNameDataGridViewTextBoxColumn";
            this.leaderNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // criminalGangBindingSource
            // 
            this.criminalGangBindingSource.DataSource = typeof(Cursovaya.Model.CriminalGang);
            // 
            // choseButton
            // 
            this.choseButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.choseButton.Location = new System.Drawing.Point(574, 494);
            this.choseButton.Name = "choseButton";
            this.choseButton.Size = new System.Drawing.Size(75, 23);
            this.choseButton.TabIndex = 1;
            this.choseButton.Text = "Chose";
            this.choseButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(689, 494);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // GangList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 552);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.choseButton);
            this.Controls.Add(this.gangGridView);
            this.MinimumSize = new System.Drawing.Size(807, 591);
            this.Name = "GangList";
            this.Text = "GangList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GangList_FormClosing);
            this.Load += new System.EventHandler(this.GangList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gangGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalGangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gangGridView;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn featuresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foundationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource criminalGangBindingSource;
        private System.Windows.Forms.Button choseButton;
        private System.Windows.Forms.Button cancelButton;
    }
}