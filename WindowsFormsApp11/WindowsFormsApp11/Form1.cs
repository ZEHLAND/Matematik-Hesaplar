using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = 25;
            textBox1.Text = sayi.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cevre, alan;
           int kenar;
            kenar = Convert.ToInt32(textBox2.Text);
            alan = kenar * kenar;
            cevre = 4 * kenar;
            textBox3.Text = alan.ToString();
            textBox4.Text = cevre.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam, carpim, bolum,fark;
            sayi1 = Convert.ToInt16(textBox6.Text);
            sayi2 = Convert.ToInt16(textBox7.Text);
            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpim = sayi1 * sayi2;
            bolum = sayi1 / sayi2;
            MessageBox.Show("Toplam = " + toplam + " Fark = " + fark + " Carpım = " + carpim + " Bölüm = " + bolum);
        }

       
    }
}
