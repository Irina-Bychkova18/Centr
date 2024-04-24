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
    public partial class вход : Form
    {
        private string receivedData;
        public вход(string data)
        {
            InitializeComponent();
            receivedData = data;
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            вход_или_регистрация вход_Или_Регистрация = new вход_или_регистрация(receivedData);
            Form1.tabControl1.TabPages.RemoveAt(0);
            Form1.tabControl1.Controls.Add(вход_Или_Регистрация.tabControl1.TabPages[0]);
        }

        private void Зарегистрироваться_button_Click(object sender, EventArgs e)
        {
            регистрация Регистрация = new регистрация();
            Form1.tabControl1.TabPages.RemoveAt(0);
            Form1.tabControl1.Controls.Add(Регистрация.tabControl1.TabPages[0]);
        }

        private void Войти_button_Click(object sender, EventArgs e)
        {
            //string a = receivedData;
            //Главная главная = new Главная();
            if (receivedData == "Админ")
            {
                if (Логин_textbox.Text == "Admin")
                {
                    if (Пароль_textBox.Text == "Admin")
                    {
                        Form1.Table_Fill("Все текстовые лекции", "SELECT id_lek AS \"Код лекции\", name AS \"Название лекции\", text AS \"Текст лекции\" FROM lekcii" + " ORDER BY \"Код лекции\"");
                        Form1.Table_Fill("Ученики", "SELECT id_uch AS \"Код ученика\", fio AS \"ФИО ученика\", data_r AS \"Дата рождения\", telephon AS \"Номер телефона\", login AS \"Логин\", parol AS \"Пароль\" FROM uchenik" + " ORDER BY \"Код ученика\"");
                        Form1.Table_Fill("Курсы", "SELECT id_kursi AS \"Код курса\", name AS \"Название курса\", kolvo_mest_vsego AS \"Количество мест всего\", mest_ostav AS \"Количество оставшихся мест\", information AS \"Информация о курсе\" FROM kursi" + " ORDER BY \"Код курса\"");
                        Form1.Table_Fill("Возраст", "SELECT id_vozr AS \"Код возраста\", name AS \"Наименование возраста\" FROM vozrast" + " ORDER BY \"Код возраста\"");
                        Form1.Table_Fill("Опыт", "SELECT id_opita AS \"Код опыта\", name AS \"Наименование опыта\" FROM opit" + " ORDER BY \"Код опыта\"");
                        Form1.Table_Fill("Должности", "SELECT id_dolj AS \"Код должности\", name AS \"Наименование должности\", id_zarp AS \"Наименование зарплаты\" FROM doljnosti" + " ORDER BY \"Код должности\"");
                        Form1.Table_Fill("Сотрудники", "SELECT id_sot AS \"Код сотрудника\", fio AS \"ФИО\", vozrast.name AS \"Возраст\","
                   + " opit.name AS \"Опыт\", telephon AS \"Телефон\", doljnosti.name AS \"Должность\", login AS \"Логин\", parol AS \"Пароль\" FROM (((sotrudniki inner join vozrast on vozrast.id_vozr = sotrudniki.id_vozr)"
                   + "left join opit on opit.id_opita = sotrudniki.id_opita) left join doljnosti on doljnosti.id_dolj = sotrudniki.id_dolj) where vozrast.id_vozr = sotrudniki.id_vozr and opit.id_opita = sotrudniki.id_opita and doljnosti.id_dolj = sotrudniki.id_dolj" +
                   " GROUP BY id_sot, fio, vozrast.name,opit.name, telephon, doljnosti.name, login, parol ORDER BY \"Код сотрудника\"");
                        меню_админ Меню = new меню_админ();
                        Form1.tabControl1.TabPages.RemoveAt(0);
                        Form1.tabControl1.Controls.Add(Меню.tabControl1.TabPages[0]);

                        //Form1.Table_Fill("Курсы", "SELECT id_kursi AS \"Код курса\", name AS \"Название курса\",  kolvo_mest_vsego AS \"Количество мест всего\"," +
                        //    " mest_ostav AS \"Количество мест оставшихся\", centr.name AS \"Название центра\", information AS \"Информация о курсе\" FROM kursi left join centr on kursi.id_centra = centr.id_centra ORDER BY \"Код курса\"");
                        Form1.Table_Fill("Дни", "SELECT id_dni AS \"Код дня\", name AS \"Дни посещений\" FROM dni ORDER BY \"Код дня\"");
                        Form1.Table_Fill("Время", "SELECT id_vrema AS \"Код времени\", name AS \"Время занятий\" FROM vrema ORDER BY \"Код времени\"");
                        Form1.Table_Fill("Пользователи", "SELECT id_usera AS \"Код_пользователя\", name AS \"Название_пользователя\" FROM users ORDER BY \"Код_пользователя\"");
                    }
                    else
                    {
                        MessageBox.Show("Неправильный пароль! Попробуйте снова.");
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный логин! Попробуйте снова.");
                }
            }


            if (receivedData == "Сотрудник")
            {
                if (Form1.Modification_Execute("Select * from sotrudniki where login = '" + Логин_textbox.Text + "' and parol = '" + Пароль_textBox.Text + "'"))
                {
                    Form1.Table_Fill("Все текстовые лекции", "SELECT id_lek AS \"Код лекции\", name AS \"Название лекции\", text AS \"Текст лекции\" FROM lekcii" + " ORDER BY \"Код лекции\"");

                    меню_сотрудник Меню_2 = new меню_сотрудник();
                    Form1.tabControl1.TabPages.RemoveAt(0);
                    Form1.tabControl1.Controls.Add(Меню_2.tabControl1.TabPages[0]);

                    Form1.Table_Fill("Дни", "SELECT id_dni AS \"Код дня\", name AS \"Дни посещений\" FROM dni ORDER BY \"Код дня\"");
                    Form1.Table_Fill("Время", "SELECT id_vrema AS \"Код времени\", name AS \"Время занятий\" FROM vrema ORDER BY \"Код времени\"");
                    Form1.Table_Fill("Пользователи", "SELECT id_usera AS \"Код_пользователя\", name AS \"Название_пользователя\" FROM users ORDER BY \"Код_пользователя\"");
                }
            }
            if (receivedData == "Учащийся")
            {
                if (Form1.Modification_Execute("Select * from uchenik where login = '" + Логин_textbox.Text + "' and parol = '" + Пароль_textBox.Text + "'"))
                {
                    Form1.Table_Fill("Личный кабинет", "SELECT id_uch AS \"Код учащегося\", fio AS \"ФИО\", data_r AS \"Дата рождения\", telephon AS \"Телефон\", login AS \"Логин\", parol AS \"Пароль\" FROM uchenik where login = '" + Логин_textbox.Text + "' and parol = '" + Пароль_textBox.Text + "'");
                    Form1.Table_Fill("Все текстовые лекции", "SELECT id_lek AS \"Код лекции\", name AS \"Название лекции\", text AS \"Текст лекции\" FROM lekcii" + " ORDER BY \"Код лекции\"");
                    Form1.Table_Fill("Ученик_Курс", "SELECT uchenik.fio AS \"ФИО\" , kursi.name AS \"Название курса\", dni.name AS \"Дни работы\", vrema.name AS \"Время работы\", " +
                        "uchenik.login AS \"Логин\", uchenik.parol AS \"Пароль\" FROM ((((uchenik_kursi inner join uchenik on uchenik_kursi.id_uch = uchenik.id_uch)"
                   + "left join kursi on kursi.id_kursi = uchenik_kursi.id_kursi) left join dni on dni.id_dni = uchenik_kursi.id_dni) left join vrema on vrema.id_vrema = uchenik_kursi.id_vrema)" +
                   " where uchenik_kursi.id_uch = uchenik.id_uch and kursi.id_kursi = uchenik_kursi.id_kursi and dni.id_dni = uchenik_kursi.id_dni and vrema.id_vrema = uchenik_kursi.id_vrema and uchenik.login = '" + Логин_textbox.Text + "' and uchenik.parol = '" + Пароль_textBox.Text + "'" +
                   " GROUP BY uchenik.fio, kursi.name, dni.name, vrema.name, uchenik.login, uchenik.parol ORDER BY \"ФИО\"");
                    меню_учащийся Меню_1 = new меню_учащийся();
                    Form1.tabControl1.TabPages.RemoveAt(0);
                    Form1.tabControl1.Controls.Add(Меню_1.tabControl1.TabPages[0]);

                    Form1.Table_Fill("Дни", "SELECT id_dni AS \"Код дня\", name AS \"Дни посещений\" FROM dni ORDER BY \"Код дня\"");
                    Form1.Table_Fill("Время", "SELECT id_vrema AS \"Код времени\", name AS \"Время занятий\" FROM vrema ORDER BY \"Код времени\"");
                    Form1.Table_Fill("Пользователи", "SELECT id_usera AS \"Код_пользователя\", name AS \"Название_пользователя\" FROM users ORDER BY \"Код_пользователя\"");
                }

            }
        }

        private void Показать_пароль_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Показать_пароль_checkBox.Checked)
                Пароль_textBox.UseSystemPasswordChar = false;
            else
                Пароль_textBox.UseSystemPasswordChar = true;
        }

        private void вход_Load(object sender, EventArgs e)
        {

        }
    }
}
