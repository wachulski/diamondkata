using System.Text;

namespace DiamondKata;

public class Diamond
{
    private readonly char _letter;
    private readonly int _alphaDistance;
        
    public Diamond(char letter)
    {
        _letter = letter;
        _alphaDistance = _letter - 'A';
    }
    
    public override string ToString()
    {
        if (_alphaDistance == 0)
            return _letter.ToString();

        var diamondBuilder = new StringBuilder();
        
        for (var i = 0; i <= _alphaDistance; i++)
        {
            var letter = (char)('A' + i);
            var spaces = new string(' ', _alphaDistance - i);
            var diamondPart = i == 0 ? letter.ToString() : $"{letter}{new string(' ', i * 2 - 1)}{letter}";
            diamondBuilder.Append(spaces).Append(diamondPart).Append(spaces).AppendLine();
        }
        
        return diamondBuilder.ToString();
    }
}