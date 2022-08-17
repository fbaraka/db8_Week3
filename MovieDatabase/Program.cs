//// add the using line manually. The name comes from the namespace line in the movie.cs file. 
//using MovieDatabase;

//List<Movie> movies = new List<Movie>();

//movies.Add(new Movie("The Shawshank Redemption", "Drama"));
//movies.Add(new Movie("The Godfather", "Drama"));
//movies.Add(new Movie("The Dark Knight", "Superhero"));
//movies.Add(new Movie("Return of the King", "Fantasy"));
//movies.Add(new Movie("Fellowship of the Ring", "Fantasy"));
//movies.Add(new Movie("Empire Strikes Back", "SciFi"));
//movies.Add(new Movie("Interstellar", "SciFi"));
//movies.Add(new Movie("Superman", "Superhero"));


//Console.WriteLine("Welcome to the Movie Database!");


//Console.WriteLine($"There are {movies.Count} movies in this list.");

//Console.Write("What category are you interested in? ");
//string entry = Console.ReadLine();

//if (entry == "Drama" || entry == "Superhero" || entry == "Fantasy" || entry == "Scifi")
//{
//    foreach (Movie next in movies)
//    {
//        if (next.Category == entry)
//        {
//            Console.WriteLine(next);
//        }
//    }
//}
//else
//{
//    Console.WriteLine("Sorry we do not have that category here!");
//}

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



