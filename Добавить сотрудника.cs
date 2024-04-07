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
    public partial class Добавить_сотрудника : Form
    {
        public Добавить_сотрудника()
        {
            InitializeComponent();
        }

        private void Добавить_button2_Click(object sender, EventArgs e)
        {
            
            string kod_1 = Form1.cdt.Tables["Возраст"].DefaultView[Возраст_comboBox1.SelectedIndex]["Код возраста"].ToString();
            string kod_2 = Form1.cdt.Tables["Опыт"].DefaultView[Опыт_comboBox2.SelectedIndex]["Код опыта"].ToString();
            string kod_3 = Form1.cdt.Tables["Должности"].DefaultView[Должность_comboBox3.SelectedIndex]["Код должности"].ToString();
            string kod_4 = Form1.cdt.Tables["Курсы"].DefaultView[Ведет_курс_comboBox4.SelectedIndex]["Код курса"].ToString();
            string sql = "INSERT INTO sotrudniki (fio, id_vozr, id_opita, telephon, id_dolj, id_kursi, login, parol ) VALUES ('" + ФИО_textBox1.Text + "'," 
                + kod_1 + "," + kod_2 + ",'" + Телефон_textBox5.Text + "'," + kod_3 + "," + kod_4 + ",'" + Логин_textBox8.Text + "','" + Пароль_textBox7.Text + "')";
            if (!Form1.Modification_Execute(sql))
                return;

            меню_админ Меню = new меню_админ();
            Form1.tabControl1.Controls.Add(Меню.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
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
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void Отменить_добавление_button1_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM sotrudniki where fio = '" + ФИО_textBox1.Text + "'";
            if (!Form1.Modification_Execute(sql))
                return;

            меню_админ Меню = new меню_админ();
            Form1.tabControl1.Controls.Add(Меню.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }
    }
}
