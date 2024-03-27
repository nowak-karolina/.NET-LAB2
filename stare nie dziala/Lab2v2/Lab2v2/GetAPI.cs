using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;



namespace Lab2v2 {
    internal class GetAPI {
        HttpClient client;
        public string response {  get; set; }
        public ToDo json { get; set; }
        public async Task GetData() {

            client = new HttpClient();
            string call = "http://www.boredapi.com/api/activity/";
            response = await client.GetStringAsync(call);
            Console.WriteLine(response);
            Console.WriteLine("-----------------\n");

            json = JsonSerializer.Deserialize<ToDo>(response);
            Console.WriteLine(json.ToString());
        }

    }
}
