namespace GenericsTests;

[TestFixture]
public class OverloadingTests
{
    private static T Multiply<T>(T a, T b) where T : IConvertible
    {
        dynamic x = a;
        dynamic y = b;
        return x * y;
    }

    // TODO: Create a method named Multiply that takes three generic parameters of the same type T.
    // TODO: Add a type constraint to ensure that T implements the IConvertible interface.
    // TODO: Inside the method, use the dynamic keyword to create variables x, y, and z.
    // TODO: Perform the multiplication of x, y, and z.
    // TODO: Return the result.

    private static dynamic Multiply<T, U>(T a, U b) where T : IConvertible where U : IConvertible
    {
        dynamic x = a;
        dynamic y = b;
        return x * y;
    }

    [Test]
    public void Test_Multiply_Two_Integers()
    {
        var a = 2;
        var b = 3;

        var result = Multiply<int>(a, b); // note the explicit type argument

        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void Test_Multiply_Two_Strings()
    {
        var a = "2";
        var b = "3";

        Assert.That(() => Multiply<string>(a, b), Throws.InstanceOf<Microsoft.CSharp.RuntimeBinder.RuntimeBinderException>());
    }

    // TODO: Create a test method named Test_Multiply_Three_Doubles.
    // TODO: Declare variables a, b, and c and initialize them with values 2.5, 3.5, and 1.2, respectively.
    // TODO: Call the Multiply method with a, b, and c as arguments. Store the result in a variable.
    // TODO: Use Assert.That to check if the result is equal to 10.5.

    [Test]
    public void Test_Multiply_Different_Types()
    {
        var a = 2;
        var b = 3.5;

        var result = Multiply(a, b); // note the explicit type argument is not required

        Assert.That(result, Is.EqualTo(7.0));
    }
}