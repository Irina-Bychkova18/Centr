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
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
        }
        public static int n = 0;
        public string selectedValue;
        private void FieldsForm_Fill()
        {
           
            Выборка_пользователя_combobox.Text = Form1.cdt.Tables["Пользователи"].Rows[n]["Название_пользователя"].ToString();
        }

        private void FieldsForm_Clear()
        {
            Выборка_пользователя_combobox.Text = "";
        }

        
  

        private void Далее_button_Click(object sender, EventArgs e)
        {
            //if (Выборка_пользователя_combobox.SelectedIndex == 0)
            //{
            string selectedValue = Выборка_пользователя_combobox.Text.ToString();
            // Получение выбранного значения из ComboBox
            вход_или_регистрация вход_Или_Регистрация = new вход_или_регистрация(selectedValue);
                Form1.tabControl1.TabPages.RemoveAt(0);
                Form1.tabControl1.Controls.Add(вход_Или_Регистрация.tabControl1.TabPages[0]);

            //}
        }

        private void tabPage1_Enter_1(object sender, EventArgs e)
        {
           
        }

        private void Главная_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            Form1.Table_Fill("Пользователи", "SELECT id_usera AS \"Код_пользователя\", name AS \"Название_пользователя\" FROM users ORDER BY \"Код_пользователя\"");
            Выборка_пользователя_combobox.DataSource = Form1.cdt.Tables["Пользователи"].DefaultView;
            Выборка_пользователя_combobox.DisplayMember = "Название_пользователя";
            if (Form1.cdt.Tables["Пользователи"].Rows.Count > n)
                FieldsForm_Fill();
            
        }

        private void Выборка_пользователя_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
