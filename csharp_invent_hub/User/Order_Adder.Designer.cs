namespace CSharp_Invent_HUB.csharp_invent_hub.User
{
    partial class Order_Adder
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
            this.update_order_btn = new System.Windows.Forms.Button();
            this.update_order_label = new System.Windows.Forms.Label();
            this.update_order_product = new System.Windows.Forms.ComboBox();
            this.update_order_category = new System.Windows.Forms.ComboBox();
            this.update_od_quantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // update_order_btn
            // 
            this.update_order_btn.BackColor = System.Drawing.Color.Black;
            this.update_order_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update_order_btn.ForeColor = System.Drawing.Color.Transparent;
            this.update_order_btn.Location = new System.Drawing.Point(121, 327);
            this.update_order_btn.Name = "update_order_btn";
            this.update_order_btn.Size = new System.Drawing.Size(184, 49);
            this.update_order_btn.TabIndex = 14;
            this.update_order_btn.Text = "UPDATE";
            this.update_order_btn.UseVisualStyleBackColor = false;
            this.update_order_btn.Click += new System.EventHandler(this.update_order_btn_Click);
            // 
            // update_order_label
            // 
            this.update_order_label.AutoSize = true;
            this.update_order_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update_order_label.Location = new System.Drawing.Point(85, 59);
            this.update_order_label.Name = "update_order_label";
            this.update_order_label.Size = new System.Drawing.Size(242, 41);
            this.update_order_label.TabIndex = 11;
            this.update_order_label.Text = "UPDATE ORDER";
            // 
            // update_order_product
            // 
            this.update_order_product.FormattingEnabled = true;
            this.update_order_product.Location = new System.Drawing.Point(38, 131);
            this.update_order_product.Name = "update_order_product";
            this.update_order_product.Size = new System.Drawing.Size(365, 33);
            this.update_order_product.TabIndex = 19;
            this.update_order_product.Text = "Product";
            // 
            // update_order_category
            // 
            this.update_order_category.FormattingEnabled = true;
            this.update_order_category.Location = new System.Drawing.Point(38, 187);
            this.update_order_category.Name = "update_order_category";
            this.update_order_category.Size = new System.Drawing.Size(365, 33);
            this.update_order_category.TabIndex = 20;
            this.update_order_category.Text = "Category";
            // 
            // update_od_quantity
            // 
            this.update_od_quantity.Location = new System.Drawing.Point(38, 264);
            this.update_od_quantity.Name = "update_od_quantity";
            this.update_od_quantity.PlaceholderText = "Qty";
            this.update_od_quantity.Size = new System.Drawing.Size(365, 31);
            this.update_od_quantity.TabIndex = 21;
            // 
            // Order_Adder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(434, 472);
            this.Controls.Add(this.update_od_quantity);
            this.Controls.Add(this.update_order_category);
            this.Controls.Add(this.update_order_product);
            this.Controls.Add(this.update_order_btn);
            this.Controls.Add(this.update_order_label);
            this.Name = "Order_Adder";
            this.Text = "Order_Adder";
            this.Load += new System.EventHandler(this.Order_Adder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update_order_btn;
        private System.Windows.Forms.Label update_order_label;
        private System.Windows.Forms.ComboBox update_order_product;
        private System.Windows.Forms.ComboBox update_order_category;
        private System.Windows.Forms.TextBox update_od_quantity;
    }
}