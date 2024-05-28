/******************************************************************************
 *                                                                            *
 *  Fisier:      Tags.cs                                                      *
 *  Autor(i):    Lemny Erich, Popescu Vlad                                    *
 *                                                                            *
 *     Descriere: Fișier ce descrie clasa Tags ce încapsulează informațiile   *
 * despre unele tag-uri ID3v2 a unui fișier MP3. Permite atât citirea cât și  *
 * modificarea acestor tag-uri.                                               *
 ******************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagsDLL
{
    /// <summary>
    /// Clasă pentru citirea și modificarea tag-urilor unui cântec .mp3
    /// </summary>
    public class Tags
    {
        private string _path;
        private TagLib.File _tfile;

        /// <summary>
        /// Constructorul clasei Tags
        /// </summary>
        /// <param name="path">Calea spre cântecul tag-urile căruia se dorește de accesat</param>
        public Tags(string path)
        {
            _path = path;
            _tfile = TagLib.File.Create(_path);
        }

        /// <summary>
        /// Proprietate ce returnează sau setează titlul cântecului
        /// </summary>
        public string Title
        {
            get
            {
                return _tfile.Tag.Title;
            }
            set
            {
                _tfile.Tag.Title = value;
            }
        }

        /// <summary>
        /// Proprietate ce returnează sau setează albumul cântecului
        /// </summary>
        public string Album
        {
            get
            {
                return _tfile.Tag.Album;
            }
            set
            {
                _tfile.Tag.Album = value;
            }
        }

        /// <summary>
        /// Proprietate ce returnează sau setează anul cântecului
        /// </summary>
        public uint Year
        {
            get
            {
                return _tfile.Tag.Year;
            }
            set
            {
                _tfile.Tag.Year = value;
            }
        }

        /// <summary>
        /// Proprietate ce returnează sau setează artiștii cântecului (sub formă de string[])
        /// </summary>
        public string[] Artists
        {
            get
            {
                return _tfile.Tag.Performers;
            }
            set
            {
                _tfile.Tag.Performers = value;
            }
        }

        /// <summary>
        /// Proprietate ce returnează sau setează genurile cântecului (sub formă de string[])
        /// </summary>
        public string[] Genres
        {
            get
            {
                return _tfile.Tag.Genres;
            }
            set
            {
                _tfile.Tag.Genres = value;
            }
        }

        /// <summary>
        /// Metodă ce realizează salvarea efectivă a tuturor modificărilor a tag-urilor
        /// </summary>
        public void Save()
        {
            if (_tfile != null)
            {
                _tfile.Save();
            }
        }
    }
}
