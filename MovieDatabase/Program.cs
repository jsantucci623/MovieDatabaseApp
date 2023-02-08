// Movie Database
// Jeff Santucci
// 02/07/2023

using MovieDatabase;

string typeMovie;

List<Movie> shows = new List<Movie>()
{
   new Movie() { title = "Terminator", category = "Action"},
   new Movie() { title = "Poltergeist", category = "Horror"},
   new Movie() { title = "Rio Bravo", category = "Western"},
   new Movie() { title = "Ghost Busters", category = "Comedy"},
   new Movie() { title = "West Side Story", category = "Drama"},
   new Movie() { title = "Minions", category = "Comedy"},
   new Movie() { title = "The Last Emporer", category = "Drama"},
   new Movie() { title = "Star Wars", category = "SciFi"},
   new Movie() { title = "Terminator II", category = "Action"},
   new Movie() { title = "The Good the Bad and the Ugly", category = "Western"}
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

    foreach (Movie show in shows)
    {
        if (typeMovie == show.category)
        {
            gotOne = true;
            Console.WriteLine(show.title);
        }
        
    }
    if (!gotOne)
    {
        Console.WriteLine(typeMovie + " is not one of the valid categories! ");
    }
    Console.WriteLine();
    Console.WriteLine("Would you like to continue? (y/n) ");

} while (Console.ReadLine() == "y");



