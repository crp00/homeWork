using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using NUnit.Framework;

namespace homework17_api
{
    [TestFixture]
    class API_tests
    {
        private HttpClient client = new HttpClient();

        [SetUp]
        public void Setup()
        {
           //
        }

        [TearDown] 
        public void Teardown()
        {
            //
        }

        [Test]
        public void test1()
        {
            async void getResponse()
            {
                var uri = new Uri("http://epuakyiw1888.kyiv.epam.com:8024/api/items");
                var result = await client.GetStringAsync(uri);

                Console.WriteLine(result);
            }

            getResponse();
        }
    }
}
