using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxWMPLib;

namespace FinalProject
{
    public class PlaylistItem
    {
        public PlaylistItem(AxWindowsMediaPlayer player, string url)
        {
            this.URL = url;
            var clip = player.newMedia(url);
            this.Title = clip.getItemInfo("Title");
            this.Artist = clip.getItemInfo("Artist");
            this.Length = clip.durationString;
            this.IntLength = int.Parse(clip.duration.ToString());
        }

        public string Title { get; set; }
        public string Artist { get; set; }
        public string URL { get; set; }
        public string Length { get; private set; }
        public int IntLength { get; private set; }
    }
}
