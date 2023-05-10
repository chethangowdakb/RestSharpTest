using System.Net;
using RestSharp;

namespace LearningAPIDemo;

[TestClass]
public class UnitTest1
{
    private readonly RestClient client;

    public UnitTest1()
    {
        client = new RestClient("https://jsonplaceholder.typicode.com");
    }
    [TestMethod]
    public void TestMethod1()
    {
        var request = new RestRequest("/posts", Method.Get);
        var response = client.Execute(request);
        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
    }
    [TestMethod]
    [TestCategory("Somoke")]
    public void TestMethod2()
    {
        var request = new RestRequest("/posts", Method.Get);
        var response = client.Execute(request);
        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        Assert.AreEqual("application/json", response.ContentType);
    }
}
