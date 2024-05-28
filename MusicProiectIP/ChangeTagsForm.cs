/******************************************************************************
 *                                                                            *
 *  Fisier:      ChangeTagsForm.cs                                            *
 *  Autor(i):    Lemny Erich, Popescu Vlad                                    *
 *                                                                            *
 *     Descriere: Fișier ce acompaniază fereastra de modificare a tag-urilor. *
 * Conține funcțiile de callback asociate controalelor din fereastră.         *
 ******************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TagsDLL;

namespace MusicProiectIP
{
    public partial class ChangeTagsForm : Form
    {
        private string _path;
        private Tags _tags;

        public ChangeTagsForm()
        {
            InitializeComponent();
        }

        public ChangeTagsForm(string path)
        {
            InitializeComponent();
            _path = path;
            _tags = new Tags(_path);
            string artists = "";
            string genres = "";
            for (int i = 0; i < _tags.Artists.Length; i++)
                artists += _tags.Artists[i] + ";";
            for (int i = 0; i < _tags.Genres.Length; i++)
                genres += _tags.Genres[i] + ";";

            textBoxAlbum.Text = _tags.Album;
            textBoxArtist.Text = artists;
            textBoxTitle.Text = _tags.Title;
            textBoxYear.Text = _tags.Year.ToString();
            textBoxGenre.Text = genres;
        }
        
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                _tags.Album = textBoxAlbum.Text;
                _tags.Title = textBoxTitle.Text;
                _tags.Year = uint.Parse(textBoxYear.Text);

                _tags.Artists = textBoxArtist.Text.Split(';');
                _tags.Genres = textBoxGenre.Text.Split(';');

                _tags.Save();
                MessageBox.Show("Salvat cu succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
