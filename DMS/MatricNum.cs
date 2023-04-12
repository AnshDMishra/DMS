using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS
{
    public partial class MatricNum : MetroFramework.Forms.MetroForm
    {
        string page;
        public MatricNum(string page)
        {
            this.page = page;
            InitializeComponent();
        }
        private delegate void EventHandle();
      private  void Confirm()
        {
            
            for(int i =0; i<= 100; i++)
            {
                Thread.Sleep(20);
               
                //confirm
                using (dmsEntities db = new dmsEntities())
                {

                    var query = from a in db.students
                                where a.matric_num == matricNumberBox.Text
                                select a;
                    var result = query.SingleOrDefault();
                    if (query.Any())
                    {

                        if (this.page == "required")
                        {
                            if (!DMSForm.Instance.MetroContainer.Controls.ContainsKey("UCRequiredDocument"))
                            {
                                UCRequiredDocument uc = new UCRequiredDocument(matricNumberBox.Text);
                                uc.Dock = DockStyle.Fill;
                                DMSForm.Instance.MetroContainer.Controls.Add(uc);

                            }

                            DMSForm.Instance.MetroContainer.Controls["UCRequiredDocument"].BringToFront();
                            DMSForm.Instance.MetroBack.Visible = true;
                            this.Hide();
                        }
                        else if (this.page == "report")
                        {
                            if (!DMSForm.Instance.MetroContainer.Controls.ContainsKey("UCReport"))
                            {
                                UCReport uc = new UCReport(matricNumberBox.Text);
                                uc.Dock = DockStyle.Fill;
                                DMSForm.Instance.MetroContainer.Controls.Add(uc);

                            }

                            DMSForm.Instance.MetroContainer.Controls["UCReport"].BringToFront();
                            DMSForm.Instance.MetroBack.Visible = true;
                            this.Hide();
                        }
                        else
                        {
                            if (!DMSForm.Instance.MetroContainer.Controls.ContainsKey("UCDocumentStore"))
                            {
                                UCDocumentStore uc = new UCDocumentStore(matricNumberBox.Text);
                                uc.Dock = DockStyle.Fill;
                                DMSForm.Instance.MetroContainer.Controls.Add(uc);

                            }

                            DMSForm.Instance.MetroContainer.Controls["UCDocumentStore"].BringToFront();
                            DMSForm.Instance.MetroBack.Visible = true;
                            this.Hide();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid Matric Number");
                    }
                }
            }
        }
        private void confirmMatric_Click(object sender, EventArgs e)
        {
            //confirm
            using (dmsEntities db = new dmsEntities())
            {

                var query = from a in db.students
                            where a.matric_num == matricNumberBox.Text
                            select a;
                var result = query.FirstOrDefault();
                if (query.Any())
                {

                    if (this.page == "required")
                    {
                        if (!DMSForm.Instance.MetroContainer.Controls.ContainsKey("UCRequiredDocument"))
                        {
                            UCRequiredDocument uc = new UCRequiredDocument(matricNumberBox.Text);
                            uc.Dock = DockStyle.Fill;
                            DMSForm.Instance.MetroContainer.Controls.Add(uc);

                        }

                        DMSForm.Instance.MetroContainer.Controls["UCRequiredDocument"].BringToFront();
                        DMSForm.Instance.MetroBack.Visible = true;
                        this.Hide();
                    }
                    else if (this.page == "report")
                    {
                        if (!DMSForm.Instance.MetroContainer.Controls.ContainsKey("UCReport"))
                        {
                            UCReport uc = new UCReport(matricNumberBox.Text);
                            uc.Dock = DockStyle.Fill;
                            DMSForm.Instance.MetroContainer.Controls.Add(uc);

                        }

                        DMSForm.Instance.MetroContainer.Controls["UCReport"].BringToFront();
                        DMSForm.Instance.MetroBack.Visible = true;
                        this.Hide();
                    }
                    else
                    {
                        if (!DMSForm.Instance.MetroContainer.Controls.ContainsKey("UCDocumentStore"))
                        {
                            UCDocumentStore uc = new UCDocumentStore(matricNumberBox.Text);
                            uc.Dock = DockStyle.Fill;
                            DMSForm.Instance.MetroContainer.Controls.Add(uc);

                        }

                        DMSForm.Instance.MetroContainer.Controls["UCDocumentStore"].BringToFront();
                        DMSForm.Instance.MetroBack.Visible = true;
                        this.Hide();

                    }

                }
                else
                {
                    MessageBox.Show("Invalid Matric Number");
                }
            }

            //using(var waitForm = new WaitForm(doWork))
            //   {
            //       waitForm.ShowDialog(this);
            //   }

        }
        private void doWork()
        {
            Delegate del = new EventHandle(Confirm);
            this.Invoke(del);

        }
    }
}
