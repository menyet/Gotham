using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Gotham.Client.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
        }

        static async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                // New code:
                client.BaseAddress = new Uri("http://localhost:50050/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                // New code:
                HttpResponseMessage response = await client.GetAsync("api/accounts");
                if (response.IsSuccessStatusCode)
                {
                    var accounts = await response.Content.ReadAsAsync<IEnumerable<Account>>();
                    foreach (var account in accounts)
                    {
                        System.Console.WriteLine("{0}\t${1}\t{2}", account.Name, account.Id, account.Name);
                    }
                }
            }

            System.Console.ReadKey();
        }
    }
}
