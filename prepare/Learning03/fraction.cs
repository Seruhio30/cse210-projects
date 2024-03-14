public class Fraction
{
    private int _top;
    private int _botton;

    public Fraction()
    {
        _top = 1;
        _botton = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _botton = 1;
    }

    public Fraction(int top, int botton)
    {
        _top = top;
        _botton = botton;
    }

    public string GetFrationString()
    {
        string text = $"{_top}/{_botton}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_botton;
    }
}