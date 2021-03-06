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
    public partial class Form4 : Form
    {
        public Form4()
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
            try
            {
                connCenter.connCenter().Open();
                string commandStr = "SELECT idStud AS 'ID', fioStud AS 'ФИО', drStud AS 'Дата рождения' FROM t_datetime";
                MyDA.SelectCommand = new MySqlCommand(commandStr, connCenter.connCenter());
                MyDA.Fill(table);
                bSource.DataSource = table;
                dataGridView1.DataSource = bSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            finally
            {
                MessageBox.Show("Подключение завершено.");
                connCenter.connCenter().Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DateTime dr = new DateTime();
                dr = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                MessageBox.Show(DateTime.Today.Subtract(dr.Date).Days.ToString() + " дней с момента рождения.");
            }
            catch
            {
            }
        }
    }
}
