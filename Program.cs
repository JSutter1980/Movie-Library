using NLog;
string path = Directory.GetCurrentDirectory() + "\\nlog.config";
// create instance of Logger
var logger = LogManager.LoadConfiguration(path).GetCurrentClassLogger();


Console.WriteLine("Welcome to Blockbuster Video Database!");
Console.WriteLine("What would you like to do today?");
Console.WriteLine("1.List all movies");
Console.WriteLine("2.Add Movies");

string? resp = Console.ReadLine();

if (resp == "1")
{
            if (File.Exists("movies.csv"))
            {
                StreamReader sr = new StreamReader("movies.csv");
                while (!sr.EndOfStream)
                {

                    string line = sr.ReadLine();
                    string[] arr = line.Split(',');

                    Console.WriteLine("{0}. {1}", arr);

                }

                sr.Close();

            }
    }


else if (resp == "2")
{
    Console.WriteLine("What is the name of the movie you wish to add?");
                var newMovie = Console.ReadLine();
                Console.WriteLine("What is the genre");
                var newGenre = Console.ReadLine();
            }




