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
    public partial class Учащиеся : Form
    {
        public Учащиеся()
        {
            InitializeComponent();
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
        public void ret()
        {
            string sql = "SELECT id_uch AS \"Код ученика\", fio AS \"ФИО\","
              + " data_r AS \"Дата рождения\", telephon_uch AS \"Номер телефона ученика\", gorod.name AS \"Город\", " +
              "ulica.name AS \"Улица\", dom.nomer AS \"Дом\", kvartira.nomer AS \"Квартира\"," +
              "telephon_roditela AS \"Номер телефона родителей\", login AS \"Логин\", parol AS \"Пароль\" FROM ((((uchenik inner join gorod on gorod.id_goroda = uchenik.id_g)"
               + "left join ulica on ulica.id_ulici = uchenik.id_ul) left join dom on dom.id_doma = uchenik.id_d) " +
               "left join kvartira on kvartira.id_kvartiri = uchenik.id_k) where gorod.id_goroda = uchenik.id_g " +
               "and ulica.id_ulici = uchenik.id_ul and dom.id_doma = uchenik.id_d and kvartira.id_kvartiri = uchenik.id_k GROUP BY id_uch, fio,"
              + " data_r, telephon_uch, gorod.name, ulica.name, dom.nomer, kvartira.nomer, telephon_roditela, login, parol" + " ORDER BY \"Код ученика\"";
            Form1.Table_Fill("Ученики", sql);

            dataGridView1.DataSource = Form1.cdt.Tables["Ученики"];
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;

            int numRows = dataGridView1.Rows.Count;
            Всего_учеников_textBox1.Text = numRows.ToString();
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

        private void Удалить_запись_button5_Click(object sender, EventArgs e)
        {
            string kod;
            try
            {
                kod = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Код ученика"].Value.ToString();
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
            string sql = "DELETE FROM uchenik WHERE id_uch = " + kod;
            Form1.Modification_Execute(sql);
            for (int i = Form1.cdt.Tables["Ученики"].Rows.Count - 1; i >= 0; i--)
                if (Form1.cdt.Tables["Ученики"].Rows[i]["Код ученика"].ToString() == kod)
                {
                    Form1.cdt.Tables["Ученики"].Rows.RemoveAt(i);
                    dataGridView1.CurrentCell = null;
                    return;
                }
        }

        private void Добавить_запись_button1_Click(object sender, EventArgs e)
        {
            Добавить_учащегося добавить_учащегося = new Добавить_учащегося();

            Form1.tabControl1.Controls.Add(добавить_учащегося.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void Изменить_запись_button2_Click(object sender, EventArgs e)
        {
            Изменить_учащегося.n = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Код ученика"].Value.ToString();
            Изменить_учащегося изменить_учащегося = new Изменить_учащегося();
            if (Form1.tabControl1.TabCount > 2)
                Form1.tabControl1.TabPages.RemoveAt(Form1.tabControl1.TabCount - 1);
            Form1.tabControl1.Controls.Add(изменить_учащегося.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void Назад_button1_Click(object sender, EventArgs e)
        {

        }

        private void Показать_button2_Click(object sender, EventArgs e)
        {
            string b = Convert.ToString(Поиск_textBox2.Text);
            string sql = "SELECT id_uch AS \"Код ученика\", fio AS \"ФИО\","
              + " data_r AS \"Дата рождения\", telephon_uch AS \"Номер телефона ученика\", gorod.name AS \"Город\", " +
              "ulica.name AS \"Улица\", dom.nomer AS \"Дом\", kvartira.nomer AS \"Квартира\"," +
              "telephon_roditela AS \"Номер телефона родителей\", login AS \"Логин\", parol AS \"Пароль\" FROM ((((uchenik inner join gorod on gorod.id_goroda = uchenik.id_g)"
               + "left join ulica on ulica.id_ulici = uchenik.id_ul) left join dom on dom.id_doma = uchenik.id_d) " +
               "left join kvartira on kvartira.id_kvartiri = uchenik.id_k) where gorod.id_goroda = uchenik.id_g " +
               "and ulica.id_ulici = uchenik.id_ul and dom.id_doma = uchenik.id_d and kvartira.id_kvartiri = uchenik.id_k and (fio = '" + b +
               "' or telephon_uch = '" + b + "' or telephon_roditela = '" + b + "')GROUP BY id_uch, fio,"
              + " data_r, telephon_uch, gorod.name, ulica.name, dom.nomer, kvartira.nomer, telephon_roditela, login, parol" + " ORDER BY \"Код ученика\"";
            
             Form1.Table_Fill("Ученики", sql);
        }
    }
}
