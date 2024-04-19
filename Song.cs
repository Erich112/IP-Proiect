using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore;
using CSCore.Codecs;
using CSCore.CoreAudioAPI;
using CSCore.SoundOut;
using CSCore.Codecs.MP3;
using CSCore.Tags.ID3;
namespace MusicProiectIP
{
    class Song
    {
        private string _fileName;
        private ISoundOut _soundOut;
        private IWaveSource _waveSource;
        public Song()
        {

        }
        public Song(string fileName)
        {
            _fileName = fileName;
        }
        public void Play()
        {
            _waveSource = CodecFactory.Instance.GetCodec(_fileName).ToSampleSource().ToWaveSource();
            _soundOut = new WasapiOut();
            _soundOut.Initialize(_waveSource);
            _soundOut.Play();
        }
        public void Stop()
        {
            _soundOut.Stop();
        }
    }
}
