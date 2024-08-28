using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;
using System.Diagnostics;


namespace laba2_task1
{

    class Program
    {
        static void Main(string[] args)
        {
            MainNoAsync();
            MainAsync().Wait();

            static void MainNoAsync()
            {
                Stopwatch clock = new Stopwatch();
                clock.Start();
                using (var client = new HttpClient())
                {
                    var jokes_endpoint = new Uri("https://official-joke-api.appspot.com/random_joke");
                    var jokes_result = client.GetAsync(jokes_endpoint).Result;

                    if (jokes_result.IsSuccessStatusCode)
                    {
                        var jokes_json = jokes_result.Content.ReadAsStringAsync().Result;
                        JObject get_jokes_response = JObject.Parse(jokes_json);
                        string setup = get_jokes_response["setup"].ToString();
                        string punchline = get_jokes_response["punchline"].ToString();
                        Console.WriteLine("- " + setup + "... " + punchline + " *Badumss*");
                        //Console.WriteLine("\n");
                    }

                    else
                    {
                        Console.WriteLine("Error: " + jokes_result.StatusCode);
                    }
                    ///
                    ///
                    var bored_endpoint = new Uri("https://www.boredapi.com/api/activity");
                    var bored_result = client.GetAsync(bored_endpoint).Result;

                    if (bored_result.IsSuccessStatusCode)
                    {
                        var bored_json = bored_result.Content.ReadAsStringAsync().Result;
                        JObject get_bored_response = JObject.Parse(bored_json);
                        string activity = get_bored_response["activity"].ToString();
                        Console.WriteLine("You should " + activity);
                        //Console.WriteLine("\n");
                    }

                    else
                    {
                        Console.WriteLine("Error: " + bored_result.StatusCode);
                    }
                    ///
                    ///
                    var random_endpoint = new Uri("https://randomuser.me/api/?inc=name");
                    var random_result = client.GetAsync(random_endpoint).Result;

                    if (random_result.IsSuccessStatusCode)
                    {
                        var random_json = random_result.Content.ReadAsStringAsync().Result;
                        JObject get_random_response = JObject.Parse(random_json);
                        string title = get_random_response["results"][0]["name"]["title"].ToString();
                        string first = get_random_response["results"][0]["name"]["first"].ToString();
                        string last = get_random_response["results"][0]["name"]["last"].ToString();
                        Console.WriteLine("Now you are: " + title + " " + first + " " + last);
                    }

                    else
                    {
                        Console.WriteLine("Error: " + random_result.StatusCode);
                    }
                }
                clock.Stop();
                Console.WriteLine("\n");
                Console.WriteLine($"Time:{clock.Elapsed}");
                Console.WriteLine("\n");
            }

            static async Task MainAsync()
            {
                Stopwatch clock = new Stopwatch();
                clock.Start();
                using (var client = new HttpClient())
                {
                    var jokes_endpoint = new Uri("https://official-joke-api.appspot.com/random_joke");
                    var jokes_result = await client.GetAsync(jokes_endpoint);

                    if (jokes_result.IsSuccessStatusCode)
                    {
                        var jokes_json = await jokes_result.Content.ReadAsStringAsync();
                        JObject get_jokes_response = JObject.Parse(jokes_json);
                        string setup = get_jokes_response["setup"].ToString();
                        string punchline = get_jokes_response["punchline"].ToString();
                        Console.WriteLine("- " + setup + "... " + punchline + " *Badumss*");
                        //Console.WriteLine("\n");
                    }

                    else
                    {
                        Console.WriteLine("Error: " + jokes_result.StatusCode);
                    }
                    ///
                    ///
                    var bored_endpoint = new Uri("https://www.boredapi.com/api/activity");
                    var bored_result = await client.GetAsync(bored_endpoint);

                    if (bored_result.IsSuccessStatusCode)
                    {
                        var bored_json = await bored_result.Content.ReadAsStringAsync();
                        JObject get_bored_response = JObject.Parse(bored_json);
                        string activity = get_bored_response["activity"].ToString();
                        Console.WriteLine("You should " + activity);
                        //Console.WriteLine("\n");
                    }

                    else
                    {
                        Console.WriteLine("Error: " + bored_result.StatusCode);
                    }
                    ///
                    ///
                    var random_endpoint = new Uri("https://randomuser.me/api/?inc=name");
                    var random_result = await client.GetAsync(random_endpoint);

                    if (random_result.IsSuccessStatusCode)
                    {
                        var random_json = await random_result.Content.ReadAsStringAsync();
                        JObject get_random_response = JObject.Parse(random_json);
                        string title = get_random_response["results"][0]["name"]["title"].ToString();
                        string first = get_random_response["results"][0]["name"]["first"].ToString();
                        string last = get_random_response["results"][0]["name"]["last"].ToString();
                        Console.WriteLine("Now you are: " + title + " " + first + " " + last);
                    }

                    else
                    {
                        Console.WriteLine("Error: " + jokes_result.StatusCode);
                    }
                }

                clock.Stop();
                Console.WriteLine("\n");
                Console.WriteLine($"Time:{clock.Elapsed}");
            }
        }
    }
}
