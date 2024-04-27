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
    public partial class Изменить_видеолекцию : Form
    {
        public Изменить_видеолекцию()
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
            while (Form1.cdt.Tables["Видеоролик"].Rows[i]["Код видео"].ToString() != n)
                i++;
            string sql;
            if (i < Form1.cdt.Tables["Видеоролик"].Rows.Count)
            {
                i = i + 1;
                sql = "UPDATE video SET name ='" + Название_textBox1.Text + "', text = '" + Информация_textBox4.Text + "' WHERE id_vid = " + i;
                if (!Form1.Modification_Execute(sql))
                    return;
                MessageBox.Show("Запись успешно изменена!");
            }
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            string sql = "SELECT id_vid AS \"Код видео\", name AS \"Название видеоролика\","
                + " text AS \"Видеоролик\" FROM video" + " ORDER BY \"Код видео\"";
            Form1.Table_Fill("Видеоролик", sql);

            int i = 0;
            while (Form1.cdt.Tables["Видеоролик"].Rows[i]["Код видео"].ToString() != n)
                i++;
            Название_textBox1.Text = Form1.cdt.Tables["Видеоролик"].Rows[i]["Название видеоролика"].ToString();
            Информация_textBox4.Text = Form1.cdt.Tables["Видеоролик"].Rows[i]["Видеоролик"].ToString();


            Form1.cdt.Tables["Видеоролик"].DefaultView.RowFilter = "[Код видео]=" + n;
        }
    }
}
