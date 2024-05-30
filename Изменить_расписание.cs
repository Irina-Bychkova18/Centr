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
    public partial class Изменить_расписание : Form
    {
        public Изменить_расписание()
        {
            InitializeComponent();
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
        public static string n = null;
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            Курс_comboBox1.DataSource = Form1.cdt.Tables["Курсы"].DefaultView;
            Курс_comboBox1.DisplayMember = "Название курса";

            Дни_comboBox2.DataSource = Form1.cdt.Tables["Дни"].DefaultView;
            Дни_comboBox2.DisplayMember = "Дни посещений";

            Время_comboBox3.DataSource = Form1.cdt.Tables["Время"].DefaultView;
            Время_comboBox3.DisplayMember = "Время занятий";

            string sql = "SELECT id_raspisania AS \"Код расписания\", kursi.name AS \"Название курса\","
               + " dni.name AS \"Дни работы\", vrema.name AS \"Время работы\" FROM (((raspisanie inner join kursi on kursi.id_kursi = raspisanie.id_kursi)"
               + "left join dni on dni.id_dni = raspisanie.id_dni) left join vrema on vrema.id_vrema = raspisanie.id_vrema) where kursi.id_kursi = raspisanie.id_kursi and dni.id_dni = raspisanie.id_dni and vrema.id_vrema = raspisanie.id_vrema" +
               " GROUP BY id_raspisania, kursi.name, dni.name, vrema.name ORDER BY \"Код расписания\"";
            Form1.Table_Fill("Одно расписание", sql);

            int i = 0;
            while (Form1.cdt.Tables["Одно расписание"].Rows[i]["Код расписания"].ToString() != n)
                i++;
            Курс_comboBox1.Text = Form1.cdt.Tables["Одно расписание"].Rows[i]["Название курса"].ToString();
            Дни_comboBox2.Text = Form1.cdt.Tables["Одно расписание"].Rows[i]["Дни работы"].ToString();
            Время_comboBox3.Text = Form1.cdt.Tables["Одно расписание"].Rows[i]["Время работы"].ToString();

            
            Form1.cdt.Tables["Одно расписание"].DefaultView.RowFilter = "[Код расписания]=" + n;
        }

        private void Изменить_button2_Click(object sender, EventArgs e)
        {
            string kod_1 = Form1.cdt.Tables["Курсы"].DefaultView[Курс_comboBox1.SelectedIndex]["Код курса"].ToString();
            string kod_2 = Form1.cdt.Tables["Дни"].DefaultView[Дни_comboBox2.SelectedIndex]["Код дня"].ToString();
            string kod_3 = Form1.cdt.Tables["Время"].DefaultView[Время_comboBox3.SelectedIndex]["Код времени"].ToString();
            int i = 0;
            while (Form1.cdt.Tables["Одно расписание"].Rows[i]["Код расписания"].ToString() != n)
                i++;
            string sql;
            if (i < Form1.cdt.Tables["Одно расписание"].Rows.Count)
            {
                i = i + 1;
                sql = "UPDATE raspisanie SET id_kursi = " + kod_1 + ", id_dni = " + kod_2 + ", id_vrema = " + kod_3 + " WHERE id_raspisania = " + i;
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
