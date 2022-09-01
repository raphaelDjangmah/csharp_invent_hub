namespace CSharp_Invent_HUB.csharp_invent_hub.Admin
{
    partial class Customers_Add
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
            this.customer_label_update = new System.Windows.Forms.Label();
            this.customer_update_btn = new System.Windows.Forms.Button();
            this.update_customer_phone = new System.Windows.Forms.TextBox();
            this.update_customer_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // customer_label_update
            // 
            this.customer_label_update.AutoSize = true;
            this.customer_label_update.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customer_label_update.Location = new System.Drawing.Point(100, 77);
            this.customer_label_update.Name = "customer_label_update";
            this.customer_label_update.Size = new System.Drawing.Size(368, 36);
            this.customer_label_update.TabIndex = 12;
            this.customer_label_update.Text = "UPDATE CUSTOMER DETAILS";
            this.customer_label_update.Click += new System.EventHandler(this.customer_label_update_Click);
            // 
            // customer_update_btn
            // 
            this.customer_update_btn.BackColor = System.Drawing.SystemColors.GrayText;
            this.customer_update_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customer_update_btn.ForeColor = System.Drawing.Color.Transparent;
            this.customer_update_btn.Location = new System.Drawing.Point(192, 335);
            this.customer_update_btn.Name = "customer_update_btn";
            this.customer_update_btn.Size = new System.Drawing.Size(187, 69);
            this.customer_update_btn.TabIndex = 11;
            this.customer_update_btn.Text = "UPDATE";
            this.customer_update_btn.UseVisualStyleBackColor = false;
            this.customer_update_btn.Click += new System.EventHandler(this.customer_update_btn_Click);
            // 
            // update_customer_phone
            // 
            this.update_customer_phone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.update_customer_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.update_customer_phone.Location = new System.Drawing.Point(103, 255);
            this.update_customer_phone.Multiline = true;
            this.update_customer_phone.Name = "update_customer_phone";
            this.update_customer_phone.PlaceholderText = "Customer Phone";
            this.update_customer_phone.Size = new System.Drawing.Size(365, 49);
            this.update_customer_phone.TabIndex = 10;
            this.update_customer_phone.TextChanged += new System.EventHandler(this.update_customer_phone_TextChanged);
            // 
            // update_customer_name
            // 
            this.update_customer_name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.update_customer_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.update_customer_name.Location = new System.Drawing.Point(103, 160);
            this.update_customer_name.Multiline = true;
            this.update_customer_name.Name = "update_customer_name";
            this.update_customer_name.PlaceholderText = "Customer Name";
            this.update_customer_name.Size = new System.Drawing.Size(365, 49);
            this.update_customer_name.TabIndex = 9;
            this.update_customer_name.TextChanged += new System.EventHandler(this.update_customer_name_TextChanged);
            // 
            // Customers_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 515);
            this.Controls.Add(this.customer_label_update);
            this.Controls.Add(this.customer_update_btn);
            this.Controls.Add(this.update_customer_phone);
            this.Controls.Add(this.update_customer_name);
            this.Name = "Customers_Add";
            this.Text = "Customers_Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customer_label_update;
        private System.Windows.Forms.Button customer_update_btn;
        private System.Windows.Forms.TextBox update_customer_phone;
        private System.Windows.Forms.TextBox update_customer_name;
    }
}