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
    public partial class Modify_Information : Form
    {
        Search_Member s; string smid;
        Profile p; int type;
        BachelorDataContext b = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");

        public Modify_Information(Search_Member s,string smid,string i)
        {
            InitializeComponent();
            this.s = s;
            this.smid = smid;
            type = 0;
            if (BLogin.Ban == 1)
            {
                label11.Text = "তথ্য পরিবর্তন";
                this.Text = "তথ্য পরিবর্তন";
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
                confirm.Text = "নিশ্চিত";
            }

            var x = from a in b.Members
                    where a.id == int.Parse(i)
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

            b.SubmitChanges();


        }
        public Modify_Information(Profile p, string smid, string i)
        {
            InitializeComponent();
            this.p = p;
            this.smid = smid;
            type = 1;
            if (BLogin.Ban == 1)
            {
                label11.Text = "তথ্য পরিবর্তন";
                this.Text = "তথ্য পরিবর্তন";
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
                confirm.Text = "নিশ্চিত";
            }

            var x = from a in b.Members
                    where a.id == int.Parse(i)
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

            b.SubmitChanges();


        }

        private void confirm_Click(object sender, EventArgs e)
        {
            BachelorDataContext b = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");

            Member m = b.Members.SingleOrDefault(x=>x.id==int.Parse(id.Text));

            if(id.Text != string.Empty && name.Text != string.Empty && org.Text != string.Empty && phn.Text != string.Empty && email.Text != string.Empty && address.Text != string.Empty && f_name.Text != string.Empty && f_phn.Text != string.Empty && pass.Text != string.Empty)
            {
                
                m.name = name.Text;
                m.organization = org.Text;
                m.personal_phone = phn.Text;
                m.email = email.Text;
                m.address = address.Text;
                m.father_name = f_name.Text;
                m.father_phone = f_phn.Text;
                m.password = pass.Text;

                b.SubmitChanges();
                MessageBox.Show("Profile Updated");



                
            }
            else
            {
                MessageBox.Show("Fill all the Blanks");
            }


        }

        private void back_Click(object sender, EventArgs e)
        {
            if(type == 1)
            {
                this.Hide();
                p.ppp();
                p.Show();
                
            }
            else
            {
                this.Hide();
                s.Show();
            }
        }

        private void Modify_Information_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
