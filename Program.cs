using NLog;

// See https://aka.ms/new-console-template for more information
string path = Directory.GetCurrentDirectory() + "\\nlog.config";

// create instance of Logger
var logger = LogManager.LoadConfiguration(path).GetCurrentClassLogger();

// log sample messages
logger.Trace("Sample trace message");
logger.Debug("Sample debug message");
logger.Info("Sample informational message");
logger.Warn("Sample warning message");
logger.Error("Sample error message");
logger.Fatal("Sample fatal error message\n");

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

            Console.WriteLine("{0}, {1}", arr);
            

            

        }

        sr.Close();
    }
}
