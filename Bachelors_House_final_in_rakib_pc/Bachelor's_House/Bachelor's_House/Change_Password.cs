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
    public partial class Change_Password : Form
    {
        Member_Homepage mh;
        string cid;
        public Change_Password(Member_Homepage mh,string cid)
        {
            InitializeComponent();
            this.mh = mh;
            this.cid = cid;
            if (BLogin.Ban == 1)
            {
                label3.Text = "পাসওয়ার্ড পরিবর্তন";
                old_Pass.Text = "পুরনো পাসওয়ার্ড";
                new_Pass.Text = "নতুন পাসওয়ার্ড";
                confirm_Pass.Text = "পাসওয়ার্ড নিশ্চিতকরন";
                back.Text = "ফেরত";
                confirm.Text = "নিশ্চিত";
                this.Text = "পাসওয়ার্ড পরিবর্তন";
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            BachelorDataContext b = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");

            if(!o_Pass.Text.Equals("")&&!n_Pass.Text.Equals("")&&!c_Pass.Text.Equals(""))
            {
                var x = from a in b.Members
                        where a.id == int.Parse(cid)
                        select a;

                if(x.First().password == o_Pass.Text)
                {
                    if(n_Pass.Text.Equals(c_Pass.Text))
                    {
                         Member m = b.Members.SingleOrDefault(y => y.id == int.Parse(cid));
                        m.password = n_Pass.Text;
                        b.SubmitChanges();
                        MessageBox.Show("Password Changed");

                    }
                    else
                    {
                        MessageBox.Show("New Password and Confirmed Password didn't match");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("Fill all the Blanks");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mh.Show();
        }

        private void Change_Password_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
