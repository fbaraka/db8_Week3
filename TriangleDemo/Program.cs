
Triangle first = new Triangle(4,3);


double area = first.GetArea();

Console.WriteLine(area);

Console.WriteLine(first.GetHypotenuse());
Console.WriteLine(first.GetPerimeter());


class Triangle
{

    // we have a package, like a capsule
    // the verb we use is "encapsulate"
    // we've packaged together Length and Height into a triangle concept. 
    // We have "encapsulated" length and Height into a triangle. 

    private double length;
    private double height;

    // Initializing the data
    // Create a constructor 

    public Triangle(double _length, double _height)
    {
        length = _length;
        height = _height;
    }

    public double GetArea()
    {
        return length * height / 2;
    }

    public double GetHypotenuse()
    {
        return Math.Sqrt(length * length + height * height);
    }

    public double GetPerimeter()
    {
        return length + height + GetHypotenuse();
    }

}