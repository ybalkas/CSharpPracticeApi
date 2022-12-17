using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using RestSharpDemo;
using RestSharpDemo.Models;
using RestSharpDemo.Models.Request;
using System;
using System.Threading.Tasks;

namespace MSTestApi
{
    [TestClass]
    public class UnitTest1
    {
        private const string BASE_URL = "https://reqres.in/";
        private readonly CreateUserReq createUserReq;
        private RestResponse response;

        [TestMethod]

        async public Task TestMethod1()
        {
            Console.WriteLine("Hello World");
        }


       [TestMethod]

       async public Task TestMethod2()
        {
            var api = new Demo();
            var response = await api.GetUsers(BASE_URL);
            var statCode = response.StatusCode.ToString();
            Assert.AreEqual("OK", statCode);
            Users user = HandleContent.GetContent<Users>(response);
           
            Console.WriteLine(response.Content);
            Assert.AreEqual("", "");
            Console.WriteLine(user.support.text);
            Console.WriteLine(user.page+" ---" +
                user.per_page);
            Console.WriteLine("Hello");
            Console.WriteLine(user.support.url);
            Console.WriteLine(user.data);

            foreach (var item in user.data)
            {
                Console.WriteLine(item.avatar);
                Console.WriteLine(item.email);
            }
            Console.WriteLine("text="+user.support.text);
            Console.WriteLine("url="+user.support.url);
            // Assert.AreEqual(user.page, content.page);
            // Assert.AreEqual(user.per_page, content.per_page);
        }
    }
}
