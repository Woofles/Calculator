using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textBox1.Text = "0";
            this.textBox2.Text = "0";
            this.labelOperationSign.Text = "";
        }
        //
        //Buttons
        //
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //this.textBox1.Text += "1";
            this.textBox1.Text = buttonAddTo("1", this.textBox1.Text);
        }
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            //this.textBox1.Text += "2";
            this.textBox1.Text = buttonAddTo("2", this.textBox1.Text);
        }
        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            //this.textBox1.Text += "3";
            this.textBox1.Text = buttonAddTo("3", this.textBox1.Text);
        }
        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            //this.textBox1.Text += "4";
            this.textBox1.Text = buttonAddTo("4", this.textBox1.Text);
        }
        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            //this.textBox1.Text += "5";
            this.textBox1.Text = buttonAddTo("5", this.textBox1.Text);
        }
        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            //this.textBox1.Text += "6";
            this.textBox1.Text = buttonAddTo("6", this.textBox1.Text);
        }
        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            //this.textBox1.Text += "7";
            this.textBox1.Text = buttonAddTo("7", this.textBox1.Text);
        }
        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            //this.textBox1.Text += "8";
            this.textBox1.Text = buttonAddTo("8", this.textBox1.Text);
        }
        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            //this.textBox1.Text += "9";
            this.textBox1.Text = buttonAddTo("9", this.textBox1.Text);
        }
        private void button10_MouseClick(object sender, MouseEventArgs e)
        {
            //this.textBox1.Text += "0";
            this.textBox1.Text = buttonAddTo("0", this.textBox1.Text);
        }
        private void buttonCalcEnter_MouseClick(object sender, MouseEventArgs e)
        {
            evalFinal();
        }
        //
        private string buttonAddTo(string number, string container)
        {
            if (container == "0") return number;
            else return container + number;
        }
        //
        //Main operations
        //
        private void buttonCalcPlus_MouseClick(object sender, MouseEventArgs e)
        {
            evalIntermediate();
            this.labelOperationSign.Text = "+";
            this.textBox1.Text = "0";
        }
        private void buttonCalcMinus_MouseClick(object sender, MouseEventArgs e)
        {
            evalIntermediate();
            this.labelOperationSign.Text = "-";
            this.textBox1.Text = "0";
        }
        private void buttonCalcStar_MouseClick(object sender, MouseEventArgs e)
        {
            evalIntermediate();
            this.labelOperationSign.Text = "*";
            this.textBox1.Text = "0";
        }
        private void buttonCalcSlash_MouseClick(object sender, MouseEventArgs e)
        {
            evalIntermediate();
            this.labelOperationSign.Text = "/";
            this.textBox1.Text = "0";
        }
        //
        private void evalIntermediate()
        {
            switch (this.labelOperationSign.Text)
            {
                case "+":
                { this.textBox2.Text = (double.Parse(this.textBox2.Text) + double.Parse(this.textBox1.Text)).ToString(); };break;
                case "-":
                { this.textBox2.Text = (double.Parse(this.textBox2.Text) - double.Parse(this.textBox1.Text)).ToString(); }break;
                case "*":
                { this.textBox2.Text = (double.Parse(this.textBox2.Text) * double.Parse(this.textBox1.Text)).ToString(); }break;
                case "/":
                { this.textBox2.Text = (double.Parse(this.textBox2.Text) / double.Parse(this.textBox1.Text)).ToString(); }break;
                case "":
                { this.textBox2.Text = this.textBox1.Text; }break;
            }
        }
        private void evalFinal()
        {
            switch (this.labelOperationSign.Text)
            {
                case "+":
                { this.textBox3.Text = (double.Parse(this.textBox2.Text) + double.Parse(this.textBox1.Text)).ToString(); }; break;
                case "-":
                { this.textBox3.Text = (double.Parse(this.textBox2.Text) - double.Parse(this.textBox1.Text)).ToString(); }
                break;
                case "*":
                { this.textBox3.Text = (double.Parse(this.textBox2.Text) * double.Parse(this.textBox1.Text)).ToString(); }
                break;
                case "/":
                { this.textBox3.Text = (double.Parse(this.textBox2.Text) / double.Parse(this.textBox1.Text)).ToString(); }
                break;
            }
        }
        //
        //Auxiliary
        //
        private void buttonClearEvery_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox2.Text = "0";
            this.textBox1.Text = "0";
            this.textBox3.Text = "";
            this.labelOperationSign.Text = "";
        }
        private void buttonClearBack_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text.Length > 1) { this.textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1); }
            else if (textBox1.Text != "0") { this.textBox1.Text = "0"; }
        }
        //
        //private void buttonClearCurrent_MouseClick(object sender, MouseEventArgs e)
        //{
        //    this.textBox1.Text = "0";
        //}
    }
}
