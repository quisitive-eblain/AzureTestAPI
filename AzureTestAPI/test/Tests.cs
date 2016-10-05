using System;
using Xunit;
using AzureTestAPI.Controllers;
using System.Collections.Generic;

namespace AzureTestAPI.Tests
{
    public class ValuesControllerTests
    {
        [Fact]
        public void Get_Test() 
        {
            ValuesController controller = new ValuesController();
            var responseContent = new List<string>();
            foreach(string s in controller.Get())
            {
                responseContent.Add(s);
            }

            if (responseContent.Count > 0)
                Assert.True(true);
            else
                Assert.True(false);
        }
    }
}
