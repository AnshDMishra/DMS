namespace DMS
{
    partial class UCDocumentStore
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.categoryComboBox = new MetroFramework.Controls.MetroComboBox();
            this.sessionComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.semesterComboBox = new MetroFramework.Controls.MetroComboBox();
            this.saveDocumentButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel = new MetroFramework.Controls.MetroLabel();
            this.matTextBox = new MetroFramework.Controls.MetroTextBox();
            this.uploadNewButton = new MetroFramework.Controls.MetroButton();
            this.docPictureBox = new System.Windows.Forms.PictureBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.docPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(89, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Category";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(89, 130);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Session";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(89, 269);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Document";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.ItemHeight = 23;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Student Profile",
            "Course Form",
            "Project"});
            this.categoryComboBox.Location = new System.Drawing.Point(216, 83);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(244, 29);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.UseSelectable = true;
            // 
            // sessionComboBox
            // 
            this.sessionComboBox.FormattingEnabled = true;
            this.sessionComboBox.ItemHeight = 23;
            this.sessionComboBox.Location = new System.Drawing.Point(216, 130);
            this.sessionComboBox.Name = "sessionComboBox";
            this.sessionComboBox.Size = new System.Drawing.Size(244, 29);
            this.sessionComboBox.TabIndex = 1;
            this.sessionComboBox.UseSelectable = true;
            this.sessionComboBox.SelectionChangeCommitted += new System.EventHandler(this.sessionComboBox_SelectionChangeCommitted);
            this.sessionComboBox.DisplayMemberChanged += new System.EventHandler(this.UCDocumentStore_Load);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(89, 192);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Semester";
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.ItemHeight = 23;
            this.semesterComboBox.Location = new System.Drawing.Point(216, 192);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(244, 29);
            this.semesterComboBox.TabIndex = 1;
            this.semesterComboBox.UseSelectable = true;
            // 
            // saveDocumentButton
            // 
            this.saveDocumentButton.Location = new System.Drawing.Point(216, 380);
            this.saveDocumentButton.Name = "saveDocumentButton";
            this.saveDocumentButton.Size = new System.Drawing.Size(75, 32);
            this.saveDocumentButton.TabIndex = 4;
            this.saveDocumentButton.Text = "Save";
            this.saveDocumentButton.UseSelectable = true;
            this.saveDocumentButton.Click += new System.EventHandler(this.saveDocumentButton_Click);
            // 
            // metroLabel
            // 
            this.metroLabel.AutoSize = true;
            this.metroLabel.Location = new System.Drawing.Point(89, 48);
            this.metroLabel.Name = "metroLabel";
            this.metroLabel.Size = new System.Drawing.Size(103, 19);
            this.metroLabel.TabIndex = 0;
            this.metroLabel.Text = "Matric  Number";
            // 
            // matTextBox
            // 
            // 
            // 
            // 
            this.matTextBox.CustomButton.Image = null;
            this.matTextBox.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.matTextBox.CustomButton.Name = "";
            this.matTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.matTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.matTextBox.CustomButton.TabIndex = 1;
            this.matTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.matTextBox.CustomButton.UseSelectable = true;
            this.matTextBox.CustomButton.Visible = false;
            this.matTextBox.Lines = new string[0];
            this.matTextBox.Location = new System.Drawing.Point(216, 48);
            this.matTextBox.MaxLength = 32767;
            this.matTextBox.Name = "matTextBox";
            this.matTextBox.PasswordChar = '\0';
            this.matTextBox.ReadOnly = true;
            this.matTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matTextBox.SelectedText = "";
            this.matTextBox.SelectionLength = 0;
            this.matTextBox.SelectionStart = 0;
            this.matTextBox.ShortcutsEnabled = true;
            this.matTextBox.Size = new System.Drawing.Size(244, 23);
            this.matTextBox.TabIndex = 5;
            this.matTextBox.UseSelectable = true;
            this.matTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.matTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uploadNewButton
            // 
            this.uploadNewButton.Location = new System.Drawing.Point(323, 380);
            this.uploadNewButton.Name = "uploadNewButton";
            this.uploadNewButton.Size = new System.Drawing.Size(75, 32);
            this.uploadNewButton.TabIndex = 4;
            this.uploadNewButton.Text = "Upload New";
            this.uploadNewButton.UseSelectable = true;
            this.uploadNewButton.Click += new System.EventHandler(this.uploadNewButton_Click);
            // 
            // docPictureBox
            // 
            this.docPictureBox.InitialImage = global::DMS.Properties.Resources.icons8_image_file_512;
            this.docPictureBox.Location = new System.Drawing.Point(216, 238);
            this.docPictureBox.Name = "docPictureBox";
            this.docPictureBox.Size = new System.Drawing.Size(244, 108);
            this.docPictureBox.TabIndex = 2;
            this.docPictureBox.TabStop = false;
            this.docPictureBox.Click += new System.EventHandler(this.docPictureBox_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(89, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(166, 25);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Upload Document";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // UCDocumentStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.matTextBox);
            this.Controls.Add(this.uploadNewButton);
            this.Controls.Add(this.saveDocumentButton);
            this.Controls.Add(this.docPictureBox);
            this.Controls.Add(this.semesterComboBox);
            this.Controls.Add(this.sessionComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel);
            this.Controls.Add(this.metroLabel1);
            this.Location = new System.Drawing.Point(120, 0);
            this.Name = "UCDocumentStore";
            this.Size = new System.Drawing.Size(609, 450);
            this.Load += new System.EventHandler(this.UCDocumentStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.docPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox categoryComboBox;
        private MetroFramework.Controls.MetroComboBox sessionComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox semesterComboBox;
        private System.Windows.Forms.PictureBox docPictureBox;
        private MetroFramework.Controls.MetroButton saveDocumentButton;
        private MetroFramework.Controls.MetroLabel metroLabel;
        private MetroFramework.Controls.MetroTextBox matTextBox;
        private MetroFramework.Controls.MetroButton uploadNewButton;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}
