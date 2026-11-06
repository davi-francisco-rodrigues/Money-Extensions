namespace MoneyExtension.Tests;

public class MoneyTest
{
    [Fact]
    public void ShouldConvertDecimalToInt()
    {
        var amount = 278.97m;
        var result = amount.ToCents();

        Assert.Equal(27897, result);
    }
}
