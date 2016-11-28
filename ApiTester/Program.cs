using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Enqueue.Data;


namespace ApiTester
{
    class Program
    {
        private static string baseUri = "http://localhost:21963/";
       // private static string baseUri = "http://meetdoctornow.com/";
        static void Main(string[] args)
        {
          
          // RegisterConsumerTest().Wait();
          //  LoginConsumerTest().Wait();
           // SearchServiceProvider().Wait();
           // StartBooking().Wait();
           // GetCurrentToken().Wait();
            GetToken().Wait();
           //CompleteSkipToken().Wait();
            // GetToken().Wait();
            // CloseBooking().Wait();
            // StartSession().Wait();
            // CloseSession().Wait();
        }
        static async Task RegisterConsumerTest()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    HttpResponseMessage response = null;
                    var user = new Consumer
                    {
                        UserName= "sample string 2",
                        Password= "sample string 3",
                        FullName= "sample string 4",
                        Email= "sample string 5",
                        Phone= "sample string 6",
                        IsAppUser= true,
                    };
                    response = await client.PostAsJsonAsync("api/consumer/register", user);
                    if (response.IsSuccessStatusCode)
                    {
                        
                    }
                    Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                    Console.Read();
                }
                catch (HttpRequestException e)
                {
                    // Handle exception.
                }
            }
        }
        static async Task LoginConsumerTest()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    HttpResponseMessage response = null;
                    var user = new Consumer
                    {
                        UserName = "zubair1598",
                        Password = "abcd@1",                        
                    };
                    response = await client.PostAsJsonAsync("api/consumer/login", user);
                    if (response.IsSuccessStatusCode)
                    {

                    }
                    Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                    Console.Read();
                }
                catch (HttpRequestException e)
                {
                    // Handle exception.
                }
            }
        }
        static async Task SearchServiceProvider()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    HttpResponseMessage response = null;

                    response = await client.GetAsync("api/provider/DR1");
                    if (response.IsSuccessStatusCode)
                    {

                    }
                    Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                    Console.Read();
                }
                catch (HttpRequestException e)
                {
                    // Handle exception.
                }
            }
        }
        static async Task GetCurrentToken()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    HttpResponseMessage response = null;

                    response = await client.GetAsync("api/token/nowserving/1/5/1");
                    if (response.IsSuccessStatusCode)
                    {

                    }
                    Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                    Console.Read();
                }
                catch (HttpRequestException e)
                {
                    // Handle exception.
                }
            }
        }
        static async Task GetToken()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    HttpResponseMessage response = null;
                    
                    response = await client.GetAsync("api/token/get/1/12/1/zubair/123445555443/true");
                    if (response.IsSuccessStatusCode)
                    {

                    }
                    Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                    Console.Read();
                }
                catch (HttpRequestException e)
                {
                    // Handle exception.
                }
            }
        }
        static async Task NextToken()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    HttpResponseMessage response = null;

                    response = await client.GetAsync("api/token/list/1/1");
                    if (response.IsSuccessStatusCode)
                    {

                    }
                    Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                    Console.Read();
                }
                catch (HttpRequestException e)
                {
                    // Handle exception.
                }
            }
        }
        static async Task CompleteSkipToken()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    HttpResponseMessage response = null;

                    response = await client.GetAsync("/api/token/completeskip/1190/true/it was nice visit");
                    if (response.IsSuccessStatusCode)
                    {

                    }
                    Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                    Console.Read();
                }
                catch (HttpRequestException e)
                {
                    // Handle exception.
                }
            }
        }
        
        static async Task StartBooking()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    HttpResponseMessage response = null;

                    response = await client.GetAsync("api/token/booking/start/1/1");
                    if (response.IsSuccessStatusCode)
                    {

                    }
                    Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                    Console.Read();
                }
                catch (HttpRequestException e)
                {
                    // Handle exception.
                }
            }
        }
        static async Task CloseBooking()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    HttpResponseMessage response = null;

                    response = await client.GetAsync("api/token/booking/close/1/1");
                    if (response.IsSuccessStatusCode)
                    {

                    }
                    Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                    Console.Read();
                }
                catch (HttpRequestException e)
                {
                    // Handle exception.
                }
            }
        }
        static async Task StartSession()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    HttpResponseMessage response = null;

                    response = await client.GetAsync("api/provider/session/start/1/1");
                    if (response.IsSuccessStatusCode)
                    {

                    }
                    Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                    Console.Read();
                }
                catch (HttpRequestException e)
                {
                    // Handle exception.
                }
            }
        }
        static async Task CloseSession()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    HttpResponseMessage response = null;

                    response = await client.GetAsync("api/provider/session/close/1/1");
                    if (response.IsSuccessStatusCode)
                    {

                    }
                    Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                    Console.Read();
                }
                catch (HttpRequestException e)
                {
                    // Handle exception.
                }
            }
        }
     
    }
}
