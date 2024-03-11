namespace retakeProject
{
    partial class addorder
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupboxorder = new System.Windows.Forms.GroupBox();
            this.comboBoxMenu = new System.Windows.Forms.ComboBox();
            this.sumlabel = new System.Windows.Forms.Label();
            this.Finishbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.radiobtnLarge = new System.Windows.Forms.RadioButton();
            this.radiobtnMedium = new System.Windows.Forms.RadioButton();
            this.radiobtnSmall = new System.Windows.Forms.RadioButton();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupboxorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "add order ";
            // 
            // groupboxorder
            // 
            this.groupboxorder.Controls.Add(this.label5);
            this.groupboxorder.Controls.Add(this.comboBoxMenu);
            this.groupboxorder.Controls.Add(this.sumlabel);
            this.groupboxorder.Controls.Add(this.Finishbtn);
            this.groupboxorder.Controls.Add(this.Addbtn);
            this.groupboxorder.Controls.Add(this.listBoxItems);
            this.groupboxorder.Controls.Add(this.radiobtnLarge);
            this.groupboxorder.Controls.Add(this.radiobtnMedium);
            this.groupboxorder.Controls.Add(this.radiobtnSmall);
            this.groupboxorder.Controls.Add(this.textBoxname);
            this.groupboxorder.Controls.Add(this.label4);
            this.groupboxorder.Controls.Add(this.label3);
            this.groupboxorder.Controls.Add(this.label2);
            this.groupboxorder.Location = new System.Drawing.Point(29, 106);
            this.groupboxorder.Name = "groupboxorder";
            this.groupboxorder.Size = new System.Drawing.Size(742, 286);
            this.groupboxorder.TabIndex = 1;
            this.groupboxorder.TabStop = false;
            this.groupboxorder.Text = "order";
            // 
            // comboBoxMenu
            // 
            this.comboBoxMenu.FormattingEnabled = true;
            this.comboBoxMenu.Location = new System.Drawing.Point(180, 80);
            this.comboBoxMenu.Name = "comboBoxMenu";
            this.comboBoxMenu.Size = new System.Drawing.Size(184, 21);
            this.comboBoxMenu.TabIndex = 13;
            // 
            // sumlabel
            // 
            this.sumlabel.AutoSize = true;
            this.sumlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumlabel.Location = new System.Drawing.Point(505, 178);
            this.sumlabel.Name = "sumlabel";
            this.sumlabel.Size = new System.Drawing.Size(35, 16);
            this.sumlabel.TabIndex = 12;
            this.sumlabel.Text = "sum";
            // 
            // Finishbtn
            // 
            this.Finishbtn.Location = new System.Drawing.Point(417, 200);
            this.Finishbtn.Name = "Finishbtn";
            this.Finishbtn.Size = new System.Drawing.Size(136, 50);
            this.Finishbtn.TabIndex = 10;
            this.Finishbtn.Text = "checkout";
            this.Finishbtn.UseVisualStyleBackColor = true;
            this.Finishbtn.Click += new System.EventHandler(this.Finishbtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(417, 51);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(136, 50);
            this.Addbtn.TabIndex = 9;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(44, 165);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(320, 95);
            this.listBoxItems.TabIndex = 8;
            // 
            // radiobtnLarge
            // 
            this.radiobtnLarge.AutoSize = true;
            this.radiobtnLarge.Location = new System.Drawing.Point(263, 142);
            this.radiobtnLarge.Name = "radiobtnLarge";
            this.radiobtnLarge.Size = new System.Drawing.Size(48, 17);
            this.radiobtnLarge.TabIndex = 7;
            this.radiobtnLarge.TabStop = true;
            this.radiobtnLarge.Text = "large";
            this.radiobtnLarge.UseVisualStyleBackColor = true;
            // 
            // radiobtnMedium
            // 
            this.radiobtnMedium.AutoSize = true;
            this.radiobtnMedium.Location = new System.Drawing.Point(160, 142);
            this.radiobtnMedium.Name = "radiobtnMedium";
            this.radiobtnMedium.Size = new System.Drawing.Size(61, 17);
            this.radiobtnMedium.TabIndex = 6;
            this.radiobtnMedium.TabStop = true;
            this.radiobtnMedium.Text = "meduim";
            this.radiobtnMedium.UseVisualStyleBackColor = true;
            // 
            // radiobtnSmall
            // 
            this.radiobtnSmall.AutoSize = true;
            this.radiobtnSmall.Location = new System.Drawing.Point(56, 142);
            this.radiobtnSmall.Name = "radiobtnSmall";
            this.radiobtnSmall.Size = new System.Drawing.Size(48, 17);
            this.radiobtnSmall.TabIndex = 5;
            this.radiobtnSmall.TabStop = true;
            this.radiobtnSmall.Text = "small";
            this.radiobtnSmall.UseVisualStyleBackColor = true;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(180, 50);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(184, 20);
            this.textBoxname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Products Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "oeder ID ";
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(189, 405);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(370, 40);
            this.Backbtn.TabIndex = 11;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cert Sum:";
            // 
            // addorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.groupboxorder);
            this.Controls.Add(this.label1);
            this.Name = "addorder";
            this.Text = "addorder";
            this.Load += new System.EventHandler(this.addorder_Load);
            this.groupboxorder.ResumeLayout(false);
            this.groupboxorder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupboxorder;
        private System.Windows.Forms.RadioButton radiobtnLarge;
        private System.Windows.Forms.RadioButton radiobtnMedium;
        private System.Windows.Forms.RadioButton radiobtnSmall;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sumlabel;
        private System.Windows.Forms.Button Finishbtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.ComboBox comboBoxMenu;
        private System.Windows.Forms.Label label5;
    }
}