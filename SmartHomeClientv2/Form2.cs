using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SmartHomeClientv2
{
    public partial class Form2 : Form
    {
        string URL = ConfigurationManager.AppSettings["SmartHomeURL"];
        private string _username;
        private string _password;


        public Form2(string username, string password)
        {
            InitializeComponent();
            comboBoxType.Items.Add("thermostat");
            comboBoxType.Items.Add("camera");
            comboBoxType.Items.Add("light");

            comboBoxStatus.Items.Add("on");
            comboBoxStatus.Items.Add("off");

            comboBoxUpdateType.Items.Add("thermostat");
            comboBoxUpdateType.Items.Add("camera");
            comboBoxUpdateType.Items.Add("light");

            comboBoxUpdateStatus.Items.Add("on");
            comboBoxUpdateStatus.Items.Add("off");
            _username = username;
            _password = password;

        }
        private RestClient CreateAuthenticatedClient()
        {
            var client = new RestClient(URL);
            var authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{_username}:{_password}"));
            client.AddDefaultHeader("Authorization", $"Basic {authToken}");
            return client;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async void button1_Click(object sender, EventArgs e)
        {
            var client = CreateAuthenticatedClient();
            var request = new RestRequest("devices", Method.Get);

            try
            {
                var cancellationTokenSource = new CancellationTokenSource();
                var response = await client.ExecuteAsync(request, cancellationTokenSource.Token);

                var parsedJson = JsonConvert.DeserializeObject(response.Content);
                var formattedJson = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
                richTextBox1.Text = formattedJson;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    richTextBox1.Text = formattedJson;
                }
                else
                {
                    richTextBox1.Text = $"Error occurred! Status code: {response.StatusCode}\n{response.Content}";
                }
            }
            catch (Exception ex)
            {
                richTextBox1.Text = $"An exception occurred: {ex.Message}";
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return; 
            }

            var client = CreateAuthenticatedClient();

            var deviceData = new
            {
                device_name = textBoxName.Text, 
                device_type = comboBoxType.SelectedItem.ToString(),
                status = comboBoxStatus.SelectedItem.ToString()
            };

            var deviceJson = JsonConvert.SerializeObject(deviceData);

            var request = new RestRequest("devices", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", deviceJson, ParameterType.RequestBody);

            try
            {
                var cancellationTokenSource = new CancellationTokenSource();
                var response = await client.ExecuteAsync(request, cancellationTokenSource.Token);

                if (response.StatusCode == System.Net.HttpStatusCode.Created) 
                {
                    MessageBox.Show("Device created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to create device. Status code: {response.StatusCode}\n{response.Content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An exception occurred: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Please enter a device name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a device type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a device status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private async void buttonGetDevice_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxDeviceId.Text, out int deviceId))
            {
                await GetDeviceById(deviceId);
            }
            else
            {
                MessageBox.Show("Please enter a valid device ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task GetDeviceById(int deviceId)
        {
            var client = CreateAuthenticatedClient();
            var request = new RestRequest($"devices/{deviceId}", Method.Get);

            try
            {
                var response = await client.ExecuteAsync(request);
                var parsedJson = JsonConvert.DeserializeObject(response.Content);
                var formattedJson = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
                richTextBox1.Text = formattedJson;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        richTextBox1.Text = formattedJson;
                    });
                }
                else
                {
                    MessageBox.Show($"Failed to retrieve device. Status code: {response.StatusCode}\n{response.Content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An exception occurred: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class DeviceModel
        {
            public string device_type { get; set; }
            public string device_name { get; set; }
            public string status { get; set; }
        }

        private async void buttonUpdateDevice_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxUpdateId.Text, out int deviceId))
            {
                MessageBox.Show("Please enter a valid device ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var deviceUpdate = new DeviceModel
            {
                device_type = comboBoxUpdateType.SelectedItem.ToString(),
                device_name = textBoxUpdateName.Text,
                status = comboBoxUpdateStatus.SelectedItem.ToString()
            };

            await UpdateDeviceById(deviceId, deviceUpdate);
        }

        private async Task UpdateDeviceById(int deviceId, DeviceModel deviceUpdate)
        {
            var client = CreateAuthenticatedClient();
            var request = new RestRequest($"devices/{deviceId}", Method.Put);

            request.AddJsonBody(deviceUpdate);

            try
            {
                var response = await client.ExecuteAsync(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK || response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    MessageBox.Show("Device updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to update device. Status code: {response.StatusCode}\n{response.Content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An exception occurred: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonDeleteDevice_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxDeleteDeviceId.Text, out int deviceId))
            {
                MessageBox.Show("Please enter a valid device ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this device?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                await DeleteDeviceById(deviceId);
            }
        }

        private async Task DeleteDeviceById(int deviceId)
        {
            var client = CreateAuthenticatedClient();
            var request = new RestRequest($"devices/{deviceId}", Method.Delete);

            try
            {
                var response = await client.ExecuteAsync(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK || response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    MessageBox.Show("Device deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to delete device. Status code: {response.StatusCode}\n{response.Content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An exception occurred: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
