namespace DMS
{
    partial class UCStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.saveStudentButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.matNumTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.emailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.phoneTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lastnameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.firstnameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.surnameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.studentGrid = new MetroFramework.Controls.MetroGrid();
            this.levelComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.DOBDateTime = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(30, 13);
            this.metroLabel1.MinimumSize = new System.Drawing.Size(200, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(197, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Student Management";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.WrapToLine = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(224, 418);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(111, 42);
            this.cancelButton.TabIndex = 30;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveStudentButton
            // 
            this.saveStudentButton.Location = new System.Drawing.Point(30, 418);
            this.saveStudentButton.Name = "saveStudentButton";
            this.saveStudentButton.Size = new System.Drawing.Size(111, 42);
            this.saveStudentButton.TabIndex = 28;
            this.saveStudentButton.Text = "Save Student";
            this.saveStudentButton.UseSelectable = true;
            this.saveStudentButton.Click += new System.EventHandler(this.saveStudentButton_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(30, 242);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(79, 19);
            this.metroLabel5.TabIndex = 32;
            this.metroLabel5.Text = "Matric Num";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(30, 204);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 19);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "Email";
            // 
            // matNumTextBox
            // 
            // 
            // 
            // 
            this.matNumTextBox.CustomButton.Image = null;
            this.matNumTextBox.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.matNumTextBox.CustomButton.Name = "";
            this.matNumTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.matNumTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.matNumTextBox.CustomButton.TabIndex = 1;
            this.matNumTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.matNumTextBox.CustomButton.UseSelectable = true;
            this.matNumTextBox.CustomButton.Visible = false;
            this.matNumTextBox.Lines = new string[0];
            this.matNumTextBox.Location = new System.Drawing.Point(122, 238);
            this.matNumTextBox.MaxLength = 32767;
            this.matNumTextBox.Name = "matNumTextBox";
            this.matNumTextBox.PasswordChar = '\0';
            this.matNumTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matNumTextBox.SelectedText = "";
            this.matNumTextBox.SelectionLength = 0;
            this.matNumTextBox.SelectionStart = 0;
            this.matNumTextBox.ShortcutsEnabled = true;
            this.matNumTextBox.Size = new System.Drawing.Size(235, 23);
            this.matNumTextBox.TabIndex = 26;
            this.matNumTextBox.UseSelectable = true;
            this.matNumTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.matNumTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(30, 163);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(46, 19);
            this.metroLabel7.TabIndex = 34;
            this.metroLabel7.Text = "Phone";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(30, 132);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 35;
            this.metroLabel3.Text = "LastName";
            // 
            // emailTextBox
            // 
            // 
            // 
            // 
            this.emailTextBox.CustomButton.Image = null;
            this.emailTextBox.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.emailTextBox.CustomButton.Name = "";
            this.emailTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailTextBox.CustomButton.TabIndex = 1;
            this.emailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailTextBox.CustomButton.UseSelectable = true;
            this.emailTextBox.CustomButton.Visible = false;
            this.emailTextBox.Lines = new string[0];
            this.emailTextBox.Location = new System.Drawing.Point(122, 200);
            this.emailTextBox.MaxLength = 32767;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.SelectionLength = 0;
            this.emailTextBox.SelectionStart = 0;
            this.emailTextBox.ShortcutsEnabled = true;
            this.emailTextBox.Size = new System.Drawing.Size(235, 23);
            this.emailTextBox.TabIndex = 25;
            this.emailTextBox.UseSelectable = true;
            this.emailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // phoneTextBox
            // 
            // 
            // 
            // 
            this.phoneTextBox.CustomButton.Image = null;
            this.phoneTextBox.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.phoneTextBox.CustomButton.Name = "";
            this.phoneTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.phoneTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.phoneTextBox.CustomButton.TabIndex = 1;
            this.phoneTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.phoneTextBox.CustomButton.UseSelectable = true;
            this.phoneTextBox.CustomButton.Visible = false;
            this.phoneTextBox.Lines = new string[0];
            this.phoneTextBox.Location = new System.Drawing.Point(122, 163);
            this.phoneTextBox.MaxLength = 32767;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.PasswordChar = '\0';
            this.phoneTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneTextBox.SelectedText = "";
            this.phoneTextBox.SelectionLength = 0;
            this.phoneTextBox.SelectionStart = 0;
            this.phoneTextBox.ShortcutsEnabled = true;
            this.phoneTextBox.Size = new System.Drawing.Size(235, 23);
            this.phoneTextBox.TabIndex = 24;
            this.phoneTextBox.UseSelectable = true;
            this.phoneTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.phoneTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(30, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 36;
            this.metroLabel2.Text = "FirstName";
            // 
            // lastnameTextBox
            // 
            // 
            // 
            // 
            this.lastnameTextBox.CustomButton.Image = null;
            this.lastnameTextBox.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.lastnameTextBox.CustomButton.Name = "";
            this.lastnameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lastnameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lastnameTextBox.CustomButton.TabIndex = 1;
            this.lastnameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lastnameTextBox.CustomButton.UseSelectable = true;
            this.lastnameTextBox.CustomButton.Visible = false;
            this.lastnameTextBox.Lines = new string[0];
            this.lastnameTextBox.Location = new System.Drawing.Point(122, 132);
            this.lastnameTextBox.MaxLength = 32767;
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.PasswordChar = '\0';
            this.lastnameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastnameTextBox.SelectedText = "";
            this.lastnameTextBox.SelectionLength = 0;
            this.lastnameTextBox.SelectionStart = 0;
            this.lastnameTextBox.ShortcutsEnabled = true;
            this.lastnameTextBox.Size = new System.Drawing.Size(235, 23);
            this.lastnameTextBox.TabIndex = 23;
            this.lastnameTextBox.UseSelectable = true;
            this.lastnameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lastnameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // firstnameTextBox
            // 
            // 
            // 
            // 
            this.firstnameTextBox.CustomButton.Image = null;
            this.firstnameTextBox.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.firstnameTextBox.CustomButton.Name = "";
            this.firstnameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.firstnameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.firstnameTextBox.CustomButton.TabIndex = 1;
            this.firstnameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.firstnameTextBox.CustomButton.UseSelectable = true;
            this.firstnameTextBox.CustomButton.Visible = false;
            this.firstnameTextBox.Lines = new string[0];
            this.firstnameTextBox.Location = new System.Drawing.Point(122, 94);
            this.firstnameTextBox.MaxLength = 32767;
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.PasswordChar = '\0';
            this.firstnameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstnameTextBox.SelectedText = "";
            this.firstnameTextBox.SelectionLength = 0;
            this.firstnameTextBox.SelectionStart = 0;
            this.firstnameTextBox.ShortcutsEnabled = true;
            this.firstnameTextBox.Size = new System.Drawing.Size(235, 23);
            this.firstnameTextBox.TabIndex = 22;
            this.firstnameTextBox.UseSelectable = true;
            this.firstnameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.firstnameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // surnameTextBox
            // 
            // 
            // 
            // 
            this.surnameTextBox.CustomButton.Image = null;
            this.surnameTextBox.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.surnameTextBox.CustomButton.Name = "";
            this.surnameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.surnameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.surnameTextBox.CustomButton.TabIndex = 1;
            this.surnameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.surnameTextBox.CustomButton.UseSelectable = true;
            this.surnameTextBox.CustomButton.Visible = false;
            this.surnameTextBox.Lines = new string[0];
            this.surnameTextBox.Location = new System.Drawing.Point(122, 63);
            this.surnameTextBox.MaxLength = 32767;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.PasswordChar = '\0';
            this.surnameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.surnameTextBox.SelectedText = "";
            this.surnameTextBox.SelectionLength = 0;
            this.surnameTextBox.SelectionStart = 0;
            this.surnameTextBox.ShortcutsEnabled = true;
            this.surnameTextBox.Size = new System.Drawing.Size(235, 23);
            this.surnameTextBox.TabIndex = 21;
            this.surnameTextBox.UseSelectable = true;
            this.surnameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.surnameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(30, 63);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(61, 19);
            this.metroLabel8.TabIndex = 29;
            this.metroLabel8.Text = "Surname";
            // 
            // studentGrid
            // 
            this.studentGrid.AllowUserToDeleteRows = false;
            this.studentGrid.AllowUserToResizeRows = false;
            this.studentGrid.AutoGenerateColumns = false;
            this.studentGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.studentGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.studentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.matricnumDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.createdonDataGridViewTextBoxColumn});
            this.studentGrid.DataSource = this.studentBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.studentGrid.EnableHeadersVisualStyles = false;
            this.studentGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.studentGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.studentGrid.Location = new System.Drawing.Point(391, 63);
            this.studentGrid.Name = "studentGrid";
            this.studentGrid.ReadOnly = true;
            this.studentGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.studentGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.studentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentGrid.Size = new System.Drawing.Size(621, 418);
            this.studentGrid.TabIndex = 37;
            this.studentGrid.DoubleClick += new System.EventHandler(this.studentGrid_DoubleClick);
            // 
            // levelComboBox
            // 
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.ItemHeight = 23;
            this.levelComboBox.Items.AddRange(new object[] {
            "100 Level",
            "200 Level",
            "300 Level",
            "400 Level"});
            this.levelComboBox.Location = new System.Drawing.Point(122, 277);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(235, 29);
            this.levelComboBox.TabIndex = 38;
            this.levelComboBox.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(30, 287);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(38, 19);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "Level";
            // 
            // DOBDateTime
            // 
            this.DOBDateTime.Location = new System.Drawing.Point(122, 337);
            this.DOBDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.DOBDateTime.Name = "DOBDateTime";
            this.DOBDateTime.Size = new System.Drawing.Size(235, 29);
            this.DOBDateTime.TabIndex = 39;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(30, 347);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(37, 19);
            this.metroLabel9.TabIndex = 32;
            this.metroLabel9.Text = "DOB";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matricnumDataGridViewTextBoxColumn
            // 
            this.matricnumDataGridViewTextBoxColumn.DataPropertyName = "matric_num";
            this.matricnumDataGridViewTextBoxColumn.HeaderText = "Matric Number";
            this.matricnumDataGridViewTextBoxColumn.Name = "matricnumDataGridViewTextBoxColumn";
            this.matricnumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "Level";
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdonDataGridViewTextBoxColumn
            // 
            this.createdonDataGridViewTextBoxColumn.DataPropertyName = "created_on";
            this.createdonDataGridViewTextBoxColumn.HeaderText = "created_on";
            this.createdonDataGridViewTextBoxColumn.Name = "createdonDataGridViewTextBoxColumn";
            this.createdonDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdonDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(DMS.student);
            // 
            // UCStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DOBDateTime);
            this.Controls.Add(this.levelComboBox);
            this.Controls.Add(this.studentGrid);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveStudentButton);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.matNumTextBox);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UCStudent";
            this.Size = new System.Drawing.Size(1013, 577);
            this.Load += new System.EventHandler(this.UCStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton saveStudentButton;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox matNumTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox emailTextBox;
        private MetroFramework.Controls.MetroTextBox phoneTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox lastnameTextBox;
        private MetroFramework.Controls.MetroTextBox firstnameTextBox;
        private MetroFramework.Controls.MetroTextBox surnameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroGrid studentGrid;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private MetroFramework.Controls.MetroComboBox levelComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroDateTime DOBDateTime;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdonDataGridViewTextBoxColumn;
    }
}
