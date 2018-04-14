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
    public partial class Search_Member : Form
    {
        Manager_Homepage h; string sid;
        public Search_Member()
        {
            InitializeComponent();
        }
        public Search_Member(Manager_Homepage h,string sid)
        {
            InitializeComponent();
            this.h = h;
            this.sid = sid;
            if (BLogin.Ban == 1)
            {
                label11.Text = "অনুসন্ধান";
                this.Text = "অনুসন্ধান";
                label2.Text = "আইডি";
                search.Text = "অনুসন্ধান";
                modify.Text = "পরিবর্তন";
                delete.Text = "মুছে ফেলা";
                back.Text = "ফেরত";
            }
        }
        private void modify_Click(object sender, EventArgs e)
        {
            BachelorDataContext b = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");
            if(!id.Text.Equals(""))
            {
                try
                {
                    var x = from a in b.Members
                            where a.id == int.Parse(id.Text)
                            select a;

                
                    Modify_Information mi = new Modify_Information(this,sid,id.Text);
                    this.Hide();
                    mi.Show();
                    b.Dispose();
                }
                catch(Exception)
                {
                    MessageBox.Show("Id Not found");
                }
            }
            else
            {
                MessageBox.Show("Fill the id section");

            }
            

        }

        private void delete_Click(object sender, EventArgs e)
        {
            BachelorDataContext b = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");

            if(!id.Text.Equals(""))
            {
                if(id.Text!=sid)
                {
                    try
                    {
                        Member m = b.Members.SingleOrDefault(x => x.id == int.Parse(id.Text));
                        
                        if (m.type == 0)
                        {
                            Account ac = b.Accounts.SingleOrDefault(y => y.id == int.Parse(id.Text));
                            MealList ml = b.MealLists.SingleOrDefault(z => z.id == int.Parse(id.Text));

                            b.Accounts.DeleteOnSubmit(ac);
                            b.MealLists.DeleteOnSubmit(ml);
                        }
                        b.Members.DeleteOnSubmit(m);
                        b.SubmitChanges();
                        MessageBox.Show("Member successfully Deleted");

                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Id Not found");
                    }
                }
                else
                {
                    MessageBox.Show("দুঃখিত! আপনি নিজের আইডি মুছে ফেলতে পারবেন না");
                }
            }
            else
            {
                MessageBox.Show("Fill the id section");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            h.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            BachelorDataContext b = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");
            if(!id.Text.Equals(""))
            {
                try
                {
                    var x = from a in b.Members
                            where a.id == int.Parse(id.Text)
                            select a;


                    Profile p = new Profile(this,id.Text);
                    this.Hide();
                    p.Show();
                    b.Dispose();
                }
                catch(Exception)
                {
                    MessageBox.Show("Id Not found");
                }
            }
            else
            {
                MessageBox.Show("Fill the id section");

            }
        }
        

        private void Search_Member_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
