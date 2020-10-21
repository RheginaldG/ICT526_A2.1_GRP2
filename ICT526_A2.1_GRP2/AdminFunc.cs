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
    public partial class AdminFunc : Form
    {
        public AdminFunc()
        {
            InitializeComponent();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Checkout cf = new Checkout();
            cf.ShowDialog();
        }//The checkout form appears when the check-out button is pressed.

        private void btnInvMan_Click(object sender, EventArgs e)
        {
            InventoryMan IM = new InventoryMan();
            IM.ShowDialog();
        }//The Inventory Main form appears when the Inventory Management button is pressed.

        private void AdminFunc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Application.Restart();
        }// If the user terminates this form, it returns to the initial program window (the program restarts).
    }
}
