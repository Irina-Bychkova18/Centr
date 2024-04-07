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
    public partial class курсы : Form
    {
        public курсы()
        {
            InitializeComponent();
        }

        private void Выход_button4_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
        public static string n = null;
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            string sql = "SELECT id_kursi AS \"Код курса\", name AS \"Название курса\","
              + " kolvo_mest_vsego AS \"Количество мест всего\", mest_ostav AS \"Количество оставшихся мест\", " +
              "information AS \"Информация о курсе\" FROM kursi" + " ORDER BY \"Код курса\"";
            Form1.Table_Fill("Курсы", sql);

            int i = 0;
            while (Form1.cdt.Tables["Курсы"].Rows[i]["Код курса"].ToString() != n)
                i++;
            Название_textBox1.Text = Form1.cdt.Tables["Курсы"].Rows[i]["Название курса"].ToString();
            Всего_мест_textBox3.Text = Form1.cdt.Tables["Курсы"].Rows[i]["Количество мест всего"].ToString();
            Оставшиеся_места_textBox2.Text = Form1.cdt.Tables["Курсы"].Rows[i]["Количество оставшихся мест"].ToString();


            Form1.cdt.Tables["Курсы"].DefaultView.RowFilter = "[Код курса]=" + n;


            dataGridView1.DataSource = Form1.cdt.Tables["Курсы"].DefaultView;
            dataGridView1.Columns["Код курса"].Visible = false;
            dataGridView1.Columns["Название курса"].Visible = false;
            dataGridView1.Columns["Количество мест всего"].Visible = false;
            dataGridView1.Columns["Количество оставшихся мест"].Visible = false;
       
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;

            
        }

        private void dataGridView1_BindingContextChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
        }

        private void Записаться_на_курс_button1_Click(object sender, EventArgs e)
        {
            Записаться_на_курс записаться_На_Курс = new Записаться_на_курс();
            Form1.tabControl1.TabPages.RemoveAt(0);
            Form1.tabControl1.Controls.Add(записаться_На_Курс.tabControl1.TabPages[0]);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
