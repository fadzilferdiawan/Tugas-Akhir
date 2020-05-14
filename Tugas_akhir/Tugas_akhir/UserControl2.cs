using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Tugas_akhir
{   
    public partial class UserControl2 : UserControl
    {
        float duit, japel, jpaprika, jbrokoli;

        public UserControl2()
        {
            InitializeComponent();
        }

        private void apel_Click(object sender, EventArgs e)
        {
            if (japel != 0)
            {
                duit -= japel;
            }
                float apel;
            apel = float.Parse(this.jmlapel.Text);
            japel = apel * 25000;
            duit += japel;
            this.total.Text = Convert.ToString(duit);
        }

        private void paprika_Click(object sender, EventArgs e)
        {
            if (jpaprika != 0)
            {
                duit -= jpaprika;
            }
            float paprika;
            paprika = float.Parse(this.jmlpaprika.Text);
            jpaprika = paprika * 5000;
            duit += jpaprika;
            this.total.Text = Convert.ToString(duit);
        }

        private void brokoli_click(object sender, EventArgs e)
        {
            if (jbrokoli != 0)
            {
                duit -= jbrokoli;
            }
            float brokoli;
            brokoli = float.Parse(this.jmlbrokoli.Text);
            jbrokoli = brokoli * 12000;
            duit += jbrokoli;
            this.total.Text = Convert.ToString(duit);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (String.IsNullOrEmpty(jmlapel.Text))
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void bayar_click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.bayar.Text))
            {
                this.keterangan.Text = Convert.ToString("Masukkan Jumlah uang yang dibayarkan");
            }
            else
            {
                float bayar, kembali;
                bayar = float.Parse(this.bayar.Text);
                kembali = bayar - duit;
                this.kembali.Text = Convert.ToString(kembali);
                if (kembali < 0)
                {
                    keterangan.Text = Convert.ToString("Maaf Uang Anda Kurang");
                }
                else
                {
                    keterangan.Text = Convert.ToString("Silahkan Berbelanja Kembali");
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (String.IsNullOrEmpty(jmlpaprika.Text))
                button2.Enabled = false;
            else
                button2.Enabled = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            if (String.IsNullOrEmpty(jmlbrokoli.Text))
                button5.Enabled = false;
            else
                button5.Enabled = true;
        }
    }
}
