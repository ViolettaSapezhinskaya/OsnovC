using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Udvoitel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.Text = "Добро пожаловать в игру удвоитель!";
            Game.Text = "Играть";
            End.Text = "Выход";
        }

        private void Game_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.Show();
        }

        private void End_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
