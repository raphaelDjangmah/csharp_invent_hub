namespace CSharp_Invent_HUB
{
    partial class Signup_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.othernames = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.confirm_password = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.otp = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(650, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(709, 509);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(360, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome To SHOPRITE";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // firstname
            // 
            this.firstname.BackColor = System.Drawing.SystemColors.HighlightText;
            this.firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstname.Location = new System.Drawing.Point(26, 143);
            this.firstname.Multiline = true;
            this.firstname.Name = "firstname";
            this.firstname.PlaceholderText = "First Name";
            this.firstname.Size = new System.Drawing.Size(284, 44);
            this.firstname.TabIndex = 4;
            this.firstname.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(89, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(442, 61);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(438, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Create An Account With Us";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Eras Medium ITC", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(676, 668);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(490, 34);
            this.label5.TabIndex = 12;
            this.label5.Text = "SHOPRITE, Your Shop Right Here!";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // othernames
            // 
            this.othernames.BackColor = System.Drawing.SystemColors.HighlightText;
            this.othernames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.othernames.Location = new System.Drawing.Point(342, 143);
            this.othernames.Multiline = true;
            this.othernames.Name = "othernames";
            this.othernames.PlaceholderText = "Last Name";
            this.othernames.Size = new System.Drawing.Size(284, 44);
            this.othernames.TabIndex = 13;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.HighlightText;
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Location = new System.Drawing.Point(26, 208);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.PlaceholderText = "Email";
            this.email.Size = new System.Drawing.Size(600, 44);
            this.email.TabIndex = 14;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.HighlightText;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Location = new System.Drawing.Point(26, 273);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PlaceholderText = "Choose Password";
            this.password.Size = new System.Drawing.Size(600, 44);
            this.password.TabIndex = 15;
            // 
            // confirm_password
            // 
            this.confirm_password.BackColor = System.Drawing.SystemColors.HighlightText;
            this.confirm_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirm_password.Location = new System.Drawing.Point(26, 352);
            this.confirm_password.Multiline = true;
            this.confirm_password.Name = "confirm_password";
            this.confirm_password.PlaceholderText = "Re-Enter Password";
            this.confirm_password.Size = new System.Drawing.Size(600, 44);
            this.confirm_password.TabIndex = 16;
            this.confirm_password.TextChanged += new System.EventHandler(this.confirm_password_TextChanged);
            // 
            // phone
            // 
            this.phone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.phone.BackColor = System.Drawing.SystemColors.HighlightText;
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone.Location = new System.Drawing.Point(26, 427);
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.PlaceholderText = "Phone Number";
            this.phone.Size = new System.Drawing.Size(370, 44);
            this.phone.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.AliceBlue;
            this.button2.Location = new System.Drawing.Point(387, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 44);
            this.button2.TabIndex = 18;
            this.button2.Text = "Verify Number";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // otp
            // 
            this.otp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.otp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.otp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.otp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otp.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.otp.Location = new System.Drawing.Point(89, 507);
            this.otp.Multiline = true;
            this.otp.Name = "otp";
            this.otp.PlaceholderText = "Enter 6 Digit Code";
            this.otp.Size = new System.Drawing.Size(456, 53);
            this.otp.TabIndex = 20;
            this.otp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(26, 677);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(222, 25);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already Have An Account?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Signup_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1353, 711);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.otp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.confirm_password);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.othernames);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Signup_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox othernames;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox confirm_password;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox otp;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
