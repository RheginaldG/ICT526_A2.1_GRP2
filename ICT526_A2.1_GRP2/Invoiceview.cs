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
    public partial class Invoiceview : Form
    {
        decimal totalpr;
        decimal gst;
        decimal subtotal;

        public Invoiceview()
        {
            



            InitializeComponent();

            var col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Product";
            col1.Name = "Product";
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Confirmprodlist.Columns.Add(col1);

            var col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Qty";
            col2.Name = "Qty";
            col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Confirmprodlist.Columns.Add(col2);

            var col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Price";
            col3.Name = "Price";
            col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Confirmprodlist.Columns.Add(col3);

            var col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Total";
            col4.Name = "Total";
            col4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Confirmprodlist.Columns.Add(col4);

          

        }
        public void SetList(string A, string B, string C, string D, string E)
        {
            Confirmprodlist.Rows.Add(A, B, string.Format("${0}", C), string.Format("${0} - ${1}", D, E));
        }

        public void Gettpr(decimal T)
        {
            totalpr = T;
            gst = totalpr * 3 / 23;
            subtotal = totalpr - gst;

            totalpr = decimal.Round(totalpr, 2);
            gst = decimal.Round(gst, 2);
            subtotal = decimal.Round(subtotal, 2);

        }

        private void Form4_Load(object sender, EventArgs e)
        {

            
            label8.Text = DateTime.Now.ToString("ddMMyyyy");
            label9.Text = DateTime.Now.ToString("t");
            label10.Text = Convert.ToString(subtotal);
            label11.Text = Convert.ToString(gst);
            label12.Text = Convert.ToString(totalpr);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

  
        private void Done_Click(object sender, EventArgs e)
        {
            Salessystem s1 = new Salessystem();

            s1.Invoice_create(subtotal, gst, totalpr, Confirmprodlist);


            this.Close();
        }
    }
}
