using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Complectyuwie
        {
            public int cena;
            public int god_vipyska;
            public string DisplayComplect()
            {
                return ($"Цена: {cena}." + $" Год выпуска: {god_vipyska}.");
            }
            public Complectyuwie(int cn, int gv)
            {
                cena = cn;
                god_vipyska = gv;
            }
        }
        class CP : Complectyuwie
        {
            public int chastota;
            public int colvo_yader;
            public int colvo_potokov;
            public string DisplayCP()
            {
                return ($"Частота: {chastota}." + $" Количество ядер: {colvo_yader}." + $" Количество потоков: {colvo_potokov}.");
            }
            public CP(int cn, int gv, int ch, int cy, int cp) : base(cn, gv)
            {
                chastota = ch;
                colvo_yader = cy;
                colvo_potokov = cp;
            }
        }
        class Videocard : Complectyuwie
        {
            public int chastotaCPU;
            public string proizvoditel;
            public int objem_pamyati;
            public void DisplayVideo()
            {
                MessageBox.Show($"Частота ЦПУ: {chastotaCPU}." + $" Производитель: {proizvoditel}." + $" Объём памяти: {objem_pamyati}.");
            }
            public Videocard(int cn, int gv, int ccpu, string pr, int op) : base(cn, gv)
            {
                chastotaCPU = ccpu;
                proizvoditel = pr;
                objem_pamyati = op;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Complectyuwie cn = new Complectyuwie(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            listBox1.Items.Add(cn.DisplayComplect());
            CP cp = new CP(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
            listBox1.Items.Add(cp.DisplayCP());
        }
    }
}
