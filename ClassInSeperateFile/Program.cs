using ClassInSeperateFile;

Rectangle rect = new Rectangle("First", 10.1m, 20.2m);
Console.WriteLine(rect);
Console.WriteLine(Rectangle.Count);

Rectangle rect2 = new Rectangle("First", 2.5m, 3.6m);
Console.WriteLine(rect2);
Console.WriteLine(Rectangle.Count);

Rectangle rect3 = new Rectangle("First", 1.1m, 2.2m);
Console.WriteLine(rect3);
Console.WriteLine(Rectangle.Count);

string entry = "10";
Console.WriteLine(Convert.ToInt32(entry));

