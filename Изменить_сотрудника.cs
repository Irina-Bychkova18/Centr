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
    public partial class Изменить_сотрудника : Form
    {
        public Изменить_сотрудника()
        {
            InitializeComponent();
        }
        public static string n = null;
        private void Изменить_button2_Click(object sender, EventArgs e)
        {
            string kod_1 = Form1.cdt.Tables["Возраст"].DefaultView[Возраст_comboBox1.SelectedIndex]["Код возраста"].ToString();
            string kod_2 = Form1.cdt.Tables["Опыт"].DefaultView[Опыт_comboBox2.SelectedIndex]["Код опыта"].ToString();
            string kod_3 = Form1.cdt.Tables["Должности"].DefaultView[Должность_comboBox3.SelectedIndex]["Код должности"].ToString();
            string kod_4 = Form1.cdt.Tables["Курсы"].DefaultView[Ведет_курс_comboBox4.SelectedIndex]["Код курса"].ToString();
            int i = 0;
            while (Form1.cdt.Tables["Сотрудники"].Rows[i]["Код сотрудника"].ToString() != n)
                i++;
            string sql;
            if (i < Form1.cdt.Tables["Сотрудники"].Rows.Count)
            {
                i = i + 1;
                sql = "UPDATE sotrudniki SET fio ='" + ФИО_textBox1.Text + "', id_vozr = " + kod_1 + ", id_opita = " + kod_2 +
                    ", telephon ='" + Телефон_textBox5.Text + "', id_dolj =" + kod_3 + ", id_kursi = " + kod_4 + ", login = '" +
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
            Возраст_comboBox1.DataSource = Form1.cdt.Tables["Возраст"].DefaultView;
            Возраст_comboBox1.DisplayMember = "Наименование возраста";

            Опыт_comboBox2.DataSource = Form1.cdt.Tables["Опыт"].DefaultView;
            Опыт_comboBox2.DisplayMember = "Наименование опыта";

            Должность_comboBox3.DataSource = Form1.cdt.Tables["Должности"].DefaultView;
            Должность_comboBox3.DisplayMember = "Наименование должности";

            Ведет_курс_comboBox4.DataSource = Form1.cdt.Tables["Курсы"].DefaultView;
            Ведет_курс_comboBox4.DisplayMember = "Название курса";

            string sql = "SELECT id_sot AS \"Код сотрудника\", fio AS \"ФИО\", vozrast.name AS \"Возраст\","
               + " opit.name AS \"Опыт\", telephon AS \"Телефон\", doljnosti.name AS \"Должность\", kursi.name AS \"Ведет курсы\", login AS \"Логин\", parol AS \"Пароль\" FROM ((((sotrudniki inner join vozrast on vozrast.id_vozr = sotrudniki.id_vozr)"
               + "left join opit on opit.id_opita = sotrudniki.id_opita) left join doljnosti on doljnosti.id_dolj = sotrudniki.id_dolj) " +
               "left join kursi on kursi.id_kursi = sotrudniki.id_kursi) where vozrast.id_vozr = sotrudniki.id_vozr and opit.id_opita = sotrudniki.id_opita and doljnosti.id_dolj = sotrudniki.id_dolj and kursi.id_kursi = sotrudniki.id_kursi" +
               " GROUP BY id_sot, fio, vozrast.name,opit.name, telephon, doljnosti.name, kursi.name, login, parol ORDER BY \"Код сотрудника\"";
            Form1.Table_Fill("Сотрудники", sql);

            int i = 0;
            while (Form1.cdt.Tables["Сотрудники"].Rows[i]["Код сотрудника"].ToString() != n)
                i++;

            ФИО_textBox1.Text = Form1.cdt.Tables["Сотрудники"].Rows[i]["ФИО"].ToString();
            Возраст_comboBox1.Text = Form1.cdt.Tables["Сотрудники"].Rows[i]["Возраст"].ToString();
            Опыт_comboBox2.Text = Form1.cdt.Tables["Сотрудники"].Rows[i]["Опыт"].ToString();
            Телефон_textBox5.Text = Form1.cdt.Tables["Сотрудники"].Rows[i]["Телефон"].ToString();
            Должность_comboBox3.Text = Form1.cdt.Tables["Сотрудники"].Rows[i]["Должность"].ToString();
            Ведет_курс_comboBox4.Text = Form1.cdt.Tables["Сотрудники"].Rows[i]["Ведет курсы"].ToString();
            Логин_textBox8.Text = Form1.cdt.Tables["Сотрудники"].Rows[i]["Логин"].ToString();
            Пароль_textBox7.Text = Form1.cdt.Tables["Сотрудники"].Rows[i]["Пароль"].ToString();

            Form1.cdt.Tables["Сотрудники"].DefaultView.RowFilter = "[Код сотрудника]=" + n;
        }
    }
}
