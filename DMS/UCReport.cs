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

namespace DMS
{
    public partial class UCReport : MetroFramework.Controls.MetroUserControl
    {
        documentstore model = new documentstore();
        dmsEntities db = new dmsEntities();
        public string matnum;
        public int std;
        public string address = "";

        public UCReport(string matric)
        {
            this.matnum = matric;
            InitializeComponent();
            loadData();
        }

        private void UCReport_Load(object sender, EventArgs e)
        {
            

                //var query = db.documentstores.Where(y => y.semesterId == std).Select(p => p.document).ToList();
                //var query = from a in db.studentrequirements
                //            where a.student_id == std
                //          //  && a.password == passwordTextBox.Text
                //            select a;
                //var result = query.SingleOrDefault();


            ////var st = (from o in db.records where o.name == nameTextBox.Text select o).First();

            //string pathstring = Path.Combine(result.referece_letter);

            //pictureBox1.Image = Image.FromFile(pathstring);


            ////byte[] ap = Encoding.ASCII.GetBytes(result.document);
            ////MemoryStream ms = new MemoryStream(ap);
            ////pictureBox1.Image = Image.FromStream(ms);
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            //model.student_id = std;
            //db.studentrequirements.Add(model);
            //db.SaveChanges();

        }
        //groupBox1.
        void loadData()
        {
            using (dmsEntities db = new dmsEntities())
            {
                var query = from a in db.students
                            where a.matric_num == matnum
                            select a;
                var student = query.FirstOrDefault();

                //var student = db.students.Where(x => x.matric_num ==matnum).SingleOrDefault();
                if (query.Any())
                {
                    std = student.id;
                    //MessageBox.Show(std.ToString());
                    

                    surnameTextBox.Text = student.surname;
                    firstnameTextBox.Text = student.firstname;
                    lastnameTextBox.Text = student.lastname;
                    phoneTextBox.Text = student.phone;
                    emailTextBox.Text = student.email;
                    matNumTextBox.Text = matnum;
                    levelComboBox.SelectedValue = student.level;
                    DOBDateTime.Text = student.DOB;
                }

            }
        }

        private void reportRequired_Click(object sender, EventArgs e)
        { 
            requiredPanel.Visible = true;
            uploadedPanel.Visible = false;

        }

        private void olevelButton_Click(object sender, EventArgs e)
        {
            Clear();
            int std = db.students.Where(x => x.matric_num == matnum).Select(y => y.id).FirstOrDefault();
            var st = (from o in db.studentrequirements where o.student_id == std select o).FirstOrDefault();
            if (st != null)
            {
                if(st.olevel_result != null)
                {
                                    showingLabel.Text = "O Level Result";
                                    address = st.olevel_result;
                                    string pathstring = Path.Combine(st.olevel_result);

                                    pictureBox1.Image = Image.FromFile(pathstring);
                }
                
            }
            else
            {
                MessageBox.Show("No Document For this student");
            }
          
        }

        private void jambDeButton_Click(object sender, EventArgs e)
        {
            Clear();
            int std = db.students.Where(x => x.matric_num == matnum).Select(y => y.id).FirstOrDefault();
            var st = (from o in db.studentrequirements where o.student_id == std select o).FirstOrDefault();
            if (st != null)
            {
                if (st.jamb_de != null)
                {
                    showingLabel.Text = "Jamb/DE Result";
            string pathstring = Path.Combine(st.jamb_de);
            address = st.jamb_de;
            pictureBox1.Image = Image.FromFile(pathstring);
                }

            }
            else
            {
                MessageBox.Show("No Document For this student");
            }
        }

        private void AffidavitButton_Click(object sender, EventArgs e)
        {
            Clear();

            int std = db.students.Where(x => x.matric_num == matnum).Select(y => y.id).FirstOrDefault();
            var st = (from o in db.studentrequirements where o.student_id == std select o).FirstOrDefault();
            if (st != null)
            {
                if (st.affidavit != null)
                {
                    showingLabel.Text = "Affidavit";
            string pathstring = Path.Combine(st.affidavit);
            address = st.affidavit;
            pictureBox1.Image = Image.FromFile(pathstring);
        }

    }
            else
            {
                MessageBox.Show("No Document For this student");
            }
        }

        private void referenceButton_Click(object sender, EventArgs e)
        {
            Clear();
            int std = db.students.Where(x => x.matric_num == matnum).Select(y => y.id).FirstOrDefault();
            var st = (from o in db.studentrequirements where o.student_id == std select o).FirstOrDefault();
            if (st != null)
            {
                if (st.referece_letter != null)
                {
                    showingLabel.Text = "Reference Letter";
            string pathstring = Path.Combine(st.referece_letter);
            address = st.referece_letter;
            pictureBox1.Image = Image.FromFile(pathstring);
                }

            }
            else
            {
                MessageBox.Show("No Document For this student");
            }

        }

        private void birthButton_Click(object sender, EventArgs e)
        {
            Clear();
            int std = db.students.Where(x => x.matric_num == matnum).Select(y => y.id).FirstOrDefault();
            var st = (from o in db.studentrequirements where o.student_id == std select o).FirstOrDefault();
            if (st != null)
            {
                if (st.birth_certificate != null)
                {
                    showingLabel.Text = "Birth Certificate";
                    string pathstring = Path.Combine(st.birth_certificate);
                    address = st.birth_certificate;
                    pictureBox1.Image = Image.FromFile(pathstring);
                }

            }
            else
            {
                MessageBox.Show("No Document For this student");
            }
        }
        private void metroTile2_Click(object sender, EventArgs e)
        {
            requiredPanel.Visible = false;
            uploadedPanel.Visible = true; 
            uploadedListView.Items.Clear();
           using(dmsEntities dms = new dmsEntities())
            {
                //for (int i = 0; i <= list.Count; i++)
                //    {
                //        imgs.Images.Add(d.id.ToString(), Image.FromFile(d.document));
                //        //     string pathstring = Path.Combine(d.document);
                //        //     img.Images.Add(Image.FromFile(pathstring));

                //        //    uploadedListView.SmallImageList = img;
                //        item.ImageIndex = i;
                //    } 
                var list = dms.documentstores.Where(x => x.studentId == std).ToList();
                //  ImageList imgs = new ImageList();
                //  imgs.ImageSize = new Size(50,50);
                //uploadedListView.SmallImageList = imgs;
                foreach (documentstore d in list)
                {
                    ListViewItem item = new ListViewItem(d.id.ToString()); 

                    item.SubItems.Add(d.docCategory);
                    item.SubItems.Add(d.semester.semester_name);
                    //item.ImageIndex = 1;
                    uploadedListView.Items.Add(item);
                }
                //foreach (documentstore doc in list)
                //{
                //    //ListViewItem item = new ListViewItem(doc.id.ToString());
                //    imgs.Images.Add(doc= 0;
                //    uploadedListView.Items.Add(new ListViewItem(new string[] { doc.docCategory, doc.semester.semester_name }, doc.id.ToString()));

                //    //uploadedListView.Items.Add(item);
                //}
            }

        }

        private void uploadedListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            if (uploadedListView.SelectedItems.Count == 0)
                return;
            ListViewItem item = uploadedListView.SelectedItems[0];

            int id = Convert.ToInt16(item.Text);


            var st = (from o in db.documentstores where o.id == id select o).First();

            showingLabel.Text = st.semester.semester_name;
            string pathstring = Path.Combine(st.document);
            address = st.document;
            pictureBox1.Image = Image.FromFile(pathstring);

            //MessageBox.Show(item.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Zoom zoom = new Zoom(address);
            zoom.ShowDialog();
            //string address = pictureBox1.ImageLocation.ToString();
            //MessageBox.Show(address);
        }

        void Clear()
        {
            pictureBox1.Image = null;
            address = "";
        }

    }
}
