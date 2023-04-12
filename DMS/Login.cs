using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        admin model = new admin();
        public Login()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using(dmsEntities db = new dmsEntities())
            {
                model.staffID = staffIdTextBox.Text;
                model.password = passwordTextBox.Text;

                var query = from a in db.admins
                            where a.staffID == staffIdTextBox.Text
                            && a.password == passwordTextBox.Text
                            select a;
                var result = query.SingleOrDefault();
                if (query.Any())
                {
                     
                   Auth.fullname =result.surname +" "+result.firstname+" "+result.lastname;
                    DMSForm dms = new DMSForm();
                    this.Hide();
                    dms.Show();
                }
                else
                {
                    MessageBox.Show("Invalid staff Id or password");
                }
            }
        }
    }
}
