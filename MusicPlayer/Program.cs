using System;
using NAudio.Wave;

namespace MusicPlayer
{
    internal class Program
    {
        private static void Main()
        {
            var player = new Player();

            Console.WriteLine(@"Please specify mp3 file location (e.g C:\\Users\UserName\Desktop\Music.mp3)...");
            var path = Console.ReadLine();

            player.GetFilePath(path);
            player.Play();

            Console.WriteLine("Type 1 to PLAY, 2 to PAUSE, 3 to DISPOSE, 4 to EXIT");
            var playerOption = Console.ReadLine();
            do
            {             
                switch (playerOption)
                {
                    case "1":
                        player.Play();
                        break;
                    case "2":
                        player.Pause();
                        break;
                    case "3":
                        player.Dispose();
                        break;
                    default:
                        Console.WriteLine("Option not recognized.");
                        break;
                }
                playerOption = Console.ReadLine();
            } while (playerOption != "4");

            Console.ReadKey();
        }
    }
}
