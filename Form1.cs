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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi, şifre;
            kullaniciadi=textBox1.Text;
            şifre=textBox2.Text;
            if (kullaniciadi == "1" && şifre == "1")
            {
                MessageBox.Show("Giriş Başarılı","EMRE TEKNOLOJİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Form2 instance'ını oluşturun
        Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                this.Hide();
                // Form1 instance'ını gizleyin veya kapatın
                

                
            }
            else {
                MessageBox.Show("Giriş Başarısız");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("çıkılsın mı knks", "EMRE TEKNOLOJİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Formu küçült
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
