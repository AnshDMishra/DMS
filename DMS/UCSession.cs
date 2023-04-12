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
    public partial class UCSession : MetroFramework.Controls.MetroUserControl
    {
        session model = new session();
        public UCSession()
        {
            InitializeComponent();
        }
        void Clear()
        {
            sessionTextBox.Text = "";
            model.id = 0;
            saveSessionButton.Text = "Save Session";
        }
        private void saveSessionButton_Click(object sender, EventArgs e)
        {
            model.session_name = sessionTextBox.Text;
            using(dmsEntities db = new dmsEntities())
            {
                if (model.id == 0)//insert
                    db.sessions.Add(model);
                else
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges(); 
            }
            Clear();
            MessageBox.Show("Saved Successfully");
            PopulateGridView();


        }
        void PopulateGridView()
        {
            using(dmsEntities db = new dmsEntities())
            {
                sessionGrid.AutoGenerateColumns = false;
                sessionGrid.DataSource = db.sessions.ToList<session>();
            }
        }
        private void UCSession_Load(object sender, EventArgs e)
        {
            Clear();
            using (dmsEntities db = new dmsEntities())
            {
                sessionGrid.DataSource = db.sessions.ToList<session>();

            }
        }

        private void sessionGrid_DoubleClick(object sender, EventArgs e)
        {
            if (sessionGrid.CurrentRow.Index != -1)
            {
                model.id = Convert.ToInt32(sessionGrid.CurrentRow.Cells["id"].Value);
                using (dmsEntities db = new dmsEntities())
                {
                    model = db.sessions.Where(x => x.id == model.id).FirstOrDefault();
                    sessionTextBox.Text = model.session_name; 
                }
                saveSessionButton.Text = "Update Session";

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void sessionGrid_DoubleClick_1(object sender, EventArgs e)
        {
            if (sessionGrid.CurrentRow.Index != -1)
            {

                model.id = Convert.ToInt32(sessionGrid.SelectedCells[0].Value);
                using (dmsEntities db = new dmsEntities())
                {
                    model = db.sessions.Where(x => x.id == model.id).FirstOrDefault();
                    sessionTextBox.Text = model.session_name; 
                }
                saveSessionButton.Text = "Update Session";

            }
        }

       
    }
}
