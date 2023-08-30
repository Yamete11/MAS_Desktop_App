namespace MAS_FE
{
    partial class OrderForm
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
            this.Cart_listbox = new System.Windows.Forms.ListBox();
            this.Products_listbox = new System.Windows.Forms.ListBox();
            this.Food_button = new System.Windows.Forms.Button();
            this.Drik_button = new System.Windows.Forms.Button();
            this.Pay_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Void_button = new System.Windows.Forms.Button();
            this.Send_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sum_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cash_button = new System.Windows.Forms.Button();
            this.Mastercard_button = new System.Windows.Forms.Button();
            this.Visa_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cart_listbox
            // 
            this.Cart_listbox.FormattingEnabled = true;
            this.Cart_listbox.ItemHeight = 15;
            this.Cart_listbox.Location = new System.Drawing.Point(46, 102);
            this.Cart_listbox.Name = "Cart_listbox";
            this.Cart_listbox.Size = new System.Drawing.Size(225, 229);
            this.Cart_listbox.TabIndex = 0;
            this.Cart_listbox.SelectedIndexChanged += new System.EventHandler(this.Cart_listbox_SelectedIndexChanged);
            // 
            // Products_listbox
            // 
            this.Products_listbox.FormattingEnabled = true;
            this.Products_listbox.ItemHeight = 15;
            this.Products_listbox.Location = new System.Drawing.Point(216, 32);
            this.Products_listbox.Name = "Products_listbox";
            this.Products_listbox.Size = new System.Drawing.Size(225, 244);
            this.Products_listbox.TabIndex = 1;
            this.Products_listbox.SelectedIndexChanged += new System.EventHandler(this.Products_listbox_SelectedIndexChanged);
            // 
            // Food_button
            // 
            this.Food_button.Location = new System.Drawing.Point(46, 21);
            this.Food_button.Name = "Food_button";
            this.Food_button.Size = new System.Drawing.Size(125, 43);
            this.Food_button.TabIndex = 2;
            this.Food_button.Text = "Food";
            this.Food_button.UseVisualStyleBackColor = true;
            this.Food_button.Click += new System.EventHandler(this.Food_button_Click);
            // 
            // Drik_button
            // 
            this.Drik_button.Location = new System.Drawing.Point(323, 21);
            this.Drik_button.Name = "Drik_button";
            this.Drik_button.Size = new System.Drawing.Size(124, 43);
            this.Drik_button.TabIndex = 3;
            this.Drik_button.Text = "Drink";
            this.Drik_button.UseVisualStyleBackColor = true;
            this.Drik_button.Click += new System.EventHandler(this.Drik_button_Click);
            // 
            // Pay_button
            // 
            this.Pay_button.Location = new System.Drawing.Point(618, 21);
            this.Pay_button.Name = "Pay_button";
            this.Pay_button.Size = new System.Drawing.Size(124, 43);
            this.Pay_button.TabIndex = 4;
            this.Pay_button.Text = "Pay";
            this.Pay_button.UseVisualStyleBackColor = true;
            this.Pay_button.Click += new System.EventHandler(this.Pay_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(46, 370);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(125, 43);
            this.Cancel_button.TabIndex = 5;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(31, 78);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(124, 43);
            this.Add_button.TabIndex = 6;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Void_button
            // 
            this.Void_button.Location = new System.Drawing.Point(31, 177);
            this.Void_button.Name = "Void_button";
            this.Void_button.Size = new System.Drawing.Size(124, 43);
            this.Void_button.TabIndex = 7;
            this.Void_button.Text = "Void";
            this.Void_button.UseVisualStyleBackColor = true;
            this.Void_button.Click += new System.EventHandler(this.Void_button_Click);
            // 
            // Send_button
            // 
            this.Send_button.Location = new System.Drawing.Point(618, 380);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(124, 43);
            this.Send_button.TabIndex = 8;
            this.Send_button.Text = "Send";
            this.Send_button.UseVisualStyleBackColor = true;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "List of products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sum:";
            // 
            // Sum_label
            // 
            this.Sum_label.AutoSize = true;
            this.Sum_label.Location = new System.Drawing.Point(114, 343);
            this.Sum_label.Name = "Sum_label";
            this.Sum_label.Size = new System.Drawing.Size(38, 15);
            this.Sum_label.TabIndex = 12;
            this.Sum_label.Text = "label4";
            this.Sum_label.Click += new System.EventHandler(this.Sum_label_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Void_button);
            this.panel1.Controls.Add(this.Add_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Products_listbox);
            this.panel1.Location = new System.Drawing.Point(301, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 304);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Cash_button);
            this.panel2.Controls.Add(this.Mastercard_button);
            this.panel2.Controls.Add(this.Visa_button);
            this.panel2.Location = new System.Drawing.Point(301, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 304);
            this.panel2.TabIndex = 14;
            // 
            // Cash_button
            // 
            this.Cash_button.Location = new System.Drawing.Point(233, 125);
            this.Cash_button.Name = "Cash_button";
            this.Cash_button.Size = new System.Drawing.Size(124, 43);
            this.Cash_button.TabIndex = 2;
            this.Cash_button.Text = "Cash";
            this.Cash_button.UseVisualStyleBackColor = true;
            this.Cash_button.Click += new System.EventHandler(this.Cash_button_Click);
            // 
            // Mastercard_button
            // 
            this.Mastercard_button.Location = new System.Drawing.Point(31, 177);
            this.Mastercard_button.Name = "Mastercard_button";
            this.Mastercard_button.Size = new System.Drawing.Size(124, 43);
            this.Mastercard_button.TabIndex = 1;
            this.Mastercard_button.Text = "Mastercard";
            this.Mastercard_button.UseVisualStyleBackColor = true;
            this.Mastercard_button.Click += new System.EventHandler(this.Mastercard_button_Click);
            // 
            // Visa_button
            // 
            this.Visa_button.Location = new System.Drawing.Point(31, 78);
            this.Visa_button.Name = "Visa_button";
            this.Visa_button.Size = new System.Drawing.Size(124, 43);
            this.Visa_button.TabIndex = 0;
            this.Visa_button.Text = "Visa";
            this.Visa_button.UseVisualStyleBackColor = true;
            this.Visa_button.Click += new System.EventHandler(this.Visa_button_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 451);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Sum_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Send_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Pay_button);
            this.Controls.Add(this.Drik_button);
            this.Controls.Add(this.Food_button);
            this.Controls.Add(this.Cart_listbox);
            this.Controls.Add(this.panel1);
            this.Name = "OrderForm";
            this.Text = "```";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Cart_listbox;
        private System.Windows.Forms.ListBox Products_listbox;
        private System.Windows.Forms.Button Food_button;
        private System.Windows.Forms.Button Drik_button;
        private System.Windows.Forms.Button Pay_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Void_button;
        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Sum_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Cash_button;
        private System.Windows.Forms.Button Mastercard_button;
        private System.Windows.Forms.Button Visa_button;
    }
}