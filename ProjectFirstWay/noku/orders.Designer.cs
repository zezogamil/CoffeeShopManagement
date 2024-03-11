namespace noku
{
    partial class orders
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
            this.Ordergroupbox = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SmallRB = new System.Windows.Forms.RadioButton();
            this.MediumRB = new System.Windows.Forms.RadioButton();
            this.LargeRB = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Addproductbtn = new System.Windows.Forms.Button();
            this.Checkoutbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.BusketOForders = new System.Windows.Forms.ListBox();
            this.Sumlbl = new System.Windows.Forms.Label();
            this.Ordergroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ordergroupbox
            // 
            this.Ordergroupbox.Controls.Add(this.Sumlbl);
            this.Ordergroupbox.Controls.Add(this.BusketOForders);
            this.Ordergroupbox.Controls.Add(this.Checkoutbtn);
            this.Ordergroupbox.Controls.Add(this.Addproductbtn);
            this.Ordergroupbox.Controls.Add(this.comboBox1);
            this.Ordergroupbox.Controls.Add(this.LargeRB);
            this.Ordergroupbox.Controls.Add(this.MediumRB);
            this.Ordergroupbox.Controls.Add(this.SmallRB);
            this.Ordergroupbox.Controls.Add(this.textBox1);
            this.Ordergroupbox.Controls.Add(this.label5);
            this.Ordergroupbox.Controls.Add(this.label4);
            this.Ordergroupbox.Controls.Add(this.label3);
            this.Ordergroupbox.Controls.Add(this.label2);
            this.Ordergroupbox.Location = new System.Drawing.Point(44, 86);
            this.Ordergroupbox.Name = "Ordergroupbox";
            this.Ordergroupbox.Size = new System.Drawing.Size(696, 309);
            this.Ordergroupbox.TabIndex = 0;
            this.Ordergroupbox.TabStop = false;
            this.Ordergroupbox.Text = "Order";
            this.Ordergroupbox.Enter += new System.EventHandler(this.Ordergroupbox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "make an order ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Products :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(511, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "SUM :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 20);
            this.textBox1.TabIndex = 4;
            // 
            // SmallRB
            // 
            this.SmallRB.AutoSize = true;
            this.SmallRB.Location = new System.Drawing.Point(130, 138);
            this.SmallRB.Name = "SmallRB";
            this.SmallRB.Size = new System.Drawing.Size(50, 17);
            this.SmallRB.TabIndex = 5;
            this.SmallRB.TabStop = true;
            this.SmallRB.Text = "Small";
            this.SmallRB.UseVisualStyleBackColor = true;
            // 
            // MediumRB
            // 
            this.MediumRB.AutoSize = true;
            this.MediumRB.Location = new System.Drawing.Point(238, 138);
            this.MediumRB.Name = "MediumRB";
            this.MediumRB.Size = new System.Drawing.Size(62, 17);
            this.MediumRB.TabIndex = 6;
            this.MediumRB.TabStop = true;
            this.MediumRB.Text = "Medium";
            this.MediumRB.UseVisualStyleBackColor = true;
            // 
            // LargeRB
            // 
            this.LargeRB.AutoSize = true;
            this.LargeRB.Location = new System.Drawing.Point(365, 138);
            this.LargeRB.Name = "LargeRB";
            this.LargeRB.Size = new System.Drawing.Size(55, 17);
            this.LargeRB.TabIndex = 7;
            this.LargeRB.TabStop = true;
            this.LargeRB.Text = "Large ";
            this.LargeRB.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(174, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(278, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // Addproductbtn
            // 
            this.Addproductbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addproductbtn.Location = new System.Drawing.Point(503, 65);
            this.Addproductbtn.Name = "Addproductbtn";
            this.Addproductbtn.Size = new System.Drawing.Size(160, 54);
            this.Addproductbtn.TabIndex = 9;
            this.Addproductbtn.Text = "Add";
            this.Addproductbtn.UseVisualStyleBackColor = true;
            this.Addproductbtn.Click += new System.EventHandler(this.Addproductbtn_Click);
            // 
            // Checkoutbtn
            // 
            this.Checkoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkoutbtn.Location = new System.Drawing.Point(503, 177);
            this.Checkoutbtn.Name = "Checkoutbtn";
            this.Checkoutbtn.Size = new System.Drawing.Size(160, 54);
            this.Checkoutbtn.TabIndex = 10;
            this.Checkoutbtn.Text = "Checkout";
            this.Checkoutbtn.UseVisualStyleBackColor = true;
            this.Checkoutbtn.Click += new System.EventHandler(this.Checkoutbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.Location = new System.Drawing.Point(251, 401);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(254, 37);
            this.Exitbtn.TabIndex = 1;
            this.Exitbtn.Text = "Back";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // BusketOForders
            // 
            this.BusketOForders.FormattingEnabled = true;
            this.BusketOForders.Location = new System.Drawing.Point(29, 177);
            this.BusketOForders.Name = "BusketOForders";
            this.BusketOForders.Size = new System.Drawing.Size(432, 95);
            this.BusketOForders.TabIndex = 11;
            // 
            // Sumlbl
            // 
            this.Sumlbl.AutoSize = true;
            this.Sumlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sumlbl.Location = new System.Drawing.Point(588, 249);
            this.Sumlbl.Name = "Sumlbl";
            this.Sumlbl.Size = new System.Drawing.Size(23, 16);
            this.Sumlbl.TabIndex = 12;
            this.Sumlbl.Text = "....";
            // 
            // orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ordergroupbox);
            this.Name = "orders";
            this.Text = "orders";
            this.Ordergroupbox.ResumeLayout(false);
            this.Ordergroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Ordergroupbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Checkoutbtn;
        private System.Windows.Forms.Button Addproductbtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton LargeRB;
        private System.Windows.Forms.RadioButton MediumRB;
        private System.Windows.Forms.RadioButton SmallRB;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.ListBox BusketOForders;
        private System.Windows.Forms.Label Sumlbl;
    }
}