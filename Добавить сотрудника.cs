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
            
            
            string kod_2 = Form1.cdt.Tables["Опыт"].DefaultView[Опыт_comboBox2.SelectedIndex]["Код опыта"].ToString();
            string kod_3 = Form1.cdt.Tables["Должности"].DefaultView[Должность_comboBox3.SelectedIndex]["Код должности"].ToString();
            string kod_4 = Form1.cdt.Tables["Курсы"].DefaultView[Ведет_курс_comboBox4.SelectedIndex]["Код курса"].ToString();
            string kod_5 = Form1.cdt.Tables["Город"].DefaultView[Город_comboBox3.SelectedIndex]["Код города"].ToString();
            string kod_6 = Form1.cdt.Tables["Улица"].DefaultView[Улица_comboBox4.SelectedIndex]["Код улицы"].ToString();
            string kod_7 = Form1.cdt.Tables["Дом"].DefaultView[Дом_comboBox1.SelectedIndex]["Код дома"].ToString();
            string kod_8 = Form1.cdt.Tables["Квартира"].DefaultView[Квартира_comboBox2.SelectedIndex]["Код квартиры"].ToString();
            string sql = "INSERT INTO sotrudniki (fio, data_r, id_opita, telephon, id_g, id_ul, id_d, id_k, id_dolj, id_kursi, login, parol ) VALUES ('" + ФИО_textBox1.Text + "','" 
                + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',"  + kod_2 + ",'" + maskedTextBox1.Text + "'," + kod_5 + "," + kod_6 + "," + kod_7 + "," + kod_8 + "," + kod_3 + "," + kod_4 + ",'" + Логин_textBox8.Text + "','" + Пароль_textBox7.Text + "')";
            if (!Form1.Modification_Execute(sql))
                return;

            MessageBox.Show("Новая запись успешно добавлена!");
            меню_админ Меню = new меню_админ();
            Form1.tabControl1.Controls.Add(Меню.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
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

        private void label10_Click(object sender, EventArgs e)
        {

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
    }
}
