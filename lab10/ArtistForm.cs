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
    public partial class ArtistForm : Form
    {
        LibArtist.Artist artist;
        public ArtistForm(LibArtist.Artist artist)
        {
            InitializeComponent();
            this.artist = artist;
            comboBoxGenre.DataSource = Enum.GetValues(typeof(LibArtist.Artist.ChooseGenre));
            comboBoxCountry.DataSource = Enum.GetValues(typeof(LibArtist.Artist.Countries));
            ArtistBindingSource.DataSource = artist;
            ArtistBindingSource.BindingComplete += CarBindingSource_BindingComplete;
        }

        private void CarBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteState != BindingCompleteState.Success)
            {
                MessageBox.Show(e.ErrorText);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(artist.Artname) && !string.IsNullOrEmpty(artist.Surname))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Fields are empty");
            }
        }
  
    }
}
