using System;
using NAudio.Wave;

namespace MusicPlayer
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine(@"Please specify mp3 file location (e.g C:\\Users\UserName\Desktop\Music.mp3)...");
            var path = Console.ReadLine();

            var player = new WaveOutEvent();
            var audioFile = new AudioFileReader(path);
            player.Init(audioFile);
            player.Play();

            Console.WriteLine("Click any button to dispose and stop music");
            Console.ReadKey();

            player.Dispose();
            audioFile.Dispose();

            Console.WriteLine("Silence...");
            Console.ReadKey();
        }
    }
}
