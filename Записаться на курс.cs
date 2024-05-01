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
            ФИО_textBox1.Text = "Введите фамилию, имя и отчество";
            ФИО_textBox1.ForeColor = Color.Gray;
            
        }

        private void Выход_button4_Click(object sender, EventArgs e)
        {
            
            Form1.tabControl1.TabPages.RemoveAt(0);
            
        }

        private void Фамилия_textBox1_Enter(object sender, EventArgs e)
        {
            ФИО_textBox1.Text = "";
            ФИО_textBox1.ForeColor = Color.Black;
        }

       

        private void Фамилия_textBox1_Leave(object sender, EventArgs e)
        {
            if (ФИО_textBox1.Text == "")
            {
                ФИО_textBox1.Text = "Введите фамилию, имя и отчество";
                ФИО_textBox1.ForeColor = Color.Gray;
            }
        }

        

        private void Записаться_button1_Click(object sender, EventArgs e)
        {
            
            string kod_1 = Form1.cdt.Tables["Курсы"].DefaultView[Курс_comboBox2.SelectedIndex]["Код курса"].ToString();
            string kod_2 = Form1.cdt.Tables["Дни"].DefaultView[Дни_посещений_comboBox3.SelectedIndex]["Код дня"].ToString();
            string kod_3 = Form1.cdt.Tables["Время"].DefaultView[Время_занятий_comboBox4.SelectedIndex]["Код времени"].ToString();
            string sql = "INSERT INTO zapis (fio, id_kursi , id_dni , id_vrema ) VALUES ('" + ФИО_textBox1.Text  + "'," + kod_1 + "," + kod_2 + "," + kod_3 + ")";
            if (!Form1.Modification_Execute(sql))
                return;

            меню_админ Меню = new меню_админ();
            Form1.tabControl1.Controls.Add(Меню.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
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
    }
}
