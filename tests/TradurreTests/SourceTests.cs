namespace Tradurre;

[TestClass]
public sealed class SourceTests
{
    [TestMethod]
    public void ToJsonTest()
    {
        Source s = new();

        string expected = "{\"FileName\":null,\"LineNumber\":-1,\"Value\":\"\"}";

#if DEBUG
        expected = "{\r\n  \"FileName\": null,\r\n  \"LineNumber\": -1,\r\n  \"Value\": \"\"\r\n}";
#endif

        Assert.AreEqual(expected, s.ToJson());
    }
}