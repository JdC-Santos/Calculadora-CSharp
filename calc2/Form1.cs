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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Teclado(keyData.ToString());
            return base.ProcessCmdKey(ref msg, keyData);
        }
        protected void Teclado(string key)
        {
            //MessageBox.Show(key.ToString());
            switch (key)
            {
                case "NumPad1":
                    //MessageBox.Show("ok");
                    botao.PerformClick();
                    break;
                case "NumPad2":
                    //MessageBox.Show("ok");
                    button1.PerformClick();
                    break;
                case "NumPad3":
                    //MessageBox.Show("ok");
                    button2.PerformClick();
                    break;
                case "NumPad4":
                    //MessageBox.Show("ok");
                    button6.PerformClick();
                    break;
                case "NumPad5":
                    //MessageBox.Show("ok");
                    button7.PerformClick();
                    break;
                case "NumPad6":
                    //MessageBox.Show("ok");
                    button8.PerformClick();
                    break;
                case "NumPad7":
                    //MessageBox.Show("ok");
                    button9.PerformClick();
                    break;
                case "NumPad8":
                    //MessageBox.Show("ok");
                    button10.PerformClick();
                    break;
                case "NumPad9":
                    //MessageBox.Show("ok");
                    button11.PerformClick();
                    break;
                case "NumPad0":
                    //MessageBox.Show("ok");
                    button3.PerformClick();
                    break;
                case "Subtract":
                    //MessageBox.Show("ok");
                    button15.PerformClick();
                    break;
                case "Add":
                    //MessageBox.Show("ok");
                    button14.PerformClick();
                    break;
                case "Multiply":
                    //MessageBox.Show("ok");
                    button16.PerformClick();
                    break;
                case "Divide":
                    //MessageBox.Show("ok");
                    button17.PerformClick();
                    break;
                case "Return":
                    //MessageBox.Show("ok");
                    button5.PerformClick();
                    break;
                case "Back":
                    //MessageBox.Show("ok");
                    button13.PerformClick();
                    break;
                case "RButton, Oemtilde":
                    //MessageBox.Show("ok");
                    button4.PerformClick();
                    break;
            }
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

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("dsdsdsa");
            txt.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAHhhhhhhhhhhhhhhhhhhh";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("dsdsdsa");
           
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
             MessageBox.Show("dsdsdsa");
        }
    }
}
