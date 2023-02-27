using NLog;
string path = Directory.GetCurrentDirectory() + "\\nlog.config";
// create instance of Logger
var logger = LogManager.LoadConfiguration(path).GetCurrentClassLogger();

List<string[]> movies = new List<string[]>();

 if (File.Exists("movies.csv"))
    {
        StreamReader sr = new StreamReader("movies.csv");
        int i = 1;                
        while (!sr.EndOfStream)
        {    
            string line = sr.ReadLine();
            string movieString = line.Substring(line.IndexOf(",") + 1);
            string[] movie = movieString.Split(",");
            movies.Add(movie);
        }
        sr.Close();
    }

string resp = "";
while(resp != "3"){
    Console.WriteLine("Welcome to Blockbuster Video Database!");
    Console.WriteLine("What would you like to do today?");
    Console.WriteLine("1.List all movies");
    Console.WriteLine("2.Add Movies");
    Console.WriteLine("3.Exit program");
    resp = Console.ReadLine();
    if (resp == "1")
    {  
        int i = 1;
        foreach(string[] movie in movies)
        {
            Console.WriteLine("{0}. {1} {2}", i, movie[0], movie[1]);
            i++;
        }
    }
    else if (resp == "2")
    {   
        string[] newEntry = new string[2];
        Console.WriteLine("What is the name of the movie you wish to add?");
        var newMovie = Console.ReadLine();
        newEntry[0] = newMovie;
        Console.WriteLine("What is the genre?");
        var newGenre = Console.ReadLine();
        newEntry[1] = newGenre;
        Boolean found = false;
        foreach(string[] movie in movies){
            if(movie[0].Equals(newEntry[0]) && movie[1].Equals(newEntry[1])){
                Console.WriteLine("Movie already exists");
                found = true;
                break;
            }
        }
        if(!found){
            movies.Add(newEntry);
            Console.WriteLine("Movie Added");
        }

    }
}




