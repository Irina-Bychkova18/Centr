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
    public partial class Добавить_расписание : Form
    {
        public Добавить_расписание()
        {
            InitializeComponent();
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            Курс_comboBox1.DataSource = Form1.cdt.Tables["Курсы"].DefaultView;
            Курс_comboBox1.DisplayMember = "Название курса";

            Дни_comboBox2.DataSource = Form1.cdt.Tables["Дни"].DefaultView;
            Дни_comboBox2.DisplayMember = "Дни посещений";

            Время_comboBox3.DataSource = Form1.cdt.Tables["Время"].DefaultView;
            Время_comboBox3.DisplayMember = "Время занятий";

        
        }

        private void Добавить_button2_Click(object sender, EventArgs e)
        {
            string kod_1 = Form1.cdt.Tables["Курсы"].DefaultView[Курс_comboBox1.SelectedIndex]["Код курса"].ToString();
            string kod_2 = Form1.cdt.Tables["Дни"].DefaultView[Дни_comboBox2.SelectedIndex]["Код дня"].ToString();
            string kod_3 = Form1.cdt.Tables["Время"].DefaultView[Время_comboBox3.SelectedIndex]["Код времени"].ToString();
            
            string sql = "INSERT INTO raspisanie (id_kursi, id_dni, id_vrema) VALUES (" +  kod_1 + "," + kod_2 + "," + kod_3 + ")";
            if (!Form1.Modification_Execute(sql))
                return;

            MessageBox.Show("Новая запись успешно добавлена!");
            меню_админ Меню = new меню_админ();
            Form1.tabControl1.Controls.Add(Меню.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void Отменить_добавление_button1_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM raspisanie where id_kursi = '" + Курс_comboBox1.Text + "'";
            if (!Form1.Modification_Execute(sql))
                return;

            меню_админ Меню = new меню_админ();
            Form1.tabControl1.Controls.Add(Меню.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }
    }
}
