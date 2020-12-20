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
    public partial class Form1 : Form
    {
        Double Result = 2;
        String nb1;
        String nb2;
        String Op = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClick(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            if (btn.Text != "+" && btn.Text != "-" && btn.Text != "*" && btn.Text != "/" && btn.Text != "=")
            {
                ResultBox.Text += btn.Text;
               
            }
            else
            {
                if (String.IsNullOrEmpty(nb1))
                {
                    nb1 = ResultBox.Text;
                    ResultBox.Text = "";
                    Op = btn.Text;

                }
                if (String.IsNullOrEmpty(nb2) && !String.IsNullOrEmpty(nb1))
                {
                    nb2 = ResultBox.Text;
                    ResultBox.Text = "";
                    
                }
                
                

                if (!String.IsNullOrEmpty(nb1)  && !String.IsNullOrEmpty(nb2))
                {
                    switch (Op)
                    {
                        case "+":
                            Result = Convert.ToDouble(nb1) + Convert.ToDouble(nb2);
                            ResultBox.Text = "";
                            nb1 = "";
                            nb2 = "";
                            break;
                        case "-":
                            Result = Convert.ToDouble(nb1) - Convert.ToDouble(nb2);
                            ResultBox.Text = "";
                            nb1 = "";
                            nb2 = "";
                            break;
                        case "*":
                            Result = Convert.ToDouble(nb1) * Convert.ToDouble(nb2);
                            ResultBox.Text = "";
                            nb1 = "";
                            nb2 = "";
                            break;
                        case "/":
                            Result = Convert.ToDouble(nb1) / Convert.ToDouble(nb2);
                            ResultBox.Text = "";
                            nb1 = "";
                            nb2 = "";
                            break;
                       

                    }
                    ResultBox.Text = Convert.ToString(Result);

                }



            }
            



        }

        private void ResultClick(object sender, EventArgs e)
        {
            
        }
    }
}
