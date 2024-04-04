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
    public partial class Записаться_на_курс : Form
    {
        public Записаться_на_курс()
        {
            InitializeComponent();
            Фамилия_textBox1.Text = "Введите фамилию";
            Фамилия_textBox1.ForeColor = Color.Gray;
            Имя_textBox3.Text = "Введите имя";
            Имя_textBox3.ForeColor = Color.Gray;
            Отчество_textBox2.Text = "Введите отчество";
            Отчество_textBox2.ForeColor = Color.Gray;
        }

        private void Выход_button4_Click(object sender, EventArgs e)
        {
            
            Form1.tabControl1.TabPages.RemoveAt(0);
            
        }

        private void Фамилия_textBox1_Enter(object sender, EventArgs e)
        {
            Фамилия_textBox1.Text = "";
            Фамилия_textBox1.ForeColor = Color.Black;
        }

        private void Имя_textBox3_Enter(object sender, EventArgs e)
        {
            Имя_textBox3.Text = "";
            Имя_textBox3.ForeColor = Color.Black;
        }

        private void Отчество_textBox2_Enter(object sender, EventArgs e)
        {
            Отчество_textBox2.Text = "";
            Отчество_textBox2.ForeColor = Color.Black;
        }

        private void Фамилия_textBox1_Leave(object sender, EventArgs e)
        {
            if (Фамилия_textBox1.Text == "")
            {
                Фамилия_textBox1.Text = "Введите фамилию";
                Фамилия_textBox1.ForeColor = Color.Gray;
            }
        }

        private void Имя_textBox3_Leave(object sender, EventArgs e)
        {
            if (Имя_textBox3.Text == "")
            {
                Имя_textBox3.Text = "Введите фамилию";
                Имя_textBox3.ForeColor = Color.Gray;
            }
        }

        private void Отчество_textBox2_Leave(object sender, EventArgs e)
        {
            if (Отчество_textBox2.Text == "")
            {
                Отчество_textBox2.Text = "Введите фамилию";
                Отчество_textBox2.ForeColor = Color.Gray;
            }
        }

        private void Записаться_button1_Click(object sender, EventArgs e)
        {
            
            string kod_1 = Form1.cdt.Tables["Курсы"].DefaultView[Курс_comboBox2.SelectedIndex]["Код курса"].ToString();
            string kod_2 = Form1.cdt.Tables["Дни"].DefaultView[Дни_посещений_comboBox3.SelectedIndex]["Код дня"].ToString();
            string kod_3 = Form1.cdt.Tables["Время"].DefaultView[Время_занятий_comboBox4.SelectedIndex]["Код времени"].ToString();
            string sql = "INSERT INTO zapis (familia, imja, otchestvo, id_kursi , id_dni , id_vrema ) VALUES ('" + Фамилия_textBox1.Text + "','" + Имя_textBox3.Text + "','" + Отчество_textBox2.Text + "'," + kod_1 + "," + kod_2 + "," + kod_3 + ")";
            if (!Form1.Modification_Execute(sql))
                return;

            меню Меню = new меню();
            Form1.tabControl1.Controls.Add(Меню.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            Курс_comboBox2.DataSource = Form1.cdt.Tables["Курсы"].DefaultView;
            Курс_comboBox2.DisplayMember = "Название курса";

            Дни_посещений_comboBox3.DataSource = Form1.cdt.Tables["Дни"].DefaultView;
            Дни_посещений_comboBox3.DisplayMember = "Дни посещений";

            Время_занятий_comboBox4.DataSource = Form1.cdt.Tables["Время"].DefaultView;
            Время_занятий_comboBox4.DisplayMember = "Время занятий";
        }
    }
}
