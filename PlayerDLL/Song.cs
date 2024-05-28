/******************************************************************************
 *                                                                            *
 *  Fisier:      Song.cs                                                      *
 *  Autor(i):    Lemny Erich, Popescu Vlad                                    *
 *                                                                            *
 *     Descriere: Acest fișier descrie clasa Song, ce reprezintă un singur    *
 *  cântec din intefață. Conține metode pentru realizarea diferitor acțiuni   *
 *  asupra unui cântec specific, precum Play, Pause, Stop, Initialize etc.    *
 *  Cu ajutorul clasei Song se realizează design pattern-ul Fațadă peste      *
 *  librăria CSCore.                                                          *
 ******************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;

namespace PlayerDLL
{
    /// <summary>
    /// Clasa ce încapsulează funcionalitățile legate de un cântec particular
    /// </summary>
    public class Song
    {
        private string _path;
        private ISoundOut _soundOut;
        private IWaveSource _waveSource;

        private bool _pressedButtonStop = false;

        private Player _player;

        public Player Player
        {
            get
            {
                return _player;
            }
            set
            {
                _player = value;
            }
        }

        /// <summary>
        /// Proprietate pentru accesarea locației cântecului
        /// </summary>
        public string Path
        {
            get
            {
                return _path;
            }
        }

        /// <summary>
        /// Constructorul clasei Song
        /// </summary>
        /// <param name="path">Calea către cântec</param>
        public Song(string path)
        {
            _path = path;
        }

        /// <summary>
        /// Metoda dată realizează inițializări necesare
        /// </summary>
        public void Initialize()
        {
            _waveSource = CodecFactory.Instance.GetCodec(_path);
            _soundOut = new WasapiOut() { Latency = 100 };
            _soundOut.Initialize(_waveSource);
            _soundOut.Stopped += OnStopped;
            _pressedButtonStop = false;
        }

        /// <summary>
        /// Metoda dată eliberează memoria ocupată de resursele acestui cântec
        /// </summary>
        public void Delete()
        {
            if (_soundOut != null && _waveSource != null)
            {
                _soundOut.Stop();
                _soundOut.Dispose();
                _soundOut = null;
                _waveSource.Dispose();
                _waveSource = null;
            }
            else
            {
                throw new Exception("Delete without Initialization in Song");
            }
        }

        private void OnStopped(object sender, PlaybackStoppedEventArgs e)
        {
            if (!_pressedButtonStop)
            {
                Delete();

                if (_player.RepeatSong)
                {
                    _player.State = new HasSongsState(_player);
                    _player.Play();
                    _player.SetCurrentSongState("Playing > " + _player.GetCurrentSongName());
                }
                else
                {
                    _player.State = new HasSongsState(_player);
                    _player.NextSong();
                    _player.Play();
                    _player.SetCurrentSongState("Playing > " + _player.GetCurrentSongName());
                }
            }
        }

        /// <summary>
        /// Metoda dată pornește redarea cântecului
        /// </summary>
        public void Play()
        {
            if (_soundOut != null)
            {
                _soundOut.Play();
            }
            else
            {
                throw new Exception("Nu a fost inițializat clasa Song înainte de Play");
            }
        }

        /// <summary>
        /// Metoda dată oprește complet cântecul
        /// </summary>
        public void Stop()
        {
            if (_soundOut != null)
            {
                _soundOut.Stop();
                _pressedButtonStop = true;
            }
            else
            {
                throw new Exception("Nu a fost inițializat clasa Song înainte de Stop");
            }
        }

        /// <summary>
        /// Metoda dată pune pe pauză cântecul
        /// </summary>
        public void Pause()
        {
            if (_soundOut != null)
            {
                _soundOut.Pause();
            }
            else
            {
                throw new Exception("Nu a fost inițializat clasa Song înainte de Pause");
            }
        }

        /// <summary>
        /// Metoda dată repornește redarea unui cântec
        /// </summary>
        public void Resume()
        {
            if (_soundOut != null)
            {
                _soundOut.Resume();
            }
            else
            {
                throw new Exception("Nu a fost inițializat clasa Song înainte de Play");
            }
        }

        /// <summary>
        /// Metodă pentru accesarea stării curente a cântecului
        /// </summary>
        /// <returns>Starea curentă, sau PlaybackState.Stopped dacă clasa Song nu a fost 
        ///          inițializată</returns>
        public PlaybackState GetPlaybackState()
        {
            if (_soundOut != null)
                return _soundOut.PlaybackState;
            else
                return PlaybackState.Stopped;
        }

        /// <summary>
        /// Proprietate pentru accesarea și setarea poziției în cântecul curent. În caz de neinițializare este TimeSpan.Zero
        /// </summary>
        public TimeSpan Position
        {
            get
            {
                if (_waveSource != null)
                    return _waveSource.GetPosition();
                return TimeSpan.Zero;
            }
            set
            {
                if (_waveSource != null)
                    _waveSource.SetPosition(value);
            }
        }

        /// <summary>
        /// Proprietate pentru accesarea lungimii cântecului curent. În caz de neinițializare este TimeSpan.Zero
        /// </summary>
        public TimeSpan Length
        {
            get
            {
                if (_waveSource != null)
                    return _waveSource.GetLength();
                return TimeSpan.Zero;
            }
        }
    }
}
