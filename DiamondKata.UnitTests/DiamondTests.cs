namespace DiamondKata.UnitTests;

public class DiamondTests
{
    [Fact]
    public void When_just_letter_A_Then_Should_Print_Just_A()
    {
        var diamond = new Diamond('A');

        var actual = diamond.ToString();

        Assert.Equal("A", actual);
    }
}