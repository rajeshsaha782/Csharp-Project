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
    public partial class Accounce : Form
    {
        
        Manager_Homepage mn;
        public Accounce(Manager_Homepage mn)
        {
            InitializeComponent();
            this.mn = mn;
            if (BLogin.Ban == 1)
            {
                label2.Text = "হিসাব নিকাশ";
                CalculateMealRatetton1.Text = "খাদ্য মূল্যহার গণনা";
                AddBalance.Text = "ব্যাল্যান্স যোগ/বিয়োগ";
                CheckBalance.Text = "চেক ব্যাল্যান্স";
                TotalCalculation.Text = "মোট গণনা";
                BazarCost.Text = "বাজার মূল্য";
                ldLabel.Text = "আইডি";
                IdMessage.Text = "শূন্য ঘর পূরণ করুন";
                Enter.Text = "ইন্টার";
                back.Text = "ফেরত";
                logout.Text = "লগ আউট";
                this.Text = "অ্যাকাউন্স";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mn.Show();
        }
        private void SetVisibleFalse()
        {

            IdText.Visible = false;
            ldLabel.Visible = false;
            Enter.Visible = false;
            IdMessage.Visible = false;
        }
        public double calMealRate()
        {
            BachelorDataContext bdc = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");

            var x = from a in bdc.Balances
                    select a;
            int tc = x.FirstOrDefault().totalCost;

            int totalNumberOfMeal = 0;

            var y = from a in bdc.Accounts
                    select a;
            foreach (var b in y)
            {
                totalNumberOfMeal += b.totalNumberOfMeal;
            }
            if (totalNumberOfMeal == 0)
            {
                return 0;
            }
            else
            {
                double mealRate = Convert.ToDouble(tc) / Convert.ToDouble(totalNumberOfMeal);
                return mealRate;
            }
            
        }

        private void CalculateMealRatetton1_Click(object sender, EventArgs e)
        {
            SetVisibleFalse();

            double mealRate = calMealRate();
            MessageBox.Show(String.Format("{0:F3}", mealRate));

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            BLogin l = new BLogin();
            l.Show();
        }

        private void AddBalance_Click(object sender, EventArgs e)
        {
            SetVisibleFalse();
            Add_Balance a = new Add_Balance(this);
            this.Hide();
            a.Show();
        }

        private void CheckBalance_Click(object sender, EventArgs e)
        {
            ldLabel.Text = "Id";
            IdText.Visible = true;
            ldLabel.Visible = true;
            Enter.Visible = true;
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            BachelorDataContext bdc = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");
            if(ldLabel.Text.Equals("Id"))
            {
                if(IdText.Text.Equals(""))
                {
                    IdMessage.Visible = true;
                }
                else
                {
                    try
                    {

                        double mealRate = calMealRate();
                        

                        var x = from a in bdc.Accounts
                                where a.id.Equals(IdText.Text)
                                select a;
                        int currentBalance=(x.FirstOrDefault().balance)-Convert.ToInt32(Convert.ToDouble(x.FirstOrDefault().totalNumberOfMeal)*mealRate);
                        IdMessage.Visible = false;
                        MessageBox.Show("Initial Balance is " + Convert.ToString(x.FirstOrDefault().balance) + "\r\nCurrent Balance: " + Convert.ToString(currentBalance));
                    }

                    catch(NullReferenceException)
                    {
                        MessageBox.Show("Invalid Id");
                    }
                    catch(FormatException)
                    {
                        MessageBox.Show("Invalid format");
                    }
                }
            }
            else
            {
                if(IdText.Equals(""))
                {
                    IdMessage.Text = "*Fill Cost";
                }

                else
                {
                    try
                    {
                        if(bdc.Balances.FirstOrDefault().totalBalance >= Convert.ToInt32(IdText.Text))
                        {
                            bdc.Balances.FirstOrDefault().totalCost = bdc.Balances.FirstOrDefault().totalCost + Convert.ToInt32(IdText.Text);
                            bdc.Balances.FirstOrDefault().totalBalance = bdc.Balances.FirstOrDefault().totalBalance - Convert.ToInt32(IdText.Text);
                            //var x = from a in bdc.Balances
                            //        where a.id==1
                            //        select a;
                            //x.FirstOrDefault().totalCost = x.FirstOrDefault().totalCost + Convert.ToInt32(IdText.Text);
                            //Balance b = bdc.Balances.SingleOrDefault(y => y.id == 1);
                            //b.totalCost = b.totalCost + Convert.ToInt32(IdText.Text);
                            //bdc.SubmitChanges();
                            MessageBox.Show("Succesful");
                        }
                        else
                        {
                            MessageBox.Show("Balance is below " + IdText.Text);
                        }

                    }
                    catch(Exception)
                    {
                        IdMessage.Text = "*Invalid Input";

                    }
                }



                bdc.SubmitChanges();



            }

            
        }

        

        private void BazarCost_Click(object sender, EventArgs e)
        {
            IdText.Visible = true;
            ldLabel.Visible = true;
            Enter.Visible = true;
            IdMessage.Visible = false;
            ldLabel.Text = "Cost";
           
        }

        private void TotalCalculation_Click(object sender, EventArgs e)
        {
            Total_Calculation t = new Total_Calculation(mn);
            this.Hide();
            t.Show();
        }

        private void Accounce_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

      
    }
}
