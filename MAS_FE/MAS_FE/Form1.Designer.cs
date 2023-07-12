namespace MAS_FE
{
    partial class Form1
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
            this.Order_listbox = new System.Windows.Forms.ListBox();
            this.Select_button = new System.Windows.Forms.Button();
            this.Create_button = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Order_listbox
            // 
            this.Order_listbox.FormattingEnabled = true;
            this.Order_listbox.ItemHeight = 15;
            this.Order_listbox.Location = new System.Drawing.Point(45, 90);
            this.Order_listbox.Name = "Order_listbox";
            this.Order_listbox.Size = new System.Drawing.Size(692, 259);
            this.Order_listbox.TabIndex = 0;
            this.Order_listbox.SelectedIndexChanged += new System.EventHandler(this.Order_listbox_SelectedIndexChanged);
            // 
            // Select_button
            // 
            this.Select_button.Location = new System.Drawing.Point(45, 23);
            this.Select_button.Name = "Select_button";
            this.Select_button.Size = new System.Drawing.Size(122, 41);
            this.Select_button.TabIndex = 1;
            this.Select_button.Text = "Select";
            this.Select_button.UseVisualStyleBackColor = true;
            this.Select_button.Click += new System.EventHandler(this.Select_button_Click);
            // 
            // Create_button
            // 
            this.Create_button.Location = new System.Drawing.Point(221, 23);
            this.Create_button.Name = "Create_button";
            this.Create_button.Size = new System.Drawing.Size(122, 41);
            this.Create_button.TabIndex = 2;
            this.Create_button.Text = "Create order";
            this.Create_button.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Location = new System.Drawing.Point(45, 377);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(122, 41);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit_button";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Create_button);
            this.Controls.Add(this.Select_button);
            this.Controls.Add(this.Order_listbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Order_listbox;
        private System.Windows.Forms.Button Select_button;
        private System.Windows.Forms.Button Create_button;
        private System.Windows.Forms.Button Exit;
    }
}
