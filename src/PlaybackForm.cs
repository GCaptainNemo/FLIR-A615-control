using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Flir.Atlas.Image;

namespace ThermalImageStreamerDemo
{
    // Simple playback of a SEQ (radiometric data) file.
    // Also see IRImageReaderDemo on how to open Thermal image files.
    public partial class PlaybackForm : Form
    {
        private ThermalImageFile _imageFile;
        private string Path { get; set; }
        private bool IsDirty { get; set; }
        readonly Timer _timer = new Timer();
        public PlaybackForm(string path)
        {
            Path = path;
            InitializeComponent();
        }

        private void PlaybackForm_Load(object sender, EventArgs e)
        {
            _imageFile  = new ThermalImageFile(Path);
            _imageFile.Changed += _imageFile_Changed;
            pictureBox1.Image = _imageFile.Image;
            if (_imageFile.ThermalSequencePlayer.Count() > 1)
            {
                _timer.Interval = 20;
                _timer.Tick += _timer_Tick;
                _timer.Start();
            }
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            if (!IsDirty) return;
            IsDirty = false;
            _imageFile.EnterLock();
            try
            {
                pictureBox1.Image = _imageFile.Image;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
            finally
            {
                _imageFile.ExitLock();
            }
        }

        void _imageFile_Changed(object sender, ImageChangedEventArgs e)
        {
            IsDirty = true;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            _imageFile.ThermalSequencePlayer.Play();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            _imageFile.ThermalSequencePlayer.Stop();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            _imageFile.ThermalSequencePlayer.Pause();
        }

        private void PlaybackForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _timer.Stop();
        }
    }
}
