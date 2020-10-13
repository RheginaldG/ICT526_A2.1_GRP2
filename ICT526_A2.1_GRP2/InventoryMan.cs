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
    public partial class InventoryMan : Form
    {

        List<Inventory> inventories = new List<Inventory>(); //list of all inventory item and their detail 
        List<Inventory> invs = new List<Inventory>(); //probably redundant
        public InventoryMan()
        {
            InitializeComponent();
            var col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Item";
            col1.Name = "ItemName";
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataInvIM.Columns.Add(col1);

            var col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Item Code";
            col2.Name = "Item Code";
            col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataInvIM.Columns.Add(col2);

            var col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Available Quantity";
            col3.Name = "Available Quantity";
            col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataInvIM.Columns.Add(col3);

            var col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Color";
            col4.Name = "Color";
            col4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataInvIM.Columns.Add(col4);

            var col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Price";
            col5.Name = "Price";
            col5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataInvIM.Columns.Add(col5);

            var col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Discount";
            col6.Name = "Discount";
            col6.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataInvIM.Columns.Add(col6);

            //creating the table for the dataInv datagridview 


            using (StreamReader SR = new StreamReader(@".\InventoryList.txt"))
            {
                while (!SR.EndOfStream)
                {

                    string line = SR.ReadLine();
                    string[] s = line.Split(new string[] { ", " }, StringSplitOptions.None);   //splits by a string of a comma and a space
                    string name = s[0];
                    string itemcode = s[1];
                    string quantity = s[2];
                    string color = s[3];
                    string price = s[4];
                    string discount = s[5];

                    Inventory inv = new Inventory
                    {
                        Name = name,
                        ItemCode = itemcode,
                        Quantity = quantity,
                        Color = color,
                        Price = price,
                        Discount = discount




                    };
                    inventories.Add(inv); //added all the split items into the list


                }

                foreach (Inventory inventory in inventories) //populates the dataInv datagridview
                {
                    dataInvIM.Rows.Add(inventory.Name, inventory.ItemCode, inventory.Quantity, inventory.Color, inventory.Price, inventory.Discount);
                }
                dataInvIM.Rows.Remove(dataInvIM.Rows[0]); //removes the header because it's not needed.
            }

        }

        private void InventoryMan_Load(object sender, EventArgs e)
        {

        }

       

        private void btnAddIM_Click(object sender, EventArgs e)
        {
            string commaspacecheck = ", "; //needed to check if the text entered has a comma and a space, prevents issues later when the file is read again. 
            int itemcodeparse;
            int quantityparse;
            double priceparse;
            double discountparse;
            if (!int.TryParse(txtCodeIM.Text, out itemcodeparse)) //checks first if the item code is an int
            {
                MessageBox.Show("Please check if Item Code is a numerical value without a decimal point.");
            }

            else if (Convert.ToString(txtNameIM.Text).Contains(commaspacecheck)) //checks if the string has a comma and a space.
            {
                MessageBox.Show("Please check the syntax of the Item name.");
            }
            else if (Convert.ToString(txtColIM.Text).Contains(commaspacecheck)) //checks if the string has a comma and a space.
            {
                MessageBox.Show("Please check the syntax of the Color of the product");
            }
            else if (!int.TryParse(txtQuanIM.Text, out quantityparse)) //checks if the quantity is an int
            {
                MessageBox.Show("Please check if quantity is a numeric value without decimal points.");
            }
            else if (!double.TryParse(txtprcIM.Text, out priceparse)) //checks if the price is a double
            {
                MessageBox.Show("Please check if Price set is a numeric value");
            }
            else if (!double.TryParse(txtdiscIM.Text, out discountparse) || discountparse > 100) //checks if the discount is a double and also if it's in the range of 0 to 100
            {
                MessageBox.Show("Please check if Discount set is a numeric value or is in a range of 0-100");


            }

            else //the new item is now cleared to br written
            {

                Inventory inv = new Inventory
                {
                    Name = txtNameIM.Text,
                    ItemCode = txtCodeIM.Text,
                    Quantity = txtQuanIM.Text,
                    Color = txtColIM.Text,
                    Price = txtprcIM.Text,
                    Discount = txtdiscIM.Text


                };
                invs.Add(inv); // somewhat redundant, might use this if I wrote better code.
                try
                {

                    StreamWriter IW = new StreamWriter(@".\InventoryList.txt");
                    IW.WriteLine("<Product_name, Code, Available_Quantity, Color, Price, Discount>"); //because the header was wrote off, on the dataInv we need to write it back
                    for (int i = 0; i < dataInvIM.Rows.Count; i++) //writes the whole dataInv to a textfile with a comma per item, 
                    {                                            //could have been approached differently by just reading the current text file and then writing it again
                                                                 //but the current method of a for loop still works, so it's applied here.
                        for (int j = 0; j < dataInvIM.Columns.Count; j++)
                        {
                            IW.Write(dataInvIM.Rows[i].Cells[j].Value.ToString());

                            if (j != dataInvIM.Columns.Count - 1)
                            {
                                IW.Write(", ");
                            }
                        }
                        IW.WriteLine("");
                    }
                    IW.Write(inv.Name + ", " + inv.ItemCode + ", " + inv.Quantity + ", " + inv.Color + ", " + inv.Price + ", " + inv.Discount); //new item is written at the bottom
                    IW.Close();
                }
                catch (Exception h)
                {
                    MessageBox.Show("Exception: " + h.Message); //creates an exception if file creation ended up getting corrupted 
                }
                finally
                {
                    MessageBox.Show("Item Added succesfully!");
                }

                dataInvIM.Rows.Add(inv.Name, inv.ItemCode, inv.Quantity, inv.Color, inv.Price, inv.Discount); //this is both for visuals and for the rewrite if the new item is added to dataInv


                txtNameIM.Clear();
                txtprcIM.Clear();
                txtCodeIM.Clear();
                txtColIM.Clear();
                txtdiscIM.Clear();
                txtQuanIM.Clear();
                //clears all the textboxes
            }
        }

        private void btnUpdateIM_Click(object sender, EventArgs e)
        {
            this.Hide();

            //AdminFunc admin = new AdminFunc();
            //admin.Hide();

            InventoryUp frm2 = new InventoryUp();
            frm2.ShowDialog();

            //opens the inventory update form, also hides this form to prevent corruptions of the text file
            //just in case the user updates data from this form and also on the inventory update form
        }
    }
}