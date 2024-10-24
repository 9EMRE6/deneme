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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
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

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            // Form2 instance'ını oluşturun
            Hasta hasta = new Hasta();
            hasta.Show();
            this.Hide();
            // Form1 instance'ını gizleyin veya kapatın
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Eğer panel1'in genişliği 50 ise, genişliği 200 yap
            if (panel1.Width == 54)
            {
                panel1.Width = 200; // panel genişliği
            }
            else
            {
                panel1.Width = 54; // panelin kapalı hali
            }
        }
    }
}
