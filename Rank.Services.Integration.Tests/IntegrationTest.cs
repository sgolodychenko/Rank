using System;
using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;

namespace Rank.Services.Integration.Tests
{
    [TestFixture]
    public class IntegrationTest
    {
        [Test]
        public void ConnectivityTest()
        {
            try
            {
                string page = "http://localhost";

                var client = new HttpClient();
                var response = client.GetAsync(page).Result;
                var content = response.Content.ReadAsStringAsync();
                Console.WriteLine(content.Status);
                Console.WriteLine(content.Result);
            }
            catch (Exception)
            {
                
            }          
        }
        
    }
}
