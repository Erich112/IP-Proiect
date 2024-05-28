/******************************************************************************
 *                                                                            *
 *  Fisier:      Player.cs                                                     *
 *  Autor(i):    Popescu Vlad                                                 *
 *                                                                            *
 *     Descriere: Fișierul ce reprezintă player-ul din aplicație. Conține     *
 *  referințe la toate cântecele actuale, precum și metode pentru a acționa   *
 *  asupra lor. Are și metode pentru lucrul cu interfața grafică.             *
 ******************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerDLL
{
    /// <summary>
    /// Una din clasele esențiale a aplicației. Reprezintă player-ul aplicației, cu toate funcționalitățile aferente
    /// </summary>
    public class Player
    {
        private AbstractPlayerState _state;

        /// <summary>
        /// Un enum cu stările posibile pe care le poate avea clasa Player
        /// </summary>
        public enum States
        {
            NoSongs,
            HasSongs,
            PlayingSong,
            PausedSong
        }

        private States _currentState;
        public States CurrentState
        {
            get
            {
                return _currentState;
            }
            set
            {
                _currentState = value;
            }
        }

        private Song _currentSong;
        private int _currentSongIndex;
        private bool _repeatSong;

        private ListBox _listBoxSongs;
        private Timer _timerPosition;
        private TextBox _currentSongState;

        private List<Song> _allSongs;

        public AbstractPlayerState State
        {
            set
            {
                _state = value;
            }
        }

        public Song CurrentSong
        {
            get
            {
                return _currentSong;
            }

            set
            {
                _currentSong = value;
            }
        }

        /// <summary>
        /// Constuctorul clasei Player
        /// </summary>
        /// <param name="listBoxSongs">Un ListBox din interfață pentru cântece</param>
        /// <param name="timerPosition">Un timer pentru trackbar-ul din interfață</param>
        /// <param name="currentSongState">Un TextBox în care se afișează ce cântec este redat sau pe pauză</param>
        public Player(ListBox listBoxSongs, Timer timerPosition, TextBox currentSongState)
        {
            _state = new NoSongsState(this);
            _allSongs = new List<Song>();
            _listBoxSongs = listBoxSongs;
            _timerPosition = timerPosition;
            _currentSongState = currentSongState;
            _repeatSong = false;
        }

        /// <summary>
        /// Metodă pentru accesarea titlului cântecului curent selectat în Player
        /// </summary>
        /// <returns>Titlul cântecului selectat</returns>
        public string GetCurrentSongName()
        {
            return _listBoxSongs.SelectedItem.ToString();
        }

        public void SetCurrentSongState(string state)
        {
            _currentSongState.Text = state;
        }

        /// <summary>
        /// Pornește sau oprește timer-ul asociat Player-ului și trackBar-ului din interfață
        /// </summary>
        /// <param name="state">True pentru setarea timer-ului, altfel false</param>
        public void SetTimer(bool state)
        {
            _timerPosition.Enabled = state;
        }

        /// <summary>
        /// Proprietate ce accesează sau setează flag-ul pentru repetarea cântecului curent
        /// </summary>
        public bool RepeatSong
        {
            get
            {
                return _repeatSong;
            }
            set
            {
                _repeatSong = value;
            }
        }

        /// <summary>
        /// Metodă ce returnează locațiile tuturor cântecelor din Player
        /// </summary>
        /// <returns>O listă de string-uri, fiecare element reprezentând o locație</returns>
        public List<string> GetAllSongsLocations()
        {
            List<string> allSongs = new List<string>();

            for (int i = 0; i < _allSongs.Count; i++)
            {
                allSongs.Add(_allSongs[i].Path);
            }

            return allSongs;
        }

        public bool IsEmpty()
        {
            return (_allSongs.Count == 0);
        }

        public void AddSong(Song song)
        {
            _allSongs.Add(song);
        }

        public void DeleteSongs()
        {
            if (_allSongs.Count > 0)
            {
                _allSongs.Clear();
                _currentSongIndex = -1;
                _currentSong = null;
            }
        }

        public void SelectSong(int index)
        {
            _currentSong = _allSongs[index];
            _currentSongIndex = index;
        }

        public void NextSong()
        {
            if (_currentState == States.NoSongs)
                return;

            if (_currentSongIndex == _allSongs.Count - 1)
            {
                _currentSong = _allSongs[0];
                _currentSongIndex = 0;
                _listBoxSongs.SelectedIndex = _currentSongIndex;
            }
            else
            {
                _currentSong = _allSongs[_currentSongIndex + 1];
                _currentSongIndex++;
                _listBoxSongs.SelectedIndex = _currentSongIndex;
            }
        }

        public void PrevSong()
        {
            if (_currentState == States.NoSongs)
                return;

            if (_currentSongIndex == 0)
            {
                _currentSong = _allSongs[_allSongs.Count - 1];
                _currentSongIndex = _allSongs.Count - 1;
                _listBoxSongs.SelectedIndex = _currentSongIndex;
            }
            else
            {
                _currentSong = _allSongs[_currentSongIndex - 1];
                _currentSongIndex--;
                _listBoxSongs.SelectedIndex = _currentSongIndex;
            }
        }

        public int CurrentSongIndex
        {
            get
            {
                return _currentSongIndex;
            }
            set
            {
                _currentSongIndex = value;
            }
        }

        /// <summary>
        /// Această metodă apelează metoda Play din State-ul aferent Player-ului dintr-un moment dat
        /// </summary>
        public void Play()
        {
            _state.Play();
        }

        /// <summary>
        /// Această metodă apelează metoda Pause din State-ul aferent Player-ului dintr-un moment dat
        /// </summary>
        public void Pause()
        {
            _state.Pause();
        }

        /// <summary>
        /// Această metodă apelează metoda Stop din State-ul aferent Player-ului dintr-un moment dat
        /// </summary>
        public void Stop()
        {
            _state.Stop();
        }
    }
}
