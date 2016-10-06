using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace TestAzureAPIUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private string urlBase = @"https://quisitivetestazureapi.azurewebsites.net/";
        [TestMethod]
        public async Task Get_Test()
        {
            //make call to controller after deployment
            var url = $"{urlBase}api/values";

            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            //request.ContentType = "application/json; charset=utf-8";

            //var response = (HttpWebResponse)request.GetResponse();
            //Stream resStream = response.GetResponseStream();

            HttpClient client = new HttpClient();
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(url),
                Method = HttpMethod.Get,
            };
            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.SendAsync(request);
            //var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();

        }
    }
}
