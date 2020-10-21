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
using System.Text.RegularExpressions;

namespace ICT526_A2._1_GRP2
{
    /* ID: 1815101
     Author: Rheginald Gregorio
    Description: Updates the product details of a product*/
    public partial class InventoryUp : Form
    {
        List<Inventory> ic = new List<Inventory>();
        public void listpop()
        {
            using (StreamReader SR = new StreamReader(@".\InventoryList.txt")) //reads the file
            {
                while (!SR.EndOfStream)
                {

                    string line = SR.ReadLine();
                    string[] s = line.Split(new string[] { ", " }, StringSplitOptions.None); //splits the strings by comma and a space
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

                    Inventory codes = new Inventory
                    {

                        ItemCode = itemcode
                    };

                    ic.Add(codes);


                    cmbIU.Items.Add(inv); //with the help of public override string ItemCode the combobox will show the itemcode 


                    cmbIU.AutoCompleteSource = AutoCompleteSource.CustomSource; //creates an auto complete for the combo box
                    cmbIU.AutoCompleteMode = AutoCompleteMode.SuggestAppend;    //this limits the mistake of writing a wrong item code 
                    cmbIU.AutoCompleteCustomSource.Add(inv.ItemCode);           //if the itemcode does not exist, the the program will not show anything 

                }
                cmbIU.Items.RemoveAt(0);
                cmbIU.AutoCompleteCustomSource.RemoveAt(0);

            }
        }


        public InventoryUp()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InventoryUp_Load(object sender, EventArgs e)
        {

            listpop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            InventoryMan frm1 = new InventoryMan();
            frm1.ShowDialog();
        }

        private void cmbIU_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inventory selecteditem = (Inventory)cmbIU.SelectedItem;
            lblNameIU.Text = selecteditem.Name;
            lblqtyIU.Text = selecteditem.Quantity;
            lblcolIU.Text = selecteditem.Color;
            lblprcIU.Text = selecteditem.Price;
            lbldiscIU.Text = selecteditem.Discount;
            lblcodeIU.Text = selecteditem.ItemCode;

            txtNameIU.Text = selecteditem.Name;
            txtQtyIU.Text = selecteditem.Quantity;
            txtclrIU.Text = selecteditem.Color;
            txtdiscIU.Text = selecteditem.Discount;
            txtprcIU.Text = selecteditem.Price;
        }

        private void btnupdateIU_Click(object sender, EventArgs e)
        {
            string commaspacecheck = ", ";
            int quantityparse;
            double priceparse;
            double discountparse;

            if (cmbIU.SelectedIndex == -1) //checks if the current index is at -1, if it is an error message shows, the program also has multiple safety measures in place
            {                                  //regarding inputing an item without an item code
                MessageBox.Show("Please enter a correct code");
            }
            else
            {

                if (Convert.ToString(txtNameIU.Text).Contains(commaspacecheck))
                {
                    MessageBox.Show("Please check the syntax of the Item name.");
                }
                else if (Convert.ToString(txtclrIU.Text).Contains(commaspacecheck))
                {
                    MessageBox.Show("Please check the syntax of the Color of the product");
                }
                else if (!int.TryParse(txtQtyIU.Text, out quantityparse))
                {
                    MessageBox.Show("Please check if quantity is a numeric value without decimal points.");
                }
                else if (!double.TryParse(txtprcIU.Text, out priceparse))
                {
                    MessageBox.Show("Please check if Price set is a numeric value");
                }
                else if (!double.TryParse(txtdiscIU.Text, out discountparse) || discountparse > 100)
                {
                    MessageBox.Show("Please check if Discount set is a numeric value");
                }
                else
                {
                    string olddetail = Convert.ToString(lblNameIU.Text) + ", " + Convert.ToString(lblcodeIU.Text) + ", " + Convert.ToString(lblqtyIU.Text)
                        + ", " + Convert.ToString(lblcolIU.Text) + ", " + Convert.ToString(lblprcIU.Text) + ", " + Convert.ToString(lbldiscIU.Text);

                    string newdetail = Convert.ToString(txtNameIU.Text) + ", " + Convert.ToString(lblcodeIU.Text) + ", " + Convert.ToString(txtQtyIU.Text)
                        + ", " + Convert.ToString(txtclrIU.Text) + ", " + Convert.ToString(txtprcIU.Text) + ", " + Convert.ToString(txtdiscIU.Text);

                    StreamReader sr = new StreamReader(@".\InventoryList.txt");

                    string itemdetail = sr.ReadToEnd();
                    sr.Close();
                    itemdetail = Regex.Replace(itemdetail, olddetail, newdetail); //regex updates the text file, the best part about it; if it doesn't find the old item 
                                                                                  //to be updated, it does not commit the updtate preventing hassles regarding fixing the text file. 
                    StreamWriter sw = new StreamWriter(@".\InventoryList.txt");
                    sw.Write(itemdetail);
                    sw.Close();

                    string updatemessage = "Item " + Convert.ToString(lblcodeIU.Text) + " has been updated";

                    MessageBox.Show(updatemessage);

                    //AdminFunc admin = new AdminFunc();
                    //admin.Close();

                    InventoryUp up = new InventoryUp(); 
                    this.Hide();
                    up.Show();
                }
            }
                }
            }
}
