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
    public partial class Добавить_успеваемость : Form
    {
        public Добавить_успеваемость()
        {
            InitializeComponent();
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            ФИО_ученика_comboBox1.DataSource = Form1.cdt.Tables["Ученики"].DefaultView;
            ФИО_ученика_comboBox1.DisplayMember = "ФИО ученика";

            Название_лекции_comboBox2.DataSource = Form1.cdt.Tables["Все текстовые лекции"].DefaultView;
            Название_лекции_comboBox2.DisplayMember = "Название лекции";
        }

        private void Добавить_button2_Click(object sender, EventArgs e)
        {
            string kod_1 = Form1.cdt.Tables["Ученики"].DefaultView[ФИО_ученика_comboBox1.SelectedIndex]["Код ученика"].ToString();
            string kod_2 = Form1.cdt.Tables["Все текстовые лекции"].DefaultView[Название_лекции_comboBox2.SelectedIndex]["Код лекции"].ToString();
            

            string sql = "INSERT INTO uspevaemost (id_uch, id_lek, proideno_lekcii_fl, vsego_lekcii_fl) VALUES (" + kod_1 + "," + kod_2 + "," + Пройдено_лекций_textBox1.Text + "," + Всего_лекций_textBox2.Text + ")";
            if (!Form1.Modification_Execute(sql))
                return;

            MessageBox.Show("Новая запись успешно добавлена!");
            меню_админ Меню = new меню_админ();
            Form1.tabControl1.Controls.Add(Меню.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void Отменить_добавление_button1_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM uspevaemost where proideno_lekcii_fl = " + Пройдено_лекций_textBox1.Text;
            if (!Form1.Modification_Execute(sql))
                return;

            меню_админ Меню = new меню_админ();
            Form1.tabControl1.Controls.Add(Меню.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }
    }
}
