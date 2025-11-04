[![Open in Codespaces](https://classroom.github.com/assets/launch-codespace-2972f46106e565e64193e422d61a12cf1da4916b45550586e14ef0a7c637dd04.svg)](https://classroom.github.com/open-in-codespaces?assignment_repo_id=21455431)
## In-Class Programming Assignment: Convert Object-Based Method to Generic Method

### Objective:

Convert the given object-based `ReverseArray` method and its corresponding test to use C# Generics.

### Starter Code:

Here's the starter code, which is object-based:

```csharp
[TestFixture]
public class ArrayReverseTests
{
    private static void ReverseArray(object[] arr)
    {
        var n = arr.Length;
        for (var i = 0; i < n / 2; i++)
        {
            (arr[i], arr[n - i - 1]) = (arr[n - i - 1], arr[i]);
        }
    }

    [Test]
    public void Test_Reverse_Object_Array()
    {
        object[] arr =
        {
            1, 2, 3, 4
        };

        ReverseArray(arr);

        object[] expected =
        {
            4, 3, 2, 1
        };

        Assert.That(arr, Is.EqualTo(expected));
    }
}
```

### Instructions:

1. **Convert Method to Generic**: Replace the object parameter in `ReverseArray` with a generic `T` parameter.
2. **Update Test Method**: Convert the test method to work with a generic-based `ReverseArray` method.
    - Change the object array to an integer array in the test.
    - Update the `ReverseArray` call in the test to match the new generic signature.
3. **Run Test**: After making these changes, run the test to make sure it passes.


Note: The internal logic of `ReverseArray` did not change, only its signature.
