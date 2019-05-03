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

namespace FinalProject
{
    public partial class frmEditPlaylist : Form
    {
        frmHome home;
        Playlist playlist;

        public frmEditPlaylist(frmHome home, Playlist playlist)
        {
            InitializeComponent();
            this.home = home;
            this.playlist = playlist;
            CenterToParent();
        }

        private void frmEditPlaylist_Load(object sender, EventArgs e)
        {
            foreach (PlaylistItem songs in playlist.Items)
            {
                lbxEditPlaylist.Items.Add(songs.Title + " by " + songs.Artist);
            }
            lblEditPlaylistName.Text = playlist.Name;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (lbxEditPlaylist.SelectedIndices.Count != 1)
            {
                MessageBox.Show("Please select a single song to move up!");
            } else
            {
                if (lbxEditPlaylist.SelectedIndex == lbxEditPlaylist.Items.Count - 1)
                {
                    MessageBox.Show("Item is already at the top!");
                    return;
                }
                lbxEditPlaylist.Items.Insert(lbxEditPlaylist.SelectedIndex - 1, lbxEditPlaylist.Items[lbxEditPlaylist.SelectedIndex]);
                lbxEditPlaylist.Items.RemoveAt(lbxEditPlaylist.SelectedIndex);
            }
        }

        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            if (lbxEditPlaylist.SelectedIndices.Count != 1)
            {
                MessageBox.Show("Please select a song to remove!");
                return;
            } 

            lbxEditPlaylist.Items.RemoveAt(lbxEditPlaylist.SelectedIndex);
            playlist.RemoveAt(lbxEditPlaylist.SelectedIndex);
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (lbxEditPlaylist.SelectedIndices.Count != 1)
            {
                MessageBox.Show("Please select a single song to move down!");
            } else
            {
                if (lbxEditPlaylist.SelectedIndex == lbxEditPlaylist.Items.Count-1)
                {
                    MessageBox.Show("Item is already at the bottom!");
                    return;
                }
                lbxEditPlaylist.Items.Insert(lbxEditPlaylist.SelectedIndex + 1, lbxEditPlaylist.Items[lbxEditPlaylist.SelectedIndex]);
                lbxEditPlaylist.Items.RemoveAt(lbxEditPlaylist.SelectedIndex);
            }
        }

        private void btnDeletePlaylist_Click(object sender, EventArgs e)
        {
            if (btnDeletePlaylist.Text == "DELETE PLAYLIST")
            {
                btnDeletePlaylist.Text = "ARE YOU SURE? CLICK AGAIN TO CONFIRM.";
                btnDeletePlaylist.BackColor = Color.Red;
            } else
            {
                home.removePlaylist(playlist);
                try
                {
                    File.Delete(playlist.URL);
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = { "#EXTM3U"
            };

                File.WriteAllLines(Application.StartupPath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }
    }
}
