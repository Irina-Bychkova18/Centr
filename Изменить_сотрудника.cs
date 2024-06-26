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
    public partial class Изменить_сотрудника : Form
    {
        public Изменить_сотрудника()
        {
            InitializeComponent();
        }
        public static string n = null;
        private void Изменить_button2_Click(object sender, EventArgs e)
        {
            
            string kod_2 = Form1.cdt.Tables["Опыт"].DefaultView[Опыт_comboBox2.SelectedIndex]["Код опыта"].ToString();
            string kod_3 = Form1.cdt.Tables["Должности"].DefaultView[Должность_comboBox3.SelectedIndex]["Код должности"].ToString();
            string kod_4 = Form1.cdt.Tables["Курсы"].DefaultView[Ведет_курс_comboBox4.SelectedIndex]["Код курса"].ToString();
            string kod_5 = Form1.cdt.Tables["Город"].DefaultView[Город_comboBox3.SelectedIndex]["Код города"].ToString();
            string kod_6 = Form1.cdt.Tables["Улица"].DefaultView[Улица_comboBox4.SelectedIndex]["Код улицы"].ToString();
            string kod_7 = Form1.cdt.Tables["Дом"].DefaultView[Дом_comboBox1.SelectedIndex]["Код дома"].ToString();
            string kod_8 = Form1.cdt.Tables["Квартира"].DefaultView[Квартира_comboBox2.SelectedIndex]["Код квартиры"].ToString();
            int i = 0;
            while (Form1.cdt.Tables["Сотрудник"].Rows[i]["Код сотрудника"].ToString() != n)
                i++;
            string sql;
            if (i < Form1.cdt.Tables["Сотрудник"].Rows.Count)
            {
                i = i + 1;
                sql = "UPDATE sotrudniki SET fio ='" + ФИО_textBox1.Text + "', data_r = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', id_opita = " + kod_2 +
                    ", telephon ='" + maskedTextBox1.Text + "', id_g = " + kod_5 + ", id_ul = " + kod_6 + ", id_d = " + kod_7 + ", id_k = " + kod_8 + ", id_dolj =" + kod_3 + ", id_kursi = " + kod_4 + ", login = '" +
                    Логин_textBox8.Text + "',  parol = '" + Пароль_textBox7.Text + "' WHERE id_sot = " + i;
                if (!Form1.Modification_Execute(sql))
                    return;
                MessageBox.Show("Запись успешно изменена!");
            }
            
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        

        private void tabPage1_Enter(object sender, EventArgs e)
        {

            Опыт_comboBox2.DataSource = Form1.cdt.Tables["Опыт"].DefaultView;
            Опыт_comboBox2.DisplayMember = "Наименование опыта";

            Город_comboBox3.DataSource = Form1.cdt.Tables["Город"].DefaultView;
            Город_comboBox3.DisplayMember = "Название города";

            Улица_comboBox4.DataSource = Form1.cdt.Tables["Улица"].DefaultView;
            Улица_comboBox4.DisplayMember = "Название улицы";

            Дом_comboBox1.DataSource = Form1.cdt.Tables["Дом"].DefaultView;
            Дом_comboBox1.DisplayMember = "Номер дома";

            Квартира_comboBox2.DataSource = Form1.cdt.Tables["Квартира"].DefaultView;
            Квартира_comboBox2.DisplayMember = "Номер квартиры";

            Должность_comboBox3.DataSource = Form1.cdt.Tables["Должности"].DefaultView;
            Должность_comboBox3.DisplayMember = "Наименование должности";

            Ведет_курс_comboBox4.DataSource = Form1.cdt.Tables["Курсы"].DefaultView;
            Ведет_курс_comboBox4.DisplayMember = "Название курса";

            string sql = "SELECT id_sot AS \"Код сотрудника\", fio AS \"ФИО\", data_r AS \"Дата рождения\","
               + " opit.name AS \"Опыт\", telephon AS \"Телефон\", gorod.name AS \"Город\", " +
              "ulica.name AS \"Улица\", dom.nomer AS \"Дом\", kvartira.nomer AS \"Квартира\", doljnosti.name AS \"Должность\", kursi.name AS \"Ведет курсы\", login AS \"Логин\", parol AS \"Пароль\" FROM (((((((sotrudniki inner join opit on opit.id_opita = sotrudniki.id_opita) left join doljnosti on doljnosti.id_dolj = sotrudniki.id_dolj) " +
               "left join kursi on kursi.id_kursi = sotrudniki.id_kursi) left join gorod on gorod.id_goroda = sotrudniki.id_g) " +
               "left join ulica on ulica.id_ulici = sotrudniki.id_ul) left join dom on dom.id_doma = sotrudniki.id_d) left join kvartira on kvartira.id_kvartiri = sotrudniki.id_k) " +
               "where opit.id_opita = sotrudniki.id_opita and " +
               "doljnosti.id_dolj = sotrudniki.id_dolj and kursi.id_kursi = sotrudniki.id_kursi and  gorod.id_goroda = sotrudniki.id_g and ulica.id_ulici = sotrudniki.id_ul " +
               "and dom.id_doma = sotrudniki.id_d and kvartira.id_kvartiri = sotrudniki.id_k GROUP BY id_sot, fio, data_r, opit.name, telephon, gorod.name, ulica.name, dom.nomer, kvartira.nomer, doljnosti.name, kursi.name, login, parol ORDER BY \"Код сотрудника\"";
            ;
            Form1.Table_Fill("Сотрудник", sql);

            int i = 0;
            while (Form1.cdt.Tables["Сотрудник"].Rows[i]["Код сотрудника"].ToString() != n)
                i++;

            ФИО_textBox1.Text = Form1.cdt.Tables["Сотрудник"].Rows[i]["ФИО"].ToString();
            dateTimePicker1.Text = Form1.cdt.Tables["Сотрудник"].Rows[i]["Дата рождения"].ToString();
            Опыт_comboBox2.Text = Form1.cdt.Tables["Сотрудник"].Rows[i]["Опыт"].ToString();
            maskedTextBox1.Text = Form1.cdt.Tables["Сотрудник"].Rows[i]["Телефон"].ToString();
            Город_comboBox3.Text = Form1.cdt.Tables["Сотрудник"].Rows[i]["Город"].ToString();
            Улица_comboBox4.Text = Form1.cdt.Tables["Сотрудник"].Rows[i]["Улица"].ToString();
            Дом_comboBox1.Text = Form1.cdt.Tables["Сотрудник"].Rows[i]["Дом"].ToString();
            Квартира_comboBox2.Text = Form1.cdt.Tables["Сотрудник"].Rows[i]["Квартира"].ToString();
            Должность_comboBox3.Text = Form1.cdt.Tables["Сотрудник"].Rows[i]["Должность"].ToString();
            Ведет_курс_comboBox4.Text = Form1.cdt.Tables["Сотрудник"].Rows[i]["Ведет курсы"].ToString();
            Логин_textBox8.Text = Form1.cdt.Tables["Сотрудник"].Rows[i]["Логин"].ToString();
            Пароль_textBox7.Text = Form1.cdt.Tables["Сотрудник"].Rows[i]["Пароль"].ToString();

            Form1.cdt.Tables["Сотрудник"].DefaultView.RowFilter = "[Код сотрудника]=" + n;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Добавить_улицу f2 = new Добавить_улицу();
            f2.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Добавить_должность f3 = new Добавить_должность();
            f3.Show();
        }

        private void Выход_button_Click_1(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
    }
}
