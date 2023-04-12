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
    public partial class DMSForm : MetroFramework.Forms.MetroForm
    {
        static DMSForm _instance;
        public static DMSForm Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new DMSForm();
                return _instance;
            }
        }

        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get { return mPanel; }
            set { mPanel = value; }
        }
        public MetroFramework.Controls.MetroLink MetroBack
        {
            get { return mlBack; }
            set { mlBack = value; }
        }
        public DMSForm()
        {
            InitializeComponent(); 
            this.StyleManager = metroStyleManager1;
        }

        private void DMSForm_Load(object sender, EventArgs e)
        {
            StartTimer();
            mlBack.Visible = false;
            _instance = this;
            Dashboard uc = new Dashboard();
            uc.Dock = DockStyle.Fill;
            mPanel.Controls.Add(uc);
            loggedName.Text = Auth.fullname;
           
        }
        System.Windows.Forms.Timer tmr = null;
        public void StartTimer()
        {
            tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = DateTime.Now.ToString();
        }

        void clearHistory()
        {
            DMSForm.Instance.MetroContainer.Controls.Clear();

            Dashboard uc = new Dashboard();
            uc.Dock = DockStyle.Fill;
            mPanel.Controls.Add(uc);
            //if (DMSForm.Instance.MetroContainer.Controls.ContainsKey("UCAdmin"))
            //{
            //    UCAdmin uc = new UCAdmin();
            //    uc.Dock = DockStyle.Fill;
            //    DMSForm.Instance.MetroContainer.Controls.Remove(uc);

            //}
            //if (DMSForm.Instance.MetroContainer.Controls.ContainsKey("UCReport"))
            //{
            //    string g = "";
            //    UCReport uc = new UCReport(g);
            //    uc.Dock = DockStyle.Fill;
            //    DMSForm.Instance.MetroContainer.Controls.Remove(uc);

            //}


        }

        private void mlBack_Click(object sender, EventArgs e)
        {
            mPanel.Controls["Dashboard"].BringToFront();
            mlBack.Visible = false;
            clearHistory();
        }
    }
}
