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
    public partial class Member_Homepage : Form
    {
        BLogin l; string mhid;
        public Member_Homepage(BLogin l,string mhid)
        {
            InitializeComponent();
            this.l = l;
            this.mhid = mhid;
            if (BLogin.Ban == 1)
            {
                label3.Text = "মেম্বার হোম পেজ";
                this.Text = "মেম্বার হোম পেজ";
                label1.Text = "খাদ্য";
                clearMeal.Text = "খাদ্য মুছা";
                viewProfile.Text = "প্রোফাইল দেখুন";
                change_Password.Text = "পাসওয়ার্ড পরিবর্তন";
                member_List.Text = "মেম্বার তালিকা";
                check_Meal_Info.Text = "খাদ্য তথ্য চেক";
                checkBalance.Text = "ব্যাল্যান্স চেক";
                back.Text = "ফেরত";
                logout.Text = "লগ আউট";
            }
        }
        public Member_Homepage(string mhid)
        {
            InitializeComponent();
            this.mhid = mhid;
            if (BLogin.Ban == 1)
            {
                label3.Text = "মেম্বার হোম পেজ";
                this.Text = "মেম্বার হোম পেজ";
                label1.Text = "খাদ্য";
                clearMeal.Text = "খাদ্য মুছা";
                viewProfile.Text = "প্রোফাইল দেখুন";
                change_Password.Text = "পাসওয়ার্ড পরিবর্তন";
                member_List.Text = "মেম্বার তালিকা";
                check_Meal_Info.Text = "খাদ্য তথ্য চেক";
                checkBalance.Text = "ব্যাল্যান্স চেক";
                back.Text = "ফেরত";
                logout.Text = "লগ আউট";
            }
        }
        private void viewProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile p = new Profile(this, mhid);
            p.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            l.show();
        }

        private void member_List_Click(object sender, EventArgs e)
        {
            this.Hide();
            Member_List m = new Member_List(this);
            m.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            l.show();
        }

        private void change_Password_Click(object sender, EventArgs e)
        {
            this.Hide();
            Change_Password cp = new Change_Password(this, mhid);
            cp.Show();
        }

        private void addMeal_Click(object sender, EventArgs e)
        {
            if (!mealText.Text.Equals(""))
            {
                BachelorDataContext b = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");
                var x = from a in b.MealLists
                        where mhid.Equals(a.id)
                        select a;

                if (x.FirstOrDefault().id == null)
                {
                    x.FirstOrDefault().dailyMeal = 0;

                }

                x.FirstOrDefault().dailyMeal += Convert.ToInt32(mealText.Text);
                b.SubmitChanges();
                var y = from a in b.Accounts
                        where mhid.Equals(a.id)
                        select a;
                y.FirstOrDefault().totalNumberOfMeal += Convert.ToInt32(mealText.Text);
                b.SubmitChanges();
                MessageBox.Show("Succesfully Added.And now your meal number is " + (x.FirstOrDefault().dailyMeal));
            }
            else
            {
                MessageBox.Show("Put your Meal!");
            }
        }

        private void deduct_Click(object sender, EventArgs e)
        {
            if (!mealText.Text.Equals(""))
            {
                BachelorDataContext b = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");
                var x = from a in b.MealLists
                        where mhid.Equals(a.id)
                        select a;
                if (x.FirstOrDefault().id == null)
                {
                    x.FirstOrDefault().dailyMeal = 0;

                }
                if (x.FirstOrDefault().dailyMeal >= Convert.ToInt32(mealText.Text))
                {
                    x.FirstOrDefault().dailyMeal -= Convert.ToInt32(mealText.Text);
                    b.SubmitChanges();
                    MessageBox.Show("Succesfully Deducted.And now your meal number is " + (x.FirstOrDefault().dailyMeal));
                }
                else
                {
                    MessageBox.Show("Your Existing meal number is below " + mealText.Text + ". And now your meal number is " + (x.FirstOrDefault().dailyMeal));
                }


                var y = from a in b.Accounts
                        where mhid.Equals(a.id)
                        select a;
                y.FirstOrDefault().totalNumberOfMeal -= Convert.ToInt32(mealText.Text);
                b.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Put your Meal!");
            }
        }

        private void checkBalance_Click(object sender, EventArgs e)
        {
            BachelorDataContext bdc = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");



            double mealRate;


            var x = from a in bdc.Balances
                    select a;
            int tc = x.FirstOrDefault().totalCost;

            int totalNumberOfMeal = 0;

            var y = from b in bdc.Accounts
                    select b;
            foreach (var b in y)
            {
                totalNumberOfMeal += b.totalNumberOfMeal;
            }
            if (totalNumberOfMeal == 0)
            {
                mealRate=0;

            }
            else
            {
                mealRate = Convert.ToDouble(tc) / Convert.ToDouble(totalNumberOfMeal);
                
            }

            var z = from a in bdc.Accounts
                        where a.id.Equals(mhid)
                        select a;
                int currentBalance = (z.FirstOrDefault().balance) - Convert.ToInt32(Convert.ToDouble(z.FirstOrDefault().totalNumberOfMeal) * mealRate);
                MessageBox.Show("Initial Balance is " + Convert.ToString(z.FirstOrDefault().balance) + "\r\nCurrent Balance: " + Convert.ToString(currentBalance));
            

            
            
            

        }

        private void clearMeal_Click(object sender, EventArgs e)
        {
            BachelorDataContext b = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");
            var x = from a in b.MealLists
                    where mhid.Equals(Convert.ToString(a.id))
                    select a;
            x.FirstOrDefault().dailyMeal = 0;
            MessageBox.Show("Cleared");
            b.SubmitChanges();

        }

        private void check_Meal_Info_Click(object sender, EventArgs e)
        {
            BachelorDataContext b = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");
            ///Total Meal and initial balace

            var z = from a in b.Accounts
                    where a.id==Convert.ToInt32(mhid)
                    select a;

            //Meal Rate
            var x = from a in b.Balances
                    select a;
            int tc = x.FirstOrDefault().totalCost;

            int totalNumberOfMeal = 0;

            var y = from a in b.Accounts
                    select a;
            foreach (var c in y)
            {
                totalNumberOfMeal += c.totalNumberOfMeal;
            }
            if (totalNumberOfMeal == 0)
            {
                totalNumberOfMeal = 1;
            }
            double mealRate = Convert.ToDouble(tc) / Convert.ToDouble(totalNumberOfMeal);


            double remainBalance=Convert.ToDouble(z.FirstOrDefault().totalNumberOfMeal)*mealRate;
            MessageBox.Show("Total Meal: " + z.FirstOrDefault().totalNumberOfMeal + "\r\nMeal Rate: " + String.Format("{0:F3}", mealRate) + "\r\nInitial Balance: " + z.FirstOrDefault().balance + "\r\nRemaining Balance: " + Convert.ToString(z.FirstOrDefault().balance - (Convert.ToInt32(remainBalance))));
        }

        private void Member_Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
