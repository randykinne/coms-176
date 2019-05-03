using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;

namespace FinalProject
{
    public partial class frmHome : Form
    {
        // Variables for controlling window location
        private bool move;
        private int locX;
        private int locY;

        // Variables for controlling music player
        private bool paused = false;

        // Pausing and unpausing
        private void pause()
        {
            paused = true;
            // Stop the timer
            time.Stop();
            // Pause axWindowsMediaPlayer
            axWMP.Ctlcontrols.pause();
            // Set button texts
            btnAltPause.Text = "PLAY";
            btnPlayPause.Text = "PLAY";
        }

        private void unpause()
        {
            // If there is no song currently playing, play the first song
            if (CurrentPlaylist.currentItem != null)
            {
                paused = false;
                // Start the timer
                time.Start();
                // Play from axWindowsMediaPlayer
                axWMP.Ctlcontrols.play();
                // Set button texts
                btnAltPause.Text = "PAUSE";
                btnPlayPause.Text = "PAUSE";
            }
            else
            {
                // If the playlist has at least 1 song, play the first song
                if (CurrentPlaylist.Items.Count > 0)
                {
                    playSong(CurrentPlaylist.Items[0]);
                }
                else
                {
                    MessageBox.Show("Please add a song to play!");
                }
            }
        }

        // This contains all playlists
        private List<Playlist> playlists;
        //Adding + removing playlists
        public void addPlaylist(Playlist playlist)
        {
            playlists.Add(playlist);
            lstvPlaylists.Items.Add(playlist.Name);
        }
        public void removePlaylist(Playlist playlist)
        {
            lstvPlaylists.Items.RemoveAt(playlists.IndexOf(playlist));
            playlists.Remove(playlist);
        }

        // Controls current playlist based on index
        private int currentPlaylistIndex { get; set; }
        public Playlist CurrentPlaylist => playlists[currentPlaylistIndex];

        // Function for displaying a playlist to the home screen
        private void SetPlaylist(Playlist playlist)
        {
            // Set the index
            currentPlaylistIndex = playlists.IndexOf(playlist);
            // Set the labels to the playlist info
            lblCurrentPlaylist.Text = playlist.Name;
            lblPlaylistInfo.Text = playlist.Items.Count.ToString() + " songs";
            // Clear the songs and add all of the ones from the playlist
            lbxSongs.Items.Clear();
            foreach (PlaylistItem item in playlist.Items)
            {
                lbxSongs.Items.Add(item.Title + " by " + item.Artist);
            }
        }

        // Timer for controlling the bar
        private Timer time;

        // Function for playing a song
        private void playSong(PlaylistItem item)
        {
            // Start everything fresh, so if there's currently a timer, stop it
            if (time != null)
            {
                time.Stop();
            }

            // Switch both buttons to pause
            if (btnAltPause.Text == "PLAY" || btnPlayPause.Text == "PLAY")
            {
                btnAltPause.Text = "PAUSE";
                btnPlayPause.Text = "PAUSE";
            }

            // Set the current playing song
            CurrentPlaylist.currentItem = item;

            // Set the labels to the song info
            lblSongName.Text = item.Title;
            lblSongArtist.Text = item.Artist;

            // Play the song via axWMP
            axWMP.URL = item.URL;
            
            // Set the trackbar to 0
            tbMusic.Value = 0;

            // Set the trackbar maximum to the length of the song, this has to be done later to let axWMP load the song length
            tbMusic.Maximum = item.IntLength;
            // Set the label for the song length
            lblMusicLength.Text = item.Length;

            // Start the new timer at 1000 ms
            time = new Timer
            {
                Interval = 1000 // 1 second
            };

            // Add tick event
            time.Tick += Time_Tick;

            // Start timer
            time.Start();
        }

        // Tick events
        private void Time_Tick(object sender, EventArgs e)
        {
            // Stop time if the song is paused
            if (paused)
            {
                time.Stop();
            }
            else
            {
                // If it's the end of the song, play the next song in the playlist
                if (tbMusic.Value == tbMusic.Maximum)
                {
                    playSong(CurrentPlaylist.Next());
                } else
                {
                    // Otherwise increment trackbar and update labels
                    tbMusic.Value++;
                    lblMusicProgress.Text = axWMP.Ctlcontrols.currentPositionString;
                    lblMusicLength.Text = TimeSpan.FromSeconds(axWMP.currentMedia.duration - axWMP.Ctlcontrols.currentPosition).ToString("mm\\:ss");
                }
            }
        }

        public frmHome()
        {
            InitializeComponent();
        }

        // Home load
        private void frmHome_Load(object sender, EventArgs e)
        {
            // Create new playlist list object
            playlists = new List<Playlist>();

            // Search startup path for .m3u files
            string[] fileArray = Directory.GetFiles(Application.StartupPath, "*.m3u");
            foreach (string file in fileArray)
            {
                // Create new playlist object for each
                Playlist playlist = new Playlist(file);
                try
                {
                    // Read the file
                    StreamReader reader = File.OpenText(file);
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Each line that starts with #EXTINF is a song on the playlist
                        if (line.StartsWith("#EXTINF"))
                        {
                            // Get the next line and replace to get accurate path for WMP
                            line = Path.GetFullPath(reader.ReadLine()).Replace("%20", " ");
                            // Add song to playlist
                            playlist.Add(new PlaylistItem(axWMP, line));
                        }
                    }

                    // Add the playlist
                    addPlaylist(playlist);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

            // After all playlists are loaded, set the home to the first playlist
            // This will cause an error if there are no playlists
            SetPlaylist(playlists[0]);
        }

        /*
         *  THESE CONTROL THE CUSTOM MENU BAR
         * */
        private void pnlBar_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            locX = e.X;
            locY = e.Y;
        }

        private void pnlBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - locX, MousePosition.Y - locY);
            }
        }

        private void pnlBar_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        // THESE CONTROL CUSTOM BUTTON HIGHLIGHTING EFFECTS

        private void lblExitButton_MouseHover(object sender, EventArgs e)
        {
            lblExitButton.BackColor = Color.Firebrick;
        }

        private void lblExitButton_MouseLeave(object sender, EventArgs e)
        {
            lblExitButton.BackColor = Color.Transparent;
        }

        // CLOSE BUTTON
        private void lblExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblNewPlaylist_MouseHover(object sender, EventArgs e)
        {
            lblNewPlaylist.ForeColor = Color.White;
        }

        private void lblNewPlaylist_MouseLeave(object sender, EventArgs e)
        {
            lblNewPlaylist.ForeColor = Color.Silver;
        }

        private void lblNewPlaylist_Click(object sender, EventArgs e)
        {
            new frmNewPlaylist(this, axWMP).Show();
        }

        private void lstvPlaylists_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            foreach (ListViewItem item in lstvPlaylists.Items)
            {
                item.ForeColor = Color.Silver;
            }
            e.Item.ForeColor = Color.White;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (paused)
            {
                unpause();
            }
            else
            {
                pause();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            playSong(CurrentPlaylist.Next());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            playSong(CurrentPlaylist.Previous());
        }

        private void btnAltPause_Click(object sender, EventArgs e)
        {
            if (btnAltPause.Text == "PAUSE")
            {
                axWMP.Ctlcontrols.pause();
                btnAltPause.Text = "PLAY";
                pause();
            } else
            {
                axWMP.Ctlcontrols.play();
                btnAltPause.Text = "PAUSE";
                unpause();
            }
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            axWMP.settings.volume = tbVolume.Value*10; // axWMP volume setting expressed on scale of 1-100, so we'll go by 10 instead and then multiply
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            string[] doc, path;
            OpenFileDialog dialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Mp3 Files|*.mp3|Avi Filse|*.avi|Wav Files|*.wav"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                doc = dialog.SafeFileNames;
                path = dialog.FileNames;
                for (int i=0; i<doc.Length; i++)
                {
                    PlaylistItem item = new PlaylistItem(axWMP, path[i]);
                    CurrentPlaylist.Add(item);
                    lbxSongs.Items.Add(item.Title + " by " + item.Artist);
                }
            }
        }

        private void lbxSongs_SelectedIndexChanged(object sender, EventArgs e)
        { 
            CurrentPlaylist.currentItem = CurrentPlaylist.Items[lbxSongs.SelectedIndex];
            playSong(CurrentPlaylist.currentItem);
        }

        private void tbMusic_Scroll(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.currentPosition = double.Parse(tbMusic.Value.ToString());
        }

        private void lstvPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvPlaylists.SelectedIndices.Count < 1)
            {
                return;
            }
            else
            {
                SetPlaylist(playlists[lstvPlaylists.SelectedIndices[0]]);
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            CurrentPlaylist.Shuffle();
            lbxSongs.Items.Clear();
            foreach (PlaylistItem song in CurrentPlaylist.Items)
            {
                lbxSongs.Items.Add(song.Title + " by " + song.Artist);
            }
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
                if (btnPlayPause.Text == "PAUSE")
                {
                    axWMP.Ctlcontrols.pause();
                    btnPlayPause.Text = "PLAY";
                    pause();
                }
                else
                {
                    axWMP.Ctlcontrols.play();
                    btnPlayPause.Text = "PAUSE";
                    unpause();
                }
        }

        private void btnEditPlaylist_Click(object sender, EventArgs e)
        {
            new frmEditPlaylist(this, CurrentPlaylist).Show();
        }
    }
}
