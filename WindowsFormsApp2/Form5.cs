using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        //DataAdapter получает данные из источника данных.
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        //BindingSource обеспечивает унифицированный доступ к источнику данных.
        private BindingSource bSource = new BindingSource();
        private DataTable table = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
