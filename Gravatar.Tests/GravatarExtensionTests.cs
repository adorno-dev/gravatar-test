namespace Gravatar.Tests;

[TestClass]
public class GravatarExtensionTests
{
    [TestCategory("Gravatar Tests")]
    [TestMethod("Should validate gravatar extension")]
    [DataRow(null, 200, false)]
    [DataRow("", 200, false)]
    [DataRow(" ", 200, false)]
    [DataRow("a@a", 200, false)]
    [DataRow("a@gmail.com.br", 200, false)]
    [DataRow("adorno.dev@gmail.com", null, true)]
    [DataRow("adorno.dev@gmail.com", 200, true)]
    public void ShouldValidateGravatar(string email, int? size, bool status)
    {
        var result = $"https://gravatar.com/avatar/1a651f1e6f55ad106ef8502857805d7e?s={size ?? 80}";

        Assert.AreEqual(expected: email.ToGravatar(size ?? 80) == result, actual: status);
    }
}