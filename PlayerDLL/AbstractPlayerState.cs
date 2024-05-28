/******************************************************************************
 *                                                                            *
 *  Fisier:      AbstractPlayerState.cs                                                     *
 *  Autor(i):    Popescu Vlad                                                 *
 *                                                                            *
 *     Descriere: Fișier ce conține clasa abstractă AbstractPlayerState       *
 * moștenită de cele 4 clase a stărilor.                                      *
 ******************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDLL
{
    /// <summary>
    /// Clasă abstractă pentru implementarea stărilor clasei Player
    /// </summary>
    public abstract class AbstractPlayerState
    {
        protected Player _player;

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

        public abstract void Play();
        public abstract void Stop();
        public abstract void Pause();
    }
}
