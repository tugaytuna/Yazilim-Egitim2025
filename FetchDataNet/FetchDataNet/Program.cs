using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FetchDataNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            while (true)
            {
                switch (Console.ReadLine()) {
                    case "1":
                        GetPokemon();
                        break;
                    case "2":
                        break;
                    default:
                        GetPokemon();
                        break;
                }
            }

        }


        public static async void GetPokemon()
        {
            //Define your baseUrl
            string baseUrl = "https://localhost:7013/First/Stok/2";
            //Have your using statements within a try/catch block
            try
            {
                //We will now define your HttpClient with your first using statement which will use a IDisposable.
                using (HttpClient client = new HttpClient())
                {
                    //In the next using statement you will initiate the Get Request, use the await keyword so it will execute the using statement in order.
                    client.BaseAddress = new Uri(baseUrl);
                    var res =  client.GetAsync(baseUrl).Result;
                    
                        //Then get the content from the response in the next using statement, then within it you will get the data, and convert it to a c# object.
                        using (HttpContent content = res.Content)
                        {
                            //Now assign your content to your data variable, by converting into a string using the await keyword.
                            //var data2 = content.
                            var data = await content.ReadAsStringAsync();
                            //If the data isn't null return log convert the data using newtonsoft JObject Parse class method on the data.
                            if (data != null)
                            {
                            //Now log your data in the console
                            Console.WriteLine("data------------{0}", data);

                            //Urun[] urunlerDizi = data;
                            //List<Urun> urunler = new List<Urun>();

                        }
                            else
                            {
                                Console.WriteLine("NO Data----------");
                            }
                        }
                    
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception Hit------------");
                Console.WriteLine(exception);
            }
        }


    }
}
