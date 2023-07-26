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
        int IdOrder = 0;
        int IdOrderType;
        int TableNumber;
        public List<Product>? foodList { get; set; }
        public List<Product>? drinkList { get; set; }

        public List<OrderProduct>? orderProducts { get; set; }
        public OrderForm()
        {
            InitializeComponent();
        }
        public OrderForm(int IdOrder)
        {
            InitializeComponent();
            this.IdOrder = IdOrder;
        }

        public OrderForm(int IdOrderType, int TableNumber)
        {
            InitializeComponent();
            this.IdOrderType = IdOrderType;
            this.TableNumber = TableNumber;
        }

        private async void OrderForm_Load(object sender, EventArgs e)
        {
            List<Product> products = await GetOrdersFromApi();
            orderProducts = await GetOrderProductsFromApi(IdOrder);

            Cart_listbox.Items.AddRange(orderProducts.ToArray());

            foodList = products.Where(product => product.IdProductCategory == 1).ToList();
            drinkList = products.Where(product => product.IdProductCategory == 2).ToList();

            UpdateSum();
            Products_listbox.Items.AddRange(foodList.ToArray());
            panel1.Visible = true;
            panel1.Controls.Add(Products_listbox);
            panel1.Controls.Add(Add_button);
            panel1.Controls.Add(Void_button);
            panel1.Controls.Add(label2);
            panel2.Visible = false;
            panel2.Controls.Add(Cash_button);
            panel2.Controls.Add(Visa_button);
            panel2.Controls.Add(Mastercard_button);
            
            
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
            panel1.Visible = true;
            panel2.Visible = false;
            Products_listbox.Items.Clear();
            Products_listbox.Items.AddRange(drinkList.ToArray());

        }

        private void Food_button_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
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

            UpdateSum();

        }

        private void Void_button_Click(object sender, EventArgs e)
        {
            if (Cart_listbox.SelectedItem != null)
            {
                Cart_listbox.Items.Remove(Cart_listbox.SelectedItem);
            }

            UpdateSum();
        }

        private void UpdateSum()
        {
            float totalPrice = Cart_listbox.Items.Cast<OrderProduct>().Sum(orderProduct => orderProduct.Price);
            Sum_label.Text = totalPrice.ToString();
        }

        private async void Send_button_Click(object sender, EventArgs e)
        {
            List<int> productResults = new List<int>();

            foreach (var item in Cart_listbox.Items)
            {
                OrderProduct selectedOrderProduct = item as OrderProduct;

                productResults.Add(selectedOrderProduct.IdProduct);
            }

            if(IdOrder == 0)
            {
                await SendNewOrder(productResults);
            } else
            {
                await SendProductResults(productResults);
            }
            

            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private async Task SendNewOrder(List<int> productResults)
        {
            NewOrderDTO newOrderDTO = new NewOrderDTO()
            {
                IdOrderType = this.IdOrderType,
                TableNumber = this.TableNumber,
                IdProducts = productResults
            };

            using (HttpClient httpClient = new HttpClient())
            {
                string url = "https://localhost:44325/api/Order";


                string jsonContent = JsonConvert.SerializeObject(newOrderDTO);


                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");


                HttpResponseMessage response = await httpClient.PostAsync(url, content);


                if (response.IsSuccessStatusCode)
                {

                    Console.WriteLine("ProductResults sent successfully.");
                }
                else
                {

                    Console.WriteLine("Failed to send ProductResults. Status code: " + response.StatusCode);
                }
            }
        }

        private async Task SendProductResults(List<int> productResults)
        {

            ProductResult productResultDTOs = new ProductResult()
            {
                IdOrder = IdOrder,
                IdProducts = productResults
            };


            using (HttpClient httpClient = new HttpClient())
            {
                string url = "https://localhost:44325/api/OrderProduct";

                
                string jsonContent = JsonConvert.SerializeObject(productResultDTOs);

                
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                
                HttpResponseMessage response = await httpClient.PutAsync(url, content);

                
                if (response.IsSuccessStatusCode)
                {
                    
                    Console.WriteLine("ProductResults sent successfully.");
                }
                else
                {
                    
                    Console.WriteLine("Failed to send ProductResults. Status code: " + response.StatusCode);
                }
            }
        }

        private void Pay_button_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            
        }

        public async Task SendReceipt(PaymentMethod paymentMethod)
        {
            ReceiptDTO receiptDTO = new ReceiptDTO()
            {
                IdOrder = this.IdOrder,
                NIP = "NIP",
                PaymentMethod = paymentMethod
            };


            using (HttpClient httpClient = new HttpClient())
            {
                string url = "https://localhost:44325/api/Receipt";


                string jsonContent = JsonConvert.SerializeObject(receiptDTO);


                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");


                HttpResponseMessage response = await httpClient.PostAsync(url, content);


                if (response.IsSuccessStatusCode)
                {

                    Console.WriteLine("ProductResults sent successfully.");
                }
                else
                {

                    Console.WriteLine("Failed to send ProductResults. Status code: " + response.StatusCode);
                }
            }
        }

        private async void Visa_button_Click(object sender, EventArgs e)
        {
            await SendReceipt(PaymentMethod.Visa);
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private async void Mastercard_button_Click(object sender, EventArgs e)
        {
            await SendReceipt(PaymentMethod.MasterCard);
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private async void Cash_button_Click(object sender, EventArgs e)
        {
            await SendReceipt(PaymentMethod.Cash);
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }
    }
}
