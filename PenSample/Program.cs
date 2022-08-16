

Pen firstPen = new Pen();
firstPen.InkColor = "blue";
firstPen.Length = 4.5;
firstPen.PointType = "Gel";
firstPen.PointSize = "Small";
firstPen.InkAmount = 5;

Console.WriteLine(firstPen.InkColor);
Console.WriteLine(firstPen.Length);
Console.WriteLine(firstPen.PointType);
Console.WriteLine(firstPen.PointSize);
Console.WriteLine(firstPen.InkAmount);

Console.WriteLine("Lets draw with firstpen!");
firstPen.Draw();
Console.WriteLine($"The ink is now {firstPen.InkAmount}");


Pen secondPen = new Pen();
secondPen.InkColor = "red";
secondPen.Length = 4.5;
secondPen.PointType = "ball point";
secondPen.PointSize = "medium";
secondPen.InkAmount = 2;
Console.WriteLine();

Console.WriteLine(secondPen.InkColor);
Console.WriteLine(secondPen.Length);
Console.WriteLine(secondPen.PointType);
Console.WriteLine(secondPen.PointSize);
Console.WriteLine(secondPen.InkAmount);

Console.WriteLine("Lets draw with secondPen!");
secondPen.Draw();
secondPen.Draw();

Console.WriteLine($"secondPen now has ink level {secondPen.InkAmount}");
Console.WriteLine($"firstPen now has ink level {firstPen.InkAmount}");

secondPen.Refill();
Console.WriteLine($"secondPen now has ink level {secondPen.InkAmount}");

Console.WriteLine();
Console.WriteLine("Lets refill firstPen with green ink");
firstPen.Refill("green");
Console.WriteLine($"firstPen now has ink color {firstPen.InkColor}");

Console.WriteLine();
Pen thirdPen = new Pen();
Console.WriteLine(thirdPen.InkAmount);

class Pen
{

    // Member variables
    public string InkColor;
    public double Length;
    public string PointType;
    public string PointSize;
    public int InkAmount;

    public Pen()
    {
        InkAmount = 10;
        InkColor = "black";

    }
    // Member Methods
    public void Draw()
    {
        if (InkAmount > 0)
        {
            InkAmount--;
        }
    }

    public void Refill()
    {
        InkAmount = 10;
    }

    // Let's add another Refill function that lets us sepecify ink color
    public void Refill(string newColor)
    {
        InkColor = newColor;
        InkAmount = 10;
    }




}


