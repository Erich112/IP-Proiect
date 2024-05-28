/******************************************************************************
 *                                                                            *
 *  Fisier:      Form1.cs                                                     *
 *  Autor(i):    Lemny Erich, Popescu Vlad                                    *
 *                                                                            *
 *     Descriere: Fișier ce acompaniază interfața grafică. Conține funcțiile  *
 *  de callback asociate controalelor din interfață, precum butoanelor Play,  *
 *  Pause, Stop, Select Song etc.                                             * 
 ******************************************************************************/

using CSCore.SoundOut;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PlayerDLL;
using PlaylistDLL;

namespace MusicProiectIP
{
    public partial class Form1 : Form
    {
        Player _player;
        bool _stopSliderUpdate = false;

        public Form1()
        {
            InitializeComponent();
            _player = new Player(listBoxPlaylist, timerPosition, textBoxCurrentSongState);
            labelPosition.Text = "00:00 / 00:00";
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (listBoxPlaylist.Items.Count == 0)
                MessageBox.Show("No songs to play!");
            else
            {
                if (_player.CurrentSongIndex != listBoxPlaylist.SelectedIndex)
                {
                    _player.Stop();
                    _player.SelectSong(listBoxPlaylist.SelectedIndex);
                }

                _player.Play();
                timerPosition.Enabled = true;
                textBoxCurrentSongState.Text = "Playing > " + listBoxPlaylist.SelectedItem.ToString();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerPosition.Enabled = false;
            _player.Stop();
            trackBarPosition.Value = 0;
            labelPosition.Text = "00:00 / 00:00";

            textBoxCurrentSongState.Text = "";
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            _player.Pause();
            if (listBoxPlaylist.Items.Count != 0)
                textBoxCurrentSongState.Text = "Paused | " + listBoxPlaylist.SelectedItem.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _player.Stop();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            string songLocation = dialog.FileName;
            string[] temp = songLocation.Split("\\".ToCharArray());
            string songName = temp[temp.Length-1];

            listBoxPlaylist.Items.Add(songName);
            listBoxPlaylist.SelectedIndex = 0;

            Song newSong = new Song(songLocation);
            newSong.Player = _player;

            _player.AddSong(newSong);
            _player.SelectSong(0);
            _player.State = new HasSongsState(_player);

            //s = new Song(songLocation);
           // _p.AddSong(newSong);
            
           // var f = TagLib.File.Create(songLocation);
           // string allPerformers = "";
           // string allGenres = "";
           // //string[] a = { "1", "2" };
           // //f.Tag.Genres = a;
           // for (int i = 0; i < f.Tag.Performers.Length; i++)
           //     allPerformers += f.Tag.Performers[i];
           // for (int i = 0; i < f.Tag.Genres.Length; i++)
           //     allGenres += f.Tag.Genres[i];
           ////string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

           // Console.WriteLine(f.Tag.Title + "  " + f.Tag.Year + "   " + f.Tag.Album + "   " + allPerformers + "  " + allGenres);
        }

        private void buttonEditTags_Click(object sender, EventArgs e)
        {
            // ar trebui aici un try-catch sau cv in caz de cineva apasa pe butonul de edit 
            // daca nu e nicio melodie pusa sa apara un pop-up "nu ai nicio melodie"
            //ChangeTagsForm formTags = new ChangeTagsForm(_p.GetCurrentSong());
            //formTags.Show();
            if (_player.IsEmpty())
                MessageBox.Show("No songs added!");
            else
            {
                ChangeTagsForm formTags = new ChangeTagsForm(_player.CurrentSong.Path);
                formTags.Show();
            }
        }

        private void buttonNewPlaylist_Click(object sender, EventArgs e)
        {
            _player.DeleteSongs();
            _player.State = new NoSongsState(_player);
            listBoxPlaylist.Items.Clear();
            labelPosition.Text = "00:00 / 00:00";
            timerPosition.Enabled = false;

            textBoxCurrentSongState.Text = "";
        }

        private void listBoxPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //_player.SelectSong(listBoxPlaylist.SelectedIndex);
            if (_player.CurrentState != Player.States.NoSongs)
                _player.SelectSong(listBoxPlaylist.SelectedIndex);
            //Console.WriteLine(listBoxPlaylist.SelectedIndex);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (_player.CurrentState == Player.States.NoSongs)
                return;

            timerPosition.Enabled = false;
            _player.Stop();
            _player.NextSong();
            _player.Play();
            timerPosition.Enabled = true;

            textBoxCurrentSongState.Text = "Playing > " + listBoxPlaylist.SelectedItem.ToString();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (_player.CurrentState == Player.States.NoSongs)
                return;

            timerPosition.Enabled = false;
            _player.Stop();
            _player.NextSong();
            _player.Play();
            timerPosition.Enabled = true;

            textBoxCurrentSongState.Text = "Playing > " + listBoxPlaylist.SelectedItem.ToString();
        }

        private void checkBoxRepeat_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxRepeat.CheckState == CheckState.Checked)
                _player.RepeatSong = true;
            else
                _player.RepeatSong = false;
        }

        private void buttonSavePlaylist_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text Files | *.txt";
            dialog.FileName = textBoxPlaylistName.Text;

            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            string playlistPath = dialog.FileName;

            List<string> allSongs = _player.GetAllSongsLocations();

            Playlist.Save(playlistPath, allSongs);
            //Console.WriteLine(allSongs[0]);
            //Console.WriteLine(dialog.FileName);
        }

        private void buttonOpenPlaylist_Click(object sender, EventArgs e)
        {
            //string playlistLocation = filePath;
            //temp = playlistLocation.Split("\\".ToCharArray());
            //string playlistName = temp[temp.Length - 1];
            //playlistName = playlistName.Substring(0, playlistName.Length - 4);
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files | *.txt";
            //dialog.FileName = textBoxPlaylistName.Text;
            dialog.Title = "Select a playlist (.txt)";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            string[] allSongs = Playlist.Open(dialog.FileName);

            string[] temp = dialog.FileName.Split("\\".ToCharArray());
            string playlistName = temp[temp.Length - 1];

            // Numele playlist-ului fara extensia .txt
            textBoxPlaylistName.Text = playlistName.Substring(0, playlistName.Length - 4);

            if (listBoxPlaylist.Items.Count > 0)
            {
                _player.DeleteSongs();
                listBoxPlaylist.Items.Clear();
            }

            for (int i = 0; i < allSongs.Length; i++)
            {
                string songLocation = allSongs[i];
                string[] tempSong = songLocation.Split("\\".ToCharArray());
                string songName = tempSong[tempSong.Length - 1];

                listBoxPlaylist.Items.Add(songName);
                listBoxPlaylist.SelectedIndex = 0;

                Console.WriteLine("AICI = " + songLocation);
                Song newSong = new Song(songLocation);
                newSong.Player = _player;

                _player.AddSong(newSong);
                _player.SelectSong(0);
                _player.State = new HasSongsState(_player);
            }
        }

        private void timerPosition_Tick(object sender, EventArgs e)
        {
            TimeSpan position = _player.CurrentSong.Position;
            TimeSpan length = _player.CurrentSong.Length;
            if (position > length)
                length = position;

            labelPosition.Text = String.Format(@"{0:mm\:ss} / {1:mm\:ss}", position, length);

            if (!_stopSliderUpdate &&
                length != TimeSpan.Zero && position != TimeSpan.Zero)
            {
                double perc = position.TotalMilliseconds / length.TotalMilliseconds * trackBarPosition.Maximum;
                trackBarPosition.Value = (int)perc;
            }
        }

        private void trackBarPosition_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _stopSliderUpdate = false;
        }

        private void trackBarPosition_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _stopSliderUpdate = true;
        }

        private void trackBarPosition_ValueChanged(object sender, EventArgs e)
        {
            if (_stopSliderUpdate && timerPosition.Enabled && _player.CurrentState != Player.States.NoSongs)
            {
                double perc = trackBarPosition.Value / (double)trackBarPosition.Maximum;
                TimeSpan position = TimeSpan.FromMilliseconds(_player.CurrentSong.Length.TotalMilliseconds * perc);
                _player.CurrentSong.Position = position;
            }
        }

        private void menuItemAboutHelp_Click(object sender, EventArgs e)
        {
            // Help realizat de Anghel Ioana
            System.Diagnostics.Process.Start("Help_mp.chm");
        }
    }
}
