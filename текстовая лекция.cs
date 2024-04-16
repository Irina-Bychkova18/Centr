﻿using System;
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
    public partial class текстовая_лекция : Form
    {
        public текстовая_лекция()
        {
            InitializeComponent();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {

        }
        public static int k = 0;
        private void FieldsForm_Fill()
        {
            Название_textBox1.Text = Form1.cdt.Tables["Все текстовые лекции"].Rows[k]["Название лекции"].ToString();
            string sql = "SELECT text AS \"Текст лекции\" FROM lekcii where name ='" + Название_textBox1.Text + "'";
            Form1.Table_Fill("текстовые лекции", sql);
            dataGridView1.DataSource = Form1.cdt.Tables["текстовые лекции"].DefaultView;
        }

        private void FieldsForm_Clear()
        {
            Название_textBox1.Text = "";

        }
        public static string n = null;
        public void field()
        {
            string sql = "SELECT id_lek AS \"Код лекции\", name AS \"Название лекции\","
                + " text AS \"Текст лекции\" FROM lekcii" + " ORDER BY \"Код лекции\"";
            Form1.Table_Fill("Все текстовые лекции", sql);

            int i = 0;
            while (Form1.cdt.Tables["Все текстовые лекции"].Rows[i]["Код лекции"].ToString() != n)
                i++;
            Название_textBox1.Text = Form1.cdt.Tables["Все текстовые лекции"].Rows[i]["Название лекции"].ToString();

            Form1.cdt.Tables["Все текстовые лекции"].DefaultView.RowFilter = "[Код лекции]=" + n;


            dataGridView1.DataSource = Form1.cdt.Tables["Все текстовые лекции"].DefaultView;
            dataGridView1.Columns["Код лекции"].Visible = false;
            dataGridView1.Columns["Название лекции"].Visible = false;
            

            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
        }
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            field();
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void Вперед_button1_Click(object sender, EventArgs e)
        {
            if (k < Form1.cdt.Tables["Все текстовые лекции"].Rows.Count) k++;
            if (Form1.cdt.Tables["Все текстовые лекции"].Rows.Count > k)
            {
                FieldsForm_Fill();
            }
            else
            {
                FieldsForm_Clear();
            }
        }

        private void dataGridView1_BindingContextChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
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
            if (Form1.cdt.Tables["Все текстовые лекции"].Rows.Count > 0)
            {
                k = 0; FieldsForm_Fill();
            }
        }

        private void В_конец_button5_Click(object sender, EventArgs e)
        {
            FieldsForm_Clear();
            k = Form1.cdt.Tables["Все текстовые лекции"].Rows.Count;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
