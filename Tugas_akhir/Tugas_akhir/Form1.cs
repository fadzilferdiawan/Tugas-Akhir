using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_akhir
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get { return panel4; }
            set { panel4 = value; }
        }
        public Button BackButton
        {
            get { return home; }
            set { home = value; }
        }
        public Button Catalog
        {
            get { return catalog; }
            set { catalog = value; }
        }
        public Panel SidePanel
        {
            get { return sidepanel; }
            set { sidepanel = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidepanel.Height = home.Height;
            sidepanel.Top = home.Top;
            Form1.Instance.PnlContainer.Controls["UserControl1"].BringToFront();
            home.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanel.Height = catalog.Height;
            sidepanel.Top = catalog.Top;
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UserControl2"))
            {
                UserControl2 uc2 = new UserControl2();
                uc2.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(uc2);
            }
            Form1.Instance.PnlContainer.Controls["UserControl2"].BringToFront();
            catalog.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            home.Visible = true;
            _obj = this;

            UserControl1 uc = new UserControl1();
            uc.Dock = DockStyle.Fill;
            panel4.Controls.Add(uc);
        }

    }
}
