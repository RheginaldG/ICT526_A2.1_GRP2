namespace ICT526_A2._1_GRP2
{
    partial class Checkout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PcodeLable = new System.Windows.Forms.Label();
            this.Pquntitylable = new System.Windows.Forms.Label();
            this.Iquntity_tBox = new System.Windows.Forms.TextBox();
            this.CO_addbtn = new System.Windows.Forms.Button();
            this.CO_removebtn = new System.Windows.Forms.Button();
            this.Item_input_comb = new System.Windows.Forms.ComboBox();
            this.Salesprodlist = new System.Windows.Forms.DataGridView();
            this.CO_Payconfirmbtn = new System.Windows.Forms.Button();
            this.tpr = new System.Windows.Forms.Label();
            this.Totalprlabel = new System.Windows.Forms.Label();
            this.CO_Closebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Salesprodlist)).BeginInit();
            this.SuspendLayout();
            // 
            // PcodeLable
            // 
            this.PcodeLable.AutoSize = true;
            this.PcodeLable.Location = new System.Drawing.Point(250, 60);
            this.PcodeLable.Name = "PcodeLable";
            this.PcodeLable.Size = new System.Drawing.Size(120, 18);
            this.PcodeLable.TabIndex = 0;
            this.PcodeLable.Text = "Product Code";
            // 
            // Pquntitylable
            // 
            this.Pquntitylable.AutoSize = true;
            this.Pquntitylable.Location = new System.Drawing.Point(679, 60);
            this.Pquntitylable.Name = "Pquntitylable";
            this.Pquntitylable.Size = new System.Drawing.Size(74, 18);
            this.Pquntitylable.TabIndex = 1;
            this.Pquntitylable.Text = "Quantity";
            // 
            // Iquntity_tBox
            // 
            this.Iquntity_tBox.Location = new System.Drawing.Point(829, 55);
            this.Iquntity_tBox.Name = "Iquntity_tBox";
            this.Iquntity_tBox.Size = new System.Drawing.Size(100, 28);
            this.Iquntity_tBox.TabIndex = 2;
            // 
            // CO_addbtn
            // 
            this.CO_addbtn.Location = new System.Drawing.Point(1023, 48);
            this.CO_addbtn.Name = "CO_addbtn";
            this.CO_addbtn.Size = new System.Drawing.Size(102, 43);
            this.CO_addbtn.TabIndex = 5;
            this.CO_addbtn.Text = "Add";
            this.CO_addbtn.UseVisualStyleBackColor = true;
            this.CO_addbtn.Click += new System.EventHandler(this.CO_addbtn_Click);
            // 
            // CO_removebtn
            // 
            this.CO_removebtn.Location = new System.Drawing.Point(1144, 334);
            this.CO_removebtn.Name = "CO_removebtn";
            this.CO_removebtn.Size = new System.Drawing.Size(113, 55);
            this.CO_removebtn.TabIndex = 6;
            this.CO_removebtn.Text = "Remove";
            this.CO_removebtn.UseVisualStyleBackColor = true;
            this.CO_removebtn.Click += new System.EventHandler(this.CO_removebtn_Click);
            // 
            // Item_input_comb
            // 
            this.Item_input_comb.FormattingEnabled = true;
            this.Item_input_comb.Location = new System.Drawing.Point(394, 57);
            this.Item_input_comb.Name = "Item_input_comb";
            this.Item_input_comb.Size = new System.Drawing.Size(132, 26);
            this.Item_input_comb.TabIndex = 7;
            // 
            // Salesprodlist
            // 
            this.Salesprodlist.AllowUserToAddRows = false;
            this.Salesprodlist.AllowUserToDeleteRows = false;
            this.Salesprodlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Salesprodlist.Location = new System.Drawing.Point(77, 138);
            this.Salesprodlist.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Salesprodlist.Name = "Salesprodlist";
            this.Salesprodlist.ReadOnly = true;
            this.Salesprodlist.RowHeadersWidth = 62;
            this.Salesprodlist.Size = new System.Drawing.Size(1035, 438);
            this.Salesprodlist.TabIndex = 23;
            // 
            // CO_Payconfirmbtn
            // 
            this.CO_Payconfirmbtn.Location = new System.Drawing.Point(921, 677);
            this.CO_Payconfirmbtn.Name = "CO_Payconfirmbtn";
            this.CO_Payconfirmbtn.Size = new System.Drawing.Size(191, 86);
            this.CO_Payconfirmbtn.TabIndex = 24;
            this.CO_Payconfirmbtn.Text = "Payment Confirmed";
            this.CO_Payconfirmbtn.UseVisualStyleBackColor = true;
            this.CO_Payconfirmbtn.Click += new System.EventHandler(this.CO_Payconfirmbtn_Click);
            // 
            // tpr
            // 
            this.tpr.AutoSize = true;
            this.tpr.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tpr.Location = new System.Drawing.Point(890, 604);
            this.tpr.Name = "tpr";
            this.tpr.Size = new System.Drawing.Size(160, 24);
            this.tpr.TabIndex = 25;
            this.tpr.Text = "Total Price : ";
            this.tpr.Click += new System.EventHandler(this.label3_Click);
            // 
            // Totalprlabel
            // 
            this.Totalprlabel.AutoSize = true;
            this.Totalprlabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Totalprlabel.Location = new System.Drawing.Point(1056, 604);
            this.Totalprlabel.Name = "Totalprlabel";
            this.Totalprlabel.Size = new System.Drawing.Size(24, 24);
            this.Totalprlabel.TabIndex = 26;
            this.Totalprlabel.Text = "0";
            this.Totalprlabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // CO_Closebtn
            // 
            this.CO_Closebtn.Location = new System.Drawing.Point(77, 665);
            this.CO_Closebtn.Name = "CO_Closebtn";
            this.CO_Closebtn.Size = new System.Drawing.Size(191, 86);
            this.CO_Closebtn.TabIndex = 27;
            this.CO_Closebtn.Text = "Close Checkout";
            this.CO_Closebtn.UseVisualStyleBackColor = true;
            this.CO_Closebtn.Click += new System.EventHandler(this.CO_Closebtn_Click);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1383, 813);
            this.Controls.Add(this.CO_Closebtn);
            this.Controls.Add(this.Totalprlabel);
            this.Controls.Add(this.tpr);
            this.Controls.Add(this.CO_Payconfirmbtn);
            this.Controls.Add(this.Salesprodlist);
            this.Controls.Add(this.Item_input_comb);
            this.Controls.Add(this.CO_removebtn);
            this.Controls.Add(this.CO_addbtn);
            this.Controls.Add(this.Iquntity_tBox);
            this.Controls.Add(this.Pquntitylable);
            this.Controls.Add(this.PcodeLable);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Salesprodlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PcodeLable;
        private System.Windows.Forms.Label Pquntitylable;
        private System.Windows.Forms.TextBox Iquntity_tBox;
        private System.Windows.Forms.Button CO_addbtn;
        private System.Windows.Forms.Button CO_removebtn;
        private System.Windows.Forms.ComboBox Item_input_comb;
        private System.Windows.Forms.DataGridView Salesprodlist;
        private System.Windows.Forms.Button CO_Payconfirmbtn;
        private System.Windows.Forms.Label tpr;
        private System.Windows.Forms.Label Totalprlabel;
        private System.Windows.Forms.Button CO_Closebtn;
    }
}