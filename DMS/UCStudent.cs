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
    public partial class UCStudent : MetroFramework.Controls.MetroUserControl
    {
        student model = new student();
        int sid = 0;
        public UCStudent()
        {
            InitializeComponent();
        }
        void Clear()
        {
            surnameTextBox.Text = firstnameTextBox.Text = lastnameTextBox.Text = matNumTextBox.Text 
                = DOBDateTime.Text = phoneTextBox.Text = emailTextBox.Text = DOBDateTime.Text = "";
            levelComboBox.SelectedIndex = -1;
            model.id = 0;
            sid = 0;
            saveStudentButton.Text = "Save Student";
        }
        void PopulateDataGridView()
        {
            using(dmsEntities db = new dmsEntities())
            {
                studentGrid.AutoGenerateColumns = false;
                studentGrid.DataSource = db.students.ToList<student>();
            }
        }
        private void UCStudent_Load(object sender, EventArgs e)
        {
            Clear();
            using (dmsEntities db = new dmsEntities())
            {
                studentGrid.DataSource = db.students.ToList();
            }
        }

        private void saveStudentButton_Click(object sender, EventArgs e)
        {
             
            
            DateTime time = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            string dateTimeVariable = time.ToString(format);
            model.surname = surnameTextBox.Text;
            model.firstname = firstnameTextBox.Text;
            model.lastname = lastnameTextBox.Text;
            model.matric_num = matNumTextBox.Text;
            model.phone = phoneTextBox.Text;
            model.email = emailTextBox.Text;
            model.level = (string)levelComboBox.SelectedItem;
            //MessageBox.Show((string)levelComboBox.SelectedItem);
            model.DOB = DOBDateTime.Text;
            model.created_on = dateTimeVariable;
            using (dmsEntities db = new dmsEntities())
            {

                //db.students.Add(model);
                //db.Configuration.AutoDetectChangesEnabled = true;
                //db.SaveChanges();

                if (model.id == 0)//insert
                    db.students.Add(model);
                else
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
              
                db.Configuration.AutoDetectChangesEnabled = true;
                db.SaveChanges();
                sid = model.id;

            }
            MessageBox.Show("Saved successfully","DMS Message");
            if (sid == 0)
            {
                 if (!DMSForm.Instance.MetroContainer.Controls.ContainsKey("UCRequiredDocument"))
                            {
                                UCRequiredDocument uc = new UCRequiredDocument(matNumTextBox.Text);
                                uc.Dock = DockStyle.Fill;
                                DMSForm.Instance.MetroContainer.Controls.Add(uc);
                                Clear();
                            }

                            DMSForm.Instance.MetroContainer.Controls["UCRequiredDocument"].BringToFront();
                            DMSForm.Instance.MetroBack.Visible = true;
                            this.Hide();

            }
            PopulateDataGridView(); 
            Clear();
        }

        private void studentGrid_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show(studentGrid.SelectedCells[0].Value.ToString());
            if (studentGrid.CurrentRow.Index != -1)
            {
                //model.id = Convert.ToInt32(studentGrid.CurrentRow.Cells["id"].Value);
                model.id = Convert.ToInt32((studentGrid.SelectedCells[0].Value));
                using (dmsEntities db = new dmsEntities())
                {
                    model = db.students.Where(x => x.id == model.id).FirstOrDefault();
                    surnameTextBox.Text = model.surname;
                    firstnameTextBox.Text = model.firstname;
                    lastnameTextBox.Text = model.lastname;
                    matNumTextBox.Text = model.matric_num;
                    phoneTextBox.Text = model.phone;
                    emailTextBox.Text = model.email;
                    levelComboBox.SelectedItem = model.level;
                    DOBDateTime.Text = model.DOB;

                    saveStudentButton.Text = "Update Student";
                }

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
