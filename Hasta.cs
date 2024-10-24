using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DİS_KLİNİĞİ_OTOMASYONU
{
    public partial class Hasta : Form
    {
        public Hasta()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Eğer panel1'in genişliği 50 ise, genişliği 200 yap
            if (panel1.Width == 54)
            {
                panel1.Width = 180; // panel genişliği
            }
            else
            {
                panel1.Width = 54; // panelin kapalı hali
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("çıkılsın mı knks", "EMRE Technology", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Formu küçült
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
