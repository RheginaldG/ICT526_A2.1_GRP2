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
        }

        private void btnInvMan_Click(object sender, EventArgs e)
        {
            InventoryMan IM = new InventoryMan();
            IM.ShowDialog();
        }

        private void AdminFunc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Application.Restart();
        }
    }
}
