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
            this.Exit_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Raport_button = new System.Windows.Forms.Button();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.Raport_panel = new System.Windows.Forms.Panel();
            this.Raport_label = new System.Windows.Forms.Label();
            this.Raport_listbox = new System.Windows.Forms.ListBox();
            this.Back_button = new System.Windows.Forms.Button();
            this.Main_panel.SuspendLayout();
            this.Raport_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Order_listbox
            // 
            this.Order_listbox.FormattingEnabled = true;
            this.Order_listbox.ItemHeight = 15;
            this.Order_listbox.Location = new System.Drawing.Point(28, 68);
            this.Order_listbox.Name = "Order_listbox";
            this.Order_listbox.Size = new System.Drawing.Size(692, 259);
            this.Order_listbox.TabIndex = 0;
            this.Order_listbox.SelectedIndexChanged += new System.EventHandler(this.Order_listbox_SelectedIndexChanged);
            // 
            // Select_button
            // 
            this.Select_button.Location = new System.Drawing.Point(28, 6);
            this.Select_button.Name = "Select_button";
            this.Select_button.Size = new System.Drawing.Size(122, 41);
            this.Select_button.TabIndex = 1;
            this.Select_button.Text = "Select";
            this.Select_button.UseVisualStyleBackColor = true;
            this.Select_button.Click += new System.EventHandler(this.Select_button_Click);
            // 
            // Create_button
            // 
            this.Create_button.Location = new System.Drawing.Point(198, 6);
            this.Create_button.Name = "Create_button";
            this.Create_button.Size = new System.Drawing.Size(122, 41);
            this.Create_button.TabIndex = 2;
            this.Create_button.Text = "Create order";
            this.Create_button.UseVisualStyleBackColor = true;
            this.Create_button.Click += new System.EventHandler(this.Create_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.AutoSize = true;
            this.Exit_button.Location = new System.Drawing.Point(50, 395);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(122, 41);
            this.Exit_button.TabIndex = 3;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(382, 6);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(122, 41);
            this.Add_button.TabIndex = 4;
            this.Add_button.Text = "Add product";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Raport_button
            // 
            this.Raport_button.Location = new System.Drawing.Point(564, 6);
            this.Raport_button.Name = "Raport_button";
            this.Raport_button.Size = new System.Drawing.Size(122, 41);
            this.Raport_button.TabIndex = 5;
            this.Raport_button.Text = "Raport";
            this.Raport_button.UseVisualStyleBackColor = true;
            this.Raport_button.Click += new System.EventHandler(this.Raport_button_Click);
            // 
            // Main_panel
            // 
            this.Main_panel.Controls.Add(this.Raport_button);
            this.Main_panel.Controls.Add(this.Order_listbox);
            this.Main_panel.Controls.Add(this.Select_button);
            this.Main_panel.Controls.Add(this.Add_button);
            this.Main_panel.Controls.Add(this.Create_button);
            this.Main_panel.Location = new System.Drawing.Point(22, 30);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(757, 348);
            this.Main_panel.TabIndex = 6;
            // 
            // Raport_panel
            // 
            this.Raport_panel.Controls.Add(this.Raport_label);
            this.Raport_panel.Controls.Add(this.Raport_listbox);
            this.Raport_panel.Location = new System.Drawing.Point(22, 33);
            this.Raport_panel.Name = "Raport_panel";
            this.Raport_panel.Size = new System.Drawing.Size(757, 348);
            this.Raport_panel.TabIndex = 6;
            // 
            // Raport_label
            // 
            this.Raport_label.AutoSize = true;
            this.Raport_label.Location = new System.Drawing.Point(354, 32);
            this.Raport_label.Name = "Raport_label";
            this.Raport_label.Size = new System.Drawing.Size(42, 15);
            this.Raport_label.TabIndex = 7;
            this.Raport_label.Text = "Raport";
            // 
            // Raport_listbox
            // 
            this.Raport_listbox.FormattingEnabled = true;
            this.Raport_listbox.ItemHeight = 15;
            this.Raport_listbox.Location = new System.Drawing.Point(28, 68);
            this.Raport_listbox.Name = "Raport_listbox";
            this.Raport_listbox.Size = new System.Drawing.Size(692, 259);
            this.Raport_listbox.TabIndex = 6;
            this.Raport_listbox.SelectedIndexChanged += new System.EventHandler(this.Raport_listbox_SelectedIndexChanged);
            // 
            // Back_button
            // 
            this.Back_button.AutoSize = true;
            this.Back_button.Location = new System.Drawing.Point(620, 395);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(122, 41);
            this.Back_button.TabIndex = 7;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Main_panel);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Raport_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Main_panel.ResumeLayout(false);
            this.Raport_panel.ResumeLayout(false);
            this.Raport_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Order_listbox;
        private System.Windows.Forms.Button Select_button;
        private System.Windows.Forms.Button Create_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Raport_button;
        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.Panel Raport_panel;
        private System.Windows.Forms.ListBox Raport_listbox;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Label Raport_label;
    }
}
