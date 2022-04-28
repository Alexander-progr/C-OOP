using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double onenum;
        Double twonum;
        string operation;
        bool f = false;
        private void number_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "+-":
                    if (output.Text.Contains('-'))
                    {
                        output.Text = output.Text.Substring(1);
                    }
                    else
                    {
                        output.Text = output.Text.Insert(0, "-");
                    }
                    break;
                case ",":
                    if (f == false)
                    {
                        if (output.Text.Contains(','))
                        {
                            break;
                        }
                        else
                        {
                            output.Text += ((Button)sender).Text;
                            break;
                        }
                    }
                    else
                    {
                        f = false;
                        output.Text = "0,";
                        break;
                    }
                case "0":
                    if (f == false)
                    {
                        if (output.Text != "0")
                            output.Text += ((Button)sender).Text;
                    }
                    else
                    {
                        f = false;
                        output.Text = ((Button)sender).Text;
                    }
                    break;
                default:
                    if (f == false)
                    {
                        if (output.Text != "0")
                        {
                            output.Text += ((Button)sender).Text;

                        }
                        else
                        {
                            output.Text = ((Button)sender).Text;
                        }
                    }
                    else
                    {
                        f = false;
                        output.Text = ((Button)sender).Text;
                    }
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void operation_Click(object sender, EventArgs e)
        {
            f = true;
            switch (((Button)sender).Text)
            {
                case "+":
                    onenum = Convert.ToDouble(output.Text);
                    operation = "+";
                    break;
                case "-":
                    onenum = Convert.ToDouble(output.Text);
                    operation = "-";
                    break;
                case "*":
                    onenum = Convert.ToDouble(output.Text);
                    operation = "*";
                    break;
                case "/":
                    onenum = Convert.ToDouble(output.Text);
                    operation = "/";
                    break;
                case "//":
                    onenum = Convert.ToDouble(output.Text);
                    operation = "//";
                    break;
                case "%":
                    onenum = Convert.ToDouble(output.Text);
                    operation = "%";
                    break;
                case "^":
                    onenum = Convert.ToDouble(output.Text);
                    operation = "^";
                    break;
                case "RND":
                    onenum = Convert.ToDouble(output.Text);
                    operation = "RND";
                    break;
            }
        }
        private void clean_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "CE":
                    output.Text = "0";
                    break;
                case "C":
                    if (output.Text.Length != 1)
                    {
                        output.Text = output.Text.Substring(0, output.Text.Length - 1);
                    }
                    else
                    {
                        output.Text = "0";
                    }
                    break;
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
            f = true;
            switch (operation)
            {
                case "+":
                    twonum = Convert.ToDouble(output.Text);
                    output.Text = Convert.ToString(onenum + twonum);
                    break;
                case "-":
                    twonum = Convert.ToDouble(output.Text);
                    output.Text = Convert.ToString(onenum - twonum);
                    break;
                case "*":
                    twonum = Convert.ToDouble(output.Text);
                    output.Text = Convert.ToString(onenum * twonum);
                    break;
                case "/":
                    if (output.Text != "0")
                    {

                        twonum = Convert.ToDouble(output.Text);
                        output.Text = Convert.ToString(onenum / twonum);
                    }
                    else
                    {
                        output.Text = "НА НУЛЬ НЕЛЬЗЯ ДЕЛИТЬ!!!! >:(";
                    }
                    break;
                case "//":
                    if (output.Text != "0")
                    {

                        twonum = Convert.ToDouble(output.Text);
                        output.Text = Convert.ToString(Math.Round(onenum / twonum));
                    }
                    else
                    {
                        output.Text = "НА НУЛЬ НЕЛЬЗЯ ДЕЛИТЬ!!!! >:(";
                    }
                    break;
                case "%":
                    twonum = Convert.ToDouble(output.Text);
                    output.Text = Convert.ToString(onenum % twonum);
                    break;
                case "^":
                    twonum = Convert.ToDouble(output.Text);
                    output.Text = Convert.ToString(Math.Pow(onenum, twonum));
                    break;
                case "RND":
                    var Rnd = new Random();
                    twonum = Convert.ToDouble(output.Text);
                    if (onenum > twonum)
                    {
                        output.Text = Convert.ToString(Math.Floor((onenum - twonum + 1) * Rnd.Next()));
                    }
                    else
                    {
                        output.Text = Convert.ToString(Math.Floor((twonum - onenum + 1) * Rnd.NextDouble()));
                    }
                    break;
            }
        }
    }
}
