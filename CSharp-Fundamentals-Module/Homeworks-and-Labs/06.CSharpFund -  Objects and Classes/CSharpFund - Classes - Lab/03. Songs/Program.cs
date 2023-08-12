using System.Dynamic;

namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine()); // read from the console number Of The Songs

            List<Song> songs = new List<Song>(); // create new List which is from our created Data Type<Song>
            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] randomData = Console
                    .ReadLine() // read data from the console
                    .Split("_", StringSplitOptions.RemoveEmptyEntries); // split the data to elements and list them to an array

                string typeList = randomData[0]; // type list equals first element[0]
                string nameOfSong = randomData[1]; // name of song equals second element[1]
                string timeOfSong = randomData[2]; // duration of song equals third element[2]

                Song song = new Song(typeList, nameOfSong, timeOfSong); // create new object[instance] from our dataType which we can describe our object with the current properties
                
                songs.Add(song); // add the finished object to the collection of songs
            }

            Song.PrintResult(songs); // invoke method which will print out final result and the name of our songs
        }
    }

    public class Song // define class
    {
        public Song(string typeList, string nameOfSong, string timeOfSong) // define a constructor
        {
            TypeList = typeList; // list variable typeList to prop TypeList
            Name = nameOfSong; // list variable nameOfSong to prop Name
            Time = timeOfSong; // list variable timeOfSong to prop Time
        }
        public string TypeList { get; set; } // property from string type 

        public string Name { get; set; } // property from string type

        public string Time { get; set; } // property from string type

        public static void PrintResult(List<Song> songs) // define a method which Prints The Final Result
        {
            string printTypeList = Console.ReadLine(); // read from the console what type is the list

            if (printTypeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name); // print all song names
                }

                return;
            }

            List<Song> filteredSongs = songs // create List for songs which are equal to the readed type list
                .Where(s => s.TypeList == printTypeList) /*define method which finds where we have equal typeLists and list the song*/
                .ToList(); // make the variable a collection

            foreach (Song song in filteredSongs)
            {
                Console.WriteLine(song.Name); // print song names with equal type list
            }
        }
    }
}