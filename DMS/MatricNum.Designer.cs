namespace DMS
{
    partial class MatricNum
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.matricNumberBox = new MetroFramework.Controls.MetroTextBox();
            this.confirmMatric = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 121);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Matric Number";
            // 
            // matricNumberBox
            // 
            // 
            // 
            // 
            this.matricNumberBox.CustomButton.Image = null;
            this.matricNumberBox.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.matricNumberBox.CustomButton.Name = "";
            this.matricNumberBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.matricNumberBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.matricNumberBox.CustomButton.TabIndex = 1;
            this.matricNumberBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.matricNumberBox.CustomButton.UseSelectable = true;
            this.matricNumberBox.CustomButton.Visible = false;
            this.matricNumberBox.Lines = new string[0];
            this.matricNumberBox.Location = new System.Drawing.Point(117, 121);
            this.matricNumberBox.MaxLength = 32767;
            this.matricNumberBox.Name = "matricNumberBox";
            this.matricNumberBox.PasswordChar = '\0';
            this.matricNumberBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matricNumberBox.SelectedText = "";
            this.matricNumberBox.SelectionLength = 0;
            this.matricNumberBox.SelectionStart = 0;
            this.matricNumberBox.ShortcutsEnabled = true;
            this.matricNumberBox.Size = new System.Drawing.Size(236, 23);
            this.matricNumberBox.TabIndex = 1;
            this.matricNumberBox.UseSelectable = true;
            this.matricNumberBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.matricNumberBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // confirmMatric
            // 
            this.confirmMatric.Location = new System.Drawing.Point(117, 183);
            this.confirmMatric.Name = "confirmMatric";
            this.confirmMatric.Size = new System.Drawing.Size(135, 28);
            this.confirmMatric.TabIndex = 2;
            this.confirmMatric.Text = "Confirm";
            this.confirmMatric.UseSelectable = true;
            this.confirmMatric.Click += new System.EventHandler(this.confirmMatric_Click);
            // 
            // MatricNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.confirmMatric);
            this.Controls.Add(this.matricNumberBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "MatricNum";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Matric Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox matricNumberBox;
        private MetroFramework.Controls.MetroButton confirmMatric;
    }
}