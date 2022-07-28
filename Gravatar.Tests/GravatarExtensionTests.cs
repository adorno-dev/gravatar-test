namespace Gravatar.Tests;

[TestClass]
public class GravatarExtensionTests
{
    [TestCategory("Gravatar Tests")]
    [TestMethod("Should validate gravatar extension")]
    [DataRow(null, false)]
    [DataRow("", false)]
    [DataRow(" ", false)]
    [DataRow("a@a", false)]
    [DataRow("a@gmail.com.br", false)]
    [DataRow("adorno.dev@gmail.com", true)]
    public void ShouldValidateGravatar(string email, bool status)
    {
        var result = "https://gravatar.com/avatar/1a651f1e6f55ad106ef8502857805d7e";

        Assert.AreEqual(expected: email.ToGravatar() == result, actual: status);
    }
}