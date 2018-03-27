using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace MusicPlayer
{
    internal class Player : IDisposable
    {
        private readonly WaveOutEvent _waveOutEvent;
        private AudioFileReader _audioFileReader;
        private bool _disposed;

        public Player()
        {
            _waveOutEvent = new WaveOutEvent();
        }

        public void GetPath(string path)
        {                       
            _audioFileReader = new AudioFileReader(path);
            _waveOutEvent.Init(_audioFileReader);
        }

        public void Play()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException("Player");
            }
            _waveOutEvent.Play();
        }

        public void Pause()
        {
            _waveOutEvent.Stop();
        }

        public void Dispose()
        {
            _audioFileReader.Dispose();
            _waveOutEvent.Dispose();
            _disposed = true;
        }
    }
}
