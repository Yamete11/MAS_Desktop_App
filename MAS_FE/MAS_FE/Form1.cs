using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAS_FE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Order_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            
            List<Order> orders = await GetOrdersFromApi();

            
            Order_listbox.Items.AddRange(orders.ToArray());

        }

        private async Task<List<Order>> GetOrdersFromApi()
        {
            var apiUrl = "https://localhost:44325/api/Order";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    List<Order> orders = JsonConvert.DeserializeObject<List<Order>>(json);
                    return orders;
                }
                else
                {
                    // Handle error response
                    MessageBox.Show("Failed to retrieve data from the API.");
                    return new List<Order>();
                }
            }
        }

        private void Select_button_Click(object sender, EventArgs e)
        {
            Order? Order = Order_listbox.SelectedItem as Order;
            OrderForm orderForm = new OrderForm(Order.IdOrder);
            orderForm.Show();
            this.Hide();
        }
    }
}
