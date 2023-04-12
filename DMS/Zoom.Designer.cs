namespace DMS
{
    partial class Zoom
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
            this.zoomTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.zoomPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.zoomPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.zoomTrackBar.Location = new System.Drawing.Point(122, 24);
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Size = new System.Drawing.Size(381, 23);
            this.zoomTrackBar.TabIndex = 0;
            this.zoomTrackBar.Text = "Zoom";
            this.zoomTrackBar.Value = 0;
            this.zoomTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.zoomTrackBar_Scroll);
            // 
            // zoomPictureBox
            // 
            this.zoomPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoomPictureBox.Location = new System.Drawing.Point(20, 60);
            this.zoomPictureBox.Name = "zoomPictureBox";
            this.zoomPictureBox.Size = new System.Drawing.Size(760, 433);
            this.zoomPictureBox.TabIndex = 1;
            this.zoomPictureBox.TabStop = false;
            // 
            // Zoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.zoomPictureBox);
            this.Controls.Add(this.zoomTrackBar);
            this.Name = "Zoom";
            this.Text = "Zoom";
            this.Load += new System.EventHandler(this.Zoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zoomPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTrackBar zoomTrackBar;
        private System.Windows.Forms.PictureBox zoomPictureBox;
    }
}