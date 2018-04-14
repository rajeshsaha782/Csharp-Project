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
    public partial class Member_Registration : Form
    {
        Manager_Homepage h; 
        string hid;
        int type;
        public Member_Registration()
        {
            InitializeComponent();
        }
        public Member_Registration(Manager_Homepage h,string id,int type)
        {
            InitializeComponent();
            this.h = h;
            this.hid = id;
            this.type = type;
            if (BLogin.Ban == 1)
            {
                label11.Text = "নিবন্ধন";
                this.Text = "মেম্বার নিবন্ধন";
                id_l.Text = "আইডি";
                name_l.Text = "নাম";
                org_l.Text = "সংগঠন";
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
        }
        private void manager()
        {
            BachelorDataContext b = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");
            Member m = new Member();
            int p = 0;
            try
            {
                if (id.Text != string.Empty && name.Text != string.Empty && org.Text != string.Empty && phn.Text != string.Empty && email.Text != string.Empty && address.Text != string.Empty && f_name.Text != string.Empty && f_phn.Text != string.Empty && pass.Text != string.Empty)
                {
                    m.id = int.Parse(id.Text);
                    m.name = name.Text;
                    m.organization = org.Text;
                    m.personal_phone = phn.Text;
                    m.email = email.Text;
                    m.address = address.Text;
                    m.father_name = f_name.Text;
                    m.father_phone = f_phn.Text;
                    

                    try
                    {
                        DateTime myDate = DateTime.ParseExact(j_date.Text, "dd-MM-yy",
                                       System.Globalization.CultureInfo.InvariantCulture);
                        m.joinning_date = myDate;
                        m.password = pass.Text;
                        m.type = 1;

                        b.Members.InsertOnSubmit(m);
                        b.SubmitChanges();
                        MessageBox.Show("Successfully added a manager");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please Fill the Date 'dd-mm-yy' this formate ");
                        p = 1;
                    }
                    

                }
                else
                {
                    MessageBox.Show("Fill up the all things");
                }

            }
            catch (Exception)
            {
                if (p == 0)
                    MessageBox.Show("Id is already Used");
            }
            b.Dispose();
            
        }


        private void confirm_Click(object sender, EventArgs e)
        {

            BachelorDataContext b = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");

            try
                {
            var z = from a in b.Members
                    where a.id.Equals(id.Text)
                    select a;


            if (z.Count() > 0)
            {
                MessageBox.Show("Id already Exist");
            }
            else
            {
                
                    if (type == 1)
                    {
                        manager();
                    }
                    else
                    {
                        Member m = new Member();
                        MealList ml = new MealList();
                        Account ac = new Account();
                        int p = 0;
                        try
                        {
                            if (id.Text != string.Empty && name.Text != string.Empty && org.Text != string.Empty && phn.Text != string.Empty && email.Text != string.Empty && address.Text != string.Empty && f_name.Text != string.Empty && f_phn.Text != string.Empty && pass.Text != string.Empty)
                            {
                                m.id = int.Parse(id.Text);
                                m.name = name.Text;
                                m.organization = org.Text;
                                m.personal_phone = phn.Text;
                                m.email = email.Text;
                                m.address = address.Text;
                                m.father_name = f_name.Text;
                                m.father_phone = f_phn.Text;
                                ml.id = m.id;
                                ml.dailyMeal = 0;
                                ac.id = m.id;
                                ac.balance = 0;
                                ac.totalNumberOfMeal = 0;


                                try
                                {
                                    DateTime myDate = DateTime.ParseExact(j_date.Text, "dd-MM-yy",
                                                   System.Globalization.CultureInfo.InvariantCulture);
                                    m.joinning_date = myDate;
                                    m.password = pass.Text;
                                    m.type = 0;

                                    MessageBox.Show("Successfully added a member");
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Please Fill the Date 'dd-mm-yy' this formate ");
                                    p = 1;
                                }

                                b.Members.InsertOnSubmit(m);
                                b.Accounts.InsertOnSubmit(ac);
                                b.MealLists.InsertOnSubmit(ml);
                                b.SubmitChanges();


                            }
                            else
                            {
                                MessageBox.Show("Fill up the all things");
                            }

                        }
                        catch (Exception)
                        {
                            if (p == 0)
                                MessageBox.Show("Id is already Used");
                        }
                    }
                   
                }
                

                


            }
            catch (System.FormatException)
            {
                MessageBox.Show("Fill Id");
            }
            b.Dispose();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            h.Show();
        }

        private void Member_Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
