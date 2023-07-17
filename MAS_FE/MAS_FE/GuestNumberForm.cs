using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAS_FE
{
    public partial class GuestNumberForm : Form
    {
        public GuestNumberForm()
        {
            InitializeComponent();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void Confirm_button_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            
            if (int.TryParse(input, out int number))
            {
                if (number <= 23)
                {
                    this.Hide();
                    OrderForm Order = new OrderForm(2, number);
                    Order.Show();
                }
                else
                {
                    MessageBox.Show("Number must be less than or equal to 23.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
