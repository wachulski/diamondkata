namespace DiamondKata.UnitTests;

public class DiamondTests
{
    [Fact]
    public void When_A_Then_should_print_just_A()
    {
        var diamond = new Diamond('A');

        var actual = diamond.ToString();

        Assert.Equal("A", actual);
    }

    [Fact]
    public void When_B_Then_should_print_top_line_of_A_surrounded_with_spaces()
    {
        var diamond = new Diamond('B');
        var expected = " A ";
        
        var actual = diamond.ToString().Split(Environment.NewLine)[0];
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void When_B_Then_should_print_top_half()
    {
        var diamond = new Diamond('B');
        var expected = @" A 
B B";

        var actual = diamond.ToString();
        
        Assert.StartsWith(expected, actual);
    }

    [Fact]
    public void When_B_Then_should_print_ABBA_diamond()
    {
        var diamond = new Diamond('B');
        var expected = @" A 
B B
 A";

        var actual = diamond.ToString();

        Assert.Equal(expected, actual);
    }
}