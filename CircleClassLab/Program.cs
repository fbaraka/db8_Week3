
Console.WriteLine("Welcome to Circle Builder!");

List<Circle> circleList = new List<Circle>();
bool keepGoing = true;
do
{

    Console.Write("Please enter a radius: ");
    double radius = Convert.ToDouble(Console.ReadLine());

    Circle newCircle = new Circle(radius);
    newCircle.CalculateCircumfrence(radius);
    newCircle.CalculateArea(radius);
    Console.WriteLine(newCircle);
    circleList.Add(newCircle);
  

    
    keepGoing = KeepGoing();

    


} while (keepGoing);

Console.WriteLine($"Goodbye! You made {circleList.Count} circle objects");



static bool KeepGoing()
{

    while (true)
    {
        Console.Write("Would you like to keep going? (y/n): ");
        string response = Console.ReadLine().ToLower();
        Console.WriteLine();
        if (response == "y" || response == "yes")
        {
            return true;
        }
        else if (response == "n" || response == "no")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Please enter y or n");
        }
    }
}
class Circle 
{


   
    public double circumfrence;
    public double area;


    public Circle(double _radius)
    {

    }

    public double CalculateCircumfrence(double _radius)
    {
        // 2 pi r
        return circumfrence = 2 * Math.PI * _radius;
    }

    public double CalculateArea(double _radius)
    {
        // pi r square
        return area = Math.PI * _radius * _radius;

    }


    public override string ToString()
    {
        return $"Circumfrence = {circumfrence}\nArea = {area, 25}\n";
    }

}

class Validator
{

}

