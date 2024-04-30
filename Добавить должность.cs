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
    public partial class Добавить_должность : Form
    {
        public Добавить_должность()
        {
            InitializeComponent();
        }

        private void Добавить_button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO doljnosti (name) VALUES ('" + Название_должности_textBox1.Text + "')";
            if (!Form1.Modification_Execute(sql))
                return;

            MessageBox.Show("Новая запись успешно добавлена!");
            Form1.Table_Fill("Должности", "SELECT id_dolj AS \"Код должности\", name AS \"Наименование должности\", id_zarp AS \"Наименование зарплаты\" FROM doljnosti" + " ORDER BY \"Код должности\"");
        }
    }
}
