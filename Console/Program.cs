using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp

{
    class Program
    {
        static void Main(string[] args)
        {
            using (var apiClient = new HttpClient())
            {
                var mediaType = new MediaTypeWithQualityHeaderValue("application/json");

                apiClient.BaseAddress = new Uri("https://localhost:44340/");
                apiClient.DefaultRequestHeaders.Accept.Add(mediaType);

                var message = apiClient.GetAsync("/api/Friends").Result;

                if (message.IsSuccessStatusCode)
                {
                    Console.Write(message.Content.ReadAsStringAsync().Result);
                }

            }
        }
    }
}
