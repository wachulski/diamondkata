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
    
    [Fact]
    public void When_Z_Then_should_print_large_diamond()
    {
        var diamond = new Diamond('Z');
        var expected = @"_________________________A_________________________
________________________B_B________________________
_______________________C___C_______________________
______________________D_____D______________________
_____________________E_______E_____________________
____________________F_________F____________________
___________________G___________G___________________
__________________H_____________H__________________
_________________I_______________I_________________
________________J_________________J________________
_______________K___________________K_______________
______________L_____________________L______________
_____________M_______________________M_____________
____________N_________________________N____________
___________O___________________________O___________
__________P_____________________________P__________
_________Q_______________________________Q_________
________R_________________________________R________
_______S___________________________________S_______
______T_____________________________________T______
_____U_______________________________________U_____
____V_________________________________________V____
___W___________________________________________W___
__X_____________________________________________X__
_Y_______________________________________________Y_
Z_________________________________________________Z
_Y_______________________________________________Y_
__X_____________________________________________X__
___W___________________________________________W___
____V_________________________________________V____
_____U_______________________________________U_____
______T_____________________________________T______
_______S___________________________________S_______
________R_________________________________R________
_________Q_______________________________Q_________
__________P_____________________________P__________
___________O___________________________O___________
____________N_________________________N____________
_____________M_______________________M_____________
______________L_____________________L______________
_______________K___________________K_______________
________________J_________________J________________
_________________I_______________I_________________
__________________H_____________H__________________
___________________G___________G___________________
____________________F_________F____________________
_____________________E_______E_____________________
______________________D_____D______________________
_______________________C___C_______________________
________________________B_B________________________
_________________________A_________________________".ReplaceLineEndings();

        var actual = Act(diamond);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData('1')]
    [InlineData('Ą')]
    public void When_letter_is_not_alpha_char_Throws(char letter)
    {
        Assert.Throws<ArgumentException>(() => new Diamond(letter));
    }

    [Fact]
    public void When_lowercase_Then_should_be_supported()
    {
        var diamond = new Diamond('a');

        var actual = Act(diamond);

        Assert.Equal("A", actual);
    }

    private static string Act(Diamond diamond)
    {
        return diamond.ToString().Replace(' ', '_');
    }
}