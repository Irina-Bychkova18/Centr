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
    public partial class Сотрудники : Form
    {
        public Сотрудники()
        {
            InitializeComponent();
        }
        public int numRows;
        private void Выход_button4_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
        public static int n = 0;
        private void FieldsForms()
        {
            ФИОtextBox1.Text = Form1.cdt.Tables["Сотрудники"].Rows[n]["ФИО"].ToString();
            Должность_comboBox1.Text = Form1.cdt.Tables["Сотрудники"].Rows[n]["Должность"].ToString();
            Ведет_курсы_textBox2.Text = Form1.cdt.Tables["Сотрудники"].Rows[n]["Ведет курсы"].ToString();
        }
        private void FieldsForm_Clear()
        {
            ФИОtextBox1.Text = "";
            Должность_comboBox1.Text = "";
            Ведет_курсы_textBox2.Text = "";
        }
        private void Удалить_button3_Click(object sender, EventArgs e)
        {
            string kod;
            try
            {
                kod = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Код сотрудника"].Value.ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Не указан удаляемый экземпляр!!!", "Ошибка"); return;
            }
            string message = "Вы точно хотите удалить запись № " + kod + "?";
            string caption = "Удаление записи";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult rezult = MessageBox.Show(message, caption, buttons);
            if (rezult == DialogResult.No) { return; }
            string sql = "DELETE FROM sotrudniki WHERE id_sot = " + kod;
            Form1.Modification_Execute(sql);
            for (int i = Form1.cdt.Tables["Сотрудники"].Rows.Count - 1; i >= 0; i--)
                if (Form1.cdt.Tables["Сотрудники"].Rows[i]["Код сотрудника"].ToString() == kod)
                {
                    Form1.cdt.Tables["Сотрудники"].Rows.RemoveAt(i);
                    dataGridView1.CurrentCell = null;
                    return;
                }
        }
        public void ret()
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14);
            string sql = "SELECT id_sot AS \"Код сотрудника\", fio AS \"ФИО\", data_r AS \"Дата рождения\","
               + " opit.name AS \"Опыт\", telephon AS \"Телефон\", gorod.name AS \"Город\", " +
              "ulica.name AS \"Улица\", dom.nomer AS \"Дом\", kvartira.nomer AS \"Квартира\", doljnosti.name AS \"Должность\", kursi.name AS \"Ведет курсы\", login AS \"Логин\", parol AS \"Пароль\" FROM (((((((sotrudniki inner join opit on opit.id_opita = sotrudniki.id_opita) left join doljnosti on doljnosti.id_dolj = sotrudniki.id_dolj) " +
               "left join kursi on kursi.id_kursi = sotrudniki.id_kursi) left join gorod on gorod.id_goroda = sotrudniki.id_g) " +
               "left join ulica on ulica.id_ulici = sotrudniki.id_ul) left join dom on dom.id_doma = sotrudniki.id_d) left join kvartira on kvartira.id_kvartiri = sotrudniki.id_k) " +
               "where opit.id_opita = sotrudniki.id_opita and " +
               "doljnosti.id_dolj = sotrudniki.id_dolj and kursi.id_kursi = sotrudniki.id_kursi and  gorod.id_goroda = sotrudniki.id_g and ulica.id_ulici = sotrudniki.id_ul " +
               "and dom.id_doma = sotrudniki.id_d and kvartira.id_kvartiri = sotrudniki.id_k GROUP BY id_sot, fio, data_r, opit.name, telephon, gorod.name, ulica.name, dom.nomer, kvartira.nomer, doljnosti.name, kursi.name, login, parol ORDER BY \"Код сотрудника\"";
            Form1.Table_Fill("Сотрудники", sql);

            Должность_comboBox1.DataSource = Form1.cdt.Tables["Сотрудники"].DefaultView;
            Должность_comboBox1.DisplayMember = "Должность";

            

            if (Form1.cdt.Tables["Сотрудники"].Rows.Count > n)
            {
                FieldsForms();

            }
            dataGridView1.DataSource = Form1.cdt.Tables["Сотрудники"];
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
            dataGridView1.Columns["ФИО"].Visible = false;
            dataGridView1.Columns["Должность"].Visible = false;
        }
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            ret();
        }

        private void dataGridView1_BindingContextChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void Добавить_button2_Click(object sender, EventArgs e)
        {
            int numRows = dataGridView1.Rows.Count;
            Добавить_сотрудника добавить_Сотрудника = new Добавить_сотрудника(numRows);
            
            Form1.tabControl1.Controls.Add(добавить_Сотрудника.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Form1.cdt.Tables["Сотрудники"].Rows.Count > n)
            {
                FieldsForms();

            }
            
        }

        private void Изменить_button1_Click(object sender, EventArgs e)
        {
            Изменить_сотрудника.n = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Код сотрудника"].Value.ToString();
            Изменить_сотрудника изменить_Сотрудника = new Изменить_сотрудника();
            if (Form1.tabControl1.TabCount > 2)
                Form1.tabControl1.TabPages.RemoveAt(Form1.tabControl1.TabCount - 1);
            Form1.tabControl1.Controls.Add(изменить_Сотрудника.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ФИОtextBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Должность_comboBox1.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            Ведет_курсы_textBox2.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

            
        }

        private void ФИОtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Показать_button2_Click(object sender, EventArgs e)
        {
            
            string b = Convert.ToString(Поиск_textBox2.Text);
            string sql = "SELECT id_sot AS \"Код сотрудника\", fio AS \"ФИО\", data_r AS \"Дата рождения\","
               + " opit.name AS \"Опыт\", telephon AS \"Телефон\", gorod.name AS \"Город\", " +
              "ulica.name AS \"Улица\", dom.nomer AS \"Дом\", kvartira.nomer AS \"Квартира\", doljnosti.name AS \"Должность\", kursi.name AS \"Ведет курсы\", login AS \"Логин\", parol AS \"Пароль\" FROM (((((((sotrudniki inner join opit on opit.id_opita = sotrudniki.id_opita) left join doljnosti on doljnosti.id_dolj = sotrudniki.id_dolj) " +
               "left join kursi on kursi.id_kursi = sotrudniki.id_kursi) left join gorod on gorod.id_goroda = sotrudniki.id_g) " +
               "left join ulica on ulica.id_ulici = sotrudniki.id_ul) left join dom on dom.id_doma = sotrudniki.id_d) left join kvartira on kvartira.id_kvartiri = sotrudniki.id_k) " +
               "where opit.id_opita = sotrudniki.id_opita and " +
               "doljnosti.id_dolj = sotrudniki.id_dolj and kursi.id_kursi = sotrudniki.id_kursi and  gorod.id_goroda = sotrudniki.id_g and ulica.id_ulici = sotrudniki.id_ul " +
               "and dom.id_doma = sotrudniki.id_d and kvartira.id_kvartiri = sotrudniki.id_k and (fio = '" + b +
               "' or telephon = '" + b + "' or kursi.name = '" + b + "') GROUP BY id_sot, fio, data_r,opit.name, telephon, gorod.name, ulica.name, dom.nomer, kvartira.nomer, doljnosti.name, kursi.name, login, parol ORDER BY \"Код сотрудника\"";
            Form1.Table_Fill("Сотрудники", sql);
        }

        private void Назад_button1_Click(object sender, EventArgs e)
        {
            ret();
        }

        private void Название_столбца_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Выход_button_Click_1(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
    }
}
