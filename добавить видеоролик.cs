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
    public partial class добавить_видеоролик : Form
    {
        private int rec;
        public добавить_видеоролик(int numRows)
        {
            InitializeComponent();
            rec = numRows + 1;
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void Добавить_видео_button2_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO video (id_vid, name, text) VALUES (" + rec + ",'" + Название_textBox1.Text + "','" + Информация_textBox4.Text + "')";
            if (!Form1.Modification_Execute(sql))
                return;

            MessageBox.Show("Новая запись успешно добавлена!");
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void Отменить_добавление_button1_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM video where name ='" + Название_textBox1.Text + "' and text = '" + Информация_textBox4.Text + "'";
            if (!Form1.Modification_Execute(sql))
                return;

            меню_админ Меню = new меню_админ();
            Form1.tabControl1.Controls.Add(Меню.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void Выход_button_Click_1(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
    }
}
