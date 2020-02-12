namespace WindowsFormsApplication3
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
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            this.label1 = new System.Windows.Forms.Label();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.reset_Button = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton2 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton3 = new Infragistics.Win.Misc.UltraButton();
            this.Principal = new System.Windows.Forms.RichTextBox();
            this.Rate = new System.Windows.Forms.RichTextBox();
            this.Time = new System.Windows.Forms.RichTextBox();
            this.interestAmount = new Infragistics.Win.Misc.UltraLabel();
            this.siResult = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.ciResult = new Infragistics.Win.Misc.UltraLabel();
            this.interestAmount2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel9 = new Infragistics.Win.Misc.UltraLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Interest Calculator";
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ultraLabel1.Location = new System.Drawing.Point(29, 61);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(142, 23);
            this.ultraLabel1.TabIndex = 1;
            this.ultraLabel1.Text = "Principal Amount ($)";
            this.ultraLabel1.Click += new System.EventHandler(this.ultraLabel1_Click);
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ultraLabel2.Location = new System.Drawing.Point(29, 119);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(109, 23);
            this.ultraLabel2.TabIndex = 2;
            this.ultraLabel2.Text = "Period (Years)";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ultraLabel3.Location = new System.Drawing.Point(29, 90);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(123, 23);
            this.ultraLabel3.TabIndex = 3;
            this.ultraLabel3.Text = "Interest Rate (%)";
            // 
            // reset_Button
            // 
            appearance9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.reset_Button.Appearance = appearance9;
            this.reset_Button.ImageTransparentColor = System.Drawing.Color.DarkRed;
            this.reset_Button.Location = new System.Drawing.Point(148, 353);
            this.reset_Button.Name = "reset_Button";
            this.reset_Button.Size = new System.Drawing.Size(75, 23);
            this.reset_Button.TabIndex = 4;
            this.reset_Button.Text = "RESET";
            this.reset_Button.Click += new System.EventHandler(this.reset_Button_Click);
            // 
            // ultraButton2
            // 
            appearance10.BackColor = System.Drawing.Color.Aqua;
            appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Container;
            this.ultraButton2.Appearance = appearance10;
            this.ultraButton2.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button3D;
            this.ultraButton2.Location = new System.Drawing.Point(29, 249);
            this.ultraButton2.Name = "ultraButton2";
            this.ultraButton2.Size = new System.Drawing.Size(132, 23);
            this.ultraButton2.TabIndex = 5;
            this.ultraButton2.Text = "Compound Interest";
            this.ultraButton2.Click += new System.EventHandler(this.CI_Button_Click);
            // 
            // ultraButton3
            // 
            appearance11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            appearance11.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ultraButton3.Appearance = appearance11;
            this.ultraButton3.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button3D;
            this.ultraButton3.Location = new System.Drawing.Point(29, 172);
            this.ultraButton3.Name = "ultraButton3";
            appearance12.BackColor = System.Drawing.Color.Aqua;
            this.ultraButton3.PressedAppearance = appearance12;
            this.ultraButton3.Size = new System.Drawing.Size(100, 23);
            this.ultraButton3.TabIndex = 6;
            this.ultraButton3.Text = "Simple interest";
            this.ultraButton3.Click += new System.EventHandler(this.SI_Button_Click);
            // 
            // Principal
            // 
            this.Principal.Location = new System.Drawing.Point(187, 61);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(100, 23);
            this.Principal.TabIndex = 7;
            this.Principal.Text = "";
            this.Principal.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Rate
            // 
            this.Rate.Location = new System.Drawing.Point(187, 93);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(100, 20);
            this.Rate.TabIndex = 8;
            this.Rate.Text = "";
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(187, 124);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(100, 18);
            this.Time.TabIndex = 9;
            this.Time.Text = "";
            // 
            // interestAmount
            // 
            appearance13.BackColor = System.Drawing.Color.White;
            appearance13.ForeColor = System.Drawing.Color.Black;
            this.interestAmount.Appearance = appearance13;
            this.interestAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.interestAmount.Location = new System.Drawing.Point(187, 201);
            this.interestAmount.Name = "interestAmount";
            this.interestAmount.Size = new System.Drawing.Size(100, 23);
            this.interestAmount.TabIndex = 11;
            this.interestAmount.Text = "0.00 $";
            // 
            // siResult
            // 
            appearance14.BackColor = System.Drawing.Color.White;
            appearance14.ForeColor = System.Drawing.Color.Black;
            this.siResult.Appearance = appearance14;
            this.siResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.siResult.Location = new System.Drawing.Point(187, 172);
            this.siResult.Name = "siResult";
            this.siResult.Size = new System.Drawing.Size(100, 23);
            this.siResult.TabIndex = 12;
            this.siResult.Text = "0.00 $";
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ultraLabel4.Location = new System.Drawing.Point(293, 174);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(123, 23);
            this.ultraLabel4.TabIndex = 13;
            this.ultraLabel4.Text = "Total Amount";
            // 
            // ultraLabel6
            // 
            this.ultraLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ultraLabel6.Location = new System.Drawing.Point(293, 203);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.Size = new System.Drawing.Size(123, 23);
            this.ultraLabel6.TabIndex = 14;
            this.ultraLabel6.Text = "Interest Amount";
            // 
            // ciResult
            // 
            appearance15.BackColor = System.Drawing.Color.White;
            appearance15.ForeColor = System.Drawing.Color.Black;
            this.ciResult.Appearance = appearance15;
            this.ciResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ciResult.Location = new System.Drawing.Point(187, 249);
            this.ciResult.Name = "ciResult";
            this.ciResult.Size = new System.Drawing.Size(100, 23);
            this.ciResult.TabIndex = 15;
            this.ciResult.Text = "0.00 $";
            // 
            // interestAmount2
            // 
            appearance16.BackColor = System.Drawing.Color.White;
            appearance16.ForeColor = System.Drawing.Color.Black;
            this.interestAmount2.Appearance = appearance16;
            this.interestAmount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.interestAmount2.Location = new System.Drawing.Point(187, 278);
            this.interestAmount2.Name = "interestAmount2";
            this.interestAmount2.Size = new System.Drawing.Size(100, 23);
            this.interestAmount2.TabIndex = 16;
            this.interestAmount2.Text = "0.00 $";
            this.interestAmount2.Click += new System.EventHandler(this.CI_Button_Click);
            // 
            // ultraLabel8
            // 
            this.ultraLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ultraLabel8.Location = new System.Drawing.Point(293, 251);
            this.ultraLabel8.Name = "ultraLabel8";
            this.ultraLabel8.Size = new System.Drawing.Size(123, 23);
            this.ultraLabel8.TabIndex = 17;
            this.ultraLabel8.Text = "Total Amount";
            // 
            // ultraLabel9
            // 
            this.ultraLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ultraLabel9.Location = new System.Drawing.Point(293, 278);
            this.ultraLabel9.Name = "ultraLabel9";
            this.ultraLabel9.Size = new System.Drawing.Size(123, 23);
            this.ultraLabel9.TabIndex = 18;
            this.ultraLabel9.Text = "Interest Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(443, 401);
            this.Controls.Add(this.ultraLabel9);
            this.Controls.Add(this.ultraLabel8);
            this.Controls.Add(this.interestAmount2);
            this.Controls.Add(this.ciResult);
            this.Controls.Add(this.ultraLabel6);
            this.Controls.Add(this.ultraLabel4);
            this.Controls.Add(this.siResult);
            this.Controls.Add(this.interestAmount);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.Principal);
            this.Controls.Add(this.ultraButton3);
            this.Controls.Add(this.ultraButton2);
            this.Controls.Add(this.reset_Button);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Interest Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.Misc.UltraButton reset_Button;
        private Infragistics.Win.Misc.UltraButton ultraButton2;
        private Infragistics.Win.Misc.UltraButton ultraButton3;
        private System.Windows.Forms.RichTextBox Principal;
        private System.Windows.Forms.RichTextBox Rate;
        private System.Windows.Forms.RichTextBox Time;
        private Infragistics.Win.Misc.UltraLabel interestAmount;
        private Infragistics.Win.Misc.UltraLabel siResult;
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private Infragistics.Win.Misc.UltraLabel ultraLabel6;
        private Infragistics.Win.Misc.UltraLabel ciResult;
        private Infragistics.Win.Misc.UltraLabel interestAmount2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel8;
        private Infragistics.Win.Misc.UltraLabel ultraLabel9;
    }
}

