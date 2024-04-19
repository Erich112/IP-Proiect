using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicProiectIP
{
    public partial class Form1 : Form
    {
        Song s = new Song("karma.mp3");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s.Stop();
        }
    }
}
