﻿using Newtonsoft.Json;
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

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Order_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            
            List<Order> orders = await GetOrdersFromApi();
            List<Order> ordersWithReceipts = orders.Where(o => o.IdReceipt == null).ToList();
            Order_listbox.Items.AddRange(ordersWithReceipts.ToArray());

            List<Order> ordersWithOutReceipts = orders.Where(o => o.IdReceipt != null).ToList();
            Raport_listbox.Items.AddRange(ordersWithOutReceipts.ToArray());

            Main_panel.Visible = true;
            Main_panel.Controls.Add(Order_listbox);
            Main_panel.Controls.Add(Select_button);
            Main_panel.Controls.Add(Create_button);
            Main_panel.Controls.Add(Raport_button);
            Main_panel.Controls.Add(Add_button);
            

            Raport_panel.Visible = false;
            Raport_panel.Controls.Add(Raport_listbox);
            Raport_panel.Controls.Add(Raport_label);
            Back_button.Visible = false;
            



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
                    MessageBox.Show("Failed to retrieve data from the API.");
                    return new List<Order>();
                }
            }
        }

        private void Select_button_Click(object sender, EventArgs e)
        {

            if (Order_listbox.SelectedIndex != -1)
            {

                Order? Order = Order_listbox.SelectedItem as Order;

                OrderForm orderForm = new OrderForm(Order.IdOrder);
                orderForm.Show();
                this.Hide();
            }
            else
            {
                
                MessageBox.Show("Please select an item from the list.");
            }
            
        }

        private void Create_button_Click(object sender, EventArgs e)
        {
            TypeForm typeForm = new TypeForm();
            this.Enabled = false;
            typeForm.Show();
            
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            AddProductForm productForm = new AddProductForm();
            productForm.Show();
            this.Hide();
        }

        private void Raport_button_Click(object sender, EventArgs e)
        {
            Main_panel.Visible = false;
            Raport_panel.Visible = true;
            Back_button.Visible = true;
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Main_panel.Visible = true;
            Raport_panel.Visible = false;
            Back_button.Visible = false;
        }

        private void Raport_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
