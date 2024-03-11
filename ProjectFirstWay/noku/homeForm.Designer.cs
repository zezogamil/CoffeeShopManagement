namespace noku
{
    partial class homeForm
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
            this.addorderbtn = new System.Windows.Forms.Button();
            this.seeorderbtn = new System.Windows.Forms.Button();
            this.addproductbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addorderbtn
            // 
            this.addorderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addorderbtn.Location = new System.Drawing.Point(116, 169);
            this.addorderbtn.Name = "addorderbtn";
            this.addorderbtn.Size = new System.Drawing.Size(213, 47);
            this.addorderbtn.TabIndex = 0;
            this.addorderbtn.Text = "Add order ";
            this.addorderbtn.UseVisualStyleBackColor = true;
            this.addorderbtn.Click += new System.EventHandler(this.addorderbtn_Click);
            // 
            // seeorderbtn
            // 
            this.seeorderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeorderbtn.Location = new System.Drawing.Point(369, 169);
            this.seeorderbtn.Name = "seeorderbtn";
            this.seeorderbtn.Size = new System.Drawing.Size(213, 47);
            this.seeorderbtn.TabIndex = 1;
            this.seeorderbtn.Text = "See orders";
            this.seeorderbtn.UseVisualStyleBackColor = true;
            this.seeorderbtn.Click += new System.EventHandler(this.seeorderbtn_Click);
            // 
            // addproductbtn
            // 
            this.addproductbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addproductbtn.Location = new System.Drawing.Point(245, 239);
            this.addproductbtn.Name = "addproductbtn";
            this.addproductbtn.Size = new System.Drawing.Size(213, 47);
            this.addproductbtn.TabIndex = 2;
            this.addproductbtn.Text = "add product ";
            this.addproductbtn.UseVisualStyleBackColor = true;
            this.addproductbtn.Click += new System.EventHandler(this.addproductbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.Location = new System.Drawing.Point(250, 363);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(213, 47);
            this.Exitbtn.TabIndex = 3;
            this.Exitbtn.Text = "exit";
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "Coffee Shop";
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.addproductbtn);
            this.Controls.Add(this.seeorderbtn);
            this.Controls.Add(this.addorderbtn);
            this.Name = "homeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addorderbtn;
        private System.Windows.Forms.Button seeorderbtn;
        private System.Windows.Forms.Button addproductbtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Label label1;
    }
}

