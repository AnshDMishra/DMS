namespace DMS
{
    partial class Dashboard
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
            this.sessionLink = new MetroFramework.Controls.MetroTile();
            this.semesterLink = new MetroFramework.Controls.MetroTile();
            this.StudentLink = new MetroFramework.Controls.MetroTile();
            this.requiredLink = new MetroFramework.Controls.MetroTile();
            this.reportLink = new MetroFramework.Controls.MetroTile();
            this.AdminLink = new MetroFramework.Controls.MetroTile();
            this.DocUploadLink = new MetroFramework.Controls.MetroTile();
            this.logout = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // sessionLink
            // 
            this.sessionLink.ActiveControl = null;
            this.sessionLink.Location = new System.Drawing.Point(90, 93);
            this.sessionLink.Name = "sessionLink";
            this.sessionLink.Size = new System.Drawing.Size(187, 73);
            this.sessionLink.TabIndex = 0;
            this.sessionLink.Text = "Session";
            this.sessionLink.UseSelectable = true;
            this.sessionLink.Click += new System.EventHandler(this.sessionLink_Click);
            // 
            // semesterLink
            // 
            this.semesterLink.ActiveControl = null;
            this.semesterLink.Location = new System.Drawing.Point(288, 93);
            this.semesterLink.Name = "semesterLink";
            this.semesterLink.Size = new System.Drawing.Size(188, 73);
            this.semesterLink.TabIndex = 0;
            this.semesterLink.Text = "Semester";
            this.semesterLink.UseSelectable = true;
            this.semesterLink.Click += new System.EventHandler(this.semesterLink_Click_1);
            // 
            // StudentLink
            // 
            this.StudentLink.ActiveControl = null;
            this.StudentLink.Location = new System.Drawing.Point(487, 93);
            this.StudentLink.Name = "StudentLink";
            this.StudentLink.Size = new System.Drawing.Size(145, 123);
            this.StudentLink.TabIndex = 0;
            this.StudentLink.Text = "Student Account";
            this.StudentLink.UseSelectable = true;
            this.StudentLink.Click += new System.EventHandler(this.StudentLink_Click_1);
            // 
            // requiredLink
            // 
            this.requiredLink.ActiveControl = null;
            this.requiredLink.Location = new System.Drawing.Point(90, 191);
            this.requiredLink.Name = "requiredLink";
            this.requiredLink.Size = new System.Drawing.Size(187, 73);
            this.requiredLink.TabIndex = 0;
            this.requiredLink.Text = "Required Document";
            this.requiredLink.UseSelectable = true;
            this.requiredLink.Click += new System.EventHandler(this.requiredLink_Click_1);
            // 
            // reportLink
            // 
            this.reportLink.ActiveControl = null;
            this.reportLink.Location = new System.Drawing.Point(90, 288);
            this.reportLink.Name = "reportLink";
            this.reportLink.Size = new System.Drawing.Size(187, 73);
            this.reportLink.TabIndex = 0;
            this.reportLink.Text = "Report";
            this.reportLink.UseSelectable = true;
            this.reportLink.Click += new System.EventHandler(this.reportLink_Click_1);
            // 
            // AdminLink
            // 
            this.AdminLink.ActiveControl = null;
            this.AdminLink.Location = new System.Drawing.Point(487, 241);
            this.AdminLink.Name = "AdminLink";
            this.AdminLink.Size = new System.Drawing.Size(145, 122);
            this.AdminLink.TabIndex = 0;
            this.AdminLink.Text = "Admin Account";
            this.AdminLink.UseSelectable = true;
            this.AdminLink.Click += new System.EventHandler(this.AdminLink_Click_1);
            // 
            // DocUploadLink
            // 
            this.DocUploadLink.ActiveControl = null;
            this.DocUploadLink.Location = new System.Drawing.Point(288, 191);
            this.DocUploadLink.Name = "DocUploadLink";
            this.DocUploadLink.Size = new System.Drawing.Size(188, 73);
            this.DocUploadLink.TabIndex = 0;
            this.DocUploadLink.Text = "Upload Document";
            this.DocUploadLink.UseSelectable = true;
            this.DocUploadLink.Click += new System.EventHandler(this.DocUploadLink_Click_1);
            // 
            // logout
            // 
            this.logout.ActiveControl = null;
            this.logout.Location = new System.Drawing.Point(288, 288);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(188, 73);
            this.logout.TabIndex = 0;
            this.logout.Text = "Logout";
            this.logout.UseSelectable = true;
            this.logout.Click += new System.EventHandler(this.logout_Click_1);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logout);
            this.Controls.Add(this.AdminLink);
            this.Controls.Add(this.DocUploadLink);
            this.Controls.Add(this.StudentLink);
            this.Controls.Add(this.reportLink);
            this.Controls.Add(this.semesterLink);
            this.Controls.Add(this.requiredLink);
            this.Controls.Add(this.sessionLink);
            this.Location = new System.Drawing.Point(400, 100);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(761, 536);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile sessionLink;
        private MetroFramework.Controls.MetroTile semesterLink;
        private MetroFramework.Controls.MetroTile StudentLink;
        private MetroFramework.Controls.MetroTile requiredLink;
        private MetroFramework.Controls.MetroTile reportLink;
        private MetroFramework.Controls.MetroTile AdminLink;
        private MetroFramework.Controls.MetroTile DocUploadLink;
        private MetroFramework.Controls.MetroTile logout;
    }
}
