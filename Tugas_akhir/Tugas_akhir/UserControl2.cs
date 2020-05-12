using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_akhir
{   
    public partial class UserControl2 : UserControl
    {
        float duit = 0;
        public UserControl2()
        {
            InitializeComponent();
        }

        private void apel_Click(object sender, EventArgs e)
        {
            float apel, japel;
            apel = float.Parse(this.jmlapel.Text);
            japel = apel * 25000;
            duit += japel;
            this.total.Text = Convert.ToString(duit);
        }

        private void paprika_Click(object sender, EventArgs e)
        {
            float paprika, jpaprika;
            paprika = float.Parse(this.jmlpaprika.Text);
            jpaprika = paprika * 5000;
            duit += jpaprika;
            this.total.Text = Convert.ToString(duit);
        }

        private void brokoli_click(object sender, EventArgs e)
        {
            float brokoli, jbrokoli;
            brokoli = float.Parse(this.jmlbrokoli.Text);
            jbrokoli = brokoli * 12000;
            duit += jbrokoli;
            this.total.Text = Convert.ToString(duit);
        }

        private void bayar_click(object sender, EventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
