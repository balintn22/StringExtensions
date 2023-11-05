namespace StringExtensions;

public static class StringExtensions
{
    /// <summary>
    /// Takes the leftmost characters of a string.
    /// </summary>
    /// <param name="self">Original string.</param>
    /// <param name="length">Maximum number of characters to return.</param>
    /// <returns>
    /// Null if the input is null.
    /// The original string if the requested length is more than or equal to the length of the original string.
    /// The first length number of characters if the original string is longer than this.
    /// </returns>
    public static string? Left(this string? self, int length)
    {
        if (self == null)
            return null;

        if (string.IsNullOrEmpty(self))
            return string.Empty;

        return self.Length <= length
            ? self
            : self[..length];
    }

    /// <summary>
    /// Takes the rightmost characters of a string.
    /// </summary>
    /// <param name="self">Original string.</param>
    /// <param name="length">Maximum number of characters to return.</param>
    /// <returns>
    /// Null if the input is null.
    /// The original string if the requested length is more than or equal to the length of the original string.
    /// The last length number of characters if the original string is longer than this.
    /// </returns>
    public static string? Right(this string? self, int length)
    {
        if (self == null)
            return null;

        if (string.IsNullOrEmpty(self))
            return string.Empty;

        return self.Length <= length
            ? self
            : self[^length..];
    }
}