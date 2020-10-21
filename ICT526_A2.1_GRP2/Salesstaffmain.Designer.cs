namespace ICT526_A2._1_GRP2
{
    partial class Salesstaffmain
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
            this.Smck_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Smck_btn
            // 
            this.Smck_btn.Location = new System.Drawing.Point(128, 120);
            this.Smck_btn.Name = "Smck_btn";
            this.Smck_btn.Size = new System.Drawing.Size(153, 84);
            this.Smck_btn.TabIndex = 0;
            this.Smck_btn.Text = "Check Out";
            this.Smck_btn.UseVisualStyleBackColor = true;
            this.Smck_btn.Click += new System.EventHandler(this.Smck_btn_Click);
            // 
            // Salesstaffmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 328);
            this.Controls.Add(this.Smck_btn);
            this.Name = "Salesstaffmain";
            this.Text = "Staff Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Salesstaffmain_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Smck_btn;
    }
}