namespace DMS
{
    partial class UCSemester
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.saveSemesterButton = new MetroFramework.Controls.MetroButton();
            this.semesterTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.sessionComboBox = new MetroFramework.Controls.MetroComboBox();
            this.semesterGrid = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.semesterGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(189, 186);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(111, 42);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseSelectable = true;
            // 
            // saveSemesterButton
            // 
            this.saveSemesterButton.Location = new System.Drawing.Point(14, 186);
            this.saveSemesterButton.Name = "saveSemesterButton";
            this.saveSemesterButton.Size = new System.Drawing.Size(111, 42);
            this.saveSemesterButton.TabIndex = 14;
            this.saveSemesterButton.Text = "Save Semester";
            this.saveSemesterButton.UseSelectable = true;
            this.saveSemesterButton.Click += new System.EventHandler(this.saveSemesterButton_Click);
            // 
            // semesterTextBox
            // 
            // 
            // 
            // 
            this.semesterTextBox.CustomButton.Image = null;
            this.semesterTextBox.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.semesterTextBox.CustomButton.Name = "";
            this.semesterTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.semesterTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.semesterTextBox.CustomButton.TabIndex = 1;
            this.semesterTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.semesterTextBox.CustomButton.UseSelectable = true;
            this.semesterTextBox.CustomButton.Visible = false;
            this.semesterTextBox.Lines = new string[0];
            this.semesterTextBox.Location = new System.Drawing.Point(140, 118);
            this.semesterTextBox.MaxLength = 32767;
            this.semesterTextBox.Name = "semesterTextBox";
            this.semesterTextBox.PasswordChar = '\0';
            this.semesterTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.semesterTextBox.SelectedText = "";
            this.semesterTextBox.SelectionLength = 0;
            this.semesterTextBox.SelectionStart = 0;
            this.semesterTextBox.ShortcutsEnabled = true;
            this.semesterTextBox.Size = new System.Drawing.Size(236, 23);
            this.semesterTextBox.TabIndex = 13;
            this.semesterTextBox.UseSelectable = true;
            this.semesterTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.semesterTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 118);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(103, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Semester Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(14, 61);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Session Year";
            // 
            // sessionComboBox
            // 
            this.sessionComboBox.FormattingEnabled = true;
            this.sessionComboBox.ItemHeight = 23;
            this.sessionComboBox.Location = new System.Drawing.Point(140, 61);
            this.sessionComboBox.Name = "sessionComboBox";
            this.sessionComboBox.Size = new System.Drawing.Size(236, 29);
            this.sessionComboBox.TabIndex = 17;
            this.sessionComboBox.UseSelectable = true;
            // 
            // semesterGrid
            // 
            this.semesterGrid.AllowUserToDeleteRows = false;
            this.semesterGrid.AllowUserToResizeRows = false;
            this.semesterGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.semesterGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.semesterGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.semesterGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.semesterGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.semesterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.semesterGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.semesterGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.semesterGrid.EnableHeadersVisualStyles = false;
            this.semesterGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.semesterGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.semesterGrid.Location = new System.Drawing.Point(421, 61);
            this.semesterGrid.Name = "semesterGrid";
            this.semesterGrid.ReadOnly = true;
            this.semesterGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.semesterGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.semesterGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.semesterGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.semesterGrid.Size = new System.Drawing.Size(542, 240);
            this.semesterGrid.TabIndex = 19;
            this.semesterGrid.DoubleClick += new System.EventHandler(this.semesterGrid_DoubleClick_1);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataSource = typeof(DMS.session);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(14, 13);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(208, 25);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Semester Management";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // UCSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.semesterGrid);
            this.Controls.Add(this.sessionComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveSemesterButton);
            this.Controls.Add(this.semesterTextBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Name = "UCSemester";
            this.Size = new System.Drawing.Size(1100, 452);
            this.Load += new System.EventHandler(this.UCSemester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.semesterGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton saveSemesterButton;
        private MetroFramework.Controls.MetroTextBox semesterTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox sessionComboBox;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private MetroFramework.Controls.MetroGrid semesterGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}
