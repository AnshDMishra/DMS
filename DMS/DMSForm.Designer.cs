namespace DMS
{
    partial class DMSForm
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
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.mlBack = new MetroFramework.Controls.MetroLink();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.footerPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.timerLabel = new MetroFramework.Controls.MetroLabel();
            this.loggedName = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mPanel
            // 
            this.mPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(9, 68);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(1011, 566);
            this.mPanel.TabIndex = 0;
            this.mPanel.VerticalScrollbar = true;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // mlBack
            // 
            this.mlBack.Image = global::DMS.Properties.Resources.back;
            this.mlBack.ImageSize = 32;
            this.mlBack.Location = new System.Drawing.Point(23, 26);
            this.mlBack.Name = "mlBack";
            this.mlBack.Size = new System.Drawing.Size(75, 23);
            this.mlBack.TabIndex = 1;
            this.mlBack.UseSelectable = true;
            this.mlBack.Click += new System.EventHandler(this.mlBack_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.metroLabel1);
            this.footerPanel.Controls.Add(this.timerLabel);
            this.footerPanel.Controls.Add(this.loggedName);
            this.footerPanel.HorizontalScrollbarBarColor = true;
            this.footerPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.footerPanel.HorizontalScrollbarSize = 10;
            this.footerPanel.Location = new System.Drawing.Point(9, 640);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1011, 45);
            this.footerPanel.TabIndex = 2;
            this.footerPanel.VerticalScrollbarBarColor = true;
            this.footerPanel.VerticalScrollbarHighlightOnWheel = false;
            this.footerPanel.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Logged in as: ";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(721, 17);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(81, 19);
            this.timerLabel.TabIndex = 2;
            this.timerLabel.Text = "metroLabel1";
            // 
            // loggedName
            // 
            this.loggedName.AutoSize = true;
            this.loggedName.Location = new System.Drawing.Point(151, 8);
            this.loggedName.Name = "loggedName";
            this.loggedName.Size = new System.Drawing.Size(81, 19);
            this.loggedName.TabIndex = 2;
            this.loggedName.Text = "metroLabel1";
            // 
            // DMSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 687);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.mlBack);
            this.Controls.Add(this.mPanel);
            this.Name = "DMSForm";
            this.Text = "           DMS";
            this.Load += new System.EventHandler(this.DMSForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroPanel mPanel;
        private MetroFramework.Controls.MetroLink mlBack;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroPanel footerPanel;
        private MetroFramework.Controls.MetroLabel loggedName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel timerLabel;
    }
}

