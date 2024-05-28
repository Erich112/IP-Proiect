/******************************************************************************
 *                                                                            *
 *  Fisier:      UnitTest1.cs                                                 *
 *  Autor(i):    Popescu Vlad                                                 *
 *                                                                            *
 *     Descriere: Unit Test-urile pentru verificarea funcționării diferitor   *
 *  părți din program. În total sunt 20 de teste. Se testează în particular   *
 *  clasele Playlist, Song, Player.                                           * 
 ******************************************************************************/


using System;
using System.IO;
using System.Windows.Forms;
using CSCore.SoundOut;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlayerDLL;
using PlaylistDLL;

namespace MusicProiectTest
{
    [TestClass]
    public class MusicPlayerTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SongPlayWithoutInitialization()
        {
            Song test = new Song("karma.mp3");
            test.Play();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SongPauseWithoutInitialization()
        {
            Song test = new Song("karma.mp3");
            test.Pause();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SongStopWithoutInitialization()
        {
            Song test = new Song("karma.mp3");
            test.Stop();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SongResumeWithoutInitialization()
        {
            Song test = new Song("karma.mp3");
            test.Resume();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SongDeleteWithoutInitialization()
        {
            Song test = new Song("karma.mp3");
            test.Delete();
        }

        [TestMethod]
        public void SongGetPlaybackState()
        {
            Song test = new Song("karma.mp3");
            test.Initialize();
            Assert.AreEqual(PlaybackState.Stopped, test.GetPlaybackState());
        }

        [TestMethod]
        public void SongLengthNotInitialized()
        {
            Song test = new Song("karma.mp3");
            Assert.AreEqual(TimeSpan.Zero, test.Length);
        }

        [TestMethod]
        public void SongLengthInitialized()
        {
            Song test = new Song("karma.mp3");
            test.Initialize();
            Assert.AreNotEqual(TimeSpan.Zero, test.Length);
        }

        [TestMethod]
        public void PlayerEmpty()
        {
            Player player = new Player(new ListBox(), new Timer(), new TextBox());

            Assert.AreEqual(true, player.IsEmpty());
        }

        [TestMethod]
        public void PlayerOneSong()
        {
            Song test = new Song("karma.mp3");
            Player player = new Player(new ListBox(), new Timer(), new TextBox());
            player.AddSong(test);

            Assert.AreEqual(false, player.IsEmpty());
        }

        [TestMethod]
        public void PlayerAddDelete()
        {
            Song test = new Song("karma.mp3");
            Player player = new Player(new ListBox(), new Timer(), new TextBox());
            player.AddSong(test);
            player.DeleteSongs();

            Assert.AreEqual(true, player.IsEmpty());
        }

        [TestMethod]
        public void Player1SongNext()
        {
            Song test = new Song("karma.mp3");
            ListBox listBox = new ListBox();
            listBox.Items.Add(test);

            Player player = new Player(listBox, new Timer(), new TextBox());
            player.AddSong(test);
            player.CurrentState = Player.States.HasSongs;
            player.SelectSong(0);
            player.NextSong();

            Assert.AreEqual(test, player.CurrentSong);
        }

        [TestMethod]
        public void Player1SongPrev()
        {
            Song test = new Song("karma.mp3");
            ListBox listBox = new ListBox();
            listBox.Items.Add(test);

            Player player = new Player(listBox, new Timer(), new TextBox());
            player.AddSong(test);
            player.CurrentState = Player.States.HasSongs;
            player.SelectSong(0);
            player.PrevSong();

            Assert.AreEqual(test, player.CurrentSong);
        }

        [TestMethod]
        public void Player2SongNext()
        {
            Song test = new Song("karma.mp3");
            Song test2 = new Song("karma.mp3");
            ListBox listBox = new ListBox();
            listBox.Items.Add(test);
            listBox.Items.Add(test2);

            Player player = new Player(listBox, new Timer(), new TextBox());
            player.AddSong(test);
            player.AddSong(test2);
            player.CurrentState = Player.States.HasSongs;
            player.SelectSong(0);
            player.NextSong();

            Assert.AreEqual(test2, player.CurrentSong);
        }

        [TestMethod]
        public void Player2SongPrev()
        {
            Song test = new Song("karma.mp3");
            Song test2 = new Song("karma.mp3");
            ListBox listBox = new ListBox();
            listBox.Items.Add(test);
            listBox.Items.Add(test2);

            Player player = new Player(listBox, new Timer(), new TextBox());
            player.AddSong(test);
            player.AddSong(test2);
            player.CurrentState = Player.States.HasSongs;
            player.SelectSong(1);
            player.PrevSong();

            Assert.AreEqual(test, player.CurrentSong);
        }

        [TestMethod]
        public void PlayerSongIndex0()
        {
            Song test = new Song("karma.mp3");
            ListBox listBox = new ListBox();
            listBox.Items.Add(test);

            Player player = new Player(listBox, new Timer(), new TextBox());
            player.AddSong(test);
            player.CurrentState = Player.States.HasSongs;
            player.SelectSong(0);

            Assert.AreEqual(0, player.CurrentSongIndex);
        }

        [TestMethod]
        public void PlayerSongIndexNext1()
        {
            Song test = new Song("karma.mp3");
            Song test2 = new Song("karma.mp3");
            ListBox listBox = new ListBox();
            listBox.Items.Add(test);
            listBox.Items.Add(test2);

            Player player = new Player(listBox, new Timer(), new TextBox());
            player.AddSong(test);
            player.AddSong(test2);
            player.CurrentState = Player.States.HasSongs;
            player.SelectSong(0);
            player.NextSong();

            Assert.AreEqual(1, player.CurrentSongIndex);
        }

        [TestMethod]
        public void PlayerSongIndexPrev0()
        {
            Song test = new Song("karma.mp3");
            Song test2 = new Song("karma.mp3");
            ListBox listBox = new ListBox();
            listBox.Items.Add(test);
            listBox.Items.Add(test2);

            Player player = new Player(listBox, new Timer(), new TextBox());
            player.AddSong(test);
            player.AddSong(test2);
            player.CurrentState = Player.States.HasSongs;
            player.SelectSong(1);
            player.PrevSong();

            Assert.AreEqual(0, player.CurrentSongIndex);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void PlaylistOpenException()
        {
            string[] songs = Playlist.Open("wrongPlaylist.txt");
        }

        [TestMethod]
        public void PlaylistOpen()
        {
            string[] songs = Playlist.Open("PlaylistTest.txt");
            Assert.AreEqual(2, songs.Length);
        }
    }
}
