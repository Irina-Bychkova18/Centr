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
    public partial class регистрация : Form
    {
        public регистрация()
        {
            InitializeComponent();
        }

        private void Выход_button4_Click(object sender, EventArgs e)
        {
            вход_или_регистрация вход_Или_Регистрация = new вход_или_регистрация();
            Form1.tabControl1.TabPages.RemoveAt(0);
            Form1.tabControl1.Controls.Add(вход_Или_Регистрация.tabControl1.TabPages[0]);
        }

        private void Отменить_регистрацию_button2_Click(object sender, EventArgs e)
        {
            вход_или_регистрация вход_Или_Регистрация = new вход_или_регистрация();
            Form1.tabControl1.TabPages.RemoveAt(0);
            Form1.tabControl1.Controls.Add(вход_Или_Регистрация.tabControl1.TabPages[0]);
        }

        private void Зарегистрироваться_button1_Click(object sender, EventArgs e)
        {
            меню Меню = new меню();
            Form1.tabControl1.TabPages.RemoveAt(0);
            Form1.tabControl1.Controls.Add(Меню.tabControl1.TabPages[0]);
        }
    }
}
