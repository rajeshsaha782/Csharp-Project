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
    public partial class Profile : Form
    {
        BachelorDataContext b = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");
        Manager_Homepage h; string pid;
        int type;
        Member_Homepage mh;
        Search_Member s;
        public Profile(Search_Member s,String sid)
        {
            InitializeComponent();
            this.s = s;
            type = 3;
            pid = sid;
            if (BLogin.Ban == 1)
            {
                label11.Text = "প্রোফাইল";
                this.Text = "প্রোফাইল";
                label2.Text = "আইডি";
                label1.Text = "নাম";
                label3.Text = "সংগঠন";
                label4.Text = "ফোন";
                label5.Text = "ই-মেইল";
                label6.Text = "ঠিকানা";
                label7.Text = "বাবার নাম";
                label8.Text = "বাবার ফোন";
                label9.Text = "পাসওয়ার্ড";
                label10.Text = "যোগদান তারিখ";
                back.Text = "ফেরত";
                modify.Text = "পরিবর্তন";
            }

            modify.Visible = true;

            ppp();

        }
        public Profile(Manager_Homepage h,string pid)
        {
            InitializeComponent();
            this.h = h;
            this.pid=pid;
            type = 1;
            if (BLogin.Ban == 1)
            {
                label11.Text = "প্রোফাইল";
                this.Text = "প্রোফাইল";
                label2.Text = "আইডি";
                label1.Text = "নাম";
                label3.Text = "সংগঠন";
                label4.Text = "ফোন";
                label5.Text = "ই-মেইল";
                label6.Text = "ঠিকানা";
                label7.Text = "বাবার নাম";
                label8.Text = "বাবার ফোন";
                label9.Text = "পাসওয়ার্ড";
                label10.Text = "যোগদান তারিখ";
                back.Text = "ফেরত";
                modify.Text = "পরিবর্তন";
            }

            ppp();

        }
        public Profile(Member_Homepage mh, string pid)
        {
            InitializeComponent();
            this.mh = mh;
            this.pid = pid;
            type = 0;

            ppp();

        }
        public void ppp()
        {
            BachelorDataContext c = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");

            var x = from a in c.Members
                    where a.id == int.Parse(pid)
                    select a;

            id.Text = Convert.ToString(x.First().id);
            name.Text = x.First().name;
            org.Text = x.First().organization;
            phn.Text = x.First().personal_phone;
            email.Text = x.First().email;
            address.Text = x.First().address;
            f_name.Text = x.First().father_name;
            f_phn.Text = x.First().father_phone;
            j_date.Text = (Convert.ToString(x.First().joinning_date)).Substring(0, 9);
            pass.Text = x.First().password;
        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(type == 1)
            {
                h.Show();
            }
            else if(type==3)
            {
                modify.Visible = false;
                s.Show();
            }
            else
            {
                mh.Show();
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


                    Modify_Information mi = new Modify_Information(this, pid, id.Text);
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

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
      

       
    }
}
