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

        abstract class Complectyuwie <G>
        {
            public int cena;
            public int god_vipyska;
            G articul;
            public virtual string Display()
            {
                 return($"Цена: {cena}." + $" Год выпуска: {god_vipyska}.");
            }
            public Complectyuwie(int cn, int gv)
            {
                cena = cn;
                god_vipyska = gv;
            }
        }
        class CP <G> : Complectyuwie <G>
        {
            public int chastota { get; set; }
            public int colvo_yader { get; set; }
            public int colvo_potokov { get; set; }
            public override string Display()
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
        class Videocard <G> : Complectyuwie <G>
        {
            public int chastotaCPU { get; set; }
            public string proizvoditel { get; set; }
            public int objem_pamyati { get; set; }
            public override string Display()
            {
                return($"Частота ЦПУ: {chastotaCPU}." + $" Производитель: {proizvoditel}." + $" Объём памяти: {objem_pamyati}.");
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
            CP<int> cp = new CP<int>(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
            listBox1.Items.Add(cp.Display());
        }
         
        private void button2_Click(object sender, EventArgs e)
        {
            Videocard<int> vс = new Videocard<int>(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox6.Text), textBox7.Text, Convert.ToInt32(textBox8.Text));
            listBox1.Items.Add(vс.Display());
        }
    }
}
