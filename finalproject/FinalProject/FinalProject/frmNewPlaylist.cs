using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AxWMPLib;

namespace FinalProject
{
    public partial class frmNewPlaylist : Form
    {
        frmHome home;
        AxWindowsMediaPlayer player;

        public frmNewPlaylist(frmHome home, AxWindowsMediaPlayer player)
        {
            InitializeComponent();
            this.home = home;
            this.player = player;
            CenterToParent();
        }

        private void btnAddExistingPlaylist_Click(object sender, EventArgs e)
        {
            string[] doc, path;
            OpenFileDialog dialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "M3u Files|*.m3u",
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                doc = dialog.SafeFileNames;
                path = dialog.FileNames;
                for (int i = 0; i < doc.Length; i++)
                {
                    Playlist playlist = new Playlist(doc[i], path[i]);
                    try
                    {
                        StreamReader file = File.OpenText(path[i]);
                        string line;
                        while ((line = file.ReadLine()) != null)
                        {
                            // Each line that starts with #EXTINF is a song on the playlist
                            if (line.StartsWith("#EXTINF"))
                            {
                                playlist.Add(new PlaylistItem(player, line = file.ReadLine()));
                            }
                        }
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    home.addPlaylist(playlist);
                    Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewPlaylist_Click(object sender, EventArgs e)
        {
            if (btnNewPlaylist.Text == "CONFIRM NEW PLAYLIST")
            {
                // Confirm new playlist by name
                home.addPlaylist(new Playlist(tbNewPlaylist.Text, ""));
                try
                {
                    string[] lines = { "#EXTM3U" };
                    File.WriteAllLines(Application.StartupPath, lines);
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Close();
            }
            else
            {
                btnAddExistingPlaylist.Hide();
                lblPlaylistName.Show();
                tbNewPlaylist.Show();
            }
        }

        private void tbNewPlaylist_TextChanged(object sender, EventArgs e)
        {
            if (tbNewPlaylist.Text.Length > 0)
            {
                btnNewPlaylist.Text = "CONFIRM NEW PLAYLIST";
                btnNewPlaylist.BackColor = Color.FromArgb(128, 255, 128);
            } else
            {
                btnNewPlaylist.Text = "NEW PLAYLIST";
                btnNewPlaylist.BackColor = Color.FromArgb(128, 255, 255);
                btnAddExistingPlaylist.Show();
                lblPlaylistName.Hide();
                tbNewPlaylist.Hide();
            }
        }

        private void frmNewPlaylist_Load(object sender, EventArgs e)
        {

        }
    }
}
