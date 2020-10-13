namespace ICT526_A2._1_GRP2
{
    partial class AdminFunc
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
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnInvMan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(87, 36);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(247, 104);
            this.btnCheckout.TabIndex = 0;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnInvMan
            // 
            this.btnInvMan.Location = new System.Drawing.Point(87, 183);
            this.btnInvMan.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnInvMan.Name = "btnInvMan";
            this.btnInvMan.Size = new System.Drawing.Size(247, 104);
            this.btnInvMan.TabIndex = 1;
            this.btnInvMan.Text = "Inventory Management";
            this.btnInvMan.UseVisualStyleBackColor = true;
            this.btnInvMan.Click += new System.EventHandler(this.btnInvMan_Click);
            // 
            // AdminFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 328);
            this.Controls.Add(this.btnInvMan);
            this.Controls.Add(this.btnCheckout);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AdminFunc";
            this.Text = "Admin Function";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminFunc_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnInvMan;
    }
}