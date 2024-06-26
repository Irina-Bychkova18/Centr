﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centr
{
    public partial class Личный_кабинет_сотрудника : Form
    {
        public Личный_кабинет_сотрудника()
        {
            InitializeComponent();
        }

        public static int i = 0;
        public static string n = null;
        public static string a = null;
        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
        private void ret()
        {
            

            Опыт_comboBox2.DataSource = Form1.cdt.Tables["Опыт"].DefaultView;
            Опыт_comboBox2.DisplayMember = "Наименование опыта";

            Должность_comboBox3.DataSource = Form1.cdt.Tables["Должности"].DefaultView;
            Должность_comboBox3.DisplayMember = "Наименование должности";

            Курс_comboBox4.DataSource = Form1.cdt.Tables["Курсы"].DefaultView;
            Курс_comboBox4.DisplayMember = "Название курса";

            Город_comboBox3.DataSource = Form1.cdt.Tables["Город"].DefaultView;
            Город_comboBox3.DisplayMember = "Название города";

            Улица_comboBox4.DataSource = Form1.cdt.Tables["Улица"].DefaultView;
            Улица_comboBox4.DisplayMember = "Название улицы";

            Дом_comboBox1.DataSource = Form1.cdt.Tables["Дом"].DefaultView;
            Дом_comboBox1.DisplayMember = "Номер дома";

            Квартира_comboBox2.DataSource = Form1.cdt.Tables["Квартира"].DefaultView;
            Квартира_comboBox2.DisplayMember = "Номер квартиры";


            a = Form1.cdt.Tables["Личный кабинет сотрудника"].Rows[i]["Код сотрудника"].ToString();
            Form1.Table_Fill("Личный кабинет сотрудника", "SELECT id_sot AS \"Код сотрудника\", fio AS \"ФИО\","
                          + " data_r AS \"Дата рождения\", opit.name AS \"Опыт\", telephon AS \"Номер телефона\", gorod.name AS \"Город\", " +
                          "ulica.name AS \"Улица\", dom.nomer AS \"Дом\", kvartira.nomer AS \"Квартира\"," +
                          "doljnosti.name AS \"Должность\", kursi.name AS \"Ведет курс\", login AS \"Логин\", parol AS \"Пароль\" FROM (((((((sotrudniki inner join gorod on gorod.id_goroda = sotrudniki.id_g)"
                           + "left join ulica on ulica.id_ulici = sotrudniki.id_ul) left join dom on dom.id_doma = sotrudniki.id_d) " +
                           "left join kvartira on kvartira.id_kvartiri = sotrudniki.id_k) left join opit on opit.id_opita = sotrudniki.id_opita) " +
                           " left join doljnosti on doljnosti.id_dolj = sotrudniki.id_dolj) " +
                           "left join kursi on kursi.id_kursi = sotrudniki.id_kursi) where id_sot = " + a + " and gorod.id_goroda = sotrudniki.id_g " +
                           "and ulica.id_ulici = sotrudniki.id_ul and dom.id_doma = sotrudniki.id_d and kvartira.id_kvartiri = sotrudniki.id_k  and doljnosti.id_dolj = sotrudniki.id_dolj " +
                           " and kursi.id_kursi = sotrudniki.id_kursi and opit.id_opita = sotrudniki.id_opita GROUP BY id_sot, fio,"
                          + "data_r, opit.name, telephon, gorod.name, ulica.name, dom.nomer, kvartira.nomer, doljnosti.name, kursi.name, login, parol" + " ORDER BY \"Код сотрудника\"");
            ФИОtextBox1.Text = Form1.cdt.Tables["Личный кабинет сотрудника"].Rows[i]["ФИО"].ToString();
            dateTimePicker1.Text = Form1.cdt.Tables["Личный кабинет сотрудника"].Rows[i]["Дата рождения"].ToString();
            Опыт_comboBox2.Text = Form1.cdt.Tables["Личный кабинет сотрудника"].Rows[i]["Опыт"].ToString();
            Город_comboBox3.Text = Form1.cdt.Tables["Личный кабинет сотрудника"].Rows[i]["Город"].ToString();
            Улица_comboBox4.Text = Form1.cdt.Tables["Личный кабинет сотрудника"].Rows[i]["Улица"].ToString();
            Дом_comboBox1.Text = Form1.cdt.Tables["Личный кабинет сотрудника"].Rows[i]["Дом"].ToString();
            Квартира_comboBox2.Text = Form1.cdt.Tables["Личный кабинет сотрудника"].Rows[i]["Квартира"].ToString();
            maskedTextBox1.Text = Form1.cdt.Tables["Личный кабинет сотрудника"].Rows[i]["Номер телефона"].ToString();
            Должность_comboBox3.Text = Form1.cdt.Tables["Личный кабинет сотрудника"].Rows[i]["Должность"].ToString();
            Курс_comboBox4.Text = Form1.cdt.Tables["Личный кабинет сотрудника"].Rows[i]["Ведет курс"].ToString();
            Логин_textBox8.Text = Form1.cdt.Tables["Личный кабинет сотрудника"].Rows[i]["Логин"].ToString();
            Пароль_textBox7.Text = Form1.cdt.Tables["Личный кабинет сотрудника"].Rows[i]["Пароль"].ToString();
        }
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            ret();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Добавить_улицу f2 = new Добавить_улицу();
            f2.Show();
        }

        private void Изменить_данные_button1_Click(object sender, EventArgs e)
        {
            
            string kod_2 = Form1.cdt.Tables["Опыт"].DefaultView[Опыт_comboBox2.SelectedIndex]["Код опыта"].ToString();
            string kod_3 = Form1.cdt.Tables["Должности"].DefaultView[Должность_comboBox3.SelectedIndex]["Код должности"].ToString();
            string kod_4 = Form1.cdt.Tables["Курсы"].DefaultView[Курс_comboBox4.SelectedIndex]["Код курса"].ToString();
            string kod_5 = Form1.cdt.Tables["Город"].DefaultView[Город_comboBox3.SelectedIndex]["Код города"].ToString();
            string kod_6 = Form1.cdt.Tables["Улица"].DefaultView[Улица_comboBox4.SelectedIndex]["Код улицы"].ToString();
            string kod_7 = Form1.cdt.Tables["Дом"].DefaultView[Дом_comboBox1.SelectedIndex]["Код дома"].ToString();
            string kod_8 = Form1.cdt.Tables["Квартира"].DefaultView[Квартира_comboBox2.SelectedIndex]["Код квартиры"].ToString();

            string sql = "UPDATE sotrudniki SET fio ='" + ФИОtextBox1.Text + "', data_r = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', id_opita = " + kod_2 +
                    ", telephon ='" + maskedTextBox1.Text + "', id_g = " + kod_5 + ", id_ul = " + kod_6 + ", id_d = " + kod_7 + ", id_k = " + kod_8 + ", id_dolj =" + kod_3 + ", id_kursi = " + kod_4 + ", login = '" +
                    Логин_textBox8.Text + "',  parol = '" + Пароль_textBox7.Text + "' WHERE id_sot = " + a;
            if (!Form1.Modification_Execute(sql))
                return;
            
            MessageBox.Show("Ваши данные успешно изменены!");
            ret();
        }

        private void Выход_button_Click_1(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
    }
}
