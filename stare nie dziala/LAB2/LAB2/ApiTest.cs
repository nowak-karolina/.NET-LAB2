using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LAB2 {
    internal class ApiTest {
        public HttpClient client;
        public async Task GetData() {

    
            client = new HttpClient();
            //string call = "https://www.boredapi.com/api/activity/";
            string call = "https://dogapi.dog/api/v2/facts";
            string response = await client.GetStringAsync(call);
            Console.WriteLine(response);

            //ToDo test = JsonSerializer.Deserialize<ToDo>(response);
            Facts facts = JsonSerializer.Deserialize<Facts>(response);
            Console.WriteLine("-----------------\n");
            Console.WriteLine(facts.ToString());
        }
    }
}
