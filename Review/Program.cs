


//
// Lists
// 

List<Rectangle> myList = new List<Rectangle>();
myList.Add(new Rectangle("First", 10.5, 20.6));
myList.Add(new Rectangle("Second", 25.6, 13.2));
myList.Add(new Rectangle("Third", 12.9, 11.3));

foreach(Rectangle rect in myList)
{
    Console.WriteLine(rect);
}




// 
// Dictionaries 
// 

Console.WriteLine();
Console.WriteLine("Dictionary Practice");
Dictionary<string, int> spelling = new Dictionary<string, int>();

// Two ways to add to the dictioanry 
spelling["One"] = 1;
spelling["Fifty"] = 50;

// or...

spelling.Add("One Hundred", 100); // 

// let's loop!

foreach (var kvp in spelling)
{
    Console.WriteLine($"{kvp.Key} maps to {kvp.Value}");
}



//
// Enums
// 











class Rectangle
{
    public string Name;
    public double Length;
    public double Height;

    public Rectangle (string _Name, double _Length, double _Height)
    {
        Name = _Name;
        Length = _Length;
        Height = _Height;
    }

    // To add a ToString, start typing public override
    // and then remove auto code 

    public override string ToString()
    {
        return $"{Name}: Length {Length} Height{Height }Area: {Length * Height} Perimeter: {2 * Length + 2 * Height}";
        ;
    }

}