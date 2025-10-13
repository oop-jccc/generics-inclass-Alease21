namespace GenericsTests;

public static class ArrayUtilities
{
    public static bool IsNullOrEmpty<T>(this T[]? array)
    {
        return array == null || array.Length == 0;
    }
}