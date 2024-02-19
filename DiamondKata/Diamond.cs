using System.Text;

namespace DiamondKata;

public class Diamond
{
    private readonly char _letter;
    private readonly int _midpointDistance;

    public Diamond(char letter)
    {
        if (char.ToUpper(letter) is < 'A' or > 'Z')
            throw new ArgumentException("Letter must be a letter from A to Z");
        
        _letter = char.ToUpper(letter);
        _midpointDistance = _letter - 'A';
    }

    public override string ToString()
    {
        if (_midpointDistance == 0)
            return _letter.ToString();

        var diamondBuilder = new StringBuilder();

        var currentDistance = 0;
        var increment = 1;
        while (currentDistance >= 0)
        {
            var currentDiamondLetter = (char)('A' + currentDistance);
            var spacesAround = new string(' ', _midpointDistance - currentDistance);
            var diamondPart = currentDistance == 0
                ? currentDiamondLetter.ToString()
                : $"{currentDiamondLetter}{new string(' ', currentDistance * 2 - 1)}{currentDiamondLetter}";
            diamondBuilder.Append(spacesAround).Append(diamondPart).Append(spacesAround).AppendLine();
            
            if (currentDistance == _midpointDistance)
                increment = -1;

            currentDistance += increment;
        }

        return diamondBuilder.ToString().TrimEnd('\n').TrimEnd('\r');
    }
}