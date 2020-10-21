using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ICT526_A2._1_GRP2
{
    /* ID: 1814248
   Author: Yungyeom Hwang
  Description:  User Identification .*/
    public partial class FormLogin : Form
    {
        List<string> user = new List<string>();
        List<string> password = new List<string>();
        List<string> title = new List<string>();
        public FormLogin()
        {
            InitializeComponent();

            const string path = @".\employeedetail.txt";
            string[] lineOfContents = File.ReadAllLines(path);
            foreach (string line in lineOfContents)
            {
                string[] itemn = line.Split('|');


                user.Add(itemn[0]);
                password.Add(itemn[1]);
                title.Add(itemn[2]);
            }

            //get the information of users from the text file
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (user.Contains(txtuser.Text) && password.Contains(txtpass.Text)) // Check information have been entered correctly

            {
                if (password[Array.IndexOf(user.ToArray(), txtuser.Text)] == txtpass.Text)
                {

                    if (title[Array.IndexOf(user.ToArray(), txtuser.Text)] == "admin")
                    {
                        this.Hide();
                        User af = new Admin(txtuser.Text, txtpass.Text, "admin");
                        ((Admin)af).OpenadminMain();

                       
                    }

                    else if (title[Array.IndexOf(user.ToArray(), txtuser.Text)] == "sales staff")
                    {
                        this.Hide();
                        User sst = new Staff(txtuser.Text, txtpass.Text, "admin");
                        ((Staff)sst).Openstaffmain();

                       
                    }

                    else
                    {
                        MessageBox.Show("You don't have access.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
                //Confirm the title and open the main form accessible to that title.


            }
            else
            {
                MessageBox.Show("The Username and Password is incorrect.");
            }




        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
           
        }
    }
}
