namespace _4_uTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {

        // Arrange
        double expected = 0.9072;
        double pounds = 2;

        //Act

        double actual = Conversions.PoundsToKilos(pounds);

        //Asset

        Assert.AreEqual(expected, actual);
    }
}
