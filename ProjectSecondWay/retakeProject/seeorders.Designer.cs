namespace retakeProject
{
    partial class seeorders
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
            this.listboxIDs = new System.Windows.Forms.ListBox();
            this.listboxItems = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ordertotallabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.orderIDlabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sumOfAlllabel = new System.Windows.Forms.Label();
            this.totallabel = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listboxIDs
            // 
            this.listboxIDs.FormattingEnabled = true;
            this.listboxIDs.Location = new System.Drawing.Point(37, 122);
            this.listboxIDs.Name = "listboxIDs";
            this.listboxIDs.Size = new System.Drawing.Size(228, 212);
            this.listboxIDs.TabIndex = 11;
            this.listboxIDs.SelectedIndexChanged += new System.EventHandler(this.listboxIDs_SelectedIndexChanged);
            // 
            // listboxItems
            // 
            this.listboxItems.FormattingEnabled = true;
            this.listboxItems.Location = new System.Drawing.Point(414, 233);
            this.listboxItems.Name = "listboxItems";
            this.listboxItems.Size = new System.Drawing.Size(320, 95);
            this.listboxItems.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "See orders ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "All orders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Order Items";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(410, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Order ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Customer name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(410, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Order total :";
            // 
            // ordertotallabel
            // 
            this.ordertotallabel.AutoSize = true;
            this.ordertotallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordertotallabel.Location = new System.Drawing.Point(592, 165);
            this.ordertotallabel.Name = "ordertotallabel";
            this.ordertotallabel.Size = new System.Drawing.Size(70, 25);
            this.ordertotallabel.TabIndex = 21;
            this.ordertotallabel.Text = "label7";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(592, 132);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(70, 25);
            this.namelabel.TabIndex = 20;
            this.namelabel.Text = "label8";
            // 
            // orderIDlabel
            // 
            this.orderIDlabel.AutoSize = true;
            this.orderIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDlabel.Location = new System.Drawing.Point(592, 91);
            this.orderIDlabel.Name = "orderIDlabel";
            this.orderIDlabel.Size = new System.Drawing.Size(70, 25);
            this.orderIDlabel.TabIndex = 19;
            this.orderIDlabel.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "total orders";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "sum of all";
            // 
            // sumOfAlllabel
            // 
            this.sumOfAlllabel.AutoSize = true;
            this.sumOfAlllabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumOfAlllabel.Location = new System.Drawing.Point(146, 393);
            this.sumOfAlllabel.Name = "sumOfAlllabel";
            this.sumOfAlllabel.Size = new System.Drawing.Size(70, 24);
            this.sumOfAlllabel.TabIndex = 25;
            this.sumOfAlllabel.Text = "label12";
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallabel.Location = new System.Drawing.Point(146, 364);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(70, 24);
            this.totallabel.TabIndex = 24;
            this.totallabel.Text = "label13";
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(528, 373);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(152, 44);
            this.backbtn.TabIndex = 26;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // seeorders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.sumOfAlllabel);
            this.Controls.Add(this.totallabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ordertotallabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.orderIDlabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listboxItems);
            this.Controls.Add(this.listboxIDs);
            this.Name = "seeorders";
            this.Text = "seeorders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxIDs;
        private System.Windows.Forms.ListBox listboxItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ordertotallabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label orderIDlabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label sumOfAlllabel;
        private System.Windows.Forms.Label totallabel;
        private System.Windows.Forms.Button backbtn;
    }
}