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

    private static dynamic Multiply<T, U>(T a, U b) where T : IConvertible where U : IConvertible
    {
        dynamic x = a;
        dynamic y = b;
        return x * y;
    }

    private static T Multiply<T>(T a, T b, T c) where T : IConvertible
    {
        dynamic x = a;
        dynamic y = b;
        dynamic z = c;
        return x * y * z;
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

    [Test]
    public void Test_Multiply_Different_Types()
    {
        var a = 2;
        var b = 3.5;

        var result = Multiply(a, b); // note the explicit type argument is not required

        Assert.That(result, Is.EqualTo(7.0));
    }

    [Test]
    public void Test_Multiply_Three_Doubles()
    {
        var a = 2.5;
        var b = 3.5;
        var c = 1.2;

        var result = Multiply(a, b, c); // note the explicit type argument is not required

        Assert.That(result, Is.EqualTo(10.5));
    }
}