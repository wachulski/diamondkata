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
        
        var spaces = new string(' ', _alphaDistance);
        
        return $"{spaces}A{spaces}";
    }
}