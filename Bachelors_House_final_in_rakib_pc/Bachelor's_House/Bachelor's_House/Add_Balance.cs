using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bachelor_s_House
{
    public partial class Add_Balance : Form
    {
        Accounce a;
        public Add_Balance(Accounce a)
        {
            InitializeComponent();
            this.a = a;
            if (BLogin.Ban == 1)
            {
                label3.Text = "ব্যাল্যান্স যোগ/বিয়োগ";
                label2.Text = "আইডি";
                IdMessage.Text = "শূন্য ঘর পূরণ করুন";
                label1.Text = "পরিমাণ";
                Add.Text = "যোগ";
                back.Text = "ফেরত";
                Deduct.Text = "বিয়োগ";
                this.Text = "ব্যাল্যান্স যোগ/বিয়োগ";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            a.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            BachelorDataContext bdc = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");

            if(Id.Text.Equals(""))
            {
                IdMessage.Visible = true; ;
                IdMessage.Text = "*Please fill up your id";
            }
            else
            {
                IdMessage.Visible = false;
                try
                {
                    var x = from a in bdc.Accounts
                            where a.id.Equals(Id.Text)
                            select a;
                    x.FirstOrDefault().balance = Convert.ToInt32(Amount.Text) + x.FirstOrDefault().balance;
                    bdc.Balances.FirstOrDefault().totalBalance = bdc.Balances.FirstOrDefault().totalBalance + Convert.ToInt32(Amount.Text);
                    bdc.SubmitChanges();
                    MessageBox.Show("Successfully Added");
                    Id.Text = "";
                    Amount.Text = "";

                }
                catch(NullReferenceException)
                {
                    MessageBox.Show("Invalid Id");
                }
                catch(FormatException)
                {
                    MessageBox.Show("Invalid amount or format");
                }


            }
        }

        private void Deduct_Click(object sender, EventArgs e)
        {
            BachelorDataContext bdc = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");

            if(Id.Text.Equals(""))
            {
                IdMessage.Visible = true; ;
                IdMessage.Text = "*Please fill up your id";
            }
            else
            {
                IdMessage.Visible = false;
                try
                {
                    var x = from a in bdc.Accounts
                            where a.id.Equals(Id.Text)
                            select a;
                    if(x.FirstOrDefault().balance >= Convert.ToInt32(Amount.Text))
                    {

                        if(bdc.Balances.FirstOrDefault().totalBalance >= Convert.ToInt32(Amount.Text))
                        {
                            x.FirstOrDefault().balance = -Convert.ToInt32(Amount.Text) + x.FirstOrDefault().balance;
                            bdc.Balances.FirstOrDefault().totalBalance = bdc.Balances.FirstOrDefault().totalBalance - Convert.ToInt32(Amount.Text);
                            MessageBox.Show("Successfully Deducted");
                            Id.Text = "";
                            Amount.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Insufficient Balance");
                        }

                        bdc.SubmitChanges();

                    }
                    else
                    {
                        MessageBox.Show("Amount is below " + Amount.Text);
                    }


                }
                catch(NullReferenceException)
                {
                    MessageBox.Show("Invalid Id");
                }
                catch(FormatException)
                {
                    MessageBox.Show("Invalid amount or format");
                }


            }
        }

        private void Add_Balance_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
