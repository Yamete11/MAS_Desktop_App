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
    public partial class AddProductForm : Form
    {

        public List<Product>? foodList { get; set; }
        public List<Product>? drinkList { get; set; }
        bool CategoryFood = true;
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private async void AddProductForm_Load(object sender, EventArgs e)
        {
            List<Product> products = await GetOrdersFromApi();
            
            foodList = products.Where(product => product.IdProductCategory == 1).ToList();
            drinkList = products.Where(product => product.IdProductCategory == 2).ToList();

            listBox1.Items.AddRange(foodList.ToArray());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Food_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(foodList.ToArray());
            CategoryFood = true;
        }

        private void Drink_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(drinkList.ToArray());
            CategoryFood = false;
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

        private async void Delete_button_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Product selectedProduct = listBox1.SelectedItem as Product;

                int productIdToDelete = selectedProduct.IdProduct;

                await DeleteProduct(productIdToDelete);

                listBox1.Items.Clear();

                List<Product> products = await GetOrdersFromApi();

                foodList = products.Where(product => product.IdProductCategory == 1).ToList();
                drinkList = products.Where(product => product.IdProductCategory == 2).ToList();

                if (CategoryFood == true)
                {
                    listBox1.Items.AddRange(foodList.ToArray());
                }
                else
                {
                    listBox1.Items.AddRange(drinkList.ToArray());
                }


            }
            else
            {
                MessageBox.Show("Please select an item from the list.");
            }


            

        }

        private async Task DeleteProduct(int productIdToDelete)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string url = $"https://localhost:44325/api/Product/{productIdToDelete}";

                HttpResponseMessage response = await httpClient.DeleteAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Product deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to delete the product. Status code: " + response.StatusCode);
                }
            }
        }

    }
}
