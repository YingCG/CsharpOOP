using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicAppMongoDB
{
    public partial class Form1 : Form
    {
        AlbumDB albumsFromDB = new AlbumDB();

        BindingSource albumBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            UpdateAlbumList();
        }

        public void UpdateAlbumList()
        {
            // associate the list with the control (on top of form1)
            // connect the list to grid view
            albumBindingSource.DataSource = albumsFromDB.GetAlbums();
            dataGridView1.DataSource = albumBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateAlbumList();
            // associate the list with the control (on top of form1)
            // albumBindingSource.DataSource = albumsFromDB.GetAlbums();

            // connect the list to grid view
            //dataGridView1.DataSource = albumBindingSource;

            // load picture from the row
            //pictureBox1.Load("")

        }

        private void btnToAdd_Click(object sender, EventArgs e)
        {
            Hide();
            Additem addAlbum = new Additem(this);
            addAlbum.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int rowClick = dataGridView1.CurrentRow.Index;
            string VideoUrl = dataGridView1.Rows[rowClick].Cells[5].Value?.ToString();
            if (!string.IsNullOrWhiteSpace(VideoUrl))
            {
                Process.Start(new ProcessStartInfo(VideoUrl)
                {
                    UseShellExecute = true
                });
            }

            //vlcControl1.Play(VideoUrl);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //vlcControl1.Stop();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView dataGridView = (DataGridView)sender;

            // get the row number clicked
            int rowClicked = dataGridView.CurrentRow.Index;
            String ImageURL = dataGridView.Rows[rowClicked].Cells[4].Value?.ToString();
            if (!string.IsNullOrWhiteSpace(ImageURL))
            {
                //MessageBox.Show("Clicked" + rowClicked + "ImageURL=" + imageURL);
                try
                {
                    pictureBox1.Load(ImageURL);
                }
                catch
                {
                    Console.WriteLine("Error, no image");
                }
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            Hide();

            int rowClicked = dataGridView1.CurrentRow.Index;
            object id = dataGridView1.Rows[rowClicked].Cells[0].Value;
            Album album = albumsFromDB.GetById(id);
            Additem addAlbum = new Additem(this, album);
            addAlbum.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView1.CurrentRow.Index;
            object id = dataGridView1.Rows[rowClicked].Cells[0].Value;
            albumsFromDB.DeleteById(id);
            UpdateAlbumList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
