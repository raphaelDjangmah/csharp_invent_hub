namespace CSharp_Invent_HUB.csharp_invent_hub.Admin
{
    partial class User_Add
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
            this.update_firstname = new System.Windows.Forms.TextBox();
            this.add_update_user = new System.Windows.Forms.Label();
            this.update_email = new System.Windows.Forms.TextBox();
            this.update_othernames = new System.Windows.Forms.TextBox();
            this.update_phone = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.update_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // update_firstname
            // 
            this.update_firstname.Location = new System.Drawing.Point(80, 104);
            this.update_firstname.Multiline = true;
            this.update_firstname.Name = "update_firstname";
            this.update_firstname.PlaceholderText = "First Name";
            this.update_firstname.Size = new System.Drawing.Size(414, 46);
            this.update_firstname.TabIndex = 0;
            // 
            // add_update_user
            // 
            this.add_update_user.AutoSize = true;
            this.add_update_user.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_update_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.add_update_user.Location = new System.Drawing.Point(143, 31);
            this.add_update_user.Name = "add_update_user";
            this.add_update_user.Size = new System.Drawing.Size(284, 54);
            this.add_update_user.TabIndex = 1;
            this.add_update_user.Text = "UPDATE USER";
            this.add_update_user.Click += new System.EventHandler(this.label1_Click);
            // 
            // update_email
            // 
            this.update_email.Location = new System.Drawing.Point(80, 318);
            this.update_email.Multiline = true;
            this.update_email.Name = "update_email";
            this.update_email.PlaceholderText = "Email";
            this.update_email.Size = new System.Drawing.Size(414, 46);
            this.update_email.TabIndex = 3;
            // 
            // update_othernames
            // 
            this.update_othernames.Location = new System.Drawing.Point(80, 168);
            this.update_othernames.Multiline = true;
            this.update_othernames.Name = "update_othernames";
            this.update_othernames.PlaceholderText = "Last name";
            this.update_othernames.Size = new System.Drawing.Size(414, 46);
            this.update_othernames.TabIndex = 4;
            // 
            // update_phone
            // 
            this.update_phone.Location = new System.Drawing.Point(80, 391);
            this.update_phone.Multiline = true;
            this.update_phone.Name = "update_phone";
            this.update_phone.PlaceholderText = "Phone Number";
            this.update_phone.Size = new System.Drawing.Size(414, 46);
            this.update_phone.TabIndex = 5;
            this.update_phone.TextChanged += new System.EventHandler(this.updatePhone_TextChanged);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Peru;
            this.updateButton.Location = new System.Drawing.Point(198, 488);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(164, 53);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // update_password
            // 
            this.update_password.Location = new System.Drawing.Point(80, 238);
            this.update_password.Multiline = true;
            this.update_password.Name = "update_password";
            this.update_password.PlaceholderText = "Password";
            this.update_password.Size = new System.Drawing.Size(414, 46);
            this.update_password.TabIndex = 7;
            // 
            // User_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(650, 589);
            this.Controls.Add(this.update_password);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.update_phone);
            this.Controls.Add(this.update_othernames);
            this.Controls.Add(this.update_email);
            this.Controls.Add(this.add_update_user);
            this.Controls.Add(this.update_firstname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "User_Add";
            this.Text = "User_Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox update_firstname;
        private System.Windows.Forms.Label add_update_user;
        private System.Windows.Forms.TextBox update_email;
        private System.Windows.Forms.TextBox update_othernames;
        private System.Windows.Forms.TextBox update_phone;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox update_password;
    }
}