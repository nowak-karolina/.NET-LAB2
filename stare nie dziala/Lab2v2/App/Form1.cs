using System.Text.Json;

namespace App {
    public partial class Form1 : Form {
        private HttpClient client;
        public Form1() {
            InitializeComponent();
            client = new HttpClient();
        }


        private async void getData(object sender, EventArgs e) {
            string call = "http://www.boredapi.com/api/activity/";
            string response = await client.GetStringAsync(call);
            data_textBox.Text = response;

            ToDo json = JsonSerializer.Deserialize<ToDo>(response);
            json_textBox.Text = json.ToString();
        }
    }
}
