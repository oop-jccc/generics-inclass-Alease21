namespace GenericsTests;

[TestFixture]
public class ArrayUtilitiesTests
{
    [Test]
    public void Test_IsNullOrEmpty_ArrayIsNull()
    {
        int[]? array = null;
        // TODO: Update this line to use the IsNullOrEmpty extension method directly on the array variable.
        Assert.That(ArrayUtilities.IsNullOrEmpty(array), Is.True); 
    }

    [Test]
    public void Test_IsNullOrEmpty_ArrayIsEmpty()
    {
        var array = Array.Empty<int>();
        // TODO: Update this line to use the IsNullOrEmpty extension method directly on the array variable.
        Assert.That(ArrayUtilities.IsNullOrEmpty(array), Is.True);
    }

    [Test]
    public void Test_IsNullOrEmpty_ArrayIsNotEmpty()
    {
        var array = new[]
        {
            1, 2, 3
        };
        // TODO: Update this line to use the IsNullOrEmpty extension method directly on the array variable.
        Assert.That(ArrayUtilities.IsNullOrEmpty(array), Is.False);
    }
}