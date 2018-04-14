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
    public partial class BLogin : Form
    {
        public static int Ban;

        public BLogin()
        {
            InitializeComponent();
            Ban = 0;
        }
        public void show()
        {
            Show();
            id.Text = "";
            pass.Text = "";
        }

        private void login_Click(object sender, EventArgs e)
        {
            messegeLabel.Visible = false;
            BachelorDataContext b = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                var x = from a in b.Members
                        where a.id == int.Parse(id.Text)
                        select a;

                if (x.FirstOrDefault().password.Equals(pass.Text) && x.First().type == 1)
                {
                    this.Hide();
                    Manager_Homepage h = new Manager_Homepage(this, id.Text);
                    h.Show();
                }
                else if (x.FirstOrDefault().password.Equals(pass.Text) && x.First().type == 0)
                {
                    this.Hide();
                    Member_Homepage m = new Member_Homepage(this, id.Text);
                    m.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }
            catch (NullReferenceException)
            {
                messegeLabel.Text = "*Wrong UserId";
                messegeLabel.Visible = true;
            }
            catch (System.Reflection.TargetInvocationException)
            {
                messegeLabel.Text = "*Wrong UserId";
                messegeLabel.Visible = true;
                
            }
            catch (Exception)
            {
                messegeLabel.Text = "*Please Fill You Id";
                messegeLabel.Visible = true;
            }
            b.Dispose();
           


        }

        private void BLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void language_Click(object sender, EventArgs e)
        {
            messegeLabel.Visible = false;
            if (Ban == 1)
            {
                language.Text = "বাংলা";
                Ban = 0;
                label1.Text = "UserID";
                label2.Text = "Password";
                label3.Text = "Bachelor's House";
                login.Text = "Login";
                this.Text = "Login";
            }
            else
            {
                language.Text = "English";
                Ban = 1;
                label1.Text = "ব্যবহারকারীর আইডি";
                label2.Text = "পাসওয়ার্ড";
                label3.Text = "ব্যাচেলর খানা";
                login.Text = "লগ ইন";
                this.Text = "লগ ইন";
            }
        }

  

        

      
    }
}
