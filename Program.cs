using NLog;

// See https://aka.ms/new-console-template for more information
string path = Directory.GetCurrentDirectory() + "//nlog.config";

// create instance of Logger
var logger = LogManager.LoadConfiguration(path).GetCurrentClassLogger();
logger.Info("Program started");

Movie movie = new Movie
{
  movieId = 1,
  title = "Jeff's Killer Movie (2019)",
  genres = new List<string> { "Action", "Romance", "Comedy" }
};

MovieFile movieFile = new MovieFile(path);

string choice = "";
do
{
  // display choices to user
  Console.WriteLine("1) Add Movie");
  Console.WriteLine("2) Display All Movies");
  Console.WriteLine("Enter to quit");
  // input selection
  choice = Console.ReadLine();
  logger.Info("User choice: {Choice}", choice);


  if (choice == "1")
  {
    // Add movie
  } else if (choice == "2")
  {
    // Display All Movies
    foreach(Movie m in movieFile.Movies)
    {
      Console.WriteLine(m.Display());
    }
  }
} while (choice == "1" || choice == "2");

logger.Info("Program ended");