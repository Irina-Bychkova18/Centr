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
    public partial class Добавить_улицу : Form
    {
        public Добавить_улицу()
        {
            InitializeComponent();
        }

        private void Добавить_button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO ulica (name) VALUES ('" + Название_улицы_textBox1.Text + "')";
            if (!Form1.Modification_Execute(sql))
                return;

            MessageBox.Show("Новая запись успешно добавлена!");
            Form1.Table_Fill("Улица", "SELECT id_ulici AS \"Код улицы\", name AS \"Название улицы\" FROM ulica" + " ORDER BY \"Код улицы\"");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Название_улицы_textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
