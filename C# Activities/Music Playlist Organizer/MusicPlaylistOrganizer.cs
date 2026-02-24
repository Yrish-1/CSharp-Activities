using System;

namespace SongClass
{
    class Program
    {
        static void Main(String[] args)
        {
            double totalDuration = 0;

            Console.Write("Songs to add: ");
            int arrayLength = int.Parse(Console.ReadLine());

            Song[] songs = new Song[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"\nSong #{i + 1}");
                Console.Write("\nTitle: ");
                String songTitle = Console.ReadLine();
                Console.Write("Artist: ");
                String songArtist = Console.ReadLine();
                Console.Write("Duration (minutes): ");
                double songDuration = double.Parse(Console.ReadLine());

                totalDuration += songDuration;

                songs[i] = new Song
                {
                    title = songTitle,
                    artist = songArtist,
                    duration = songDuration
                };
            }

            double averageDuration = totalDuration / arrayLength;

            Console.WriteLine("\n== || MY PLAYLIST || ==");
            Console.WriteLine("Title\tArtist\tTime");
            Console.WriteLine("--------------------------------------------");
            for (int i = 0; i < arrayLength; i++)
            {
                songs[i].DisplaySong();
            }

            Console.WriteLine("\nTotal Duration: {0:F2} mins", totalDuration);
            Console.WriteLine("Average Duration: {0:F2} mins", averageDuration);
        }

        public class Song
        {
            public String title;
            public String artist;
            public double duration;
            public Song() : this("Unknown", "Unknown")
            {
            }

            public Song(String title, String artist) : this(title, artist, 0)
            {
            }

            public Song(String title, String artist, double duration)
            {
                this.title = title;
                this.artist = artist;
                this.duration = duration;
            }

            public void DisplaySong()
            {
                Console.WriteLine($"{title.PadRight(20)}{artist.PadRight(20)}{duration}");
            }
        }
    }
}