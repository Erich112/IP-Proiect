
namespace MusicProiectIP
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.checkBoxRepeat = new System.Windows.Forms.CheckBox();
            this.buttonNewPlaylist = new System.Windows.Forms.Button();
            this.buttonEditTags = new System.Windows.Forms.Button();
            this.buttonSavePlaylist = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.listBoxPlaylist = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxPlaylistName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelPlaylistName = new System.Windows.Forms.Label();
            this.buttonOpenPlaylist = new System.Windows.Forms.Button();
            this.trackBarPosition = new System.Windows.Forms.TrackBar();
            this.timerPosition = new System.Windows.Forms.Timer(this.components);
            this.labelPosition = new System.Windows.Forms.Label();
            this.textBoxCurrentSongState = new System.Windows.Forms.TextBox();
            this.labelCurrentSongState = new System.Windows.Forms.Label();
            this.menuItemAboutHelp = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(88, 77);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(114, 40);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play/Resume";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(208, 77);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(67, 40);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(281, 77);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(68, 40);
            this.buttonPause.TabIndex = 2;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(26, 77);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(56, 40);
            this.buttonPrev.TabIndex = 5;
            this.buttonPrev.Text = "Prev";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(373, 77);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(76, 40);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItemAbout});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2});
            this.menuItem1.Text = "File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Open";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Index = 1;
            this.menuItemAbout.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemAboutHelp});
            this.menuItemAbout.Text = "About";
            // 
            // checkBoxRepeat
            // 
            this.checkBoxRepeat.AutoSize = true;
            this.checkBoxRepeat.Location = new System.Drawing.Point(486, 77);
            this.checkBoxRepeat.Name = "checkBoxRepeat";
            this.checkBoxRepeat.Size = new System.Drawing.Size(160, 21);
            this.checkBoxRepeat.TabIndex = 7;
            this.checkBoxRepeat.Text = "Repeat current song";
            this.checkBoxRepeat.UseVisualStyleBackColor = true;
            this.checkBoxRepeat.CheckStateChanged += new System.EventHandler(this.checkBoxRepeat_CheckStateChanged);
            // 
            // buttonNewPlaylist
            // 
            this.buttonNewPlaylist.Location = new System.Drawing.Point(26, 148);
            this.buttonNewPlaylist.Name = "buttonNewPlaylist";
            this.buttonNewPlaylist.Size = new System.Drawing.Size(70, 32);
            this.buttonNewPlaylist.TabIndex = 8;
            this.buttonNewPlaylist.Text = "New";
            this.buttonNewPlaylist.UseVisualStyleBackColor = true;
            this.buttonNewPlaylist.Click += new System.EventHandler(this.buttonNewPlaylist_Click);
            // 
            // buttonEditTags
            // 
            this.buttonEditTags.Location = new System.Drawing.Point(529, 197);
            this.buttonEditTags.Name = "buttonEditTags";
            this.buttonEditTags.Size = new System.Drawing.Size(117, 35);
            this.buttonEditTags.TabIndex = 9;
            this.buttonEditTags.Text = "Edit Song Info";
            this.buttonEditTags.UseVisualStyleBackColor = true;
            this.buttonEditTags.Click += new System.EventHandler(this.buttonEditTags_Click);
            // 
            // buttonSavePlaylist
            // 
            this.buttonSavePlaylist.Location = new System.Drawing.Point(115, 149);
            this.buttonSavePlaylist.Name = "buttonSavePlaylist";
            this.buttonSavePlaylist.Size = new System.Drawing.Size(70, 31);
            this.buttonSavePlaylist.TabIndex = 10;
            this.buttonSavePlaylist.Text = "Save";
            this.buttonSavePlaylist.UseVisualStyleBackColor = true;
            this.buttonSavePlaylist.Click += new System.EventHandler(this.buttonSavePlaylist_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(487, 144);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(159, 36);
            this.buttonSelect.TabIndex = 11;
            this.buttonSelect.Text = "Select a song...";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.UseWaitCursor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // listBoxPlaylist
            // 
            this.listBoxPlaylist.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxPlaylist.FormattingEnabled = true;
            this.listBoxPlaylist.ItemHeight = 25;
            this.listBoxPlaylist.Location = new System.Drawing.Point(26, 268);
            this.listBoxPlaylist.Name = "listBoxPlaylist";
            this.listBoxPlaylist.Size = new System.Drawing.Size(620, 204);
            this.listBoxPlaylist.TabIndex = 12;
            this.listBoxPlaylist.SelectedIndexChanged += new System.EventHandler(this.listBoxPlaylist_SelectedIndexChanged);
            // 
            // textBoxPlaylistName
            // 
            this.textBoxPlaylistName.Location = new System.Drawing.Point(26, 226);
            this.textBoxPlaylistName.Name = "textBoxPlaylistName";
            this.textBoxPlaylistName.Size = new System.Drawing.Size(233, 22);
            this.textBoxPlaylistName.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelPlaylistName
            // 
            this.labelPlaylistName.AutoSize = true;
            this.labelPlaylistName.Location = new System.Drawing.Point(85, 206);
            this.labelPlaylistName.Name = "labelPlaylistName";
            this.labelPlaylistName.Size = new System.Drawing.Size(93, 17);
            this.labelPlaylistName.TabIndex = 15;
            this.labelPlaylistName.Text = "Playlist Name";
            // 
            // buttonOpenPlaylist
            // 
            this.buttonOpenPlaylist.Location = new System.Drawing.Point(208, 149);
            this.buttonOpenPlaylist.Name = "buttonOpenPlaylist";
            this.buttonOpenPlaylist.Size = new System.Drawing.Size(70, 31);
            this.buttonOpenPlaylist.TabIndex = 17;
            this.buttonOpenPlaylist.Text = "Open";
            this.buttonOpenPlaylist.UseVisualStyleBackColor = true;
            this.buttonOpenPlaylist.Click += new System.EventHandler(this.buttonOpenPlaylist_Click);
            // 
            // trackBarPosition
            // 
            this.trackBarPosition.Location = new System.Drawing.Point(12, 12);
            this.trackBarPosition.Maximum = 1000;
            this.trackBarPosition.Name = "trackBarPosition";
            this.trackBarPosition.Size = new System.Drawing.Size(437, 56);
            this.trackBarPosition.TabIndex = 18;
            this.trackBarPosition.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarPosition.ValueChanged += new System.EventHandler(this.trackBarPosition_ValueChanged);
            this.trackBarPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBarPosition_MouseDown);
            this.trackBarPosition.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarPosition_MouseUp);
            // 
            // timerPosition
            // 
            this.timerPosition.Tick += new System.EventHandler(this.timerPosition_Tick);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(483, 12);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(38, 17);
            this.labelPosition.TabIndex = 19;
            this.labelPosition.Text = "label";
            // 
            // textBoxCurrentSongState
            // 
            this.textBoxCurrentSongState.Location = new System.Drawing.Point(281, 226);
            this.textBoxCurrentSongState.Name = "textBoxCurrentSongState";
            this.textBoxCurrentSongState.Size = new System.Drawing.Size(233, 22);
            this.textBoxCurrentSongState.TabIndex = 20;
            // 
            // labelCurrentSongState
            // 
            this.labelCurrentSongState.AutoSize = true;
            this.labelCurrentSongState.Location = new System.Drawing.Point(348, 206);
            this.labelCurrentSongState.Name = "labelCurrentSongState";
            this.labelCurrentSongState.Size = new System.Drawing.Size(92, 17);
            this.labelCurrentSongState.TabIndex = 22;
            this.labelCurrentSongState.Text = "Current Song";
            // 
            // menuItemAboutHelp
            // 
            this.menuItemAboutHelp.Index = 0;
            this.menuItemAboutHelp.Text = "Help";
            this.menuItemAboutHelp.Click += new System.EventHandler(this.menuItemAboutHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 484);
            this.Controls.Add(this.labelCurrentSongState);
            this.Controls.Add(this.textBoxCurrentSongState);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.trackBarPosition);
            this.Controls.Add(this.buttonOpenPlaylist);
            this.Controls.Add(this.labelPlaylistName);
            this.Controls.Add(this.textBoxPlaylistName);
            this.Controls.Add(this.listBoxPlaylist);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonSavePlaylist);
            this.Controls.Add(this.buttonEditTags);
            this.Controls.Add(this.buttonNewPlaylist);
            this.Controls.Add(this.checkBoxRepeat);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPlay);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Proiect IP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItemAbout;
        private System.Windows.Forms.CheckBox checkBoxRepeat;
        private System.Windows.Forms.Button buttonNewPlaylist;
        private System.Windows.Forms.Button buttonEditTags;
        private System.Windows.Forms.Button buttonSavePlaylist;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.ListBox listBoxPlaylist;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxPlaylistName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelPlaylistName;
        private System.Windows.Forms.Button buttonOpenPlaylist;
        private System.Windows.Forms.TrackBar trackBarPosition;
        private System.Windows.Forms.Timer timerPosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox textBoxCurrentSongState;
        private System.Windows.Forms.Label labelCurrentSongState;
        private System.Windows.Forms.MenuItem menuItemAboutHelp;
    }
}

