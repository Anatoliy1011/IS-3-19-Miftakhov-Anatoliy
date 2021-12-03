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
            ConnCenter connCenter = new ConnCenter();
            if (textBox1.TextLength != 0)
            {
                try
                {
                    connCenter.connCenter().Open();
                    string commandStr = $"INSERT INTO t_PraktStud (fioStud, datetimeStud) VALUES (@fio,@date)";
                    //использование using, смотрел у github.com/sadus174
                    using (MySqlCommand command = new MySqlCommand(commandStr, connCenter.connCenter()))
                    {
                        command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = textBox1.Text;
                        command.Parameters.Add("@date", MySqlDbType.DateTime).Value = dateTimePicker1.Text;
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
                finally
                {
                    MessageBox.Show("Соединение закрыто.");
                    connCenter.connCenter().Close();
                }
            }
            else
            {
                MessageBox.Show("Заполните поле ФИО");
            }
        }
    }
}
