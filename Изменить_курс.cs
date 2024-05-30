using System;
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
    public partial class Изменить_курс : Form
    {
        public Изменить_курс()
        {
            InitializeComponent();
        }
        public static string n = null;
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            string sql = "SELECT id_kursi AS \"Код курса\", name AS \"Название курса\","
               + " kolvo_mest_vsego AS \"Количество мест всего\", mest_ostav AS \"Количество оставшихся мест\", cena AS \"Стоимость курса (4 занятия)\", " +
               "information AS \"Информация о курсе\" FROM kursi" + " ORDER BY \"Код курса\"";
            Form1.Table_Fill("Курс", sql);

            int i = 0;
            while (Form1.cdt.Tables["Курс"].Rows[i]["Код курса"].ToString() != n)
                i++;
            Название_textBox1.Text = Form1.cdt.Tables["Курс"].Rows[i]["Название курса"].ToString();
            Всего_мест_textBox3.Text = Form1.cdt.Tables["Курс"].Rows[i]["Количество мест всего"].ToString();
            Оставшиеся_места_textBox2.Text = Form1.cdt.Tables["Курс"].Rows[i]["Количество оставшихся мест"].ToString();
            Цена_textBox1.Text = Form1.cdt.Tables["Курс"].Rows[i]["Стоимость курса (4 занятия)"].ToString();
            Информация_textBox1.Text = Form1.cdt.Tables["Курс"].Rows[i]["Информация о курсе"].ToString();

            Form1.cdt.Tables["Курс"].DefaultView.RowFilter = "[Код курса]=" + n;
    
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void Изменить_button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (Form1.cdt.Tables["Курс"].Rows[i]["Код курса"].ToString() != n)
                i++;
            string sql;
            if (i < Form1.cdt.Tables["Курс"].Rows.Count)
            {
                i = i + 1;
                sql = "UPDATE kursi SET name ='" + Название_textBox1.Text + "', kolvo_mest_vsego = " + Всего_мест_textBox3.Text + ", mest_ostav = " + Оставшиеся_места_textBox2.Text + ", cena = " + Цена_textBox1.Text + ", information ='" + Информация_textBox1.Text + "' WHERE id_kursi = " + i;
                if (!Form1.Modification_Execute(sql))
                    return;
                MessageBox.Show("Запись успешно изменена!");
            }
        }

        private void Выход_button_Click_1(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
    }
}
