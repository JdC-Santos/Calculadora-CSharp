using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc2
{
    public partial class Form1 : Form
    {
        string n1 = "";
        string n2 = "";
        string funcao = "";

        public Form1()
        {
            InitializeComponent();

        }

        private void Botoes_Click(object sender, EventArgs e)
        {
            string d = ((Button)sender).Text;
     
            try
            {
                if (d != ",")
                {
                    double n = double.Parse(d);
                    if (funcao == "")
                    {
                        n1 += d;
                    }
                    else
                    {
                        n2 += d;
                    }
                }
                else
                {
                    if (funcao == "")
                    {
                        n1 += d;
                    }
                    else
                    {
                        n2 += d;
                    }
                }
 
                txt.Text += d;
            }
            catch(Exception)
            {
                if (funcao != "")
                {
                    if (n1 == "")
                    {
                        n1 = "0";
                    }

                    if (n2 == "")
                    {
                        n2 = "0";
                    }
                    switch (funcao)
                    {
                        case "+":
                            n1 = ( double.Parse(n1) + double.Parse(n2) ).ToString();
                            break;
                        case "-":
                            n1 = (double.Parse(n1) - double.Parse(n2)).ToString();
                            break;

                        case "*":
                            n1 = (double.Parse(n1) * double.Parse(n2)).ToString();
                            break;

                        case "/":
                            n1 = (double.Parse(n1) / double.Parse(n2)).ToString();
                            break;

                        case "C":
                            n1 = "";
                            n2 = "";
                            txt.Text = "";
                            funcao = "";
                            break;

                        case "CE":
                            funcao = "";
                            n1 = "";
                            n2 = "";
                            txt.Text = "";
                            break;
                    }
                }
                n2 = "";
                funcao = d;

                if (d != "=" && d != "C" && d != "CE")
                {
                    txt.Text = n1 + d;
                }
                else
                {
                    if (d == "C" || d == "CE")
                    {
                        funcao = "";
                        n1 = "";
                        n2 = "";
                        txt.Text = "";
                        
                    }
                    else if (d == "=")
                    {
                        funcao = "";
                        txt.Text = n1;
                    }
                    else
                    {
                        txt.Text = n1;
                    }
                }
                
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            MessageBox.Show("e.KeyCode.ToString()");
            if (e.KeyCode == Keys.A)
            {
                
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("dsdsdsa");
            txt.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAHhhhhhhhhhhhhhhhhhhh";
        }
    }
}
