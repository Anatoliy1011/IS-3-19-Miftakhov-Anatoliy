﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
    public class ConnCenter
    {
        public MySqlConnection connCenter()
        {
            string host = "caseum.ru";
            string port = "33333";
            string user = "test_user";
            string db = "db_test";
            string password = "test_pass";
            string connStr = $"server={host};port={port};user={user};database={db};password={password};";
            MySqlConnection conn = new MySqlConnection(connStr);
            return conn;
        }
    }
}
