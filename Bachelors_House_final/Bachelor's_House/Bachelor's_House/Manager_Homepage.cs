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
    public partial class Manager_Homepage : Form
    {
        BLogin l;
        string id;

        public Manager_Homepage()
        {
            InitializeComponent();
        }
        public Manager_Homepage(BLogin l,string id)
        {
            InitializeComponent();
            this.l = l;
            this.id = id;
            if (BLogin.Ban == 1)
            {
                label3.Text = "ম্যানেজার হোম পেজ";
                viewProfile.Text = "প্রোফাইল দেখুন";
                Add_member.Text = "নতুন মেম্বার যোগ";
                add_manager.Text = "নতুন ম্যানেজার যোগ";
                Modify_info.Text = "মেম্বার খুজুন";
                member_List.Text = "মেম্বার তালিকা";
                mealList.Text = "খাদ্য তালিকা";
                accounce.Text = "হিসাব নিকাশ";
                back.Text = "ফেরত";
                logout.Text = "লগ আউট";
                this.Text = "ম্যানেজার হোম পেজ";
            }

        }

        private void Add_member_Click(object sender, EventArgs e)
        {

            this.Hide();
            Member_Registration mr = new Member_Registration(this,id,0);
            mr.Show();
        }

        private void Modify_info_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search_Member sm = new Search_Member(this,id);
            sm.Show();
        }
        private void viewProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile p = new Profile(this,id);
            p.Show();
        }
        private void member_List_Click(object sender, EventArgs e)
        {
            this.Hide();
            Member_List m = new Member_List(this);
            m.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            l.show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            l.show();
        }

        private void accounce_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accounce a = new Accounce(this);
            a.Show();
        }

        private void mealList_Click(object sender, EventArgs e)
        {
            Meal_List ml = new Meal_List(this);
            this.Hide();
            ml.Show();
        }

        private void Manager_Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void add_manager_Click(object sender, EventArgs e)
        {
            this.Hide();
            Member_Registration mr = new Member_Registration(this, id,1);
            mr.Show();
        }

        

        


        
    }
}
