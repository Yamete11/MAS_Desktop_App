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
    public partial class TypeForm : Form
    {
        public TypeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm orderForm = new OrderForm(1, 0);
            orderForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestNumberForm guestNumberForm = new GuestNumberForm();
            guestNumberForm.Show();
        }
    }
}
