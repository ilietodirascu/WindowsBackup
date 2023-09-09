using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer videoPlayer = new();
            IMedia media = new Adapter(videoPlayer);
            media.Play();
        }
        public interface IMedia
        {
            public void Play();
        }

        public class Adapter : IMedia
        {
            private readonly Player _player;
            public Adapter(Player player)
            {
                _player = player;
            }
            public void Play()
            {
                _player.Play();
            }
        }
        public class VideoPlayer : Player
        {
            public override void Play()
            {
                Console.WriteLine("I am playing a video");
            }
        }
        public class AudioPlayer : Player
        {
            public override void Play()
            {
                Console.WriteLine("I am playing a song");
            }
        }
        public abstract class Player
        {
            public abstract void Play();
        }
    }
}
