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

namespace VideoPlayer
{
    public partial class Form1 : Form
    {
        List<string> filteredFiles = new List<string>();
        FolderBrowserDialog browser = new FolderBrowserDialog();
        int currentFile = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadFolderEvent(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.stop();

            if(filteredFiles.Count > 1)
            {
                filteredFiles.Clear();
                filteredFiles = null;
                Playlist.Items.Clear();

                currentFile = 0;
            }

            DialogResult result = browser.ShowDialog();
            if (result == DialogResult.OK)
            {
                filteredFiles = Directory.GetFiles(browser.SelectedPath, "*.*").Where(file => file.ToLower().EndsWith("webm") || file.ToLower().EndsWith("mp4") || file.ToLower().EndsWith("wmv") || file.ToLower().EndsWith("mkv") || file.ToLower().EndsWith("avi")).ToList();
                LoadPlaylist();
            }
        }

        private void ShowAboutEvent(object sender, EventArgs e)
        {
            MessageBox.Show("This app is made when I am exploring the tools in window form." + Environment.NewLine + " Hope you enjoyed the simple media player ");
        }

        private void MediaPlayerStateChangeEvent(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if(e.newState == 0)
            {
                // undefined load
                label2.Text = "Media Player is Ready to be loaded";
            }
            else if (e.newState == 1)
            {
                // if the file is stopped
                label2.Text = "Media Player stopped";
            }
            else if (e.newState == 3)
            {
                // if the file is playing
                label2.Text = "Duration: " + MediaPlayer.currentMedia.durationString;
            }
            else if (e.newState == 8)
            {
                // media has ended here
                if(currentFile >= filteredFiles.Count - 1)
                {
                    currentFile = 0;
                } else
                {
                    currentFile += 1;
                }
                Playlist.SelectedIndex = currentFile;
                ShowFileName(label1);
            } else if (e.newState == 9)
            {
                // if the media player is loading new video
                label2.Text = "Loading new video";
            }
            else if (e.newState == 10)
            {
                // media is ready to play again
                timer1.Start();
            }
        }

        private void PlaylistChanged(object sender, EventArgs e)
        {
            currentFile = Playlist.SelectedIndex;
            PlayFile(Playlist.SelectedItem.ToString());
            ShowFileName(label1);
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.play();
            timer1.Stop();
        }

        private void LoadPlaylist()
        {
            MediaPlayer.currentPlaylist = MediaPlayer.newPlaylist("Playliest", "");

            foreach(string videos in filteredFiles)
            {
                MediaPlayer.currentPlaylist.appendItem(MediaPlayer.newMedia(videos));
                Playlist.Items.Add(videos);
            }

            if(filteredFiles.Count > 0)
            {
                label1.Text = "Files Found" + filteredFiles.Count;
                Playlist.SelectedIndex = currentFile;
                PlayFile(Playlist.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("No Video Files Found in this folder");
            }
        }

        private void PlayFile(string url)
        {
            MediaPlayer.URL = url;
        }

        private void ShowFileName(Label name)
        {
            string file = Path.GetFileName(Playlist.SelectedItem.ToString());
            name.Text = "Currently Playing: " + file;
        }
    }
}
