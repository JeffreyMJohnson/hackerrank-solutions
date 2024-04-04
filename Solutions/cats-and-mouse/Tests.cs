namespace cats_and_mouse;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CatsEqualDistance()
    {
        int catAPosition = 1;
        int catBPosition = -1;
        int mousePosition = 0;

        string expected = "Mouse C";
        string result = CatsAndMouseSolution.catAndMouse(catAPosition, catBPosition, mousePosition);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CatAIsCloser()
    {
        int catAPosition = 1;
        int catBPosition = -2;
        int mousePosition = 0;

        string expected = "Cat A";
        string result = CatsAndMouseSolution.catAndMouse(catAPosition, catBPosition, mousePosition);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CatBIsCloser()
    {
        int catAPosition = 2;
        int catBPosition = 1;
        int mousePosition = 0;

        string expected = "Cat B";
        string result = CatsAndMouseSolution.catAndMouse(catAPosition, catBPosition, mousePosition);
        Assert.That(result, Is.EqualTo(expected));
    }
}