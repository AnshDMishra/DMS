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
    public partial class UCRequiredDocument : MetroFramework.Controls.MetroUserControl
    {
        studentrequirement model = new studentrequirement();
        public string matnum;
        public int std;
        //Image ReferenceFile, AffidavitFile, JambDEFile, OlevelFile;
        public UCRequiredDocument(string matric)
        {
            this.matnum = matric;
            InitializeComponent();
        }

        private void UCRequiredDocument_Load(object sender, EventArgs e)
        {
            matTextBox.Text = matnum;

            using(dmsEntities db = new dmsEntities())
            {
                var student = db.students.Where(x => x.matric_num == matTextBox.Text).FirstOrDefault();
                std = student.id;
            }

        }

        private void olevelPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox OlevelFile = sender as PictureBox;

            if (OlevelFile != null)
            {
                open.Filter = "(*.jpg;*.jpeg;*.bmp)| *.jpg; *.jpeg; *.bmp; ";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    OlevelFile.Image = Image.FromFile(open.FileName);

                }
            }

            //OpenFileDialog f = new OpenFileDialog();
            //f.Filter = "JPG(*.JPG)|*.jpg";
            ////f.Filter = "All Files|*.*|JPEG|*.jpg|*.gif";

            //if (f.ShowDialog() == DialogResult.OK)
            //{
            //    OlevelFile = Image.FromFile(f.FileName);
            //    olevelPictureBox.Image = OlevelFile;
            //    olevelPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //    olevelPictureBox.BorderStyle = BorderStyle.Fixed3D;
            //    //f.SafeFileName.ToString();
            //}
        }


        private void jambDEPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox JambDEFile = sender as PictureBox;

            if (JambDEFile != null)
            {
                open.Filter = "(*.jpg;*.jpeg;*.bmp)| *.jpg; *.jpeg; *.bmp; ";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    JambDEFile.Image = Image.FromFile(open.FileName);

                }
            }
            //OpenFileDialog f = new OpenFileDialog();
            //f.Filter = "JPG(*.JPG)|*.jpg";
            ////f.Filter = "All Files|*.*|JPEG|*.jpg|*.gif";

            //if (f.ShowDialog() == DialogResult.OK)
            //{
            //    JambDEFile = Image.FromFile(f.FileName);
            //    jambDEPictureBox.Image = JambDEFile;
            //    jambDEPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //    jambDEPictureBox.BorderStyle = BorderStyle.Fixed3D;
            //    //f.SafeFileName.ToString();
            //}
        }

        private void referencepictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox ReferenceFile = sender as PictureBox;

            if (ReferenceFile != null)
            {
                open.Filter = "(*.jpg;*.jpeg;*.bmp)| *.jpg; *.jpeg; *.bmp; ";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    ReferenceFile.Image = Image.FromFile(open.FileName);

                }
            }
            //    OpenFileDialog f = new OpenFileDialog();
            //    f.Filter = "JPG(*.JPG)|*.jpg";
            //    //f.Filter = "All Files|*.*|JPEG|*.jpg|*.gif";

            //    if (f.ShowDialog() == DialogResult.OK)
            //    {
            //        ReferenceFile = Image.FromFile(f.FileName);
            //        referencepictureBox.Image = ReferenceFile;
            //        referencepictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //        referencepictureBox.BorderStyle = BorderStyle.Fixed3D;
            //        //f.SafeFileName.ToString();
            //    }
            }

            private void affidavitpictureBox_Click(object sender, EventArgs e)
        {

                OpenFileDialog open = new OpenFileDialog();
                PictureBox AffidavitFile = sender as PictureBox;

                if (AffidavitFile != null)
                {
                    open.Filter = "(*.jpg;*.jpeg;*.bmp)| *.jpg; *.jpeg; *.bmp; ";
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                    AffidavitFile.Image = Image.FromFile(open.FileName);

                    }
                }

            //    OpenFileDialog f = new OpenFileDialog();
            //f.Filter = "JPG(*.JPG)|*.jpg";
            ////f.Filter = "All Files|*.*|JPEG|*.jpg|*.gif";

            //if (f.ShowDialog() == DialogResult.OK)
            //{
            //    AffidavitFile = Image.FromFile(f.FileName);
            //    affidavitpictureBox.Image = AffidavitFile;
            //    affidavitpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //    affidavitpictureBox.BorderStyle = BorderStyle.Fixed3D;
            //    //f.SafeFileName.ToString();
            //}
        }

        void Clear()
        {
            olevelComboBox.SelectedIndex = -1;
            jambComboBox.SelectedIndex = -1; 
            matTextBox.Text = "";

            olevelPictureBox.Image.Dispose();
            olevelPictureBox.Image = null;

            jambDEPictureBox.Image.Dispose();
            jambDEPictureBox.Image = null;

            affidavitpictureBox.Image.Dispose();
            affidavitpictureBox.Image = null;
            
            birthPictureBox.Image.Dispose();
            birthPictureBox.Image = null;

            referencepictureBox.Image.Dispose();
            referencepictureBox.Image = null;


        }
   
        private void saveButton_Click(object sender, EventArgs e)
        {
            //dmsEntities db = new dmsEntities();
            string person = matTextBox.Text;

            

            //MessageBox.Show(b);

            string folder = "C:\\Users\\BOLADE\\Pictures\\DMSImages";
            //olevel set up
            if (olevelPictureBox.Image != null)
            {
                //string olevelName =  "olevel_.jpg";
                string olevelName = person + "_olevel_" + Functions.Generator() + ".jpg";
                //MessageBox.Show(olevelName);
                string opathstring = Path.Combine(folder, olevelName);
                Image ol = olevelPictureBox.Image;
                ol.Save(opathstring);


                string jdName = person + "_jambde_" + Functions.Generator() + ".jpg";
                string jdpathstring = Path.Combine(folder, jdName);
                Image jd = jambDEPictureBox.Image;
                jd.Save(jdpathstring);

                string afName = person + "_affidavit_" + Functions.Generator() + ".jpg";
                string afpathstring = Path.Combine(folder, afName);
                Image aff = affidavitpictureBox.Image;

                string btName = person + "_birth_" + Functions.Generator() + ".jpg";
                string btpathstring = Path.Combine(folder, btName);
                Image birth = birthPictureBox.Image;
                birth.Save(btpathstring);

                string refName = person + "_ref_letter_" + Functions.Generator() + ".jpg";
                string refpathstring = Path.Combine(folder, refName);
                Image reff = referencepictureBox.Image;
                reff.Save(refpathstring);

                //int std = db.students.Where(x => x.matric_num == person).Select(y => y.id).FirstOrDefault();

                //studentrequirement old = db.studentrequirements.First(s => s.student_id.Equals(std));
                
                    //    var st = new studentrequirement
                    //{
                    //    student_id = std,
                    //    olevel_type = (string)olevelComboBox.SelectedItem,
                    //   olevel_result = (string)opathstring,
                    //   jamb_type = (string)jambComboBox.SelectedItem,
                    //   jamb_de = (string)jdpathstring,
                    //   affidavit = (string)afpathstring,
                    //   referece_letter = (string)refpathstring,

                    //};
                    //db.studentrequirements.Add(st);

                model.student_id = std;
                model.olevel_type = (string)olevelComboBox.SelectedItem;
                model.olevel_result = (string)opathstring;
                model.jamb_type = (string)jambComboBox.SelectedItem;
                model.jamb_de = (string)jdpathstring;
                model.affidavit = (string)afpathstring;
                model.birth_certificate = (string)btpathstring;
                model.referece_letter = (string)refpathstring;
                
                try
                {

                    using(dmsEntities db = new dmsEntities())
                    {
                        //var query = from a in db.studentrequirements
                        //            where a.student_id == std
                        //            select a;
                        //var result = query.SingleOrDefault();
                        //if (query.Any())
                        //{
                        //    model.id = result.id;
                        //    db.Entry(model).State = System.Data.Entity.EntityState.Detached;
                        //}

                        //if (model.id == 0)//nsert
                            db.studentrequirements.Add(model);
                        //else //update
                        //    db.Entry(model).State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();
                    }
                   
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
             
            }
             
          
             
             
        }

        private void birthPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox BirthFile = sender as PictureBox;

            if (BirthFile != null)
            {
                open.Filter = "(*.jpg;*.jpeg;*.bmp)| *.jpg; *.jpeg; *.bmp; ";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    BirthFile.Image = Image.FromFile(open.FileName);

                }
            }

           
        }
    }
}
