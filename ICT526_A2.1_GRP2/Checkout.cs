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
    public partial class Checkout : Form
    {
        List<Inventory> sic = new List<Inventory>();
        decimal totalpr = 0;

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

                    sic.Add(inv);
           
                    Item_input_comb.Items.Add(inv); //with the help of public override string ItemCode the combobox will show the itemcode 


                    Item_input_comb.AutoCompleteSource = AutoCompleteSource.CustomSource; //creates an auto complete for the combo box
                    Item_input_comb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;    //this limits the mistake of writing a wrong item code 
                    Item_input_comb.AutoCompleteCustomSource.Add(inv.ItemCode);           //if the itemcode does not exist, the the program will not show anything 

                }
                Item_input_comb.Items.RemoveAt(0);
                Item_input_comb.AutoCompleteCustomSource.RemoveAt(0);

            }
        }




        public Checkout()
        {
            InitializeComponent();
            var col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Product ID";
            col1.Name = "Product ID";
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Salesprodlist.Columns.Add(col1);

            var col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Product Name";
            col2.Name = "Product Name";
            col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Salesprodlist.Columns.Add(col2);

            var col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Num Required";
            col3.Name = "Num Required";
            col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Salesprodlist.Columns.Add(col3);

            var col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Original Price";
            col4.Name = "Original Price";
            col4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Salesprodlist.Columns.Add(col4);

            var col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Discount Rate(%)";
            col5.Name = "Discount Rate(%)";
            col5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Salesprodlist.Columns.Add(col5);

            var col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Discount Price";
            col6.Name = "Discount Price";
            col6.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Salesprodlist.Columns.Add(col6);

            var col7 = new DataGridViewTextBoxColumn();
            col7.HeaderText = "Discounted Price";
            col7.Name = "Discounted Price";
            col7.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Salesprodlist.Columns.Add(col7);

            //creating the table for the Salesprodlist datagridview 
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            listpop();
        }

    
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

           
        private void CO_addbtn_Click(object sender, EventArgs e)
        {
            decimal Originprice;
            decimal disprice;
            decimal discountedprice;
            decimal qty;
            totalpr = 0;

            if (string.IsNullOrEmpty(Iquntity_tBox.Text) || string.IsNullOrEmpty(Iquntity_tBox.Text))
            {
                MessageBox.Show("Missing information", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//Check if item code and quantity have been entered

            else
            {
                if (decimal.TryParse(Iquntity_tBox.Text, out qty))//Check quantity have been entered correctly
                {


                    Inventory selectedproduct = (Inventory)Item_input_comb.SelectedItem;


                    if (Convert.ToDecimal(Iquntity_tBox.Text) > Convert.ToDecimal(selectedproduct.Quantity))
                    {

                        MessageBox.Show("You have entered a quantity that cannot be purchased.", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }//Check if user enter more than the number of items remaining in the system.

                    else
                    {
                        Originprice = Convert.ToDecimal(Iquntity_tBox.Text) * Convert.ToDecimal(selectedproduct.Price);
                        disprice = Originprice * Convert.ToDecimal(selectedproduct.Discount) / 100;
                        discountedprice = Originprice - disprice;

                        Salesprodlist.Rows.Add(selectedproduct.ItemCode, string.Format("{0},{1}", selectedproduct.Name, selectedproduct.Color), Iquntity_tBox.Text, Originprice, selectedproduct.Discount, disprice, discountedprice);

                        selectedproduct.Quantity = Convert.ToString(Convert.ToDecimal(selectedproduct.Quantity) - Convert.ToDecimal(Iquntity_tBox.Text));


                        for (int j = 0; j < sic.Count; j++)
                        {
                            if (sic[j].ItemCode == (string)selectedproduct.ItemCode)
                            {
                                sic[j].Quantity = selectedproduct.Quantity;
                            }
                        }

                        for (int i = 0; i < Salesprodlist.Rows.Count; i++)
                        {
                            if (Salesprodlist.Rows.Count != 0)
                            {
                                totalpr += Convert.ToDecimal(Salesprodlist.Rows[i].Cells[6].Value);
                            }

                        }

                        Totalprlabel.Text = Convert.ToString(totalpr);
                        Item_input_comb.Text = "";
                        Iquntity_tBox.Clear();//clear the item quantity box text and item code box text after all processes are completed.

                        //Enter the item information corresponding to the entered item code and the quantity entered into the list and show it to the user.
                        //Then update the remaining quantity of the selected item.
                    }



                }
                else //when quantity have been entered incorrectly, messagebox show 
                {
                    MessageBox.Show("Syntax error", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void CO_removebtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Salesprodlist.Rows.Count; i++)
            {
                Salesprodlist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                if (Salesprodlist.Rows[i].Selected == true)
                {
                    for (int j = 0; j < sic.Count; j++)
                    {
                        if (sic[j].ItemCode == (string)Salesprodlist.Rows[i].Cells[0].Value)
                        {
                            sic[j].Quantity += Convert.ToDecimal(Salesprodlist.Rows[i].Cells[2].Value);
                        }
                    }//If the user wants to clear a particular item from the list, deletes the corresponding content from the list and updates the selected item remaining quantity by adding selected item quantity.

                    totalpr -= Convert.ToDecimal(Salesprodlist.Rows[i].Cells[6].Value);
                    Salesprodlist.Rows.Remove(Salesprodlist.Rows[i]);
                }
            }

            Totalprlabel.Text = Convert.ToString(totalpr);
            //And the total amount is changed and show.
        }

        private void CO_Payconfirmbtn_Click(object sender, EventArgs e)
        {
            this.Close();

            if (Salesprodlist.Rows.Count == 0)
            {
                MessageBox.Show("No item added", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }//If there is no registered item in the sales product list, the corresponding message is displayed.

            Salessystem sy1 = new Salessystem();

            for (int i = 0; i < Salesprodlist.Rows.Count; i++)
            {

                sy1.Confirmitem(Convert.ToString(Salesprodlist.Rows[i].Cells[1].Value), Convert.ToString(Salesprodlist.Rows[i].Cells[2].Value), Convert.ToString(Convert.ToDecimal(Salesprodlist.Rows[i].Cells[3].Value) / Convert.ToDecimal(Salesprodlist.Rows[i].Cells[2].Value)), Convert.ToString(Salesprodlist.Rows[i].Cells[3].Value), Convert.ToString(Salesprodlist.Rows[i].Cells[5].Value));

            }

            sy1.Gettotalprice(totalpr);
            sy1.Openinvoice();

            //Hand over the contents of the list and corrsponding information to the Salessystem.

            try
            {

                StreamWriter IW = new StreamWriter(@".\InventoryList.txt");

                for (int i = 0; i < sic.Count; i++)
                {

                    IW.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", sic[i].Name, sic[i].ItemCode, sic[i].Quantity, sic[i].Color, sic[i].Price, sic[i].Discount);

                }

                IW.Close();
            }//Updates the changed items information to Itemlist text file
            catch (Exception h)
            {
                MessageBox.Show("Exception: " + h.Message); //creates an exception if file creation ended up getting corrupted 
            }
        }

        private void CO_Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }//when close button pressed, form closed


 
    }
}
