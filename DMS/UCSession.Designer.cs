namespace DMS
{
    partial class UCSession
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
            this.saveSessionButton = new MetroFramework.Controls.MetroButton();
            this.sessionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.sessionGrid = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.sessionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(201, 260);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(111, 42);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveSessionButton
            // 
            this.saveSessionButton.Location = new System.Drawing.Point(20, 260);
            this.saveSessionButton.Name = "saveSessionButton";
            this.saveSessionButton.Size = new System.Drawing.Size(111, 42);
            this.saveSessionButton.TabIndex = 10;
            this.saveSessionButton.Text = "Save Session";
            this.saveSessionButton.UseSelectable = true;
            this.saveSessionButton.Click += new System.EventHandler(this.saveSessionButton_Click);
            // 
            // sessionTextBox
            // 
            // 
            // 
            // 
            this.sessionTextBox.CustomButton.Image = null;
            this.sessionTextBox.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.sessionTextBox.CustomButton.Name = "";
            this.sessionTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.sessionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sessionTextBox.CustomButton.TabIndex = 1;
            this.sessionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sessionTextBox.CustomButton.UseSelectable = true;
            this.sessionTextBox.CustomButton.Visible = false;
            this.sessionTextBox.Lines = new string[0];
            this.sessionTextBox.Location = new System.Drawing.Point(105, 158);
            this.sessionTextBox.MaxLength = 32767;
            this.sessionTextBox.Name = "sessionTextBox";
            this.sessionTextBox.PasswordChar = '\0';
            this.sessionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sessionTextBox.SelectedText = "";
            this.sessionTextBox.SelectionLength = 0;
            this.sessionTextBox.SelectionStart = 0;
            this.sessionTextBox.ShortcutsEnabled = true;
            this.sessionTextBox.Size = new System.Drawing.Size(235, 23);
            this.sessionTextBox.TabIndex = 9;
            this.sessionTextBox.UseSelectable = true;
            this.sessionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sessionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 158);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Session Year";
            // 
            // sessionGrid
            // 
            this.sessionGrid.AllowUserToDeleteRows = false;
            this.sessionGrid.AllowUserToResizeRows = false;
            this.sessionGrid.AutoGenerateColumns = false;
            this.sessionGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sessionGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sessionGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sessionGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sessionGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sessionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sessionnameDataGridViewTextBoxColumn});
            this.sessionGrid.DataSource = this.sessionBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sessionGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.sessionGrid.EnableHeadersVisualStyles = false;
            this.sessionGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sessionGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sessionGrid.Location = new System.Drawing.Point(390, 62);
            this.sessionGrid.Name = "sessionGrid";
            this.sessionGrid.ReadOnly = true;
            this.sessionGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sessionGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.sessionGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.sessionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sessionGrid.Size = new System.Drawing.Size(385, 257);
            this.sessionGrid.TabIndex = 13;
             this.sessionGrid.DoubleClick += new System.EventHandler(this.sessionGrid_DoubleClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionnameDataGridViewTextBoxColumn
            // 
            this.sessionnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sessionnameDataGridViewTextBoxColumn.DataPropertyName = "session_name";
            this.sessionnameDataGridViewTextBoxColumn.HeaderText = "Session Name";
            this.sessionnameDataGridViewTextBoxColumn.Name = "sessionnameDataGridViewTextBoxColumn";
            this.sessionnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionBindingSource1
            // 
            this.sessionBindingSource1.DataSource = typeof(DMS.session);
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataSource = typeof(DMS.session);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(20, 101);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(124, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Add New Session";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(20, 15);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(193, 25);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Session Management";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // UCSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.sessionGrid);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveSessionButton);
            this.Controls.Add(this.sessionTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UCSession";
            this.Size = new System.Drawing.Size(794, 432);
            this.Load += new System.EventHandler(this.UCSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sessionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton saveSessionButton;
        private MetroFramework.Controls.MetroTextBox sessionTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid sessionGrid;
        private System.Windows.Forms.BindingSource sessionBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionnameDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}
