using NAudio.Vorbis;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AudioPlayer
{
    public partial class MainForm : Form
    {
        private int? numberInteger;
        private List<string> paths = new List<string>();

        private BlockAlignReductionStream stream = null;
        private WaveOutEvent output = null;
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checks duplicates in audio grid
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fileName"></param>
        private void CheckDuplicatesInGrid()
        {
            for (int i = 0; i < lstMusicBoxView.Items.Count; i++)
            {
                for (int j = 2; j < lstMusicBoxView.Items.Count; j++)
                {
                    if (i != j)
                    {
                        if (lstMusicBoxView.Items[i].Text == lstMusicBoxView.Items[j].Text)
                        {
                            lstMusicBoxView.Items[j].Remove();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Stops audio
        /// </summary>
        private void DisposeWave()
        {
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing) output.Stop();
                output.Dispose();
                output = null;
            }

            if (stream != null)
            {
                stream.Dispose();
                stream = null;
            }
        }

        /// <summary>
        /// Generates audio grid
        /// </summary>
        private void GenerateGrid()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //Code to Select Songs
            ofd.InitialDirectory = "C:";
            ofd.Filter = "Media Files | *.mp3;*.wav;*.wma;*.ogg;";
            ofd.FileName = string.Empty;
            ofd.Multiselect = true;

            if (ofd.ShowDialog() != DialogResult.OK) return;
            {
                paths = ofd.FileNames.ToList();

                foreach (var path in paths)
                {
                    FileInfo file = new FileInfo(path);
                    string fileName = Path.GetFileName(path);

                    try
                    {
                        if (file.Exists)
                        {
                            if ((file.Extension.EndsWith(".mp3") || file.Extension.EndsWith(".wav") || file.Extension.EndsWith(".wma") || (file.Extension.EndsWith(".MP3") || file.Extension.EndsWith(".WAV") || file.Extension.EndsWith(".WMA"))))
                            {
                                using (AudioFileReader audioFile = new AudioFileReader(path))
                                {
                                    if (audioFile.CanRead)
                                    {
                                        PopulateAudioTaggingToGrid(path, fileName);
                                        CheckDuplicatesInGrid();
                                    }
                                }
                            }
                           
                            if (file.Extension.EndsWith(".ogg") || file.Extension.EndsWith(".OGG"))
                            {
                                using (VorbisWaveReader ogg = new VorbisWaveReader(path))
                                { 
                                    PopulateVorbisTaggingToGrid(path, fileName);
                                    CheckDuplicatesInGrid();
                                }
                            }
                        }

                        btnPlay.Visible = true;
                        btnPause.Visible = true;
                        btnResume.Visible = true;
                        btnStop.Visible = true;
                        lstMusicBoxView.Visible = true;
                        this.Cursor = Cursors.WaitCursor;
                    }

                    catch (Exception exc)
                    {
                        
                    }
                }
            }
        }

        /// <summary>
        /// Populates audio tagging to grid
        /// </summary>
        /// <param name="id"></param>
        /// <param name="path"></param>
        /// <param name="fileName"></param>
        private void PopulateAudioTaggingToGrid(string path, string fileName)
        {
            TagLib.File taggedMusic = TagLib.File.Create(path);

            double sizeInMB = new FileInfo(path).Length / 1024f / 1024f;
            string sizeInMBValue = Math.Round(sizeInMB, 2) + "MB";

            var timeDuration = new AudioFileReader(path).TotalTime;
            string lengthDuration = timeDuration.ToString(@"hh\:mm\:ss");

            string album = taggedMusic.Tag.Album;
            string artist = taggedMusic.Tag.FirstPerformer;
            string composer = taggedMusic.Tag.FirstComposer;
            string size = sizeInMBValue;

            numberInteger = (int)taggedMusic.Tag.Track;

            if (numberInteger == 0)
            {
                numberInteger = null;
            }
            else
            {
                numberInteger = (int)taggedMusic.Tag.Track;
            }

            ListViewItem lvi = new ListViewItem(path);
            lvi.SubItems.Add(album);
            lvi.SubItems.Add(numberInteger.ToString());
            lvi.SubItems.Add(fileName);
            lvi.SubItems.Add(lengthDuration);
            lvi.SubItems.Add(artist);
            lvi.SubItems.Add(composer);
            lvi.SubItems.Add(size);

            lstMusicBoxView.Items.Add(lvi);
            lvi.Text = path;

        }

        /// <summary>
        /// Populates Vorbis tagging to grid
        /// </summary>
        /// <param name="id"></param>
        /// <param name="path"></param>
        /// <param name="fileName"></param>
        private void PopulateVorbisTaggingToGrid(string path, string fileName)
        {
            TagLib.File taggedMusic = TagLib.File.Create(path);

            double sizeInMB = new FileInfo(path).Length / 1024f / 1024f;
            string sizeInMBValue = Math.Round(sizeInMB, 2) + "MB";

            var timeDuration = new VorbisWaveReader(path).TotalTime;
            string lengthDuration = timeDuration.ToString(@"hh\:mm\:ss");

            string album = taggedMusic.Tag.Album;
            string artist = taggedMusic.Tag.FirstPerformer;
            string composer = taggedMusic.Tag.FirstComposer;
            string size = sizeInMBValue;

            numberInteger = (int)taggedMusic.Tag.Track;

            if (numberInteger == 0)
            {
                numberInteger = null;
            }
            else
            {
                numberInteger = (int)taggedMusic.Tag.Track;
            }

            ListViewItem lvi = new ListViewItem(path);
            lvi.SubItems.Add(album);
            lvi.SubItems.Add(numberInteger.ToString());
            lvi.SubItems.Add(fileName);
            lvi.SubItems.Add(lengthDuration);
            lvi.SubItems.Add(artist);
            lvi.SubItems.Add(composer);
            lvi.SubItems.Add(size);

            lstMusicBoxView.Items.Add(lvi);
            lvi.Text = path;
        }

        private void btnSelectSong_Click(object sender, EventArgs e)
        {
            GenerateGrid();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (output == null)
            {
                PlayAudio();
            }
        }

        /// <summary>
        /// Plays audio files
        /// </summary>
        private void PlayAudio()
        {
            foreach (ListViewItem listItem in lstMusicBoxView.SelectedItems)
            {
                int listCount = lstMusicBoxView.SelectedItems.Count;

                if (lstMusicBoxView.SelectedItems[listCount - 1].Selected == true)
                {
                    if (lstMusicBoxView.SelectedItems[listCount - 1].Text.EndsWith(".mp3") || lstMusicBoxView.SelectedItems[listCount - 1].Text.EndsWith(".wav") || lstMusicBoxView.SelectedItems[listCount - 1].Text.EndsWith(".wma") || lstMusicBoxView.SelectedItems[listCount - 1].Text.EndsWith(".MP3") || lstMusicBoxView.SelectedItems[listCount - 1].Text.EndsWith(".WAV") || lstMusicBoxView.SelectedItems[listCount - 1].Text.EndsWith(".WMA"))
                    {
                        string fileName = lstMusicBoxView.SelectedItems[listCount - 1].Text;

                        var audioFile = new AudioFileReader(fileName);
                        var trimmed = new OffsetSampleProvider(audioFile);
                        output = new WaveOutEvent();
                        output.Init(trimmed);
                        output.Play();
                        return;
                    }

                    if(lstMusicBoxView.SelectedItems[listCount - 1].Text.EndsWith(".ogg") || lstMusicBoxView.SelectedItems[listCount - 1].Text.EndsWith(".OGG"))
                    {
                        string fileName = lstMusicBoxView.SelectedItems[listCount - 1].Text;
                        var vorbisFile = new VorbisWaveReader(fileName);
                        output = new WaveOutEvent();
                        output.Init(vorbisFile);
                        output.Play();
                        return;
                    }
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DisposeWave();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            try
            {
                if (output.PlaybackState == PlaybackState.Paused) output.Play();
            }

            catch (NullReferenceException exc)
            {
                string message = exc.Message;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing)
                {
                    output.Pause();
                }
            }
        }

        private void btnPlay_MouseHover(object sender, EventArgs e)
        {
            ToolTip play = new ToolTip();
            play.SetToolTip(btnPlay, "Play");
        }

        private void btnResume_MouseHover(object sender, EventArgs e)
        {
            ToolTip resume = new ToolTip();
            resume.SetToolTip(btnResume, "Resume");
        }

        private void btnPause_MouseHover(object sender, EventArgs e)
        {
            ToolTip pause = new ToolTip();
            pause.SetToolTip(btnPause, "Pause");
        }

        private void btnStop_MouseHover(object sender, EventArgs e)
        {
            ToolTip stop = new ToolTip();
            stop.SetToolTip(btnStop, "Stop");
        }

        private void lstMusicBoxView_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void ptbPiano_MouseHover(object sender, EventArgs e)
        {
            ToolTip piano = new ToolTip();
            piano.SetToolTip(ptbPiano, "Grand Piano");
        }
    }
}
