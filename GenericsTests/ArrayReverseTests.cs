namespace GenericsTests;

public class ArrayReverseTests
{
    // TODO: Convert this method to use generics instead of object
    private static void ReverseArray(object[] arr)
    {
        var n = arr.Length;
        for (var i = 0; i < n / 2; i++)
        {
            (arr[i], arr[n - i - 1]) = (arr[n - i - 1], arr[i]);
        }
    }

    // TODO: Convert this test to work with a generic-based ReverseArray method
    [Test]
    public void Test_Reverse_Object_Array()
    {
        // TODO: Change this object array to an integer array
        object[] arr =
        {
            1, 2, 3, 4
        };

        ReverseArray(arr);

        // TODO: Change this object array to an integer array for the expected result
        object[] expected =
        {
            4, 3, 2, 1
        };

        Assert.That(arr, Is.EqualTo(expected));
    }

    private static void ReverseArray<T>(T[] arr)
    {
        var n = arr.Length;
        for (var i = 0; i < n / 2; i++)
        {
            (arr[i], arr[n - i - 1]) = (arr[n - i - 1], arr[i]);
        }
    }

    [Test]
    public void Test_Reverse_Int_Array()
    {
        int[] arr =
        {
            1, 2, 3, 4
        };

        ReverseArray(arr);

        int[] expected =
        {
            4, 3, 2, 1
        };

        Assert.That(arr, Is.EqualTo(expected));
    }
}