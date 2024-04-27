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
    public partial class тест_экзамен : Form
    {
        public тест_экзамен()
        {
            InitializeComponent();
        }
        public static int k = 0;
        private void FieldsForm_Fill()
        {
            Название_textBox1.Text = Form1.cdt.Tables["Все домашнее задание"].Rows[k]["Название домашнего задания"].ToString();
            string sql = "SELECT text AS \"Ссылка на домашнее задание\" FROM dz where name ='" + Название_textBox1.Text + "'";
            Form1.Table_Fill("Домашнее задание", sql);
            dataGridView1.DataSource = Form1.cdt.Tables["Домашнее задание"].DefaultView;
        }

        private void FieldsForm_Clear()
        {
            Название_textBox1.Text = "";

        }
        public static string n = null;
        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            string sql = "SELECT id_dz AS \"Код домашнего задания\", name AS \"Название домашнего задания\","
                + " text AS \"Ссылка на домашнее задание\" FROM dz" + " ORDER BY \"Код домашнего задания\"";
            Form1.Table_Fill("Домашнее задание", sql);

            int i = 0;
            while (Form1.cdt.Tables["Домашнее задание"].Rows[i]["Код домашнего задания"].ToString() != n)
                i++;
            Название_textBox1.Text = Form1.cdt.Tables["Домашнее задание"].Rows[i]["Название домашнего задания"].ToString();

            Form1.cdt.Tables["Домашнее задание"].DefaultView.RowFilter = "[Код домашнего задания]=" + n;


            dataGridView1.DataSource = Form1.cdt.Tables["Домашнее задание"].DefaultView;
            dataGridView1.Columns["Код домашнего задания"].Visible = false;
            dataGridView1.Columns["Название домашнего задания"].Visible = false;


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

        private void Вперед_button1_Click(object sender, EventArgs e)
        {
            if (k < Form1.cdt.Tables["Домашнее задание"].Rows.Count) k++;
            if (Form1.cdt.Tables["Домашнее задание"].Rows.Count > k)
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
            if (Form1.cdt.Tables["Домашнее задание"].Rows.Count > 0)
            {
                k = 0; FieldsForm_Fill();
            }
        }

        private void В_конец_button5_Click(object sender, EventArgs e)
        {
            FieldsForm_Clear();
            k = Form1.cdt.Tables["Домашнее задание"].Rows.Count;
        }
    }
}
