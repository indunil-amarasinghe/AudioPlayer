
namespace AudioPlayer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlBottom = new AudioPlayer.GradientPanel();
            this.lstMusicBoxView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnResume = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.btnSelectSong = new System.Windows.Forms.Button();
            this.pnlMain = new AudioPlayer.GradientPanel();
            this.ptbPiano = new System.Windows.Forms.PictureBox();
            this.pnlRight = new AudioPlayer.GradientPanel();
            this.pnlLeft = new AudioPlayer.GradientPanel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPiano)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Angle = 60F;
            this.pnlBottom.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBottom.BottomColor = System.Drawing.Color.Empty;
            this.pnlBottom.Controls.Add(this.lstMusicBoxView);
            this.pnlBottom.Controls.Add(this.lblMessage);
            this.pnlBottom.Controls.Add(this.btnStop);
            this.pnlBottom.Controls.Add(this.btnResume);
            this.pnlBottom.Controls.Add(this.btnPause);
            this.pnlBottom.Controls.Add(this.btnPlay);
            this.pnlBottom.Controls.Add(this.btnSelectSong);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 300);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1904, 741);
            this.pnlBottom.TabIndex = 1;
            this.pnlBottom.TopColor = System.Drawing.Color.PaleGreen;
            // 
            // lstMusicBoxView
            // 
            this.lstMusicBoxView.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lstMusicBoxView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lstMusicBoxView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstMusicBoxView.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMusicBoxView.FullRowSelect = true;
            this.lstMusicBoxView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstMusicBoxView.HideSelection = false;
            this.lstMusicBoxView.Location = new System.Drawing.Point(264, 89);
            this.lstMusicBoxView.MultiSelect = false;
            this.lstMusicBoxView.Name = "lstMusicBoxView";
            this.lstMusicBoxView.Size = new System.Drawing.Size(1415, 209);
            this.lstMusicBoxView.TabIndex = 9;
            this.lstMusicBoxView.UseCompatibleStateImageBehavior = false;
            this.lstMusicBoxView.View = System.Windows.Forms.View.Details;
            this.lstMusicBoxView.Visible = false;
            this.lstMusicBoxView.SelectedIndexChanged += new System.EventHandler(this.lstMusicBoxView_SelectedIndexChanged);
            this.lstMusicBoxView.MouseLeave += new System.EventHandler(this.lstMusicBoxView_MouseLeave);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "FilePath";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Album";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 400;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "#";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Title";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 787;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Length";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Contributing Artist";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 300;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Composer";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 300;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Size";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 100;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(1057, 32);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(676, 27);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "Please select audio files of .wav, .wma, .mp3 and .ogg format only";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.ImageLocation = "";
            this.btnStop.Location = new System.Drawing.Point(992, 323);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(48, 65);
            this.btnStop.TabIndex = 6;
            this.btnStop.TabStop = false;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnStop.MouseHover += new System.EventHandler(this.btnStop_MouseHover);
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.Transparent;
            this.btnResume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResume.BackgroundImage")));
            this.btnResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnResume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResume.ImageLocation = "";
            this.btnResume.Location = new System.Drawing.Point(895, 323);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(51, 65);
            this.btnResume.TabIndex = 5;
            this.btnResume.TabStop = false;
            this.btnResume.Visible = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            this.btnResume.MouseHover += new System.EventHandler(this.btnResume_MouseHover);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.ImageLocation = "";
            this.btnPause.Location = new System.Drawing.Point(943, 323);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(51, 65);
            this.btnPause.TabIndex = 4;
            this.btnPause.TabStop = false;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            this.btnPause.MouseHover += new System.EventHandler(this.btnPause_MouseHover);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.ImageLocation = "";
            this.btnPlay.Location = new System.Drawing.Point(844, 323);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(52, 65);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.TabStop = false;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseHover += new System.EventHandler(this.btnPlay_MouseHover);
            // 
            // btnSelectSong
            // 
            this.btnSelectSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectSong.FlatAppearance.BorderSize = 0;
            this.btnSelectSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSong.Font = new System.Drawing.Font("Garamond", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSong.Location = new System.Drawing.Point(827, 7);
            this.btnSelectSong.Name = "btnSelectSong";
            this.btnSelectSong.Size = new System.Drawing.Size(222, 53);
            this.btnSelectSong.TabIndex = 0;
            this.btnSelectSong.Text = "Select Song";
            this.btnSelectSong.UseVisualStyleBackColor = true;
            this.btnSelectSong.Click += new System.EventHandler(this.btnSelectSong_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Angle = 60F;
            this.pnlMain.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMain.BottomColor = System.Drawing.Color.Empty;
            this.pnlMain.Controls.Add(this.ptbPiano);
            this.pnlMain.Controls.Add(this.pnlRight);
            this.pnlMain.Controls.Add(this.pnlLeft);
            this.pnlMain.Controls.Add(this.lblWelcome);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1904, 300);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.TopColor = System.Drawing.Color.PaleGreen;
            // 
            // ptbPiano
            // 
            this.ptbPiano.BackColor = System.Drawing.Color.Transparent;
            this.ptbPiano.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbPiano.BackgroundImage")));
            this.ptbPiano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbPiano.Location = new System.Drawing.Point(915, 96);
            this.ptbPiano.Name = "ptbPiano";
            this.ptbPiano.Size = new System.Drawing.Size(215, 180);
            this.ptbPiano.TabIndex = 5;
            this.ptbPiano.TabStop = false;
            this.ptbPiano.MouseHover += new System.EventHandler(this.ptbPiano_MouseHover);
            // 
            // pnlRight
            // 
            this.pnlRight.Angle = 60F;
            this.pnlRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRight.BackgroundImage")));
            this.pnlRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlRight.BottomColor = System.Drawing.Color.Empty;
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1578, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(326, 300);
            this.pnlRight.TabIndex = 4;
            this.pnlRight.TopColor = System.Drawing.Color.PaleGreen;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Angle = 60F;
            this.pnlLeft.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLeft.BackgroundImage")));
            this.pnlLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLeft.BottomColor = System.Drawing.Color.Empty;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(326, 300);
            this.pnlLeft.TabIndex = 3;
            this.pnlLeft.TopColor = System.Drawing.Color.PaleGreen;
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Garamond", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Gold;
            this.lblWelcome.Location = new System.Drawing.Point(518, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(931, 109);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome To Creative Digital Studio";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlMain);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio Player";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPiano)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel pnlMain;
        private System.Windows.Forms.Label lblWelcome;
        private GradientPanel pnlBottom;
        private System.Windows.Forms.Button btnSelectSong;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox btnResume;
        private System.Windows.Forms.PictureBox btnPause;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.Label lblMessage;
        private GradientPanel pnlRight;
        private GradientPanel pnlLeft;
        private System.Windows.Forms.PictureBox ptbPiano;
        private System.Windows.Forms.ListView lstMusicBoxView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}