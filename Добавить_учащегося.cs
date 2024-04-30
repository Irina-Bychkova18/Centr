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
    public partial class Добавить_учащегося : Form
    {
        public Добавить_учащегося()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ФИО_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Пароль_textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
        public void ret()
        {
            Город_comboBox3.DataSource = Form1.cdt.Tables["Город"].DefaultView;
            Город_comboBox3.DisplayMember = "Название города";

            Улица_comboBox4.DataSource = Form1.cdt.Tables["Улица"].DefaultView;
            Улица_comboBox4.DisplayMember = "Название улицы";

            Дом_comboBox1.DataSource = Form1.cdt.Tables["Дом"].DefaultView;
            Дом_comboBox1.DisplayMember = "Номер дома";

            Квартира_comboBox2.DataSource = Form1.cdt.Tables["Квартира"].DefaultView;
            Квартира_comboBox2.DisplayMember = "Номер квартиры";
        }
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            ret();
        }

        private void Отменить_добавление_button1_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM uchenik where fio = '" + ФИО_textBox1.Text + "'";
            if (!Form1.Modification_Execute(sql))
                return;

            меню_админ Меню = new меню_админ();
            Form1.tabControl1.Controls.Add(Меню.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void Добавить_button2_Click(object sender, EventArgs e)
        {
            string kod_1 = Form1.cdt.Tables["Город"].DefaultView[Город_comboBox3.SelectedIndex]["Код города"].ToString();
            string kod_2 = Form1.cdt.Tables["Улица"].DefaultView[Улица_comboBox4.SelectedIndex]["Код улицы"].ToString();
            string kod_3 = Form1.cdt.Tables["Дом"].DefaultView[Дом_comboBox1.SelectedIndex]["Код дома"].ToString();
            string kod_4 = Form1.cdt.Tables["Квартира"].DefaultView[Квартира_comboBox2.SelectedIndex]["Код квартиры"].ToString();
            string sql = "INSERT INTO uchenik (fio, data_r, telephon_uch, id_g, id_ul, id_d, id_k,telephon_roditela, login, parol) VALUES ('" + ФИО_textBox1.Text + "','" + 
                dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + maskedTextBox1.Text + "',"
                + kod_1 + "," + kod_2 + ","  + kod_3 + "," + kod_4 + ",'" + maskedTextBox2.Text + "','" + Логин_textBox8.Text + "','" + Пароль_textBox7.Text + "')";
            if (!Form1.Modification_Execute(sql))
                return;

            MessageBox.Show("Новая запись успешно добавлена!");
            меню_админ Меню = new меню_админ();
            Form1.tabControl1.Controls.Add(Меню.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Добавить_улицу f2 = new Добавить_улицу();
            f2.Show();
            
            ret();
        }
    }
}
