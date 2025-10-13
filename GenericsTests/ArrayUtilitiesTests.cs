namespace GenericsTests;

[TestFixture]
public class ArrayUtilitiesTests
{
    [Test]
    public void Test_IsNullOrEmpty_ArrayIsNull()
    {
        int[]? array = null;
        Assert.That(array.IsNullOrEmpty(), Is.True);
    }

    [Test]
    public void Test_IsNullOrEmpty_ArrayIsEmpty()
    {
        var array = Array.Empty<int>();
        Assert.That(array.IsNullOrEmpty(), Is.True);
    }

    [Test]
    public void Test_IsNullOrEmpty_ArrayIsNotEmpty()
    {
        var array = new[]
        {
            1, 2, 3
        };
        Assert.That(array.IsNullOrEmpty(), Is.False);
    }
}