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
    public partial class Добавить_лекцию : Form
    {
        public Добавить_лекцию()
        {
            InitializeComponent();
        }

        private void Добавить_лекцию_button2_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO lekcii (name, text) VALUES ('" + Название_textBox1.Text + "','" + Информация_textBox4.Text + "')";
            if (!Form1.Modification_Execute(sql))
                return;

            меню_админ Меню = new меню_админ();
            Form1.tabControl1.Controls.Add(Меню.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }

        private void Выход_button_Click(object sender, EventArgs e)
        {
            Form1.tabControl1.Controls.Remove(Form1.tabControl1.SelectedTab);
        }

        private void Отменить_добавление_button1_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM lekcii where name ='" + Название_textBox1.Text + "' and text = '" + Информация_textBox4.Text + "'";
            if (!Form1.Modification_Execute(sql))
                return;

            меню_админ Меню = new меню_админ();
            Form1.tabControl1.Controls.Add(Меню.tabControl1.TabPages[0]);
            Form1.tabControl1.SelectedIndex = Form1.tabControl1.TabCount - 1;
        }
    }
}
