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
    public partial class Form1 : Form
    {
        public Form1()
        {
            Random rnd = new Random();
            int value=rnd.Next(0,100);
            InitializeComponent();
            Comand1.Text = "+1";
            Comand2.Text = "x2";
            Reset.Text = "Сброс";
            Number.Text = "0";
            End.Text = value.ToString();
            moves.Text = "0";
            button1.Text = "Проверка";
        }
        
        private void Comand1_Click(object sender, EventArgs e)
        {
            Number.Text = (int.Parse(Number.Text) + 1).ToString();
            moves.Text=(int.Parse(moves.Text) + 1).ToString();
        }

        private void Comand2_Click(object sender, EventArgs e)
        {
            Number.Text=(int.Parse(Number.Text)*2).ToString();
            moves.Text = (int.Parse(moves.Text) + 1).ToString();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Number.Text="0";
            moves.Text="0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(End.Text) == int.Parse(Number.Text))
            {
                new Form3().Show();
                this.Close();
            }
        }
    }
}
