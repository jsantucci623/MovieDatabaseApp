// Movie Database
// Jeff Santucci
// 02/07/2023

using MovieDatabase;

string typeMovie;

List<Movie> shows = new List<Movie>()
{
   new Movie("Terminator", "Action"), // { title = "Terminator", category = "Action"},
   new Movie("Poltergeist","Horror"),
   new Movie("Rio Bravo", "Western"),
   new Movie("Ghost Busters", "Comedy"),
   new Movie("West Side Story", "Drama"),
   new Movie("Minions", "Comedy"),
   new Movie("The Last Emporer", "Drama"),
   new Movie("Star Wars", "SciFi"),
   new Movie("Terminator II", "Action"),
   new Movie("The Good the Bad and the Ugly","Western")
};

Console.WriteLine("Welcome to the Movie List Application");
Console.WriteLine();
Console.WriteLine("There are 10 movies in this list.");

do
{
    Console.WriteLine("What category of movie are you interested in? :  'Action', 'Horror', 'Western', 'Comedy', 'Drama', or 'SciFi'? ");

    typeMovie = Console.ReadLine();
    
    Console.WriteLine();

    bool gotOne = false;

    List<Movie> showResults = shows.Where(show => show.category.Equals(typeMovie)).ToList();

    foreach (Movie result in showResults)
    {
        gotOne = true;
        Console.WriteLine(result.title);
                  
    }
    if (!gotOne)
    {
        Console.WriteLine(typeMovie + " is not one of the valid categories! ");
    }
    Console.WriteLine();
    Console.WriteLine("Would you like to continue? (y/n) ");

} while (Console.ReadLine() == "y");



