Pen gelpen = new Pen("green", 5.0, "Gel", "medium");
gelpen.Print();

Pen feltpen = new Pen("blue", 4.0, "felt", "small");
feltpen.Print();

gelpen.Draw(5);
gelpen.Print();
gelpen.Draw(7);
gelpen.Print();

Console.WriteLine();
Console.WriteLine(gelpen);


class Pen
{
    public string InkColor;
    public double Length;
    public string PointType;
    public string PointSize;
    public int InkAmount;

    // Constructor that makes a new object, in this case a pen. 
    public Pen(string _InkColor, double _Length, string _PointType, string _PointSize)
    {
        InkColor = _InkColor;
        Length = _Length;
        PointType = _PointType;
        PointSize = _PointSize;
        InkAmount = 10;
    }

    public void Print()
    {
        Console.WriteLine("This pen: ");
        Console.WriteLine($"    Color: {InkColor} Length: {Length} Type: {PointType} Size: {PointSize} Amount: {InkAmount}");
    }

    public void Draw(int lineLength)
    {
        if(lineLength > InkAmount)
        {
            Console.WriteLine("Sorry, not enough ink for that!");
            return; // this ends the function. I think I would rather use an if else statment
        }
        InkAmount -= lineLength;
        if (InkAmount < 0)
        {
            InkAmount = 0;
        }
    }

    public void Refill()
    {
        InkAmount = 10;
    }

    public override string ToString()
    {
        return $"Color: {InkColor}  Length: {Length}    Type: {PointType}   Size: {PointSize}   Amount: {InkAmount}";
    }
}