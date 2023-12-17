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
                // Set up HTTP client with server URI
                client.BaseAddress = new Uri(URL);

                // Encode the credentials and set the Authorization header for Basic Authentication
                var credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);

                try
                {
                    // Send a POST request to the server's login endpoint
                    // No need to send a JSON body for Basic Authentication, so we use an empty StringContent
                    HttpResponseMessage response = await client.PostAsync("login", new StringContent(""));

                    if (response.IsSuccessStatusCode)
                    {
                        // Handle the response here if login is successful
                        string responseBody = await response.Content.ReadAsStringAsync();
                        // Deserialize responseBody if needed and perform actions
                        MessageBox.Show("Login sussessful.");
                        this.Hide();
                        Form2 form2 = new Form2(username, password);
                        form2.FormClosed += (s, args) => this.Close(); // Ensure the application closes when Form2 is closed
                        form2.Show();
                    }
                    else
                    {
                        // Handle the response here if login failed
                        MessageBox.Show("Login failed. Please check your username and password.");
                    }
                }
                catch (HttpRequestException httpEx)
                {
                    // Handle any exceptions that occur during the HTTP request
                    MessageBox.Show($"Request exception: {httpEx.Message}");
                }
                catch (Exception ex)
                {
                    // Handle other exceptions
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }


        }

        private async void btnRegistration_Click_1(object sender, EventArgs e)
        {
            // Validate the input before attempting to register
            if (IsValidInput(textBoxRegUsername.Text, textBoxRegPassword.Text))
            {
                await RegisterAsync(textBoxRegUsername.Text, textBoxRegPassword.Text);
            }
        }

        private async Task RegisterAsync(string username, string password)
        {
            using (var client = new HttpClient())
            {
                // Set up HTTP client with server URI and headers as needed
                client.BaseAddress = new Uri(URL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Create the JSON object to send
                var registrationData = new { username = username, password = password };
                string json = JsonConvert.SerializeObject(registrationData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    // Send a POST request to the server's "users" endpoint
                    HttpResponseMessage response = await client.PostAsync("users", content);

                    if (response.IsSuccessStatusCode)
                    {
                        // Handle the response here if registration is successful
                        string responseBody = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Registration successful.");
                        // Deserialize responseBody if needed and perform actions
                    }
                    else
                    {
                        // Handle the response here if registration failed
                        MessageBox.Show("Registration failed. Please try again.");
                    }
                }
                catch (HttpRequestException httpEx)
                {
                    // Handle any exceptions that occur during the HTTP request
                    MessageBox.Show($"Request exception: {httpEx.Message}");
                }
                catch (Exception ex)
                {
                    // Handle other exceptions
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private bool IsValidInput(string username, string password)
        {
            // Define a regular expression for a valid username and password: only letters and numbers
            var validInputRegex = new Regex("^[a-zA-Z0-9]*$");

            // Check if either field is empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return false;
            }

            // Check for minimum username length
            if (username.Length < 4)
            {
                MessageBox.Show("Username must be at least 4 characters long.");
                return false;
            }

            // Check for minimum password length
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.");
                return false;
            }

            // Check if username contains only letters and numbers
            if (!validInputRegex.IsMatch(username))
            {
                MessageBox.Show("Username can only contain letters and numbers.");
                return false;
            }

            // Check if password contains only letters and numbers
            if (!validInputRegex.IsMatch(password))
            {
                MessageBox.Show("Password can only contain letters and numbers.");
                return false;
            }

            return true;
        }

    }
}
