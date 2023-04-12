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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        dmsEntities db = new dmsEntities();

        private void button2_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //int month = rnd.Next(1, 13);
            //int dice = rnd.Next(1, 7);
            //int card = rnd.Next(52);

            //string final = (card + "" + dice + "" + month).ToString();
            //MessageBox.Show(final);
            if (pictureBox1.Image != null)
            {
            string fname = nameTextBox.Text + ".jpg";
            string folder = "C:\\Users\\BOLADE\\Documents\\Images";
            string pathstring = System.IO.Path.Combine(folder, fname);
                Image a = pictureBox1.Image;
                a.Save(pathstring);

            var st = new record
            {
                name = nameTextBox.Text,
                age = int.Parse(ageTextBox.Text),
                pic = pathstring,
            };
            db.records.Add(st);
            db.SaveChanges();
                LoadData();
            }
            else
            {
                MessageBox.Show("Choose Picture");
            }
        }

        void LoadData()
        {
            var s = from o in db.records select o;
            dataGridView1.DataSource = s.ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;

            if(p != null)
            {
                open.Filter = "(*.jpg;*.jpeg;*.bmp)| *.jpg; *.jpeg; *.bmp; ";
                if(open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                   
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var st = (from o in db.records where o.name == nameTextBox.Text select o).First();
             
            string pathstring = System.IO.Path.Combine(st.pic);

            pictureBox1.Image = Image.FromFile(pathstring);

        }
    }
}
