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
            Возраст_comboBox1.DataSource = Form1.cdt.Tables["Возраст"].DefaultView;
            Возраст_comboBox1.DisplayMember = "Наименование возраста";

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
            ФИОtextBox1.Text = Form1.cdt.Tables["Личный кабинет сотрудника"].Rows[i]["ФИО"].ToString();
            Возраст_comboBox1.Text = Form1.cdt.Tables["Личный кабинет сотрудника"].Rows[i]["Возраст"].ToString();
            Опыт_comboBox2.Text = Form1.cdt.Tables["Личный кабинет сотрудника"].Rows[i]["Опыт"].ToString();
            Город_comboBox3.Text = Form1.cdt.Tables["Личный кабинет сотрудника"].Rows[i]["Город"].ToString();
            Улица_comboBox4.Text = Form1.cdt.Tables["Личный кабинет сотрудника"].Rows[i]["Улица"].ToString();
            Дом_comboBox1.Text = Form1.cdt.Tables["Личный кабинет сотрудника"].Rows[i]["Дом"].ToString();
            Квартира_comboBox2.Text = Form1.cdt.Tables["Личный кабинет сотрудника"].Rows[i]["Квартира"].ToString();
            Телефон_textBox4.Text = Form1.cdt.Tables["Личный кабинет сотрудника"].Rows[i]["Номер телефона"].ToString();
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
            string kod_1 = Form1.cdt.Tables["Возраст"].DefaultView[Возраст_comboBox1.SelectedIndex]["Код возраста"].ToString();
            string kod_2 = Form1.cdt.Tables["Опыт"].DefaultView[Опыт_comboBox2.SelectedIndex]["Код опыта"].ToString();
            string kod_3 = Form1.cdt.Tables["Должности"].DefaultView[Должность_comboBox3.SelectedIndex]["Код должности"].ToString();
            string kod_4 = Form1.cdt.Tables["Курсы"].DefaultView[Курс_comboBox4.SelectedIndex]["Код курса"].ToString();
            string kod_5 = Form1.cdt.Tables["Город"].DefaultView[Город_comboBox3.SelectedIndex]["Код города"].ToString();
            string kod_6 = Form1.cdt.Tables["Улица"].DefaultView[Улица_comboBox4.SelectedIndex]["Код улицы"].ToString();
            string kod_7 = Form1.cdt.Tables["Дом"].DefaultView[Дом_comboBox1.SelectedIndex]["Код дома"].ToString();
            string kod_8 = Form1.cdt.Tables["Квартира"].DefaultView[Квартира_comboBox2.SelectedIndex]["Код квартиры"].ToString();

            string sql = "UPDATE sotrudniki SET fio ='" + ФИОtextBox1.Text + "', id_vozr = " + kod_1 + ", id_opita = " + kod_2 +
                    ", telephon ='" + Телефон_textBox4.Text + "', id_g = " + kod_5 + ", id_ul = " + kod_6 + ", id_d = " + kod_7 + ", id_k = " + kod_8 + ", id_dolj =" + kod_3 + ", id_kursi = " + kod_4 + ", login = '" +
                    Логин_textBox8.Text + "',  parol = '" + Пароль_textBox7.Text + "' WHERE id_sot = " + a;
            if (!Form1.Modification_Execute(sql))
                return;
            
            MessageBox.Show("Ваши данные успешно изменены!");
            ret();
        }


        
    }
}
