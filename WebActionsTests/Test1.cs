namespace WebActionsTests;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        Assert.AreEqual(2, 1 + 1);
    }

    [TestMethod]
    public void TestMethod2()
    {
        Assert.AreEqual(3, 1 + 4);
    }
}