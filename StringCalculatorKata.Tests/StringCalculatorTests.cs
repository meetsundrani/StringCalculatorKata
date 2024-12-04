using System;
using Xunit;
using StringCalculatorKata;

namespace StringCalculatorKata.Tests;

public class StringCalculatorTests
{
    private readonly StringCalculator _calculator;

    public StringCalculatorTests()
    {
        _calculator = new StringCalculator();
    }

    [Fact]
    public void Add_EmptyString_ReturnsZero()
    {
        int result = _calculator.Add("");
        Assert.Equal(0, result);
    }

    [Fact]
    public void Add_SingleNumber_ReturnsSameNumber()
    {
        int result = _calculator.Add("1");
        Assert.Equal(1, result);
    }

    [Fact]
    public void Add_TwoNumbers_ReturnsSum()
    {
        int result = _calculator.Add("1,5");
        Assert.Equal(6, result);
    }

    [Fact]
    public void Add_MultipleNumbers_ReturnsSum()
    {
        int result = _calculator.Add("1,2,3,4");
        Assert.Equal(10, result);
    }

    [Fact]
    public void Add_AllowNewLineSeparator_ReturnsSum()
    {
        int result = _calculator.Add("1\n2,3");
        Assert.Equal(6, result);
    }

    [Fact]
    public void Add_CustomDelimiter_ReturnsSum()
    {
        int result = _calculator.Add("//;\n1;2");
        Assert.Equal(3, result);
    }
}