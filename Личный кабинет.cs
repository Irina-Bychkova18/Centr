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
    public partial class Личный_кабинет : Form
    {
        public Личный_кабинет()
        {
            InitializeComponent();
        }

        private void Выход_button4_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
        public static int i = 0;
        public static string n = null;
        public static string a = null;
        public static string b = null;
        private string connString = "Server=localhost;Port=5432;Username = postgres; Password=toor;Database=center;";
        private void ret()
        {
            Город_comboBox3.DataSource = Form1.cdt.Tables["Город"].DefaultView;
            Город_comboBox3.DisplayMember = "Название города";

            Улица_comboBox4.DataSource = Form1.cdt.Tables["Улица"].DefaultView;
            Улица_comboBox4.DisplayMember = "Название улицы";

            Дом_comboBox1.DataSource = Form1.cdt.Tables["Дом"].DefaultView;
            Дом_comboBox1.DisplayMember = "Номер дома";

            Квартира_comboBox2.DataSource = Form1.cdt.Tables["Квартира"].DefaultView;
            Квартира_comboBox2.DisplayMember = "Номер квартиры";

            a = Form1.cdt.Tables["Личный кабинет"].Rows[i]["Код ученика"].ToString();
            int b = int.Parse(a);
            Form1.Table_Fill("Личный кабинет", "SELECT id_uch AS \"Код ученика\", fio AS \"ФИО\","
                              + " data_r AS \"Дата рождения\", telephon_uch AS \"Номер телефона ученика\", gorod.name AS \"Город\", " +
                              "ulica.name AS \"Улица\", dom.nomer AS \"Дом\", kvartira.nomer AS \"Квартира\"," +
                              "telephon_roditela AS \"Номер телефона родителей\", login AS \"Логин\", parol AS \"Пароль\" FROM ((((uchenik inner join gorod on gorod.id_goroda = uchenik.id_g)"
                               + "left join ulica on ulica.id_ulici = uchenik.id_ul) left join dom on dom.id_doma = uchenik.id_d) " +
                               "left join kvartira on kvartira.id_kvartiri = uchenik.id_k) where id_uch = " + a + " and gorod.id_goroda = uchenik.id_g " +
                               "and ulica.id_ulici = uchenik.id_ul and dom.id_doma = uchenik.id_d and kvartira.id_kvartiri = uchenik.id_k GROUP BY id_uch, fio,"
                              + " data_r, telephon_uch, gorod.name, ulica.name, dom.nomer, kvartira.nomer, telephon_roditela, login, parol" + " ORDER BY \"Код ученика\"");
            ФИОtextBox1.Text = Form1.cdt.Tables["Личный кабинет"].Rows[i]["ФИО"].ToString();
            Дата_рождения_dateTimePicker1.Text = Form1.cdt.Tables["Личный кабинет"].Rows[i]["Дата рождения"].ToString();
            Номер_телефона_textBox3.Text = Form1.cdt.Tables["Личный кабинет"].Rows[i]["Номер телефона ученика"].ToString();
            Город_comboBox3.Text = Form1.cdt.Tables["Личный кабинет"].Rows[i]["Город"].ToString();
            Улица_comboBox4.Text = Form1.cdt.Tables["Личный кабинет"].Rows[i]["Улица"].ToString();
            Дом_comboBox1.Text = Form1.cdt.Tables["Личный кабинет"].Rows[i]["Дом"].ToString();
            Квартира_comboBox2.Text = Form1.cdt.Tables["Личный кабинет"].Rows[i]["Квартира"].ToString();
            Телефон_родителей_textBox1.Text = Form1.cdt.Tables["Личный кабинет"].Rows[i]["Номер телефона родителей"].ToString();
            Логин_textBox4.Text = Form1.cdt.Tables["Личный кабинет"].Rows[i]["Логин"].ToString();
            Пароль_textBox5.Text = Form1.cdt.Tables["Личный кабинет"].Rows[i]["Пароль"].ToString();
            
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM uchenik_kursi WHERE id_uch = " + a;

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    

                    int rowCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (rowCount == 0)
                    {
                        Курсы_textBox6.Text = "";
                    }
                    else
                    {
                        Курсы_textBox6.Text = Form1.cdt.Tables["Ученик_Курс"].Rows[i]["Название курса"].ToString();
                    }
                }
            }
            
            
            
        }
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            ret();
        }

        private void Изменить_данные_button1_Click(object sender, EventArgs e)
        {
            string kod_1 = Form1.cdt.Tables["Город"].DefaultView[Город_comboBox3.SelectedIndex]["Код города"].ToString();
            string kod_2 = Form1.cdt.Tables["Улица"].DefaultView[Улица_comboBox4.SelectedIndex]["Код улицы"].ToString();
            string kod_3 = Form1.cdt.Tables["Дом"].DefaultView[Дом_comboBox1.SelectedIndex]["Код дома"].ToString();
            string kod_4 = Form1.cdt.Tables["Квартира"].DefaultView[Квартира_comboBox2.SelectedIndex]["Код квартиры"].ToString();
            
            string sql = "UPDATE uchenik SET fio = '" + ФИОtextBox1.Text + "', data_r = '" + Дата_рождения_dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', telephon_uch = '" + Номер_телефона_textBox3.Text + "', id_g = " + kod_1 + 
                    ", id_ul = " + kod_2 + ", id_d = " + kod_3 + ", id_k = " + kod_4 + ", telephon_roditela = '" + Телефон_родителей_textBox1.Text +
                    "', login = '" + Логин_textBox4.Text + "', parol = '" + Пароль_textBox5.Text + "' WHERE id_uch = " + a;
            if (!Form1.Modification_Execute(sql))
                return;

            MessageBox.Show("Вы изменили данные!");
            ret();

        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void Записаться_button5_Click(object sender, EventArgs e)
        {
            Записаться_на_курс записаться_На_Курс = new Записаться_на_курс();
            Form1.tabControl1.Controls.Add(записаться_На_Курс.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Добавить_улицу f2 = new Добавить_улицу();
            f2.Show();
        }

        private void Завершить_настоящий_курс_button6_Click(object sender, EventArgs e)
        {
            
            string message = "Вы точно хотите завершить курс '" + Курсы_textBox6.Text + "'?";
            string caption = "Завершение курса";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult rezult = MessageBox.Show(message, caption, buttons);
            if (rezult == DialogResult.No) { return; }
            string sql = "Delete from uchenik_kursi where id_uch = " + a;
            if (!Form1.Modification_Execute(sql))
                return;

            MessageBox.Show("Вы завершили текущий курс!");
            ret();

           
        }

        private void Выход_button_Click_1(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
    }
}
