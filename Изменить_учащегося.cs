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
    public partial class Изменить_учащегося : Form
    {
        public Изменить_учащегося()
        {
            InitializeComponent();
        }
        public static string n = null;
        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            Город_comboBox3.DataSource = Form1.cdt.Tables["Город"].DefaultView;
            Город_comboBox3.DisplayMember = "Название города";

            Улица_comboBox4.DataSource = Form1.cdt.Tables["Улица"].DefaultView;
            Улица_comboBox4.DisplayMember = "Название улицы";

            Дом_comboBox1.DataSource = Form1.cdt.Tables["Дом"].DefaultView;
            Дом_comboBox1.DisplayMember = "Номер дома";

            Квартира_comboBox2.DataSource = Form1.cdt.Tables["Квартира"].DefaultView;
            Квартира_comboBox2.DisplayMember = "Номер квартиры";

            string sql = "SELECT id_uch AS \"Код ученика\", fio AS \"ФИО\","
              + " data_r AS \"Дата рождения\", telephon_uch AS \"Номер телефона ученика\", gorod.name AS \"Город\", " +
              "ulica.name AS \"Улица\", dom.nomer AS \"Дом\", kvartira.nomer AS \"Квартира\"," +
              "telephon_roditela AS \"Номер телефона родителей\", login AS \"Логин\", parol AS \"Пароль\" FROM ((((uchenik inner join gorod on gorod.id_goroda = uchenik.id_g)"
               + "left join ulica on ulica.id_ulici = uchenik.id_ul) left join dom on dom.id_doma = uchenik.id_d) " +
               "left join kvartira on kvartira.id_kvartiri = uchenik.id_k) where gorod.id_goroda = uchenik.id_g " +
               "and ulica.id_ulici = uchenik.id_ul and dom.id_doma = uchenik.id_d and kvartira.id_kvartiri = uchenik.id_k GROUP BY id_uch, fio,"
              + " data_r, telephon_uch, gorod.name, ulica.name, dom.nomer, kvartira.nomer, telephon_roditela, login, parol" + " ORDER BY \"Код ученика\"";
            Form1.Table_Fill("Ученик", sql);

            int i = 0;
            while (Form1.cdt.Tables["Ученик"].Rows[i]["Код ученика"].ToString() != n)
                i++;

            ФИО_textBox1.Text = Form1.cdt.Tables["Ученик"].Rows[i]["ФИО"].ToString();
            dateTimePicker1.Text = Form1.cdt.Tables["Ученик"].Rows[i]["Дата рождения"].ToString();
            maskedTextBox1.Text = Form1.cdt.Tables["Ученик"].Rows[i]["Номер телефона ученика"].ToString();
            Город_comboBox3.Text = Form1.cdt.Tables["Ученик"].Rows[i]["Город"].ToString();
            Улица_comboBox4.Text = Form1.cdt.Tables["Ученик"].Rows[i]["Улица"].ToString();
            Дом_comboBox1.Text = Form1.cdt.Tables["Ученик"].Rows[i]["Дом"].ToString();
            Квартира_comboBox2.Text = Form1.cdt.Tables["Ученик"].Rows[i]["Квартира"].ToString();
            maskedTextBox2.Text = Form1.cdt.Tables["Ученик"].Rows[i]["Номер телефона родителей"].ToString();
            Логин_textBox8.Text = Form1.cdt.Tables["Ученик"].Rows[i]["Логин"].ToString();
            Пароль_textBox7.Text = Form1.cdt.Tables["Ученик"].Rows[i]["Пароль"].ToString();

            Form1.cdt.Tables["Ученик"].DefaultView.RowFilter = "[Код ученика]=" + n;
        }

        private void Изменить_button2_Click(object sender, EventArgs e)
        {
            string kod_1 = Form1.cdt.Tables["Город"].DefaultView[Город_comboBox3.SelectedIndex]["Код города"].ToString();
            string kod_2 = Form1.cdt.Tables["Улица"].DefaultView[Улица_comboBox4.SelectedIndex]["Код улицы"].ToString();
            string kod_3 = Form1.cdt.Tables["Дом"].DefaultView[Дом_comboBox1.SelectedIndex]["Код дома"].ToString();
            string kod_4 = Form1.cdt.Tables["Квартира"].DefaultView[Квартира_comboBox2.SelectedIndex]["Код квартиры"].ToString();
            int i = 0;
            while (Form1.cdt.Tables["Ученик"].Rows[i]["Код ученика"].ToString() != n)
                i++;
            string sql;
            if (i < Form1.cdt.Tables["Ученик"].Rows.Count)
            {
                i = i + 1;
                sql = "UPDATE uchenik SET fio ='" + ФИО_textBox1.Text + "', data_r = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', " +
                    "telephon_uch = '" + maskedTextBox1.Text + "', id_g = " + kod_1 + ", id_ul = " + kod_2 + ", id_d = " + kod_3 + ", id_k = " + kod_4 + ", telephon_roditela = '" + maskedTextBox2.Text +
                    "', login = '" + Логин_textBox8.Text + "',  parol = '" + Пароль_textBox7.Text + "' WHERE id_uch = " + i;
                if (!Form1.Modification_Execute(sql))
                    return;
                MessageBox.Show("Запись успешно изменена!");

              
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Добавить_улицу f2 = new Добавить_улицу();
            f2.Show();
        }

        private void Выход_button_Click_1(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
    }
}
