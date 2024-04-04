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
    public partial class регистрация : Form
    {
        public регистрация()
        {
            InitializeComponent();
            
            Фамилия_textBox1.Text = "Введите фамилию";
            Фамилия_textBox1.ForeColor = Color.Gray;
            Имя_textBox3.Text = "Введите имя";
            Имя_textBox3.ForeColor = Color.Gray;
            Отчество_textBox2.Text = "Введите отчество";
            Отчество_textBox2.ForeColor = Color.Gray;
            Логин_textBox4.Text = "Введите логин";
            Логин_textBox4.ForeColor = Color.Gray;
            Пароль_textBox5.Text = "Введите пароль";
            Пароль_textBox5.ForeColor = Color.Gray;
        }
        public static int n = 0;

        private void Выход_button4_Click(object sender, EventArgs e)
        {
            вход_или_регистрация вход_Или_Регистрация = new вход_или_регистрация();
            Form1.tabControl1.TabPages.RemoveAt(0);
            Form1.tabControl1.Controls.Add(вход_Или_Регистрация.tabControl1.TabPages[0]);
        }

        private void Отменить_регистрацию_button2_Click(object sender, EventArgs e)
        {
            вход_или_регистрация вход_Или_Регистрация = new вход_или_регистрация();
            Form1.tabControl1.TabPages.RemoveAt(0);
            Form1.tabControl1.Controls.Add(вход_Или_Регистрация.tabControl1.TabPages[0]);
        }

        private void Зарегистрироваться_button1_Click(object sender, EventArgs e)
        {
            Form1.Table_Fill("Пользователи", "Select * from users");
            
            
            //string sql = "SELECT new_users.id_new_usera AS \"Код\", " +
            //    "new_users.fam AS \"Фамилия\", new_users.name  AS \"Имя\", new_users.otch AS \"Отчество\", " +
            //    "centr.name AS \"name\", users.name AS \"name\", " +
            //    "new_users.login AS \"Логин\", new_users.parol AS \"Пароль\" " +
            //    "FROM ((new_users inner join centr on centr.id_centra = new_users.id_centra) " +
            //    "left join users on users.id_usera = new_users.id_usera) where new_users.id_centra = centr.id_centra " +
            //    "and users.id_usera = new_users.id_usera GROUP BY new_users.id_new_usera, new_users.fam, new_users.name, " +
            //    "new_users.otch, centr.name, users.name, new_users.login, new_users.parol ORDER BY \"Код\"";

           

            Должность_comboBox2.DataSource = Form1.cdt.Tables["Пользователи"].DefaultView;
            Должность_comboBox2.DisplayMember = "name";
            
            string kod_1 = Form1.cdt.Tables["Пользователи"].DefaultView[Должность_comboBox2.SelectedIndex]["id_usera"].ToString();
            string sql = "INSERT INTO new_users (fam, name, otch, id_usera, login, parol) VALUES ('" + Фамилия_textBox1.Text + "','" + Имя_textBox3.Text + "','" + Отчество_textBox2 + "',"  + kod_1 + ",'" + Логин_textBox4.Text + "','" + Пароль_textBox5.Text + "')";
            if (!Form1.Modification_Execute(sql))
                return;
            //Form1.cdt.Tables["Новые_пользователи"].Rows.Add(new object[] { Фамилия_textBox1.Text, Имя_textBox3.Text, Отчество_textBox2, Центр_comboBox1.Text, Должность_comboBox2.Text, Логин_textBox4.Text, Пароль_textBox5.Text });
            
            
            меню Меню = new меню();
            Form1.tabControl1.TabPages.RemoveAt(0);
            Form1.tabControl1.Controls.Add(Меню.tabControl1.TabPages[0]);
            
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

        private void Логин_textBox4_Enter(object sender, EventArgs e)
        {
            Логин_textBox4.Text = "";
            Логин_textBox4.ForeColor = Color.Black;
        }

        private void Пароль_textBox5_Enter(object sender, EventArgs e)
        {
            Пароль_textBox5.Text = "";
            Пароль_textBox5.ForeColor = Color.Black;
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
                Имя_textBox3.Text = "Введите имя";
                Имя_textBox3.ForeColor = Color.Gray;
            }
        }

        private void Отчество_textBox2_Leave(object sender, EventArgs e)
        {
            if (Отчество_textBox2.Text == "")
            {
                Отчество_textBox2.Text = "Введите отчество";
                Отчество_textBox2.ForeColor = Color.Gray;
            }
        }

        private void Логин_textBox4_Leave(object sender, EventArgs e)
        {
            if (Логин_textBox4.Text == "")
            {
                Логин_textBox4.Text = "Введите логин";
                Логин_textBox4.ForeColor = Color.Gray;
            }
        }

        private void Пароль_textBox5_Leave(object sender, EventArgs e)
        {
            if (Пароль_textBox5.Text == "")
            {
                Пароль_textBox5.Text = "Введите пароль";
                Пароль_textBox5.ForeColor = Color.Gray;
            }
        }

       

        private void регистрация_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            Form1.Table_Fill("Пользователи", "Select * from users");
            
            Должность_comboBox2.DataSource = Form1.cdt.Tables["Пользователи"].DefaultView;
            Должность_comboBox2.DisplayMember = "name";
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            вход_или_регистрация вход_Или_Регистрация = new вход_или_регистрация();
            Form1.tabControl1.TabPages.RemoveAt(0);
            Form1.tabControl1.Controls.Add(вход_Или_Регистрация.tabControl1.TabPages[0]);
        }
    }
}
