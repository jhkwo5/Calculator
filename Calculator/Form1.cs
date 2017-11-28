using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public int Result = 0;
        public bool isNewNum = true;

        public Calculator()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumButton1_Click(object sender, EventArgs e)
        {
            
            SetNum("1");
        }

        private void NumButton2_Click(object sender, EventArgs e)
        {
            SetNum("2");
        }

        public void SetNum(string num)
        {
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else
            {
                if (NumScreen.Text == "0")
                {
                    NumScreen.Text = num;
                }
                NumScreen.Text = NumScreen.Text + num;
            }
        }

        private void NumPlus_Click(object sender, EventArgs e)
        {
            int num = int.Parse(NumScreen.Text);
            Result = Result + num;

            NumScreen.Text = Result.ToString();
            isNewNum = true;
        }
    }
}
