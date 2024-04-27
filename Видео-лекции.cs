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
    public partial class Видео_лекции : Form
    {
        public Видео_лекции()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }
        public static int k = 0;
        private void FieldsForm_Fill()
        {
            Название_textBox1.Text = Form1.cdt.Tables["Все видеоролики"].Rows[k]["Название видеоролика"].ToString();
            string sql = "SELECT text AS \"Видеоролик\" FROM video where name ='" + Название_textBox1.Text + "'";
            Form1.Table_Fill("Видеоролик", sql);
            dataGridView1.DataSource = Form1.cdt.Tables["Видеоролик"].DefaultView;
        }

        private void FieldsForm_Clear()
        {
            Название_textBox1.Text = "";

        }
        public static string n = null;
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            string sql = "SELECT id_vid AS \"Код видео\", name AS \"Название видеоролика\","
                + " text AS \"Видеоролик\" FROM video" + " ORDER BY \"Код видео\"";
            Form1.Table_Fill("Видеоролик", sql);

            int i = 0;
            while (Form1.cdt.Tables["Видеоролик"].Rows[i]["Код видео"].ToString() != n)
                i++;
            Название_textBox1.Text = Form1.cdt.Tables["Видеоролик"].Rows[i]["Название видеоролика"].ToString();

            Form1.cdt.Tables["Видеоролик"].DefaultView.RowFilter = "[Код видео]=" + n;


            dataGridView1.DataSource = Form1.cdt.Tables["Видеоролик"].DefaultView;
            dataGridView1.Columns["Код видео"].Visible = false;
            dataGridView1.Columns["Название видеоролика"].Visible = false;


            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
        }

        private void Вперед_button1_Click(object sender, EventArgs e)
        {
            if (k < Form1.cdt.Tables["Видеоролик"].Rows.Count) k++;
            if (Form1.cdt.Tables["Видеоролик"].Rows.Count > k)
            {
                FieldsForm_Fill();
            }
            else
            {
                FieldsForm_Clear();
            }
        }

        private void Назад_button2_Click(object sender, EventArgs e)
        {
            if (k > 0)
            {
                k--; FieldsForm_Fill();
            }
        }

        private void В_начало_button3_Click(object sender, EventArgs e)
        {
            if (Form1.cdt.Tables["Видеоролик"].Rows.Count > 0)
            {
                k = 0; FieldsForm_Fill();
            }
        }

        private void В_конец_button5_Click(object sender, EventArgs e)
        {
            FieldsForm_Clear();
            k = Form1.cdt.Tables["Видеоролик"].Rows.Count;
        }

        private void dataGridView1_BindingContextChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
        }
    }
}
