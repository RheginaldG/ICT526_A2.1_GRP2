using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT526_A2._1_GRP2
{
    /* ID: 1814248
   Author: Yungyeom Hwang
  Description:  Privileges when the user is identified as a sales step .*/
    public partial class Salesstaffmain : Form
    {
        public Salesstaffmain()
        {
            InitializeComponent();
        }

        private void Salesstaffmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Application.Restart();
        }// If the user terminates this form, it returns to the initial program window (the program restarts).

        private void Smck_btn_Click(object sender, EventArgs e)
        {
            Checkout cf = new Checkout();
            cf.Show();
        }//The checkout form appears when the check-out button is pressed.
    }
}
