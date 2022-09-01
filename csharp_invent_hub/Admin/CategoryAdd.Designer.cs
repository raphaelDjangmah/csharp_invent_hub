namespace CSharp_Invent_HUB.csharp_invent_hub.Admin
{
    partial class CategoryAdd
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
            this.add_category_label = new System.Windows.Forms.Label();
            this.add_category_box = new System.Windows.Forms.TextBox();
            this.add_category_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_category_label
            // 
            this.add_category_label.AutoSize = true;
            this.add_category_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_category_label.Location = new System.Drawing.Point(58, 33);
            this.add_category_label.Name = "add_category_label";
            this.add_category_label.Size = new System.Drawing.Size(351, 32);
            this.add_category_label.TabIndex = 0;
            this.add_category_label.Text = "UPDATE EXISTING CATEGORY";
            this.add_category_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // add_category_box
            // 
            this.add_category_box.BackColor = System.Drawing.SystemColors.Control;
            this.add_category_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_category_box.Location = new System.Drawing.Point(72, 112);
            this.add_category_box.Multiline = true;
            this.add_category_box.Name = "add_category_box";
            this.add_category_box.PlaceholderText = "Add New Category";
            this.add_category_box.Size = new System.Drawing.Size(315, 45);
            this.add_category_box.TabIndex = 1;
            this.add_category_box.TextChanged += new System.EventHandler(this.add_category_box_TextChanged);
            // 
            // add_category_btn
            // 
            this.add_category_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add_category_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_category_btn.ForeColor = System.Drawing.Color.White;
            this.add_category_btn.Location = new System.Drawing.Point(154, 223);
            this.add_category_btn.Name = "add_category_btn";
            this.add_category_btn.Size = new System.Drawing.Size(141, 47);
            this.add_category_btn.TabIndex = 2;
            this.add_category_btn.Text = "UPDATE";
            this.add_category_btn.UseVisualStyleBackColor = false;
            this.add_category_btn.Click += new System.EventHandler(this.add_category_btn_Click);
            // 
            // CategoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(455, 357);
            this.Controls.Add(this.add_category_btn);
            this.Controls.Add(this.add_category_box);
            this.Controls.Add(this.add_category_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CategoryAdd";
            this.Text = "CategoryAdd";
            this.Load += new System.EventHandler(this.CategoryAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label add_category_label;
        private System.Windows.Forms.TextBox add_category_box;
        private System.Windows.Forms.Button add_category_btn;
    }
}