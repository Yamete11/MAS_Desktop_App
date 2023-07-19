namespace MAS_FE
{
    partial class PayForm
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
            this.Sum_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Send_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Pay_button = new System.Windows.Forms.Button();
            this.Drik_button = new System.Windows.Forms.Button();
            this.Food_button = new System.Windows.Forms.Button();
            this.Cart_listbox = new System.Windows.Forms.ListBox();
            this.Visa_button = new System.Windows.Forms.Button();
            this.Mastercard_button = new System.Windows.Forms.Button();
            this.Cash_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sum_label
            // 
            this.Sum_label.AutoSize = true;
            this.Sum_label.Location = new System.Drawing.Point(120, 346);
            this.Sum_label.Name = "Sum_label";
            this.Sum_label.Size = new System.Drawing.Size(38, 15);
            this.Sum_label.TabIndex = 25;
            this.Sum_label.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cart";
            // 
            // Send_button
            // 
            this.Send_button.Location = new System.Drawing.Point(624, 383);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(124, 43);
            this.Send_button.TabIndex = 21;
            this.Send_button.Text = "Send";
            this.Send_button.UseVisualStyleBackColor = true;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(52, 373);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(125, 43);
            this.Cancel_button.TabIndex = 18;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // Pay_button
            // 
            this.Pay_button.Location = new System.Drawing.Point(624, 24);
            this.Pay_button.Name = "Pay_button";
            this.Pay_button.Size = new System.Drawing.Size(124, 43);
            this.Pay_button.TabIndex = 17;
            this.Pay_button.Text = "Pay";
            this.Pay_button.UseVisualStyleBackColor = true;
            // 
            // Drik_button
            // 
            this.Drik_button.Location = new System.Drawing.Point(329, 24);
            this.Drik_button.Name = "Drik_button";
            this.Drik_button.Size = new System.Drawing.Size(124, 43);
            this.Drik_button.TabIndex = 16;
            this.Drik_button.Text = "Drink";
            this.Drik_button.UseVisualStyleBackColor = true;
            // 
            // Food_button
            // 
            this.Food_button.Location = new System.Drawing.Point(52, 24);
            this.Food_button.Name = "Food_button";
            this.Food_button.Size = new System.Drawing.Size(125, 43);
            this.Food_button.TabIndex = 15;
            this.Food_button.Text = "Food";
            this.Food_button.UseVisualStyleBackColor = true;
            // 
            // Cart_listbox
            // 
            this.Cart_listbox.FormattingEnabled = true;
            this.Cart_listbox.ItemHeight = 15;
            this.Cart_listbox.Location = new System.Drawing.Point(52, 105);
            this.Cart_listbox.Name = "Cart_listbox";
            this.Cart_listbox.Size = new System.Drawing.Size(225, 229);
            this.Cart_listbox.TabIndex = 13;
            // 
            // Visa_button
            // 
            this.Visa_button.Location = new System.Drawing.Point(329, 149);
            this.Visa_button.Name = "Visa_button";
            this.Visa_button.Size = new System.Drawing.Size(124, 43);
            this.Visa_button.TabIndex = 26;
            this.Visa_button.Text = "Visa";
            this.Visa_button.UseVisualStyleBackColor = true;
            // 
            // Mastercard_button
            // 
            this.Mastercard_button.Location = new System.Drawing.Point(329, 241);
            this.Mastercard_button.Name = "Mastercard_button";
            this.Mastercard_button.Size = new System.Drawing.Size(124, 43);
            this.Mastercard_button.TabIndex = 27;
            this.Mastercard_button.Text = "Mastercard";
            this.Mastercard_button.UseVisualStyleBackColor = true;
            // 
            // Cash_button
            // 
            this.Cash_button.Location = new System.Drawing.Point(486, 195);
            this.Cash_button.Name = "Cash_button";
            this.Cash_button.Size = new System.Drawing.Size(124, 43);
            this.Cash_button.TabIndex = 28;
            this.Cash_button.Text = "Cash";
            this.Cash_button.UseVisualStyleBackColor = true;
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cash_button);
            this.Controls.Add(this.Mastercard_button);
            this.Controls.Add(this.Visa_button);
            this.Controls.Add(this.Sum_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Send_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Pay_button);
            this.Controls.Add(this.Drik_button);
            this.Controls.Add(this.Food_button);
            this.Controls.Add(this.Cart_listbox);
            this.Name = "PayForm";
            this.Text = "PayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Sum_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Pay_button;
        private System.Windows.Forms.Button Drik_button;
        private System.Windows.Forms.Button Food_button;
        private System.Windows.Forms.ListBox Cart_listbox;
        private System.Windows.Forms.Button Visa_button;
        private System.Windows.Forms.Button Mastercard_button;
        private System.Windows.Forms.Button Cash_button;
    }
}