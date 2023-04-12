using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS
{
    public partial class Zoom : MetroFramework.Forms.MetroForm
    {
        string path;
        public Zoom(string path)
        {

            InitializeComponent();
            this.path = path;
        }

        private void Zoom_Load(object sender, EventArgs e)
        {
            string pathString = Path.Combine(path);
            zoomPictureBox.Image = Image.FromFile(pathString);

            zoomTrackBar.Minimum =50;
            zoomTrackBar.Maximum = 800;

            zoomPictureBox.Left = (ClientSize.Width - zoomPictureBox.Width) / 2;
            zoomPictureBox.Top = (ClientSize.Height - zoomPictureBox.Height) / 2;
        }

        private void zoomTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            zoomPictureBox.Size = new Size(zoomTrackBar.Value, zoomPictureBox.Size.Height);
            zoomPictureBox.Left = (ClientSize.Width - zoomPictureBox.Width) / 2;
            zoomPictureBox.Top = (ClientSize.Height - zoomPictureBox.Height) / 2;
        }

      
    }
}
