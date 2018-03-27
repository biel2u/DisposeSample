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

            player.GetPath(path);
            player.Play();

            Console.WriteLine("Type 1 to PLAY, 2 to PAUSE, 3 to DISPOSE, 4 to EXIT");
            var playerOption = Console.ReadLine();
            do
            {
                if (playerOption == "1")
                {
                    player.Play();
                }
                else if (playerOption == "2")
                {
                    player.Pause();
                }
                else if (playerOption == "3")
                {
                    player.Dispose();
                }
                else
                {
                    Console.WriteLine("Option not recognized.");
                }
                playerOption = Console.ReadLine();
            } while (playerOption != "4");

            Console.ReadKey();
        }
    }
}
