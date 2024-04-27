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
    public partial class Изменить_домашнее_задание : Form
    {
        public Изменить_домашнее_задание()
        {
            InitializeComponent();
        }
        public static string n = null;
        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void Изменить_button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (Form1.cdt.Tables["Домашнее задание"].Rows[i]["Код домашнего задания"].ToString() != n)
                i++;
            string sql;
            if (i < Form1.cdt.Tables["Домашнее задание"].Rows.Count)
            {
                i = i + 1;
                sql = "UPDATE dz SET name ='" + Название_textBox1.Text + "', text = '" + Информация_textBox4.Text + "' WHERE id_dz = " + i;
                if (!Form1.Modification_Execute(sql))
                    return;
                MessageBox.Show("Запись успешно изменена!");
            }
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
            Информация_textBox4.Text = Form1.cdt.Tables["Домашнее задание"].Rows[i]["Ссылка на домашнее задание"].ToString();


            Form1.cdt.Tables["Домашнее задание"].DefaultView.RowFilter = "[Код домашнего задания]=" + n;
        }
    }
}
