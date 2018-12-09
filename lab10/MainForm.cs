using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dataGridViewCars.AutoGenerateColumns = false;
            FormClosing += MainForm_FormClosing;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ви точно бажаєте вийти?", "Запитання",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }

        private void ToolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolStripButtonAdd_Click(object sender, EventArgs e)
        {
            LibArtist.Artist artist = new LibArtist.Artist();
            ArtistForm carForm = new ArtistForm(artist);
            if (carForm.ShowDialog() == DialogResult.OK)
            {
                ArtistBindingSource.Add(artist);
            }
        }

        private void ToolStripButtonClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте очистити?", "Запитання",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ArtistBindingSource.Clear();
        }

        private void ToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте видалити запис?", "Запитання",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ArtistBindingSource.RemoveCurrent();
        }

        private void ToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            LibArtist.Artist artist = ArtistBindingSource.List[ArtistBindingSource.Position] as LibArtist.Artist;
            if (artist != null)
            {
                ArtistForm carForm = new ArtistForm(artist);
                if (carForm.ShowDialog() == DialogResult.OK)
                {
                    ArtistBindingSource.List[ArtistBindingSource.Position] = artist;
                }
            }
        }


    }
}
