/******************************************************************************
 *                                                                            *
 *  Fisier:      PlayerStates.cs                                              *
 *  Autor(i):    Popescu Vlad                                                 *
 *                                                                            *
 *     Descriere: Fișier ce conține patru clase corespunzătoare celor 4 stări *
 * în care se poate afla clasa Player. Toate 4 moștenesc aceeași clasă        *
 * abstractă, fiind implementat și design pattern-ul Stare în acest program.  *
 ******************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDLL
{
    /// <summary>
    /// Clasă ce reprezintă starea de lipsă de cântece în Player
    /// </summary>
    public class NoSongsState : AbstractPlayerState
    {
        /// <summary>
        /// Constructorul clasei NoSongsState
        /// </summary>
        /// <param name="player">Player-ul care este afectat de această clasă (stare)</param>
        public NoSongsState(Player player)
        {
            Player = player;
            Player.CurrentState = Player.States.NoSongs;
            Console.WriteLine("no songs");
        }

        public override void Pause()
        {

        }

        public override void Play()
        {

        }

        public override void Stop()
        {

        }
    }

    /// <summary>
    /// Clasă ce reprezintă prezența cântecelor în Player
    /// </summary>
    public class HasSongsState : AbstractPlayerState
    {
        /// <summary>
        /// Constructorul clasei HasSongsState
        /// </summary>
        /// <param name="player">Player-ul care este afectat de această clasă (stare)</param>
        public HasSongsState(Player player)
        {
            Player = player;
            Player.CurrentState = Player.States.HasSongs;
            Console.WriteLine("with songs");
        }

        public override void Pause()
        {

        }

        public override void Play()
        {
            _player.CurrentSong.Initialize();
            _player.CurrentSong.Play();
            _player.State = new PlayingSongState(_player);
        }

        public override void Stop()
        {

        }
    }

    /// <summary>
    /// Clasă ce reprezintă redarea unui cântec în Player
    /// </summary>
    public class PlayingSongState : AbstractPlayerState
    {
        /// <summary>
        /// Constructorul clasei PlayingSongState
        /// </summary>
        /// <param name="player">Player-ul care este afectat de această clasă (stare)</param>
        public PlayingSongState(Player player)
        {
            Player = player;
            Player.CurrentState = Player.States.PlayingSong;
            Console.WriteLine("playing songs");
        }

        public override void Pause()
        {
            _player.CurrentSong.Pause();
            _player.State = new PausedSongState(_player);
        }

        public override void Play()
        {

        }

        public override void Stop()
        {
            _player.CurrentSong.Stop();
            _player.CurrentSong.Delete();
            _player.State = new HasSongsState(_player);
        }
    }

    /// <summary>
    /// Clasă ce reprezintă punerea pe pauză a unui cântec în Player
    /// </summary>
    public class PausedSongState : AbstractPlayerState
    {
        /// <summary>
        /// Constructorul clasei PausedSongState
        /// </summary>
        /// <param name="player">Player-ul care este afectat de această clasă (stare)</param>
        public PausedSongState(Player player)
        {
            Player = player;
            Player.CurrentState = Player.States.PausedSong;
            Console.WriteLine("Paused songs");
        }

        public override void Pause()
        {

        }

        public override void Play()
        {
            _player.CurrentSong.Resume();
            _player.State = new PlayingSongState(_player);
        }


        public override void Stop()
        {
            _player.CurrentSong.Stop();
            _player.CurrentSong.Delete();
            _player.State = new HasSongsState(_player);
        }
    }
}
