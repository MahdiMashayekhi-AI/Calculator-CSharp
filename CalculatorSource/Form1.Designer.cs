namespace calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnbackspace = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bbtn0 = new System.Windows.Forms.Button();
            this.btnonoff = new System.Windows.Forms.Button();
            this.txtdisplay = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btnbackspace);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.btnpoint);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.btnequal);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.bbtn0);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 335);
            this.panel1.TabIndex = 0;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(160, 10);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(148, 43);
            this.btnclear.TabIndex = 18;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnbackspace
            // 
            this.btnbackspace.Location = new System.Drawing.Point(10, 10);
            this.btnbackspace.Name = "btnbackspace";
            this.btnbackspace.Size = new System.Drawing.Size(148, 43);
            this.btnbackspace.TabIndex = 17;
            this.btnbackspace.Text = "<---------";
            this.btnbackspace.UseVisualStyleBackColor = true;
            this.btnbackspace.Click += new System.EventHandler(this.btnbackspace_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button13.Location = new System.Drawing.Point(235, 84);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(73, 55);
            this.button13.TabIndex = 16;
            this.button13.Text = "*";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operators);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button14.Location = new System.Drawing.Point(160, 84);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(73, 55);
            this.button14.TabIndex = 15;
            this.button14.Text = "-";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operators);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button15.Location = new System.Drawing.Point(85, 84);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(73, 55);
            this.button15.TabIndex = 14;
            this.button15.Text = "+";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operators);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button16.Location = new System.Drawing.Point(10, 84);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(73, 55);
            this.button16.TabIndex = 13;
            this.button16.Text = "9";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button9.Location = new System.Drawing.Point(235, 143);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(73, 55);
            this.button9.TabIndex = 12;
            this.button9.Text = "/";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operators);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button10.Location = new System.Drawing.Point(160, 143);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(73, 55);
            this.button10.TabIndex = 11;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button11.Location = new System.Drawing.Point(85, 143);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(73, 55);
            this.button11.TabIndex = 10;
            this.button11.Text = "7";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button12.Location = new System.Drawing.Point(10, 143);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(73, 55);
            this.button12.TabIndex = 9;
            this.button12.Text = "6";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btnpoint
            // 
            this.btnpoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnpoint.Location = new System.Drawing.Point(235, 201);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(73, 55);
            this.btnpoint.TabIndex = 8;
            this.btnpoint.Text = ".";
            this.btnpoint.UseVisualStyleBackColor = false;
            this.btnpoint.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button6.Location = new System.Drawing.Point(160, 201);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 55);
            this.button6.TabIndex = 7;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button7.Location = new System.Drawing.Point(85, 201);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(73, 55);
            this.button7.TabIndex = 6;
            this.button7.Text = "4";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button8.Location = new System.Drawing.Point(10, 201);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(73, 55);
            this.button8.TabIndex = 5;
            this.button8.Text = "3";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btnequal
            // 
            this.btnequal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnequal.Location = new System.Drawing.Point(235, 259);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(73, 55);
            this.btnequal.TabIndex = 4;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = false;
            this.btnequal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnequal_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(160, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(85, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // bbtn0
            // 
            this.bbtn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bbtn0.Location = new System.Drawing.Point(10, 259);
            this.bbtn0.Name = "bbtn0";
            this.bbtn0.Size = new System.Drawing.Size(73, 55);
            this.bbtn0.TabIndex = 1;
            this.bbtn0.Text = "0";
            this.bbtn0.UseVisualStyleBackColor = false;
            this.bbtn0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btnonoff
            // 
            this.btnonoff.Location = new System.Drawing.Point(22, 93);
            this.btnonoff.Name = "btnonoff";
            this.btnonoff.Size = new System.Drawing.Size(73, 43);
            this.btnonoff.TabIndex = 19;
            this.btnonoff.Text = "On";
            this.btnonoff.UseVisualStyleBackColor = true;
            this.btnonoff.Click += new System.EventHandler(this.btnonoff_Click);
            // 
            // txtdisplay
            // 
            this.txtdisplay.BackColor = System.Drawing.Color.White;
            this.txtdisplay.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtdisplay.Location = new System.Drawing.Point(22, 36);
            this.txtdisplay.Name = "txtdisplay";
            this.txtdisplay.ReadOnly = true;
            this.txtdisplay.Size = new System.Drawing.Size(298, 36);
            this.txtdisplay.TabIndex = 20;
            this.txtdisplay.TextChanged += new System.EventHandler(this.txtdisplay_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(345, 491);
            this.Controls.Add(this.txtdisplay);
            this.Controls.Add(this.btnonoff);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator | Mashayekhi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnbackspace;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btnpoint;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bbtn0;
        private System.Windows.Forms.Button btnonoff;
        private System.Windows.Forms.TextBox txtdisplay;

    }
}

