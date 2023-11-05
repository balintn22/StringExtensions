using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Tests;

[TestClass()]
public class StringExtensionsTests
{
    [DataTestMethod()]
    [DataRow(null, 1, null)]
    [DataRow("abc", 0, "")]
    [DataRow("abc", 1, "c")]
    [DataRow("abc", 4, "abc")]
    public void Right_ShouldReturnExpected(
        string input, int count, string expected)
    {
        string? result = input.Right(count);
        result.Should().Be(expected);
    }

    [DataTestMethod()]
    [DataRow(null, 1, null)]
    [DataRow("abc", 0, "")]
    [DataRow("abc", 1, "a")]
    [DataRow("abc", 4, "abc")]
    public void Left_ShouldReturnExpected(
        string input, int count, string expected)
    {
        string? result = input.Left(count);
        result.Should().Be(expected);
    }
}