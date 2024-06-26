﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Centr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Username=postgres;" +
            "Password=toor;Database=center;");
        public static DataSet cdt = new DataSet();
        public static TabControl tabControl1 = new TabControl();
        public static void Table_Fill(string name, string sql)
        {
            if (cdt.Tables[name] != null)
                cdt.Tables[name].Clear();
            NpgsqlDataAdapter dat;
            dat = new NpgsqlDataAdapter(sql, connection);
            dat.Fill(cdt, name);
            connection.Close();
        }
        public static bool Modification_Execute(string sql)
        {
            NpgsqlCommand com;
            com = new NpgsqlCommand(sql, connection);
            connection.Open();
            try
            {
                com.ExecuteNonQuery();

            }
            catch (NpgsqlException)
            {
                MessageBox.Show("Обновление базы данных не было выполнено либо из-за некорректно указанных" + " обновляемых данных либо отсутствующих, но при этом обязательных!!!", "Ошибка");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Size = new Size(1027, 702);
            this.Controls.Add(tabControl1);
            Главная главная = new Главная();
            tabControl1.Controls.Add(главная.tabControl1.TabPages[0]);

        }
    }
}
