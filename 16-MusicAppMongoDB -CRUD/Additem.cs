using System;
using System.Windows.Forms;

namespace MusicAppMongoDB
{
    public partial class Additem : Form
    {
        private readonly Form1 mainForm;
        private Album album;

        public Additem(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        public Additem(Form1 mainForm, Album album) : this(mainForm)
        {
            this.album = album;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AlbumDB database = new AlbumDB();

            var newAlbum = new Album()
            {
                AlbumName = TxtTitle.Text,
                ArtistName = TxtArtist.Text,
                Year = TxtYear.Text,
                ImageURL = TxtUrl.Text,
                VideoPath = TxtVideo.Text
                //UpdatedAt = DateTimeOffset.Now
            };

            if (album != null)
            {
                newAlbum.Id = album.Id;
            }

            database.SaveAlbum(newAlbum);
            MessageBox.Show("New album saved");
            this.Hide();
            mainForm.UpdateAlbumList();
            mainForm.Show();
        }

        private void Additem_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void Additem_Shown(object sender, EventArgs e)
        {
            if (album == null)
            {
                return;
            }

            TxtTitle.Text = album.AlbumName;
            TxtArtist.Text = album.ArtistName;
            TxtYear.Text = album.Year;
            TxtUrl.Text = album.ImageURL;
            TxtVideo.Text = album.VideoPath;
        }
    }
}
