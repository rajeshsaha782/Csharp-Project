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
    public partial class Member_List : Form
    {
        Manager_Homepage h;
        Member_Homepage mh;
        int type;
        public Member_List(Manager_Homepage h)
        {

            InitializeComponent();
            this.h = h;
            type = 1;
            BachelorDataContext b = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");
            var x = (from i in b.Members
                     select new { i.id, i.name, i.organization, i.personal_phone, i.email, i.address, i.father_name, i.father_phone, i.joinning_date, i.password, i.type }).ToList();
            dataGridView1.DataSource = x;
            if (BLogin.Ban == 1)
            {
                label1.Text = "মেম্বার তালিকা";
                this.Text = "মেম্বার তালিকা";
                back.Text = "ফেরত";
            }

        }
        public Member_List(Member_Homepage mh)
        {

            InitializeComponent();
            this.mh = mh;
            type = 0;
            if (BLogin.Ban == 1)
            {
                label1.Text = "মেম্বার তালিকা";
                this.Text = "মেম্বার তালিকা";
                back.Text = "ফেরত";
            }

            BachelorDataContext b = new BachelorDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\3-1.Summer(2016-17)\C#\Bachelors_House_final_in_rakib_pc\Bachelor's_House\Bachelor's_House\Bachelor.mdf;Integrated Security=True;Connect Timeout=30");
            var x = (from i in b.Members
                     select new { i.name, i.organization, i.personal_phone, i.email, i.address }).ToList();
            dataGridView1.DataSource = x;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(type == 1)
            {
                h.Show();
            }
            else
                mh.Show();
            
        }

        private void Member_List_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
