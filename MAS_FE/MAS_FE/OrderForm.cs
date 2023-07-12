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
    public partial class OrderForm : Form
    {
        int IdOrder;
        public List<Product> foodList { get; set; }
        public List<Product> drinkList { get; set; }
        public OrderForm(int IdOrder)
        {
            InitializeComponent();
            this.IdOrder = IdOrder;
        }

        private async void OrderForm_Load(object sender, EventArgs e)
        {
            List<Product> products = await GetOrdersFromApi();
            List<OrderProduct> orderProducts = await GetOrderProductsFromApi(IdOrder);

            Cart_listbox.Items.AddRange(orderProducts.ToArray());

            foodList = products.Where(product => product.IdProductCategory == 1).ToList();
            drinkList = products.Where(product => product.IdProductCategory == 2).ToList();

            float Sum = orderProducts.Sum(product => product.Price);
            Sum_label.Text = Sum.ToString();
            Products_listbox.Items.AddRange(foodList.ToArray());
        }

        private void Cart_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Products_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async Task<List<Product>> GetOrdersFromApi()
        {
            var apiUrl = "https://localhost:44325/api/Product";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json);
                    return products;
                }
                else
                {
                    
                    MessageBox.Show("Failed to retrieve data from the API.");
                    return new List<Product>();
                }
            }
        }

        private async Task<List<OrderProduct>> GetOrderProductsFromApi(int orderId)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"https://localhost:44325/api/OrderProduct/{orderId}";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    List<OrderProduct> orderProducts = JsonConvert.DeserializeObject<List<OrderProduct>>(json);
                    return orderProducts;
                }
                else
                {
                    // Handle error response
                    MessageBox.Show("Failed to retrieve data from the API.");
                    return new List<OrderProduct>();
                }
            }
        }

        private void Drik_button_Click(object sender, EventArgs e)
        {

            Products_listbox.Items.Clear();
            Products_listbox.Items.AddRange(drinkList.ToArray());

        }

        private void Food_button_Click(object sender, EventArgs e)
        {
            Products_listbox.Items.Clear();
            Products_listbox.Items.AddRange(foodList.ToArray());
        }

        private void Sum_label_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Product? product = Products_listbox.SelectedItem as Product;
            OrderProduct orderProduct = new OrderProduct()
            {
                IdOrderProduct = 0,
                IdOrder = IdOrder,
                IdProduct = product.IdProduct,
                Title = product.Title,
                Price = product.Price
            };
            
            Cart_listbox.Items.Add(orderProduct);
        }

        private void Void_button_Click(object sender, EventArgs e)
        {
            if (Cart_listbox.SelectedItem != null)
            {
                Cart_listbox.Items.Remove(Cart_listbox.SelectedItem);
            }
        }

        private void Send_button_Click(object sender, EventArgs e)
        {
            List<ProductResult> productResults = new List<ProductResult>();

            foreach (var item in Cart_listbox.Items)
            {
                OrderProduct selectedOrderProduct = item as OrderProduct;

                int idProduct = selectedOrderProduct.IdProduct;

                ProductResult productResult = new ProductResult
                {
                    IdProduct = idProduct,
                    IdOrder = IdOrder
                };

               productResults.Add(productResult);
            }
            SendProductResults(productResults);

            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private async Task SendProductResults(List<ProductResult> productResults)
        {
            
            List<ProductResult> productResultDTOs = productResults.Select(pr => new ProductResult
            {
                IdProduct = pr.IdProduct,
                IdOrder = pr.IdOrder
            }).ToList();

            using (HttpClient httpClient = new HttpClient())
            {
                string url = "https://localhost:44325/api/OrderProduct";

                
                string jsonContent = JsonConvert.SerializeObject(productResultDTOs);

                
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                
                HttpResponseMessage response = await httpClient.PutAsync(url, content);

                
                if (response.IsSuccessStatusCode)
                {
                    // Success
                    Console.WriteLine("ProductResults sent successfully.");
                }
                else
                {
                    // Error
                    Console.WriteLine("Failed to send ProductResults. Status code: " + response.StatusCode);
                }
            }
        }

    }
}
