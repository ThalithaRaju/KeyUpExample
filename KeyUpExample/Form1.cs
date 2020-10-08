using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyUpExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BackColor = Color.BurlyWood;
                MessageBox.Show("Enter key pressed");
                //Environment.Exit(0);
            }
           
        }

        //private void txtOne_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.K)
        //    {
        //        txtOne.Text = "Key Pressed";
        //        // MessageBox.Show("Enter key pressed");
        //    }

        //}

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.K)
            {
              lblOne.Text = "Key Pressed";
                // MessageBox.Show("Enter key pressed");
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                int a = 10, b = 20;
                int sum = a + b;
                lblOne.Text = sum.ToString();
            }
            if (e.KeyChar == 6)
            {
                MessageBox.Show("Enter key pressed");
            }
        }
    }
}
