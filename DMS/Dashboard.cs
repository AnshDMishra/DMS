using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS
{
    public partial class Dashboard : MetroFramework.Controls.MetroUserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        
        
        private void Dashboard_Load(object sender, EventArgs e)
        {
            //AdminLink.BackgroundImageLayout = ImageLayout.Stretch;
        }

        

        private void semesterLink_Click_1(object sender, EventArgs e)
        {
            if (!DMSForm.Instance.MetroContainer.Controls.ContainsKey("UCSemester"))
            {
                UCSemester uc = new UCSemester();
                uc.Dock = DockStyle.Fill;
                DMSForm.Instance.MetroContainer.Controls.Add(uc);

            }
            DMSForm.Instance.MetroContainer.Controls["UCSemester"].BringToFront();
            DMSForm.Instance.MetroBack.Visible = true;

        }

        private void sessionLink_Click(object sender, EventArgs e)
        {

            if (!DMSForm.Instance.MetroContainer.Controls.ContainsKey("UCSession"))
            {
                UCSession uc = new UCSession();
                uc.Dock = DockStyle.Fill;
                DMSForm.Instance.MetroContainer.Controls.Add(uc);

            }
            DMSForm.Instance.MetroContainer.Controls["UCSession"].BringToFront();
            DMSForm.Instance.MetroBack.Visible = true;
        }

        private void logout_Click_1(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                //windows app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                //console
                System.Environment.Exit(1);
            }
        }

        private void requiredLink_Click_1(object sender, EventArgs e)
        {
            string required = "required";
            MatricNum mat = new MatricNum(required);
            mat.Show();
        }

        private void StudentLink_Click_1(object sender, EventArgs e)
        {
            if (!DMSForm.Instance.MetroContainer.Controls.ContainsKey("UCStudent"))
            {
                UCStudent uc = new UCStudent();
                uc.Dock = DockStyle.Fill;
                DMSForm.Instance.MetroContainer.Controls.Add(uc);

            }
            DMSForm.Instance.MetroContainer.Controls["UCStudent"].BringToFront();
            DMSForm.Instance.MetroBack.Visible = true;
        }

        private void AdminLink_Click_1(object sender, EventArgs e)
        {
            if (!DMSForm.Instance.MetroContainer.Controls.ContainsKey("UCAdmin"))
            {
                UCAdmin uc = new UCAdmin();
                uc.Dock = DockStyle.Fill;
                DMSForm.Instance.MetroContainer.Controls.Add(uc);

            }
            DMSForm.Instance.MetroContainer.Controls["UCAdmin"].BringToFront();
            DMSForm.Instance.MetroBack.Visible = true;
        }

        private void reportLink_Click_1(object sender, EventArgs e)
        {
            string report = "report";
            MatricNum mat = new MatricNum(report);
            mat.Show();
        }

        private void DocUploadLink_Click_1(object sender, EventArgs e)
        {
            string document = "document";
            MatricNum mat = new MatricNum(document);
            mat.Show();
        }
    }
}
