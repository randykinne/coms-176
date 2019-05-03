using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public class Playlist
    {
        private Random random;
        public Playlist(string name, string url)
        {
            this.Name = name.Replace(".m3u", "");
            this.URL = url;
            random = new Random();
        }

        public Playlist(string url)
        {
            this.URL = url;
            this.Name = url.Replace(Application.StartupPath, "").Replace("\\", "").Replace(".m3u", "");
            random = new Random();
        }

        public List<PlaylistItem> Items = new List<PlaylistItem>();
        
        public void Add(PlaylistItem item)
        {
            Items.Add(item);
        }

        public void RemoveAt(int index)
        {
            Items.RemoveAt(index);
        }

        public void Shuffle()
        { 
            int n = Items.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                PlaylistItem value = Items[k];
                Items[k] = Items[n];
                Items[n] = value;
            }
        }

        public PlaylistItem currentItem { get; set; }

        public PlaylistItem Next()
        {
            PlaylistItem newSong;
            try
            {
                newSong = Items[Items.IndexOf(currentItem) + 1];
            }
            catch (ArgumentOutOfRangeException)
            {
                newSong = Items[0];
            }
            return newSong;
        }
        public PlaylistItem Previous()
        {
            PlaylistItem newSong;
            try
            {
                newSong = Items[Items.IndexOf(currentItem) - 1];
            } catch (ArgumentOutOfRangeException)
            {
                newSong = Items[Items.Count - 1];
            }
            return newSong;
        }
        public string Name { get; set; }

        public string URL { get; set; }
    }
}
