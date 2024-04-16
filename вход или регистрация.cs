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
    public partial class вход_или_регистрация : Form
    {
        private string receivedData;
        public вход_или_регистрация(string data)
        {
            InitializeComponent();
            receivedData = data;
        }

        private void Зарегистрироваться_button_Click(object sender, EventArgs e)
        {
            регистрация Регистрация = new регистрация();
            Form1.tabControl1.TabPages.RemoveAt(0);
            Form1.tabControl1.Controls.Add(Регистрация.tabControl1.TabPages[0]);
        }

        private void Войти_button_Click(object sender, EventArgs e)
        {
            вход Вход = new вход(receivedData);
            Form1.tabControl1.TabPages.RemoveAt(0);
            Form1.tabControl1.Controls.Add(Вход.tabControl1.TabPages[0]);
        }

        private void вход_или_регистрация_FormClosing(object sender, FormClosingEventArgs e)
        {
            Главная главная = new Главная();
            Form1.tabControl1.TabPages.RemoveAt(0);
            Form1.tabControl1.Controls.Add(главная.tabControl1.TabPages[0]);
        }

        private void вход_или_регистрация_Load(object sender, EventArgs e)
        {

        }
    }
}
