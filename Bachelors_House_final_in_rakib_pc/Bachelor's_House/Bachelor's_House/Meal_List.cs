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
    public partial class Meal_List : Form
    {
        Manager_Homepage mn;
        public Meal_List(Manager_Homepage mn)
        {
            InitializeComponent();
            this.mn = mn;
            if (BLogin.Ban == 1)
            {
                label2.Text = "খাদ্য তালিকা";
                this.Text = "খাদ্য তালিকা";
                back.Text = "ফেরত";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mn.Show();
        }

        private void Meal_List_Load(object sender, EventArgs e)
        {
            BachelorDataContext b = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");

            var x=from a in b.MealLists
                  select new {a.id,a.dailyMeal};
            mealListGrid.DataSource = x.ToList();
        }

        private void Meal_List_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
