using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicAppMongoDB
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumDB albumsFromDB = new AlbumDB();
            //Album artist1 = new Album
            //{
            //    AlbumName = "Album for coding",
            //    ArtistName = "Some artist",
            //    Year = 2022,
            //    ImageURL = "nothing yet"
            //};
            //Album artist2 = new Album
            //{
            //    AlbumName = "Album for relaxing",
            //    ArtistName = "Another artist",
            //    Year = 2000,
            //    ImageURL = "nothing yettt"
            //};

            //albumDAO.albums.Add(artist1);
            //albumDAO.albums.Add(artist2);

            // associate the list with the control (on top of form1)
            albumBindingSource.DataSource = albumsFromDB.GetAlbums();

            // connect the list to grid view
            dataGridView1.DataSource = albumBindingSource;

        }

        private void btnToAdd_Click(object sender, EventArgs e)
        {
            Hide();
            Additem addAlbum = new Additem();
            addAlbum.ShowDialog();
        }
    }
}
