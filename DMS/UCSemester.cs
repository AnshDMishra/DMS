using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS
{
    public partial class UCSemester : MetroFramework.Controls.MetroUserControl
    {
        semester model = new semester();
        
        public UCSemester()
        {
            InitializeComponent();
        }
        dmsEntities _context;
        private void UCSemester_Load(object sender, EventArgs e)
        {
            _context = new dmsEntities();
            _context.semesters.Load();
             //this.semesterBindingSource.DataSource = _context.semesters.Local.ToBindingList();
            using (dmsEntities db = new dmsEntities())
            {
 

                //sessionComboBox.DataSource = db.semesters
                //    .Include(x=>x.session)
                //    .ToList();
                sessionComboBox.DataSource = db.sessions.ToList();
                sessionComboBox.ValueMember = "id";
                sessionComboBox.DisplayMember = "session_name";
            }
            loadgrid();
            PopulateGridView();
        }
        private void loadgrid()
        {

           using (dmsEntities dms = new dmsEntities())
            {
             //var query = dms.semesters.Include(s => s.Session).ToList();
            
            }
           
        }
        void Clear()
        {
            sessionComboBox.SelectedIndex = -1;
            semesterTextBox.Text = "";
            model.id = 0;
            saveSemesterButton.Text = "Save Semester";
        }
        void PopulateGridView()
        {
            using (dmsEntities db = new dmsEntities())
            {
                //var result = db.semesters.Join(db.sessions,
                //    x => x.session_id,
                //    y => y.id,
                //    (x, y) => new { x.session_id, y.session_name }).ToList();

                //semesterGrid.AutoGenerateColumns = false;

                var data = (from sem in db.semesters.ToList()
                            join ses in db.sessions
                            on sem.session_id equals ses.id
                            select new {
                                sem.id,
                                 Session = ses.session_name,
                                 Semester = sem.semester_name }).ToList();

                semesterGrid.DataSource = data; 
                
            }
        }
        private void saveSemesterButton_Click(object sender, EventArgs e)
        {
            model.session_id = (int)sessionComboBox.SelectedValue;
            model.semester_name = semesterTextBox.Text;

            //MessageBox.Show("Selected Item Text: " + sessionComboBox.SelectedValue.ToString() + "\n" +

            //    "Index " + sessionComboBox.SelectedIndex.ToString());
            //return;

            using (dmsEntities db = new dmsEntities())
            {
                if (model.id == 0)//insert
                    db.semesters.Add(model);
                else
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            MessageBox.Show("Saved Successfully");
            PopulateGridView();
        }

        private void semesterGrid_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void semesterGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //foreach(DataGridViewColumn col in semesterGrid.Columns)



            //semester obj = (semester)semesterGrid.CurrentRow.DataBoundItem;
            
            //obj.session_id = 33;
            //if (e.RowIndex > 0 && e.ColumnIndex == 0)
            //{
            //    //semesterGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Hello";
            //    int id = (int)semesterGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            //    var sessionLineItem = (semester)(this.semesterGrid.Rows[e.RowIndex].DataBoundItem);
            //    e.Value = sessionLineItem.session.session_name;
            //}
        }

        private void semesterGrid_DoubleClick_1(object sender, EventArgs e)
        {
            if (semesterGrid.CurrentRow.Index != -1)
            {
                model.id = Convert.ToInt32(semesterGrid.CurrentRow.Cells["id"].Value);
                using (dmsEntities db = new dmsEntities())
                {
                    model = db.semesters.Where(x => x.id == model.id).FirstOrDefault();
                    semesterTextBox.Text = model.semester_name;
                    sessionComboBox.DataSource = db.sessions.ToList();
                    sessionComboBox.SelectedValue = model.session_id;
                }
                saveSemesterButton.Text = "Update Semester";

            }

        }
    }
}
