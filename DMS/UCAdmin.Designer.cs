namespace DMS
{
    partial class UCAdmin
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
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.saveAdminButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.passwordBox = new MetroFramework.Controls.MetroTextBox();
            this.staffIDTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.emailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.phoneTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lastnameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.firstnameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.surnameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.adminGrid = new MetroFramework.Controls.MetroGrid();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.adminGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(38, 12);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(113, 19);
            this.metroLabel8.TabIndex = 22;
            this.metroLabel8.Text = "Add a new admin";
            // 
            // saveAdminButton
            // 
            this.saveAdminButton.Location = new System.Drawing.Point(24, 309);
            this.saveAdminButton.Name = "saveAdminButton";
            this.saveAdminButton.Size = new System.Drawing.Size(111, 42);
            this.saveAdminButton.TabIndex = 7;
            this.saveAdminButton.Text = "Save Admin";
            this.saveAdminButton.UseSelectable = true;
            this.saveAdminButton.Click += new System.EventHandler(this.saveAdminButton_Click_1);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(24, 265);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(63, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Password";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(24, 227);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Staff ID";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 189);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 19);
            this.metroLabel4.TabIndex = 17;
            this.metroLabel4.Text = "Email";
            // 
            // passwordBox
            // 
            // 
            // 
            // 
            this.passwordBox.CustomButton.Image = null;
            this.passwordBox.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.passwordBox.CustomButton.Name = "";
            this.passwordBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordBox.CustomButton.TabIndex = 1;
            this.passwordBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordBox.CustomButton.UseSelectable = true;
            this.passwordBox.CustomButton.Visible = false;
            this.passwordBox.Lines = new string[0];
            this.passwordBox.Location = new System.Drawing.Point(116, 265);
            this.passwordBox.MaxLength = 32767;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '\0';
            this.passwordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordBox.SelectedText = "";
            this.passwordBox.SelectionLength = 0;
            this.passwordBox.SelectionStart = 0;
            this.passwordBox.ShortcutsEnabled = true;
            this.passwordBox.Size = new System.Drawing.Size(235, 23);
            this.passwordBox.TabIndex = 6;
            this.passwordBox.UseSelectable = true;
            this.passwordBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // staffIDTextBox
            // 
            // 
            // 
            // 
            this.staffIDTextBox.CustomButton.Image = null;
            this.staffIDTextBox.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.staffIDTextBox.CustomButton.Name = "";
            this.staffIDTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.staffIDTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.staffIDTextBox.CustomButton.TabIndex = 1;
            this.staffIDTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.staffIDTextBox.CustomButton.UseSelectable = true;
            this.staffIDTextBox.CustomButton.Visible = false;
            this.staffIDTextBox.Lines = new string[0];
            this.staffIDTextBox.Location = new System.Drawing.Point(116, 223);
            this.staffIDTextBox.MaxLength = 32767;
            this.staffIDTextBox.Name = "staffIDTextBox";
            this.staffIDTextBox.PasswordChar = '\0';
            this.staffIDTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.staffIDTextBox.SelectedText = "";
            this.staffIDTextBox.SelectionLength = 0;
            this.staffIDTextBox.SelectionStart = 0;
            this.staffIDTextBox.ShortcutsEnabled = true;
            this.staffIDTextBox.Size = new System.Drawing.Size(235, 23);
            this.staffIDTextBox.TabIndex = 5;
            this.staffIDTextBox.UseSelectable = true;
            this.staffIDTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.staffIDTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(24, 148);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(46, 19);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Phone";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 117);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 19;
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
            this.emailTextBox.Location = new System.Drawing.Point(116, 185);
            this.emailTextBox.MaxLength = 32767;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.SelectionLength = 0;
            this.emailTextBox.SelectionStart = 0;
            this.emailTextBox.ShortcutsEnabled = true;
            this.emailTextBox.Size = new System.Drawing.Size(235, 23);
            this.emailTextBox.TabIndex = 4;
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
            this.phoneTextBox.Location = new System.Drawing.Point(116, 148);
            this.phoneTextBox.MaxLength = 32767;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.PasswordChar = '\0';
            this.phoneTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneTextBox.SelectedText = "";
            this.phoneTextBox.SelectionLength = 0;
            this.phoneTextBox.SelectionStart = 0;
            this.phoneTextBox.ShortcutsEnabled = true;
            this.phoneTextBox.Size = new System.Drawing.Size(235, 23);
            this.phoneTextBox.TabIndex = 3;
            this.phoneTextBox.UseSelectable = true;
            this.phoneTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.phoneTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 20;
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
            this.lastnameTextBox.Location = new System.Drawing.Point(116, 117);
            this.lastnameTextBox.MaxLength = 32767;
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.PasswordChar = '\0';
            this.lastnameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastnameTextBox.SelectedText = "";
            this.lastnameTextBox.SelectionLength = 0;
            this.lastnameTextBox.SelectionStart = 0;
            this.lastnameTextBox.ShortcutsEnabled = true;
            this.lastnameTextBox.Size = new System.Drawing.Size(235, 23);
            this.lastnameTextBox.TabIndex = 2;
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
            this.firstnameTextBox.Location = new System.Drawing.Point(116, 79);
            this.firstnameTextBox.MaxLength = 32767;
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.PasswordChar = '\0';
            this.firstnameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstnameTextBox.SelectedText = "";
            this.firstnameTextBox.SelectionLength = 0;
            this.firstnameTextBox.SelectionStart = 0;
            this.firstnameTextBox.ShortcutsEnabled = true;
            this.firstnameTextBox.Size = new System.Drawing.Size(235, 23);
            this.firstnameTextBox.TabIndex = 1;
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
            this.surnameTextBox.Location = new System.Drawing.Point(116, 48);
            this.surnameTextBox.MaxLength = 32767;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.PasswordChar = '\0';
            this.surnameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.surnameTextBox.SelectedText = "";
            this.surnameTextBox.SelectionLength = 0;
            this.surnameTextBox.SelectionStart = 0;
            this.surnameTextBox.ShortcutsEnabled = true;
            this.surnameTextBox.Size = new System.Drawing.Size(235, 23);
            this.surnameTextBox.TabIndex = 0;
            this.surnameTextBox.UseSelectable = true;
            this.surnameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.surnameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 48);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Surname";
            // 
            // adminGrid
            // 
            this.adminGrid.AllowUserToDeleteRows = false;
            this.adminGrid.AllowUserToResizeRows = false;
            this.adminGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminGrid.AutoGenerateColumns = false;
            this.adminGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.adminGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.adminGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.adminGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameDataGridViewTextBoxColumn,
            this.id,
            this.password,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.createdonDataGridViewTextBoxColumn});
            this.adminGrid.DataSource = this.adminBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adminGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.adminGrid.EnableHeadersVisualStyles = false;
            this.adminGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.adminGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.adminGrid.Location = new System.Drawing.Point(372, 32);
            this.adminGrid.Name = "adminGrid";
            this.adminGrid.ReadOnly = true;
            this.adminGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.adminGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.adminGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adminGrid.Size = new System.Drawing.Size(620, 361);
            this.adminGrid.TabIndex = 23;
            this.adminGrid.DoubleClick += new System.EventHandler(this.adminGrid_DoubleClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(226, 309);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(111, 42);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataSource = typeof(DMS.admin);
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "staffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "staffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
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
            // createdonDataGridViewTextBoxColumn
            // 
            this.createdonDataGridViewTextBoxColumn.DataPropertyName = "created_on";
            this.createdonDataGridViewTextBoxColumn.HeaderText = "Created On";
            this.createdonDataGridViewTextBoxColumn.Name = "createdonDataGridViewTextBoxColumn";
            this.createdonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UCAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminGrid);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveAdminButton);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.staffIDTextBox);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UCAdmin";
            this.Size = new System.Drawing.Size(1016, 381);
            this.Load += new System.EventHandler(this.UCAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource adminBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton saveAdminButton;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox passwordBox;
        private MetroFramework.Controls.MetroTextBox staffIDTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox emailTextBox;
        private MetroFramework.Controls.MetroTextBox phoneTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox lastnameTextBox;
        private MetroFramework.Controls.MetroTextBox firstnameTextBox;
        private MetroFramework.Controls.MetroTextBox surnameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid adminGrid;
        private MetroFramework.Controls.MetroButton cancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdonDataGridViewTextBoxColumn;
    }
}
