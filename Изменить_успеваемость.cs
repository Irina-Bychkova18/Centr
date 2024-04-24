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
    public partial class Изменить_успеваемость : Form
    {
        public Изменить_успеваемость()
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
            ФИО_ученика_comboBox1.DataSource = Form1.cdt.Tables["Ученики"].DefaultView;
            ФИО_ученика_comboBox1.DisplayMember = "ФИО ученика";

            Название_лекции_comboBox2.DataSource = Form1.cdt.Tables["Все текстовые лекции"].DefaultView;
            Название_лекции_comboBox2.DisplayMember = "Название лекции";


            string sql = "SELECT id_usp AS \"Номер записи\", uchenik.fio AS \"ФИО\", lekcii.name AS \"Название лекции\","
                   + " proideno_lekcii_fl AS \"Пройдено лекций\", vsego_lekcii_fl AS \"Всего лекций\",  (proideno_lekcii_fl/vsego_lekcii_fl)*100 AS \"Процент успеваемости\" FROM ((uspevaemost inner join uchenik on uchenik.id_uch = uspevaemost.id_uch)"
                   + "left join lekcii on lekcii.id_lek = uspevaemost.id_lek) where uchenik.id_uch = uspevaemost.id_uch and lekcii.id_lek = uspevaemost.id_lek" +
                   " GROUP BY id_usp, uchenik.fio, lekcii.name, proideno_lekcii_fl, vsego_lekcii_fl ORDER BY \"Номер записи\"";
            Form1.Table_Fill("Успеваемость", sql);

            int i = 0;
            while (Form1.cdt.Tables["Успеваемость"].Rows[i]["Номер записи"].ToString() != n)
                i++;
            ФИО_ученика_comboBox1.Text = Form1.cdt.Tables["Успеваемость"].Rows[i]["ФИО"].ToString();
            Название_лекции_comboBox2.Text = Form1.cdt.Tables["Успеваемость"].Rows[i]["Название лекции"].ToString();
            Пройдено_лекций_textBox1.Text = Form1.cdt.Tables["Успеваемость"].Rows[i]["Пройдено лекций"].ToString();
            Всего_лекций_textBox2.Text = Form1.cdt.Tables["Успеваемость"].Rows[i]["Всего лекций"].ToString();
            


            Form1.cdt.Tables["Успеваемость"].DefaultView.RowFilter = "[Номер записи]=" + n;
        }

        private void Изменить_button2_Click(object sender, EventArgs e)
        {
            string kod_1 = Form1.cdt.Tables["Ученики"].DefaultView[ФИО_ученика_comboBox1.SelectedIndex]["Код ученика"].ToString();
            string kod_2 = Form1.cdt.Tables["Все текстовые лекции"].DefaultView[Название_лекции_comboBox2.SelectedIndex]["Код лекции"].ToString();
       
            
            int i = 0;
            while (Form1.cdt.Tables["Успеваемость"].Rows[i]["Номер записи"].ToString() != n)
                i++;
            string sql;
            if (i < Form1.cdt.Tables["Успеваемость"].Rows.Count)
            {
                i = i + 1;
                sql = "UPDATE uspevaemost SET id_uch = " + kod_1 + ", id_lek = " + kod_2 + ", proideno_lekcii_fl = " + Пройдено_лекций_textBox1.Text +
                    ", vsego_lekcii_fl = " + Всего_лекций_textBox2.Text + " WHERE id_usp = " + i;
                if (!Form1.Modification_Execute(sql))
                    return;
                MessageBox.Show("Запись успешно изменена!");
            }
        }
    }
}
