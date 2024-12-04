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
}