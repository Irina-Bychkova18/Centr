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
                        Form1.Table_Fill("Ученики", "SELECT id_uch AS \"Код ученика\", fio AS \"ФИО\","
              + " data_r AS \"Дата рождения\", telephon_uch AS \"Номер телефона ученика\", gorod.name AS \"Город\", " +
              "ulica.name AS \"Улица\", dom.nomer AS \"Дом\", kvartira.nomer AS \"Квартира\"," +
              "telephon_roditela AS \"Номер телефона родителей\", login AS \"Логин\", parol AS \"Пароль\" FROM ((((uchenik inner join gorod on gorod.id_goroda = uchenik.id_g)"
               + "left join ulica on ulica.id_ulici = uchenik.id_ul) left join dom on dom.id_doma = uchenik.id_d) " +
               "left join kvartira on kvartira.id_kvartiri = uchenik.id_k) where gorod.id_goroda = uchenik.id_g " +
               "and ulica.id_ulici = uchenik.id_ul and dom.id_doma = uchenik.id_d and kvartira.id_kvartiri = uchenik.id_k GROUP BY id_uch, fio,"
              + " data_r, telephon_uch, gorod.name, ulica.name, dom.nomer, kvartira.nomer, telephon_roditela, login, parol" + " ORDER BY \"Код ученика\"");
                        Form1.Table_Fill("Курсы", "SELECT id_kursi AS \"Код курса\", name AS \"Название курса\", kolvo_mest_vsego AS \"Количество мест всего\", mest_ostav AS \"Количество оставшихся мест\", information AS \"Информация о курсе\" FROM kursi" + " ORDER BY \"Код курса\"");
                        Form1.Table_Fill("Возраст", "SELECT id_vozr AS \"Код возраста\", name AS \"Наименование возраста\" FROM vozrast" + " ORDER BY \"Код возраста\"");
                        Form1.Table_Fill("Опыт", "SELECT id_opita AS \"Код опыта\", name AS \"Наименование опыта\" FROM opit" + " ORDER BY \"Код опыта\"");
                        Form1.Table_Fill("Город", "SELECT id_goroda AS \"Код города\", name AS \"Название города\" FROM gorod" + " ORDER BY \"Код города\"");
                        Form1.Table_Fill("Улица", "SELECT id_ulici AS \"Код улицы\", name AS \"Название улицы\" FROM ulica" + " ORDER BY \"Код улицы\"");
                        Form1.Table_Fill("Дом", "SELECT id_doma AS \"Код дома\", nomer AS \"Номер дома\" FROM dom" + " ORDER BY \"Код дома\"");
                        Form1.Table_Fill("Квартира", "SELECT id_kvartiri AS \"Код квартиры\", nomer AS \"Номер квартиры\" FROM kvartira" + " ORDER BY \"Код квартиры\"");
                        Form1.Table_Fill("Должности", "SELECT id_dolj AS \"Код должности\", name AS \"Наименование должности\", id_zarp AS \"Наименование зарплаты\" FROM doljnosti" + " ORDER BY \"Код должности\"");
                        Form1.Table_Fill("Сотрудники", "SELECT id_sot AS \"Код сотрудника\", fio AS \"ФИО\", vozrast.name AS \"Возраст\","
               + " opit.name AS \"Опыт\", telephon AS \"Телефон\", gorod.name AS \"Город\", " +
              "ulica.name AS \"Улица\", dom.nomer AS \"Дом\", kvartira.nomer AS \"Квартира\", doljnosti.name AS \"Должность\", kursi.name AS \"Ведет курсы\", login AS \"Логин\", parol AS \"Пароль\" FROM ((((((((sotrudniki inner join vozrast on vozrast.id_vozr = sotrudniki.id_vozr)"
               + "left join opit on opit.id_opita = sotrudniki.id_opita) left join doljnosti on doljnosti.id_dolj = sotrudniki.id_dolj) " +
               "left join kursi on kursi.id_kursi = sotrudniki.id_kursi) left join gorod on gorod.id_goroda = sotrudniki.id_g) " +
               "left join ulica on ulica.id_ulici = sotrudniki.id_ul) left join dom on dom.id_doma = sotrudniki.id_d) left join kvartira on kvartira.id_kvartiri = sotrudniki.id_k) " +
               "where vozrast.id_vozr = sotrudniki.id_vozr and opit.id_opita = sotrudniki.id_opita and " +
               "doljnosti.id_dolj = sotrudniki.id_dolj and kursi.id_kursi = sotrudniki.id_kursi and  gorod.id_goroda = sotrudniki.id_g and ulica.id_ulici = sotrudniki.id_ul " +
               "and dom.id_doma = sotrudniki.id_d and kvartira.id_kvartiri = sotrudniki.id_k GROUP BY id_sot, fio, vozrast.name,opit.name, telephon, gorod.name, ulica.name, dom.nomer, kvartira.nomer, doljnosti.name, kursi.name, login, parol ORDER BY \"Код сотрудника\"");
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
                    if (Form1.Modification_Execute("Select * from uchenik where login = '" + Логин_textbox.Text + "' and parol = '" + Пароль_textBox.Text + "'"))
                    {
                        Form1.Table_Fill("Личный кабинет", "SELECT id_uch AS \"Код ученика\", fio AS \"ФИО\","
                  + " data_r AS \"Дата рождения\", telephon_uch AS \"Номер телефона ученика\", gorod.name AS \"Город\", " +
                  "ulica.name AS \"Улица\", dom.nomer AS \"Дом\", kvartira.nomer AS \"Квартира\"," +
                  "telephon_roditela AS \"Номер телефона родителей\", login AS \"Логин\", parol AS \"Пароль\" FROM ((((uchenik inner join gorod on gorod.id_goroda = uchenik.id_g)"
                   + "left join ulica on ulica.id_ulici = uchenik.id_ul) left join dom on dom.id_doma = uchenik.id_d) " +
                   "left join kvartira on kvartira.id_kvartiri = uchenik.id_k) where login = '" + Логин_textbox.Text + "' and parol = '" + Пароль_textBox.Text + "' and gorod.id_goroda = uchenik.id_g " +
                   "and ulica.id_ulici = uchenik.id_ul and dom.id_doma = uchenik.id_d and kvartira.id_kvartiri = uchenik.id_k GROUP BY id_uch, fio,"
                  + " data_r, telephon_uch, gorod.name, ulica.name, dom.nomer, kvartira.nomer, telephon_roditela, login, parol" + " ORDER BY \"Код ученика\"");
                        Form1.Table_Fill("Все текстовые лекции", "SELECT id_lek AS \"Код лекции\", name AS \"Название лекции\", text AS \"Текст лекции\" FROM lekcii" + " ORDER BY \"Код лекции\"");
                        Form1.Table_Fill("Ученик_Курс", "SELECT uchenik.fio AS \"ФИО\" , kursi.name AS \"Название курса\", dni.name AS \"Дни работы\", vrema.name AS \"Время работы\", status AS \"Статус\", " +
                            "uchenik.login AS \"Логин\", uchenik.parol AS \"Пароль\" FROM ((((uchenik_kursi inner join uchenik on uchenik_kursi.id_uch = uchenik.id_uch)"
                       + "left join kursi on kursi.id_kursi = uchenik_kursi.id_kursi) left join dni on dni.id_dni = uchenik_kursi.id_dni) left join vrema on vrema.id_vrema = uchenik_kursi.id_vrema)" +
                       " where uchenik_kursi.id_uch = uchenik.id_uch and kursi.id_kursi = uchenik_kursi.id_kursi and dni.id_dni = uchenik_kursi.id_dni and vrema.id_vrema = uchenik_kursi.id_vrema and uchenik.login = '" + Логин_textbox.Text + "' and uchenik.parol = '" + Пароль_textBox.Text + "'" +
                       " GROUP BY uchenik.fio, kursi.name, dni.name, vrema.name, status, uchenik.login, uchenik.parol ORDER BY \"ФИО\"");
                        Form1.Table_Fill("Мои курсы", "SELECT kursi.name AS \"Название курса\", kursi.information AS \"Информация о курсе\", " +
                            "uchenik.login AS \"Логин\", uchenik.parol AS \"Пароль\" FROM ((uchenik_kursi inner join uchenik on uchenik_kursi.id_uch = uchenik.id_uch)"
                       + "left join kursi on kursi.id_kursi = uchenik_kursi.id_kursi) " +
                       " where uchenik_kursi.id_uch = uchenik.id_uch and kursi.id_kursi = uchenik_kursi.id_kursi and uchenik.login = '" + Логин_textbox.Text + "' and uchenik.parol = '" + Пароль_textBox.Text + "'" +
                       " GROUP BY kursi.name, kursi.information, uchenik.login, uchenik.parol ORDER BY \"Название курса\"");
                        меню_учащийся Меню_1 = new меню_учащийся();
                        Form1.tabControl1.TabPages.RemoveAt(0);
                        Form1.tabControl1.Controls.Add(Меню_1.tabControl1.TabPages[0]);
                        Form1.Table_Fill("Курсы", "SELECT id_kursi AS \"Код курса\", name AS \"Название курса\", kolvo_mest_vsego AS \"Количество мест всего\", mest_ostav AS \"Количество оставшихся мест\", information AS \"Информация о курсе\" FROM kursi" + " ORDER BY \"Код курса\"");
                        Form1.Table_Fill("Город", "SELECT id_goroda AS \"Код города\", name AS \"Название города\" FROM gorod" + " ORDER BY \"Код города\"");
                        Form1.Table_Fill("Улица", "SELECT id_ulici AS \"Код улицы\", name AS \"Название улицы\" FROM ulica" + " ORDER BY \"Код улицы\"");
                        Form1.Table_Fill("Дом", "SELECT id_doma AS \"Код дома\", nomer AS \"Номер дома\" FROM dom" + " ORDER BY \"Код дома\"");
                        Form1.Table_Fill("Квартира", "SELECT id_kvartiri AS \"Код квартиры\", nomer AS \"Номер квартиры\" FROM kvartira" + " ORDER BY \"Код квартиры\"");

                        Form1.Table_Fill("Дни", "SELECT id_dni AS \"Код дня\", name AS \"Дни посещений\" FROM dni ORDER BY \"Код дня\"");
                        Form1.Table_Fill("Время", "SELECT id_vrema AS \"Код времени\", name AS \"Время занятий\" FROM vrema ORDER BY \"Код времени\"");
                        Form1.Table_Fill("Пользователи", "SELECT id_usera AS \"Код_пользователя\", name AS \"Название_пользователя\" FROM users ORDER BY \"Код_пользователя\"");
                        
                        Form1.Table_Fill("Успеваемость учащегося", "SELECT id_usp AS \"Номер записи\", uchenik.fio AS \"ФИО\", uchenik.login AS \"Логин\", uchenik.parol AS \"Пароль\", lekcii.name AS \"Название лекции\","
                   + " proideno_lekcii_fl AS \"Пройдено лекций\", vsego_lekcii_fl AS \"Всего лекций\",  (proideno_lekcii_fl/vsego_lekcii_fl)*100 AS \"Процент успеваемости\" FROM ((uspevaemost inner join uchenik on uchenik.id_uch = uspevaemost.id_uch)"
                   + "left join lekcii on lekcii.id_lek = uspevaemost.id_lek) where uchenik.id_uch = uspevaemost.id_uch and lekcii.id_lek = uspevaemost.id_lek and uchenik.login = '" + Логин_textbox.Text + "' and uchenik.parol = '" + Пароль_textBox.Text + "'" +
                   " GROUP BY id_usp, uchenik.fio, uchenik.login, uchenik.parol, lekcii.name, proideno_lekcii_fl, vsego_lekcii_fl ORDER BY \"Номер записи\"");

                        Form1.Table_Fill("Посещаемость учащегося", "SELECT id_pos AS \"Номер\", uchenik.fio AS \"ФИО ученика\", uchenik.login AS \"Логин\", uchenik.parol AS \"Пароль\" FROM (poseshaemost inner join uchenik on uchenik.id_uch = poseshaemost.id_uch)"
               + " where uchenik.id_uch = poseshaemost.id_uch and uchenik.login = '" + Логин_textbox.Text + "' and uchenik.parol = '" + Пароль_textBox.Text + "'" +
               " GROUP BY id_pos, uchenik.fio, uchenik.login, uchenik.parol ORDER BY \"Номер\"");
                        Form1.Table_Fill("Даты учащегося", "SELECT * FROM (poseshaemost inner join uchenik on uchenik.id_uch = poseshaemost.id_uch)"
               + " where uchenik.id_uch = poseshaemost.id_uch and uchenik.login = '" + Логин_textbox.Text + "' and uchenik.parol = '" + Пароль_textBox.Text + "'");
                    }

                    }
                else
                {
                    MessageBox.Show("Неправильный логин! Попробуйте снова.");
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
