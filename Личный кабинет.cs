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
    public partial class Личный_кабинет : Form
    {
        public Личный_кабинет()
        {
            InitializeComponent();
        }

        private void Выход_button4_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
        public static int i = 0;
        private void tabPage1_Enter(object sender, EventArgs e)
        {

            ФИОtextBox1.Text = Form1.cdt.Tables["Личный кабинет"].Rows[i]["ФИО"].ToString();
            Дата_рождения_dateTimePicker1.Text = Form1.cdt.Tables["Личный кабинет"].Rows[i]["Дата рождения"].ToString();
            Номер_телефона_textBox3.Text = Form1.cdt.Tables["Личный кабинет"].Rows[i]["Телефон"].ToString();
            Логин_textBox4.Text = Form1.cdt.Tables["Личный кабинет"].Rows[i]["Логин"].ToString();
            Пароль_textBox5.Text = Form1.cdt.Tables["Личный кабинет"].Rows[i]["Пароль"].ToString();
            Курсы_textBox6.Text = Form1.cdt.Tables["Ученик_Курс"].Rows[i]["Название курса"].ToString();
        }
    }
}
