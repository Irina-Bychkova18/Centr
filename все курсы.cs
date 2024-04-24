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
    public partial class все_курсы : Form
    {
        public все_курсы()
        {
            InitializeComponent();
            
        }
        
        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
        public void ret()
        {
            string sql = "SELECT id_kursi AS \"Код курса\", name AS \"Название курса\","
              + " kolvo_mest_vsego AS \"Количество мест всего\", mest_ostav AS \"Количество оставшихся мест\", " +
              "information AS \"Информация о курсе\" FROM kursi" + " ORDER BY \"Код курса\"";
            Form1.Table_Fill("Курсы", sql);

            dataGridView1.DataSource = Form1.cdt.Tables["Курсы"];
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;

            int numRows = dataGridView1.Rows.Count;
            Всего_курсов_textBox1.Text = numRows.ToString();

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["Количество оставшихся мест"].Value);
            }
            Количество_оставшихся_мест_textBox2.Text = sum.ToString();
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

        private void Всего_курсов_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            курсы.n = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Код курса"].Value.ToString();
            курсы Курсы = new курсы();
            
            if (Form1.tabControl1.TabCount > 2)
                Form1.tabControl1.TabPages.RemoveAt(Form1.tabControl1.TabCount - 1);
            
            Form1.tabControl1.Controls.Add(Курсы.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Добавить_курс_button1_Click(object sender, EventArgs e)
        {
            Добавить_курс добавить_курс = new Добавить_курс();
            Form1.tabControl1.Controls.Add(добавить_курс.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void Сохранить_button3_Click(object sender, EventArgs e)
        {

        }

        private void Изменить_курс_button2_Click(object sender, EventArgs e)
        {
            Изменить_курс.n = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Код курса"].Value.ToString();
            Изменить_курс изменить_Курс = new Изменить_курс();
            if (Form1.tabControl1.TabCount > 2)
                Form1.tabControl1.TabPages.RemoveAt(Form1.tabControl1.TabCount - 1);
            Form1.tabControl1.Controls.Add(изменить_Курс.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void Удалить_курс_button5_Click(object sender, EventArgs e)
        {
            string kod;
            try
            {
                kod = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Код курса"].Value.ToString();
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
            string sql = "DELETE FROM kursi WHERE id_kursi = " + kod;
            Form1.Modification_Execute(sql);
            for (int i = Form1.cdt.Tables["Курсы"].Rows.Count - 1; i >= 0; i--)
                if (Form1.cdt.Tables["Курсы"].Rows[i]["Код курса"].ToString() == kod)
                {
                    Form1.cdt.Tables["Курсы"].Rows.RemoveAt(i);
                    dataGridView1.CurrentCell = null;
                    return;
                }
        }
    }
}
