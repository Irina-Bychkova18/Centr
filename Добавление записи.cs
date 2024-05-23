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
    public partial class Добавление_записи : Form
    {
        private int rec;
        public Добавление_записи(int numRows)
        {
            InitializeComponent();
            rec = numRows + 1;
        }
        public static string n = null;
        private void Добавить_button1_Click(object sender, EventArgs e)
        {
            string kod_1 = Form1.cdt.Tables["Ученики"].DefaultView[ФИО_comboBox1.SelectedIndex]["Код ученика"].ToString();
            string kod_2 = Form1.cdt.Tables["Курсы"].DefaultView[Курс_comboBox2.SelectedIndex]["Код курса"].ToString();
            string kod_3 = Form1.cdt.Tables["Дни"].DefaultView[Дни_посещений_comboBox3.SelectedIndex]["Код дня"].ToString();
            string kod_4 = Form1.cdt.Tables["Время"].DefaultView[Время_занятий_comboBox4.SelectedIndex]["Код времени"].ToString();

            string sql = "INSERT INTO uchenik_kursi (id_uch, id_kursi, id_dni, id_vrema) VALUES (" + kod_1 + "," + kod_2 + "," + kod_3 + "," + kod_4 + ")";
            if (!Form1.Modification_Execute(sql))
                return;

            MessageBox.Show("Новая запись успешно добавлена!");
            меню_админ Меню = new меню_админ();
            Form1.tabControl1.Controls.Add(Меню.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            ФИО_comboBox1.DataSource = Form1.cdt.Tables["Ученики"].DefaultView;
            ФИО_comboBox1.DisplayMember = "ФИО";

            Курс_comboBox2.DataSource = Form1.cdt.Tables["Курсы"].DefaultView;
            Курс_comboBox2.DisplayMember = "Название курса";

            Дни_посещений_comboBox3.DataSource = Form1.cdt.Tables["Дни"].DefaultView;
            Дни_посещений_comboBox3.DisplayMember = "Дни посещений";

            Время_занятий_comboBox4.DataSource = Form1.cdt.Tables["Время"].DefaultView;
            Время_занятий_comboBox4.DisplayMember = "Время занятий";

            string sql = "SELECT id_zap AS \"Номер записи\", uchenik.fio AS \"ФИО ученика\","
                + " kursi.name AS \"Название курса\","
               + " dni.name AS \"Дни работы\", vrema.name AS \"Время работы\" FROM ((((zapis inner join kursi on kursi.id_kursi = zapis.id_kursi)"
               + "left join dni on dni.id_dni = zapis.id_dni) left join vrema on vrema.id_vrema = zapis.id_vrema) left join uchenik on uchenik.id_uch = zapis.id_uch) where kursi.id_kursi = zapis.id_kursi and dni.id_dni = zapis.id_dni and vrema.id_vrema = zapis.id_vrema and uchenik.id_uch = zapis.id_uch" +
               " GROUP BY id_zap, uchenik.fio, kursi.name, dni.name, vrema.name ORDER BY \"Номер записи\"";
            Form1.Table_Fill("Запись", sql);

            int i = 0;
            while (Form1.cdt.Tables["Запись"].Rows[i]["Номер записи"].ToString() != n)
                i++;
            ФИО_comboBox1.Text = Form1.cdt.Tables["Запись"].Rows[i]["ФИО ученика"].ToString();
            Курс_comboBox2.Text = Form1.cdt.Tables["Запись"].Rows[i]["Название курса"].ToString();
            Дни_посещений_comboBox3.Text = Form1.cdt.Tables["Запись"].Rows[i]["Дни работы"].ToString();
            Время_занятий_comboBox4.Text = Form1.cdt.Tables["Запись"].Rows[i]["Время работы"].ToString();


            Form1.cdt.Tables["Запись"].DefaultView.RowFilter = "[Номер записи]=" + n;
        }
    }
}
