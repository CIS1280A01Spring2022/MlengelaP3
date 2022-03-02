/***********************************************************************
 * Program: Store Order
 * Programmer: Daudi Mlengela (dmlengela@cnm.edu)
 * Date: 1 March 2022
 * Purpose: Store order class with properties and constructors
 * *********************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MlengelaP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool CheckedBox1_Checked { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text
                = textBox5.Text = " ";
            radioButton1.Checked = radioButton2.Checked = radioButton3.Checked
                = false;
            checkBox1.Checked = false;

        }

        private void CheckedBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckedBox1_Checked)
            {
                label4.Visible = textBox4.Visible = true;

            }
            else 
            {
                label4.Visible = textBox4.Visible = false;
            }
        }

        
    }
}
