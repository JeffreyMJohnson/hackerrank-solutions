namespace picking_numbers;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        int[] testNums = [1,1,2,2,4,4,5,5,5];
        int expected = 5;

        int actual = Solution.PickingNumbers(testNums);

        Assert.That(actual, Is.EqualTo(expected));
    }
}