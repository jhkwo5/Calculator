using System;
using System.Windows.Forms;

namespace Calculator
{
    public enum Operator { Add, Sub, Multi, Div } 

    public partial class Calculator : Form
    {
        public int Result = 0;
        public bool isNewNum = true;
        public Operator Opt = Operator.Add;

        public Calculator()
        {
            InitializeComponent(); 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumButton1_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
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
            if(isNewNum == false)
            {
                int num = int.Parse(NumScreen.Text);
                if (Opt == Operator.Add)
                    Result = Result + num;
                else if (Opt == Operator.Div)
                    Result = Result - num;

                NumScreen.Text = Result.ToString();
                isNewNum = true;
            }
            

            Button optButton = (Button)sender;
            if (optButton.Text == "+")
                Opt = Operator.Add;
            else if (optButton.Text == "-")
                Opt = Operator.Div;
                
        }

        private void NumClear_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operator.Add;

            NumScreen.Text = "0";
        }
    }
}
