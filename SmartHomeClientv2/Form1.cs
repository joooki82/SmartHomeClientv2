using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using RestSharp;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace SmartHomeClientv2
{
    public partial class Form1 : Form
    {
        string URL;

        public Form1()
        {
            InitializeComponent();
            URL = ConfigurationManager.AppSettings["SmartHomeURL"];
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            await LoginAsync(textBoxLogUsername.Text, textBoxLogPassword.Text);
        }

        private async Task LoginAsync(string username, string password)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL);

                var credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);

                try
                {
                    HttpResponseMessage response = await client.PostAsync("login", new StringContent(""));

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Login sussessful.");
                        this.Hide();
                        Form2 form2 = new Form2(username, password);
                        form2.FormClosed += (s, args) => this.Close(); 
                        form2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login failed. Please check your username and password.");
                    }
                }
                catch (HttpRequestException httpEx)
                {
                    MessageBox.Show($"Request exception: {httpEx.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }


        }

        private async void btnRegistration_Click_1(object sender, EventArgs e)
        {
            if (IsValidInput(textBoxRegUsername.Text, textBoxRegPassword.Text))
            {
                await RegisterAsync(textBoxRegUsername.Text, textBoxRegPassword.Text);
            }
        }

        private async Task RegisterAsync(string username, string password)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var registrationData = new { username = username, password = password };
                string json = JsonConvert.SerializeObject(registrationData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync("users", content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Registration successful.");
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.");
                    }
                }
                catch (HttpRequestException httpEx)
                {
                    MessageBox.Show($"Request exception: {httpEx.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private bool IsValidInput(string username, string password)
        {
            var validInputRegex = new Regex("^[a-zA-Z0-9]*$");

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return false;
            }

            if (username.Length < 4)
            {
                MessageBox.Show("Username must be at least 4 characters long.");
                return false;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.");
                return false;
            }

            if (!validInputRegex.IsMatch(username))
            {
                MessageBox.Show("Username can only contain letters and numbers.");
                return false;
            }

            if (!validInputRegex.IsMatch(password))
            {
                MessageBox.Show("Password can only contain letters and numbers.");
                return false;
            }

            return true;
        }

    }
}
