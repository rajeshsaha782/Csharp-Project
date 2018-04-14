using System;
using System.Drawing;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        String number = "", operation = "";
        int DOTCOUNTER = 0, operation_counter = 0, number_counter = 0, plus_counter = 0, minus_counter = 0, mult_counter = 0, div_counter = 0, equl_counter = 0, word = 0, MR_counter = 0,limit=13;
        double x = 0, y = 0, memory = 0;

        public void Number(string str)
        {
            if(number.Length <= limit && !textBox1.Text.Equals("Math Error"))
            {
                if(equl_counter == 1)
                {
                    number = "";
                }
                if(MR_counter == 1)
                {
                    number = "";
                }
            
                number = number + str;
                textBox1.Text = number;

                operation_lable.Text = "";
                number_counter++;
                plus_counter = 0;
                minus_counter = 0;
                mult_counter = 0;
                div_counter = 0; equl_counter = 0;
                operation_counter = 0;
                MR_counter = 0;
            }
        }
        private void key(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString().Equals("0"))
            {
                Number("0");
            }
            else if(e.KeyChar.ToString().Equals("1"))
            {
                Number("1");
            }
            else if(e.KeyChar.ToString().Equals("2"))
            {
                Number("2");
            }
            else if(e.KeyChar.ToString().Equals("3"))
            {
                Number("3");
            }
            else if(e.KeyChar.ToString().Equals("4"))
            {
                Number("4");
            }
            else if(e.KeyChar.ToString().Equals("5"))
            {
                Number("5");
            }
            else if(e.KeyChar.ToString().Equals("6"))
            {
                Number("6");
            }
            else if(e.KeyChar.ToString().Equals("7"))
            {
                Number("7");
            }
            else if(e.KeyChar.ToString().Equals("8"))
            {
                Number("8");
            }
            else if(e.KeyChar.ToString().Equals("9"))
            {
                Number("9");
            }
            else if(e.KeyChar.ToString().Equals("."))
            {
                buttonDot_Click(sender,e);
            }

            else if(e.KeyChar.ToString().Equals("+"))
            {
                Operation("+"); operation_lable.Text = "+";
            }
            else if(e.KeyChar.ToString().Equals("-"))
            {
                Operation("-"); operation_lable.Text = "-";
            }
            else if(e.KeyChar.ToString().Equals("*"))
            {
                Operation("*"); operation_lable.Text = "*";
            }
            else if(e.KeyChar.ToString().Equals("/"))
            {
                Operation("/"); operation_lable.Text = "/";
            }
            else if(e.KeyChar.ToString().Equals("="))
            {
                buttonEq_Click(sender, e);
            }
            else if(e.KeyChar == (char)Keys.Back)
            {
                backspace_Click(sender, e);
            }
            else if(e.KeyChar == (char)Keys.Escape)
            {
                buttonCE_Click(sender,e);
            }
            

        }

        private void button0_Click(object sender, EventArgs e)
        {
            Number("0");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Number("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Number("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Number("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Number("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Number("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Number("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Number("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Number("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Number("9");
        }


        private void buttonPs_Click(object sender, EventArgs e)
        {
           Operation("+");
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            Operation("-");
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            Operation("*");
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            Operation("/");
        }

        public void Operation(string str)
        {
            if(!textBox1.Text.Equals("Math Error"))
            {
                operation_lable.Text = str;
                DOTCOUNTER = 0; equl_counter = 0;
                word++;

                if(word == 1)
                {
                    operation = str;
                }

                if(plus_counter == 0 && minus_counter == 0 && mult_counter == 0 && div_counter == 0 && number.Length != 0)
                {
                    double p = 0;
                    p = Double.Parse(textBox1.Text);

                    if(operation.Equals("+"))
                    {
                        x = x + p;
                        textBox1.Text = Convert.ToString(x);

                    }
                    else if(operation.Equals("-"))
                    {
                        if(word == 1)
                        {
                            x = p;
                        }
                        else
                        {
                            x = x - p;
                        }
                        textBox1.Text = Convert.ToString(x);
                    }
                    else if(operation.Equals("*"))
                    {
                        if(word == 1)
                        {
                            x = p;
                        }
                        else
                        {
                            x = x * p;

                        }
                        textBox1.Text = Convert.ToString(x);
                    }
                    else if(operation.Equals("/"))
                    {
                        if(word == 1)
                        {
                            x = p;
                        }
                        else
                        {
                            x = x / p;
                        }
                        textBox1.Text = Convert.ToString(x);
                    }
                }


                if(str.Equals("+") && plus_counter == 0)
                {
                    plus_counter++;
                    minus_counter = 0;
                    mult_counter = 0;
                    div_counter = 0;
                }
                else if(str.Equals("-") && minus_counter == 0)
                {
                    plus_counter = 0;
                    minus_counter++;
                    mult_counter = 0;
                    div_counter = 0;

                }
                else if(str.Equals("*") && mult_counter == 0)
                {
                    plus_counter = 0;
                    minus_counter = 0;
                    mult_counter++;
                    div_counter = 0;

                }
                else if(str.Equals("/") && div_counter == 0)
                {
                    plus_counter = 0;
                    minus_counter = 0;
                    mult_counter = 0;
                    div_counter++;

                }

                operation_counter++;

                operation = str;
                number = "";
                number_counter = 0;
            }
            
        }


        private void buttonEq_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Equals("Math Error"))
            {
                operation_lable.Text = "=";
                if(equl_counter == 0)
                {
                    equl_counter++;
                    word = 0;
                    DOTCOUNTER = 0;
                    plus_counter = 0;
                    minus_counter = 0;
                    mult_counter = 0;
                    div_counter = 0;
                    operation_counter = 0;
                    number_counter = 0;


                    if(number.Equals(""))
                    {
                        if(operation.Equals("+"))
                        {
                            y = 0;
                            x = x + y;
                            number = Convert.ToString(x);
                            textBox1.Text = number;
                        }
                        else if(operation.Equals("-"))
                        {
                            if(x == 0)
                            {
                                textBox1.Text = "0";
                            }
                            else
                            {
                                x = -x;
                                number = Convert.ToString(x);
                                textBox1.Text = number;
                            }

                        }
                        else if(operation.Equals("*"))
                        {
                            y = x;
                            x = x * y;
                            number = Convert.ToString(x);
                            textBox1.Text = number;
                        }
                        else if(operation.Equals("/"))
                        {
                            if(x == 0)
                            {
                                textBox1.Text = "Math Error";
                                x = 0; y = 0; number = "";
                            }
                            else
                            {
                                y = 1;
                                x = x / y;
                                number = Convert.ToString(x);
                                textBox1.Text = number;
                            }
                        }
                    }
                    else
                    {
                        y = Double.Parse(textBox1.Text);

                        if(operation.Equals("+"))
                        {
                            x = x + y;
                            number = Convert.ToString(x);
                            textBox1.Text = number;
                        }
                        else if(operation.Equals("-"))
                        {
                            x = x - y;
                            number = Convert.ToString(x);
                            textBox1.Text = number;
                        }
                        else if(operation.Equals("*"))
                        {
                            x = x * y;
                            number = Convert.ToString(x);
                            textBox1.Text = number;
                        }
                        else if(operation.Equals("/"))
                        {
                            x = x / y;
                            number = Convert.ToString(x);
                            textBox1.Text = number;
                        }

                    }
                    if(number.Length != 0)
                    {
                        //number=Dot_fix(number);
                    }
                    else
                    {
                        number = "0";
                    }


                    if(operation.Equals("/") && y == 0)
                    {
                        textBox1.Text = "Math Error";
                        x = 0; y = 0; number = "";
                    }


                }
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Equals("Math Error"))
            {
              number = "";
              textBox1.Text= "0";
            }
        }


        private void buttonAC_Click(object sender, EventArgs e)
        {
            x = 0; y = 0;
            plus_counter = 0;
            minus_counter = 0;
            mult_counter = 0;
            div_counter = 0; equl_counter = 0;
            word = 0;
            number = ""; operation = ""; operation_lable.Text = "";
            DOTCOUNTER = 0; operation_counter = 0; number_counter = 0;
            textBox1.Text = "0";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if(DOTCOUNTER == 0 && !textBox1.Text.Equals("Math Error"))
            {
                if(number.Equals(""))
                {
                    number = "0";
                }
                if(equl_counter == 1)
                {
                    number = "0"; equl_counter = 0;
                }
                number = number + ".";
                textBox1.Text = number;
                DOTCOUNTER++;
            }
        }

        private void buttonMplus_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Equals("Math Error"))
            {
                double n = 0;
                String m = textBox1.Text;
                n = Double.Parse(m);
                memory = memory + n;
                if(memory!=0)
                {
                    memory_lable.Text = "M";
                }
                else
                {
                    memory_lable.Text = "";
                }
            }
        }

        private void buttonMmin_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Equals("Math Error"))
            {
                double n = 0;
                String m = textBox1.Text;
                n = Double.Parse(m);
                memory = memory - n;

                if(memory != 0)
                {
                    memory_lable.Text = "M";
                }
                else
                {
                    memory_lable.Text = "";
                }
            }
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Equals("Math Error"))
            {
                MR_counter = 1;

                String m = Convert.ToString(memory);
                textBox1.Text=m; number = m;

                plus_counter = 0;
                minus_counter = 0;
                mult_counter = 0;
                div_counter = 0; equl_counter = 0;
                operation_counter = 0;
            }
        }

        private void buttonMclear_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Equals("Math Error"))
            {
                memory = 0;
                memory_lable.Text = "";
            }
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Equals("0") && !textBox1.Text.Equals("Math Error"))
            {
                number = number.Substring(0, number.Length - 1);
                textBox1.Text = number;
                number_counter--; DOTCOUNTER = 0;
            }
            if(number.Length == 0 && !textBox1.Text.Equals("Math Error"))
            {
                textBox1.Text="0";
            }
        }

       

        private void plusMinus_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Equals("Math Error"))
            {
                String r;
                if(number[0] == '-')
                {
                    r = number.Substring(1, number.Length);
                }
                else
                {
                    r = "-" + number;
                }
                number = r;
                textBox1.Text= number;
            }
        }


        public int newWidth()
        {
            return (55 * this.Width) / 304;
        }
        public int newHeight()
        {
            return (42*this.Height) / 465;
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            buttonAC.Width = newWidth();
            buttonAC.Height = newHeight();
            buttonAC.Left = (25 * this.Width) / 304;
            buttonAC.Top = (83 * this.Height) / 465;
            buttonAC.Font = new Font(buttonAC.Font.Name, 14 * this.Height / 465, buttonAC.Font.Style);

            buttonCE.Width = newWidth();
            buttonCE.Height = newHeight();
            buttonCE.Left = (86 * this.Width) / 304;
            buttonCE.Top = (83 * this.Height) / 465;
            buttonCE.Font = new Font(buttonCE.Font.Name, 14 * this.Height / 465, buttonCE.Font.Style);

            plusMinus.Width = newWidth();
            plusMinus.Height = newHeight();
            plusMinus.Left = (147 * this.Width) / 304;
            plusMinus.Top = (83 * this.Height) / 465;
            plusMinus.Font = new Font(plusMinus.Font.Name, 14 * this.Height / 465, plusMinus.Font.Style);

            backspace.Width = newWidth();
            backspace.Height = newHeight();
            backspace.Left = (208 * this.Width) / 304;
            backspace.Top = (83 * this.Height) / 465;
            backspace.Font = new Font(backspace.Font.Name, 14 * this.Height / 465, backspace.Font.Style);
        

            buttonMplus.Width = newWidth();
            buttonMplus.Height = newHeight();
            buttonMplus.Left = (25 * this.Width) / 304;
            buttonMplus.Top = (138 * this.Height) / 465;
            buttonMplus.Font = new Font(buttonMplus.Font.Name, 14 * this.Height / 465, buttonMplus.Font.Style);

            buttonMmin.Width = newWidth();
            buttonMmin.Height = newHeight();
            buttonMmin.Left = (86 * this.Width) / 304;
            buttonMmin.Top = (138 * this.Height) / 465;
            buttonMmin.Font = new Font(buttonMmin.Font.Name, 14 * this.Height / 465, buttonMmin.Font.Style);

            buttonMR.Width = newWidth();
            buttonMR.Height = newHeight();
            buttonMR.Left = (147 * this.Width) / 304;
            buttonMR.Top = (138 * this.Height) / 465;
            buttonMR.Font = new Font(buttonMR.Font.Name, 14 * this.Height / 465, buttonMR.Font.Style);

            buttonMclear.Width = newWidth();
            buttonMclear.Height = newHeight();
            buttonMclear.Left = (208 * this.Width) / 304;
            buttonMclear.Top = (138 * this.Height) / 465;
            buttonMclear.Font = new Font(buttonMclear.Font.Name, 14 * this.Height / 465, buttonMclear.Font.Style);



            button7.Width = newWidth();
            button7.Height = newHeight();
            button7.Left = (25 * this.Width) / 304;
            button7.Top = (195 * this.Height) / 465;
            button7.Font = new Font(button7.Font.Name, 14 * this.Height / 465, button7.Font.Style);

            button8.Width = newWidth();
            button8.Height = newHeight();
            button8.Left = (86 * this.Width) / 304;
            button8.Top = (195 * this.Height) / 465;
            button8.Font = new Font(button8.Font.Name, 14 * this.Height / 465, button8.Font.Style);

            button9.Width = newWidth();
            button9.Height = newHeight();
            button9.Left = (147 * this.Width) / 304;
            button9.Top = (195 * this.Height) / 465;
            button9.Font = new Font(button9.Font.Name, 14 * this.Height / 465, button9.Font.Style);

            buttonDiv.Width = newWidth();
            buttonDiv.Height = newHeight();
            buttonDiv.Left = (208 * this.Width) / 304;
            buttonDiv.Top = (195 * this.Height) / 465;
            buttonDiv.Font = new Font(buttonDiv.Font.Name, 14 * this.Height / 465, buttonDiv.Font.Style);


            button4.Width = newWidth();
            button4.Height = newHeight();
            button4.Left = (25 * this.Width) / 304;
            button4.Top = (252 * this.Height) / 465;
            button4.Font = new Font(button4.Font.Name, 14 * this.Height / 465, button4.Font.Style);

            button5.Width = newWidth();
            button5.Height = newHeight();
            button5.Left = (86 * this.Width) / 304;
            button5.Top = (252 * this.Height) / 465;
            button5.Font = new Font(button5.Font.Name, 14 * this.Height / 465, button5.Font.Style);

            button6.Width = newWidth();
            button6.Height = newHeight();
            button6.Left = (147 * this.Width) / 304;
            button6.Top = (252 * this.Height) / 465;
            button6.Font = new Font(button6.Font.Name, 14 * this.Height / 465, button6.Font.Style);

            buttonMul.Width = newWidth();
            buttonMul.Height = newHeight();
            buttonMul.Left = (208 * this.Width) / 304;
            buttonMul.Top = (252 * this.Height) / 465;
            buttonMul.Font = new Font(buttonMul.Font.Name, 14 * this.Height / 465, buttonMul.Font.Style);


            button1.Width = newWidth();
            button1.Height = newHeight();
            button1.Left = (25 * this.Width) / 304;
            button1.Top = (309 * this.Height) / 465;
            button1.Font = new Font(button1.Font.Name, 14 * this.Height / 465, button1.Font.Style);

            button2.Width = newWidth();
            button2.Height = newHeight();
            button2.Left = (86 * this.Width) / 304;
            button2.Top = (309 * this.Height) / 465;
            button2.Font = new Font(button2.Font.Name, 14 * this.Height / 465, button2.Font.Style);

            button3.Width = newWidth();
            button3.Height = newHeight();
            button3.Left = (147 * this.Width) / 304;
            button3.Top = (309 * this.Height) / 465;
            button3.Font = new Font(button3.Font.Name, 14 * this.Height / 465, button3.Font.Style);

            buttonMin.Width = newWidth();
            buttonMin.Height = newHeight();
            buttonMin.Left = (208 * this.Width) / 304;
            buttonMin.Top = (309 * this.Height) / 465;
            buttonMin.Font = new Font(buttonMin.Font.Name, 14 * this.Height / 465, buttonMin.Font.Style);


            button0.Width = newWidth();
            button0.Height = newHeight();
            button0.Left = (25 * this.Width) / 304;
            button0.Top = (366 * this.Height) / 465;
            button0.Font = new Font(button0.Font.Name, 14 * this.Height / 465, button0.Font.Style);

            buttonDot.Width = newWidth();
            buttonDot.Height = newHeight();
            buttonDot.Left = (86 * this.Width) / 304;
            buttonDot.Top = (366 * this.Height) / 465;
            buttonDot.Font = new Font(buttonDot.Font.Name, 14 * this.Height / 465, buttonDot.Font.Style);

            buttonEq.Width = newWidth();
            buttonEq.Height = newHeight();
            buttonEq.Left = (147 * this.Width) / 304;
            buttonEq.Top = (366 * this.Height) / 465;
            buttonEq.Font = new Font(buttonEq.Font.Name, 14 * this.Height / 465, buttonEq.Font.Style);

            buttonPs.Width = newWidth();
            buttonPs.Height = newHeight();
            buttonPs.Left = (208 * this.Width) / 304;
            buttonPs.Top = (366 * this.Height) / 465;
            buttonPs.Font = new Font(buttonPs.Font.Name, 14 * this.Height / 465, buttonPs.Font.Style);

            textBox1.Width=(238*this.Width)/304;
            textBox1.Height=(60*this.Height)/465;
            textBox1.Left = (25 * this.Width) / 304;
            textBox1.Top = (12 * this.Height) / 465;
            textBox1.Font = new Font(textBox1.Font.Name, 18 * this.Height / 465, textBox1.Font.Style);
            
            operation_lable.Width=(21*this.Width)/304;
            operation_lable.Height = (22 * this.Height) / 465;
            operation_lable.Left = (240 * this.Width) / 304;
            operation_lable.Top = (48 * this.Height) / 465;
            operation_lable.Font = new Font(operation_lable.Font.Name, 8 * this.Height / 465, operation_lable.Font.Style);

            memory_lable.Width=(16*this.Width)/304;
            memory_lable.Height = (16 * this.Height) / 465;
            memory_lable.Left = (28 * this.Width) / 304;
            memory_lable.Top = (50 * this.Height) / 465;
            memory_lable.Font = new Font(memory_lable.Font.Name, 8 * this.Height / 465, memory_lable.Font.Style);






        }
       

        

        
    }
}
