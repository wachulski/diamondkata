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
            var currentDiamondLetter = (char)('A' + i);
            var spacesAround = new string(' ', _alphaDistance - i);
            var diamondPart = i == 0
                ? currentDiamondLetter.ToString()
                : $"{currentDiamondLetter}{new string(' ', i * 2 - 1)}{currentDiamondLetter}";
            diamondBuilder.Append(spacesAround).Append(diamondPart).Append(spacesAround).AppendLine();
        }

        return diamondBuilder.ToString();
    }
}