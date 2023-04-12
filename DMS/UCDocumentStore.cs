using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Entity.Validation;

namespace DMS
{
    public partial class UCDocumentStore : MetroFramework.Controls.MetroUserControl
    {
        Image File;
        documentstore model = new documentstore();
        public string matnum;

        public UCDocumentStore(string matric)
        {
            this.matnum = matric;
            InitializeComponent();
        }
        // public string MatNum
        //{
        //    get { return matnum; }
        //    set { matnum = value; }
        //}

        private void UCDocumentStore_Load(object sender, EventArgs e)
        {
            
            matTextBox.Text = matnum;
            using(dmsEntities db = new dmsEntities())
            {
                

                sessionComboBox.DataSource = db.sessions.ToList();
                sessionComboBox.ValueMember = "id";
                sessionComboBox.DisplayMember = "session_name";

                //sessionComboBox.DataSource = db.semesters.ToList();
                //sessionComboBox.ValueMember = "id";
                //sessionComboBox.DisplayMember = "semester_name";
            }
        }

        private void sessionComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selected = (int) sessionComboBox.SelectedValue;

            using(dmsEntities db = new dmsEntities())
            {
                
                var result = from s in db.semesters where s.session_id.Equals(selected)
                             select s;
                semesterComboBox.DataSource = db.semesters.Where(x => x.session_id == selected).ToList();
                semesterComboBox.ValueMember = "id";
                semesterComboBox.DisplayMember = "semester_name";
            }
         //   MessageBox.Show(selected.ToString());
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            //f.Filter = "All Files|*.*|JPEG|*.jpg|*.gif";

            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                docPictureBox.Image = File;
                docPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                docPictureBox.BorderStyle = BorderStyle.Fixed3D;
                //f.SafeFileName.ToString();
            }
        }

        private void docPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox docFile = sender as PictureBox;

            if (docFile != null)
            {
                open.Filter = "(*.jpg;*.jpeg;*.bmp)| *.jpg; *.jpeg; *.bmp; ";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    docFile.Image = Image.FromFile(open.FileName);
                    docFile.BorderStyle = BorderStyle.Fixed3D;
                    docFile.SizeMode = PictureBoxSizeMode.StretchImage;

                }
            }

            //OpenFileDialog f = new OpenFileDialog();
            //f.Filter = "JPG(*.JPG)|*.jpg";
            ////f.Filter = "All Files|*.*|JPEG|*.jpg|*.gif";

            //if (f.ShowDialog() == DialogResult.OK)
            //{
            //    File = Image.FromFile(f.FileName);
            //    docPictureBox.Image = File;
            //    docPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //    docPictureBox.BorderStyle = BorderStyle.Fixed3D;
            //    //f.SafeFileName.ToString();
            //}

        }

        private void saveDocumentButton_Click(object sender, EventArgs e)
        {


            dmsEntities db = new dmsEntities();
            string b = (string)categoryComboBox.SelectedItem;
                string person = matTextBox.Text;
            int std = db.students.Where(x => x.matric_num == person).Select(y => y.id).FirstOrDefault();

            if(docPictureBox != null)
            {
                //string olevelName =  "olevel_.jpg";
                string docName = person + b + "document" + Functions.Generator() + ".jpg";
                //MessageBox.Show(olevelName);
                string docpathstring = Path.Combine(Functions.systemFolder, docName);
                Image ol = docPictureBox.Image;
                ol.Save(docpathstring);



                var st = new documentstore
                {

                    studentId = std,
                    document = (string)docpathstring,
                    docCategory = (string)categoryComboBox.SelectedItem,
                    semesterId = (int)semesterComboBox.SelectedValue,
        };
                db.documentstores.Add(st);

                try
                {
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var eve in ex.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }
                Clear();
                MessageBox.Show("Saved Successfully");

                //MessageBox.Show(b);

                //if (docPictureBox.Image != null)
                //{
                //    MemoryStream ms = new MemoryStream();
                //    docPictureBox.Image.Save(ms, docPictureBox.Image.RawFormat);
                //    byte[] a = ms.GetBuffer();
                //    ms.Close();



                //    using (dmsEntities db = new dmsEntities())
                //    {

                //        

                //    model.studentId = std;
                //        db.documentstores.Add(model);
                //        db.SaveChanges();
                //    }

                //}
            }
            else
            {
                MessageBox.Show("Choose a document to upload");
            }
        }
        void Clear()
        {
            sessionComboBox.SelectedIndex = -1;
            semesterComboBox.SelectedIndex = -1;
            categoryComboBox.Text = "";
            matTextBox.Text = "";
            saveDocumentButton.Text = "Save ";
        }

        private void uploadNewButton_Click(object sender, EventArgs e)
        {
            matTextBox.ReadOnly = false;
            matTextBox.Text = "";
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
