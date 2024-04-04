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

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            string sql = "SELECT id_lek AS \"Код лекции\", name AS \"Название лекции\","
                + " text AS \"Текст лекции\" FROM lekcii" + " ORDER BY \"Код лекции\"";
            Form1.Table_Fill("Курс", sql);

            dataGridView1.DataSource = Form1.cdt.Tables["Все текстовые лекции"];
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
        }
    }
}
