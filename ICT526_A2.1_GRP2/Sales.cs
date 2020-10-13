using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ICT526_A2._1_GRP2
{
    class Salessystem
    {

        Invoiceview invoiceview = new Invoiceview();

        public void Gettotalprice(decimal T)
        {
            invoiceview.Gettpr(T);
        }


        public void Openinvoice()
        {
            invoiceview.ShowDialog();
        }
        public void Confirmitem(string A, string B, string C, string D, string E) 
        {
            
            invoiceview.SetList(A,B,C,D,E);
        }

        
        public void Invoice_create(decimal Subtotal,decimal Totalgst, decimal Total, DataGridView Confirmprodlist)
        {
            string strDate = DateTime.Now.ToString("ddMMyyyy");
            string strtime = DateTime.Now.ToString("t");
            StreamWriter invoicewr = new StreamWriter(String.Format(@"./Invoice{0}{1}.txt", strtime, strDate));
            //Instantiate text file constructor
            invoicewr.WriteLine("***********************************INVOICE***********************************");
            invoicewr.WriteLine("*******************************The Comfort Zone******************************");
            invoicewr.WriteLine("******************************Auckland CBD Branch****************************");
            invoicewr.WriteLine("Invoice Date: {0}, {1}", DateTime.Now.DayOfWeek, DateTime.Now.ToString("dd\tMMMM\tyyyy"));
            //Enter customer information and order date in text file
            invoicewr.WriteLine("Product\t|\tQty\t|\tPrice\t|\tTotal");
       
              for (int i = 0; i < Confirmprodlist.Rows.Count; i++)
                {
                    invoicewr.WriteLine("{0}\t|\t{1}\t|\t{2}\t|\t{3}", 
                    Confirmprodlist.Rows[i].Cells[0].Value, Confirmprodlist.Rows[i].Cells[1].Value, Confirmprodlist.Rows[i].Cells[2].Value, Confirmprodlist.Rows[i].Cells[3].Value);
                }
            //
            invoicewr.WriteLine("*****************************************************************************");
            invoicewr.WriteLine("Sub Total : {0}", Subtotal); //Enter Total Price in Text File
            invoicewr.WriteLine("Total GST : {0}", Totalgst); //Enter Total Price in Text File
            invoicewr.WriteLine("Total : {0}", Total); //Enter Total Price in Text File
            invoicewr.Close(); //Terminate text write into a text file
        }


    }
}
