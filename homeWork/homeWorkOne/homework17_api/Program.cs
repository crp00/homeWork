using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;

namespace homework17_api
{
    class Program
    {
        static void Main(string[] args)
        {
            //string url = "http://epuakyiw1888.kyiv.epam.com:8024/api/items";

            //var newRequest = WebRequest.Create(url);

            //Stream someStream = newRequest.GetResponse().GetResponseStream();

            //StreamReader someReader = new StreamReader(someStream);

            //string sLine = "";
            //int i = 0;

            //while (sLine != null)
            //{
            //    i++;
            //    sLine = someReader.ReadLine();
            //    if (sLine != null)
            //    {
            //        Console.WriteLine("{0}:{1}", i, sLine);
            //    }
            //    Console.ReadLine();

            async void checkResponse()
            {
                var uri = new Uri("http://epuakyiw1888.kyiv.epam.com:8024/api/items");
                var hc = new HttpClient();

                var result = await hc.GetStringAsync(uri);
                Console.WriteLine(result);
            }

            checkResponse();
        }
    }
}
