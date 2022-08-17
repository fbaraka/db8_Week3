using MovieDatabase;


List<Movie> movies = new List<Movie>();

movies.Add(new Movie("John Wick", "Action"));
movies.Add(new Movie("John Wick: Chapter 2", "Action"));
movies.Add(new Movie("John Wick Chapter 3: Parabellum", "Action"));
movies.Add(new Movie("The Illusionist", "Mystery"));
movies.Add(new Movie("Nacho Libre", "Comedy"));
movies.Add(new Movie("Moon", "SciFi"));
movies.Add(new Movie("District 9", "SciFi"));
movies.Add(new Movie("Four Lions", "Comedy"));
movies.Add(new Movie("Knives Out", "Mystery"));
movies.Add(new Movie("Eurovision", "Comedy"));



Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine($"There are {movies.Count} movies in this list.");



do
{
    Console.Write("What category are you interested in? ");
    string userInput = Console.ReadLine().ToLower();
    Console.WriteLine();

    if (userInput == "action" || userInput == "mystery" || userInput == "comedy" || userInput == "scifi")
    {
        
        int count = 0;

        foreach (Movie movie in movies)
        {
            if (movie.Category.ToLower() == userInput)
            {
                count++;
                Console.WriteLine($"{count}. {movie}");
                Console.WriteLine();
            }
        }
    }

    else
    {
        Console.WriteLine("Sorry, we don't have any movie for that category!");
    }


} while (KeepGoing());


static bool KeepGoing()
{

    while (true)
    {
        Console.Write("Continue (y/n): ");
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

