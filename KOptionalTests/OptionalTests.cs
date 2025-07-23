using KOptional;

namespace KOptionalTests;

public class OptionalTests
{
    [Fact]
    public void DefaultConstructor_HasNoValue()
    {
        var opt = new Optional<int>();
        Assert.False(opt.HasValue);
        Assert.Equal(default, opt.Value);
    }

    [Fact]
    public void ValueConstructor_HasValue()
    {
        var opt = new Optional<int>(42);
        Assert.True(opt.HasValue);
        Assert.Equal(42, opt.Value);
    }

    [Fact]
    public void ValueConstructor_HasNullableValue()
    {
        var opt = new Optional<int?>(null);
        Assert.True(opt.HasValue);
        Assert.Null(opt.Value);
    }

    [Fact]
    public void ValueSetter_SetsHasValue()
    {
        var opt = new Optional<string>();
        opt.Value = "hello";
        Assert.True(opt.HasValue);
        Assert.Equal("hello", opt.Value);
    }

    [Fact]
    public void ValueSetter_SetsNullReferenceType()
    {
        var opt = new Optional<string>();
        opt.Value = null;
        Assert.True(opt.HasValue);
        Assert.Null(opt.Value);
    }

    [Fact]
    public void ImplicitConversion_SetsValueAndHasValue()
    {
        Optional<string> opt = "world";
        Assert.True(opt.HasValue);
        Assert.Equal("world", opt.Value);
    }

    [Fact]
    public void TryGetValue_ReturnsTrueAndValue_WhenHasValue()
    {
        var opt = new Optional<int>(99);
        var result = opt.TryGetValue(out var value);
        Assert.True(result);
        Assert.Equal(99, value);
    }

    [Fact]
    public void TryGetValue_ReturnsTrueAndNull_WhenValueIsNull()
    {
        var opt = new Optional<string?>(null);
        var result = opt.TryGetValue(out var value);
        Assert.True(result);
        Assert.Null(value);
    }

    [Fact]
    public void TryGetValue_ReturnsFalseAndDefault_WhenNoValue()
    {
        var opt = new Optional<int>();
        var result = opt.TryGetValue(out var value);
        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void Coalesce_ReturnsValue_WhenHasValue()
    {
        var opt = new Optional<string>("foo");
        Assert.Equal("foo", opt.Coalesce("bar"));
    }

    [Fact]
    public void Coalesce_ReturnsDefault_WhenNoValue()
    {
        var opt = new Optional<string>();
        Assert.Equal("bar", opt.Coalesce("bar"));
    }

    [Fact]
    public void ToString_ReturnsValueString_WhenHasValue()
    {
        var opt = new Optional<int>(123);
        Assert.Equal("123", opt.ToString());
    }

    [Fact]
    public void ToString_ReturnsNoValue_WhenNoValue()
    {
        var opt = new Optional<int>();
        Assert.Equal("No Value", opt.ToString());
    }

    [Fact]
    public void ToString_ReturnsNullString_WhenValueIsNull()
    {
        var opt = new Optional<string?>(null);
        Assert.Equal("null", opt.ToString());
    }

    [Fact]
    public void Equals_ReturnsTrue_ForEqualOptionals()
    {
        var a = new Optional<int>(5);
        var b = new Optional<int>(5);
        Assert.True(a.Equals(b));
    }

    [Fact]
    public void Equals_ReturnsFalse_ForDifferentOptionals()
    {
        var a = new Optional<int>(5);
        var b = new Optional<int>(6);
        Assert.False(a.Equals(b));
    }

    [Fact]
    public void Equals_ReturnsTrue_ForBothNullValues()
    {
        var a = new Optional<string?>(null);
        var b = new Optional<string?>(null);
        Assert.True(a.Equals(b));
        Assert.Equal(a.GetHashCode(), b.GetHashCode());
    }

    [Fact]
    public void GetHashCode_IsConsistent_ForEqualOptionals()
    {
        var a = new Optional<int>(7);
        var b = new Optional<int>(7);
        Assert.Equal(a.GetHashCode(), b.GetHashCode());
    }
}