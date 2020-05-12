using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Data.Common;

namespace Tugas_akhir
{
    public partial class UserControl1 : UserControl
    {
            public UserControl1()
            {
                InitializeComponent();
            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {

            }

            private void UserControl1_Load(object sender, EventArgs e)
            {

            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UserControl2"))
            {
                UserControl2 uc2 = new UserControl2();
                uc2.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(uc2);
            }
            Form1.Instance.PnlContainer.Controls["UserControl2"].BringToFront();
            Form1.Instance.BackButton.Visible = true;
            Form1.Instance.SidePanel.Height = Form1.Instance.catalog.Height;
            Form1.Instance.SidePanel.Top = Form1.Instance.catalog.Top;
        }

    }
}
