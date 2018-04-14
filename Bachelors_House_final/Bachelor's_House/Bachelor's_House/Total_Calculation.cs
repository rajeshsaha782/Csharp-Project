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
    public partial class Total_Calculation : Form
    {
        Manager_Homepage mn;
        public Total_Calculation(Manager_Homepage mn)
        {
            InitializeComponent();
            this.mn=mn;
            if (BLogin.Ban == 1)
            {
                TotalCost.Text = "মোট খরচ";
                this.Text = "পূর্ণ গণনা";
                TotalMeal.Text = "মোট খাবার";
                MealRate.Text = "খাদ্য মূল্য হার";
                Back.Text = "ফেরত";
                Logout.Text = "লগ আউট";
            }
        }

        private void Total_Calculation_Load(object sender, EventArgs e)
        {
            BachelorDataContext bdc = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");
            //total cost

            var x = from a in bdc.Balances
                    select a;
            int tc = x.FirstOrDefault().totalCost;

            //total number of meal

            int totalNumberOfMeal = 0;

            var y = from a in bdc.Accounts
                    select a;
            foreach (var b in y)
            {
                totalNumberOfMeal += b.totalNumberOfMeal;
            }
            double mealRate;
            if (totalNumberOfMeal == 0)
            {
                mealRate=0;
            }
            //meal rate
            else{
                mealRate = Convert.ToDouble(tc) / Convert.ToDouble(totalNumberOfMeal);
            }
            
            TotalCost.Text = "Total Cost: " + Convert.ToString(bdc.Balances.FirstOrDefault().totalCost);
            TotalMeal.Text = "Total Meal: " + Convert.ToString(totalNumberOfMeal);
            MealRate.Text = "Meal Rate: " + String.Format("{0:F3}", mealRate);

            var z = from a in bdc.Accounts
                    select a;

            foreach (var a in z)
            {
                var ac = from b in bdc.Accounts
                         where b.id.Equals(a.id)
                         select b;

                int Cost = (int)((float)(ac.FirstOrDefault().totalNumberOfMeal) * mealRate);
                int Balance = ac.FirstOrDefault().balance - Cost;
                var p = from c in bdc.Members
                        where c.id.Equals(a.id)
                        select c;
                string name = p.FirstOrDefault().name;
                TotalCal tcn = new TotalCal
                {
                    Id = a.id,
                    Name = name,

                    NumberOfMeal = ac.FirstOrDefault().totalNumberOfMeal,
                    Deposit = ac.FirstOrDefault().balance,
                    Cost = Cost,
                    Balance = Balance

                };
                bdc.TotalCals.InsertOnSubmit(tcn);
            }
            bdc.SubmitChanges();

            TotalData.DataSource = bdc.TotalCals;
        }

        private void Total_Calculation_FormClosing(object sender, FormClosingEventArgs e)
        {
            BachelorDataContext bdc = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");
            bdc.TotalCals.DeleteAllOnSubmit(bdc.TotalCals);
            bdc.SubmitChanges();
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            BachelorDataContext bdc = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");

            bdc.TotalCals.DeleteAllOnSubmit(bdc.TotalCals);
            bdc.SubmitChanges();
            Accounce a = new Accounce(mn);
            a.Show();
            this.Hide();
            //this.Close();
            //this.Dispose();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            BLogin b = new BLogin();
            this.Dispose();
            b.Show();
        }

       
    }
}
