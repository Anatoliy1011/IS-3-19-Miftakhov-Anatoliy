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
    public partial class Form3 : Form
    {
            //DataAdapter получает данные из источника данных.
            private MySqlDataAdapter MyDA = new MySqlDataAdapter();
            //BindingSource обеспечивает унифицированный доступ к источнику данных.
            private BindingSource bSource = new BindingSource();
            private DataTable table = new DataTable();
            public Form3()
            {
                InitializeComponent();
            }
        private void button1_Click(object sender, EventArgs e)
        {
                ConnCenter ConnCenter = new ConnCenter();
                try
                {
                    ConnCenter.connCenter().Open();
                    string commandStr = "SELECT id AS 'ID', fio AS 'ФИО', theme_kurs AS 'Тема' FROM t_stud";
                    MyDA.SelectCommand = new MySqlCommand(commandStr, ConnCenter.connCenter());
                    MyDA.Fill(table);
                    bSource.DataSource = table;
                    dataGridView1.DataSource = bSource;
                }
                catch (Exception xyz)
                {
                    MessageBox.Show($"{xyz}");
                }
                finally
                {
                    MessageBox.Show("Подключение завершено.");
                    ConnCenter.connCenter().Close();
                }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                try
                {
                    MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
                catch
                {
                }
        }
    }
}
