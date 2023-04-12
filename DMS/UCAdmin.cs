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
    public partial class UCAdmin : MetroFramework.Controls.MetroUserControl
    {
        admin model = new admin();
        public UCAdmin()
        {
            InitializeComponent();
        }

        private void UCAdmin_Load(object sender, EventArgs e)
        {
            Clear();
            using (dmsEntities db = new dmsEntities())
            {
                adminGrid.DataSource = db.admins.ToList();
            }
        }

        private void saveAdminButton_Click(object sender, EventArgs e)
        {
               
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            surnameTextBox.Text = firstnameTextBox.Text= lastnameTextBox.Text = staffIDTextBox.Text = phoneTextBox.Text= emailTextBox.Text = passwordBox.Text = "";
            saveAdminButton.Text = "Save Admin";
        }
        void PopulateDataGridView()
        {
            using (dmsEntities db = new dmsEntities())
            {
                adminGrid.AutoGenerateColumns = false;
                adminGrid.DataSource = db.admins.ToList<admin>();

            }
        }

        private void saveAdminButton_Click_1(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            string dateTimeVariable = time.ToString(format);
            model.surname = surnameTextBox.Text;
            model.firstname = firstnameTextBox.Text;
            model.lastname = lastnameTextBox.Text;
            model.staffID = staffIDTextBox.Text;
            model.phone = phoneTextBox.Text;
            model.email = emailTextBox.Text;
            model.password = passwordBox.Text;
            model.created_on = dateTimeVariable;
            using (dmsEntities db = new dmsEntities())
            {
                if (model.id == 0)//insert
                    db.admins.Add(model);
                else
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }
            MessageBox.Show("Saved successfully");
            Clear();
            PopulateDataGridView(); 
        }

        private void adminGrid_DoubleClick(object sender, EventArgs e)
        {
            //make sure i
            if(adminGrid.CurrentRow.Index != -1)
            {
                model.id = Convert.ToInt32(adminGrid.CurrentRow.Cells["id"].Value);
                using(dmsEntities db = new dmsEntities())
                {
                    model = db.admins.Where(x => x.id == model.id).FirstOrDefault();
                    surnameTextBox.Text = model.surname;
                    firstnameTextBox.Text = model.firstname;
                    lastnameTextBox.Text = model.lastname;
                    staffIDTextBox.Text = model.staffID;
                    phoneTextBox.Text   = model.phone;
                    emailTextBox.Text   = model.email;
                    passwordBox.Text    = model.password;
                }
                saveAdminButton.Text = "Update";

            }
        }
    }
}
