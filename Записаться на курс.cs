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
    public partial class Записаться_на_курс : Form
    {
        public Записаться_на_курс()
        {
            InitializeComponent();
            
            
        }

        private void Выход_button4_Click(object sender, EventArgs e)
        {
            
            Form1.tabControl1.TabPages.RemoveAt(0);
            
        }
        public int numRows = 0;
       

        private void Записаться_button1_Click(object sender, EventArgs e)
        {
            string kod_1 = Form1.cdt.Tables["Ученики"].DefaultView[ФИО_comboBox1.SelectedIndex]["Код ученика"].ToString();
            string kod_2 = Form1.cdt.Tables["Курсы"].DefaultView[Курс_comboBox2.SelectedIndex]["Код курса"].ToString();
            string kod_3 = Form1.cdt.Tables["Дни"].DefaultView[Дни_посещений_comboBox3.SelectedIndex]["Код дня"].ToString();
            string kod_4 = Form1.cdt.Tables["Время"].DefaultView[Время_занятий_comboBox4.SelectedIndex]["Код времени"].ToString();
            string sql = "INSERT INTO zapis (id_uch, id_kursi , id_dni , id_vrema ) VALUES (" + kod_1  + "," + kod_2 + "," + kod_3 + "," + kod_4 + ")";
            if (!Form1.Modification_Execute(sql))
                return;

            MessageBox.Show("Вы подали заявку на курс. Ожидайте ответа!");
            меню_админ Меню = new меню_админ();
            Form1.tabControl1.Controls.Add(Меню.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            ФИО_comboBox1.DataSource = Form1.cdt.Tables["Ученики"].DefaultView;
            ФИО_comboBox1.DisplayMember = "ФИО";

            Курс_comboBox2.DataSource = Form1.cdt.Tables["Курсы"].DefaultView;
            Курс_comboBox2.DisplayMember = "Название курса";

            Дни_посещений_comboBox3.DataSource = Form1.cdt.Tables["Дни"].DefaultView;
            Дни_посещений_comboBox3.DisplayMember = "Дни посещений";

            Время_занятий_comboBox4.DataSource = Form1.cdt.Tables["Время"].DefaultView;
            Время_занятий_comboBox4.DisplayMember = "Время занятий";
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Добавить_учащегося добавить_учащегося = new Добавить_учащегося(numRows);

            Form1.tabControl1.Controls.Add(добавить_учащегося.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void Выход_button_Click_1(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
    }
}
