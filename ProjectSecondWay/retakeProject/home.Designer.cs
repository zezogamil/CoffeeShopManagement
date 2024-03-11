namespace retakeProject
{
    partial class Form1
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
            this.btnaddoeder = new System.Windows.Forms.Button();
            this.btnsee = new System.Windows.Forms.Button();
            this.btnaddpro = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "My coffee shop ";
            // 
            // btnaddoeder
            // 
            this.btnaddoeder.Location = new System.Drawing.Point(287, 119);
            this.btnaddoeder.Name = "btnaddoeder";
            this.btnaddoeder.Size = new System.Drawing.Size(171, 35);
            this.btnaddoeder.TabIndex = 1;
            this.btnaddoeder.Text = "Add order ";
            this.btnaddoeder.UseVisualStyleBackColor = true;
            this.btnaddoeder.Click += new System.EventHandler(this.btnaddoeder_Click);
            // 
            // btnsee
            // 
            this.btnsee.Location = new System.Drawing.Point(287, 171);
            this.btnsee.Name = "btnsee";
            this.btnsee.Size = new System.Drawing.Size(171, 35);
            this.btnsee.TabIndex = 2;
            this.btnsee.Text = "See order ";
            this.btnsee.UseVisualStyleBackColor = true;
            this.btnsee.Click += new System.EventHandler(this.btnsee_Click);
            // 
            // btnaddpro
            // 
            this.btnaddpro.Location = new System.Drawing.Point(287, 231);
            this.btnaddpro.Name = "btnaddpro";
            this.btnaddpro.Size = new System.Drawing.Size(171, 35);
            this.btnaddpro.TabIndex = 3;
            this.btnaddpro.Text = "Add product";
            this.btnaddpro.UseVisualStyleBackColor = true;
            this.btnaddpro.Click += new System.EventHandler(this.btnaddpro_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(287, 289);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(171, 35);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnaddpro);
            this.Controls.Add(this.btnsee);
            this.Controls.Add(this.btnaddoeder);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaddoeder;
        private System.Windows.Forms.Button btnsee;
        private System.Windows.Forms.Button btnaddpro;
        private System.Windows.Forms.Button btnexit;
    }
}

