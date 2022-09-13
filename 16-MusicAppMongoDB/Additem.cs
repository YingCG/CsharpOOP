using System;
using System.Windows.Forms;

namespace MusicAppMongoDB
{
    public partial class Additem : Form
    {
        public Additem()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AlbumDB database = new AlbumDB();

            var album = new Album()
            {
                AlbumName = TxtTitle.Text,
                ArtistName = TxtArtist.Text,
                Year = TxtYear.Text,
                ImageURL = TxtUrl.Text
                //UpdatedAt = DateTimeOffset.Now
            };

            database.SaveAlbum(album);
            Form1 homepage = new Form1();
            homepage.ShowDialog();
        }
    }
}
