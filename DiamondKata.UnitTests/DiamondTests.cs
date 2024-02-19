namespace DiamondKata.UnitTests;

public class DiamondTests
{
    [Fact]
    public void When_A_Then_should_print_just_A()
    {
        var diamond = new Diamond('A');

        var actual = Act(diamond);

        Assert.Equal("A", actual);
    }

    [Fact]
    public void When_B_Then_should_print_top_line_of_A_surrounded_with_spaces()
    {
        var diamond = new Diamond('B');
        var expected = "_A_";
        
        var actual = Act(diamond).Split(Environment.NewLine)[0];
        
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void When_B_Then_should_print_top_half()
    {
        var diamond = new Diamond('B');
        var expected = @"_A_
B_B".ReplaceLineEndings();

        var actual = Act(diamond);
        
        Assert.StartsWith(expected, actual);
    }

    [Fact]
    public void When_B_Then_should_print_ABBA_diamond()
    {
        var diamond = new Diamond('B');
        var expected = @"_A_
B_B
_A_".ReplaceLineEndings();

        var actual = Act(diamond);

        Assert.Equal(expected, actual);
    }

    private static string Act(Diamond diamond)
    {
        return diamond.ToString().Replace(' ', '_');
    }
}