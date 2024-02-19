namespace DiamondKata.UnitTests;

public class DiamondTests
{
    [Fact]
    public void When_just_letter_A_Then_should_print_just_A()
    {
        var diamond = new Diamond('A');

        var actual = diamond.ToString();

        Assert.Equal("A", actual);
    }

    [Fact]
    public void When_B_ie_many_parts_Then_should_print_ABBA_diamond()
    {
        var diamond = new Diamond('B');
        var expected = @"A
B B
 A";

        var actual = diamond.ToString();

        Assert.Equal(expected, actual);
    }
}