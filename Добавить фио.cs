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
    public partial class Добавить_фио : Form
    {
        public Добавить_фио()
        {
            InitializeComponent();
        }

        private void Добавить_button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO uchenik (name) VALUES ('" + Название_улицы_textBox1.Text + "')";
            if (!Form1.Modification_Execute(sql))
                return;

            MessageBox.Show("Новая запись успешно добавлена!");
            
        }
    }
}
