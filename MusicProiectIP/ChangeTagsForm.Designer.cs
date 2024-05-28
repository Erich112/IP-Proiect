
using System;

namespace MusicProiectIP
{
    partial class ChangeTagsForm
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
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAlbum = new System.Windows.Forms.TextBox();
            this.labelArtist = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(30, 46);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(38, 17);
            this.labelYear.TabIndex = 0;
            this.labelYear.Text = "Year";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(83, 46);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(76, 22);
            this.textBoxYear.TabIndex = 1;
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(82, 104);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(181, 22);
            this.textBoxArtist.TabIndex = 2;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(83, 157);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(180, 22);
            this.textBoxTitle.TabIndex = 3;
            // 
            // textBoxAlbum
            // 
            this.textBoxAlbum.Location = new System.Drawing.Point(83, 213);
            this.textBoxAlbum.Name = "textBoxAlbum";
            this.textBoxAlbum.Size = new System.Drawing.Size(180, 22);
            this.textBoxAlbum.TabIndex = 4;
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Location = new System.Drawing.Point(30, 104);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(40, 17);
            this.labelArtist.TabIndex = 5;
            this.labelArtist.Text = "Artist";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(30, 162);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(35, 17);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Title";
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(30, 213);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(47, 17);
            this.labelAlbum.TabIndex = 7;
            this.labelAlbum.Text = "Album";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(30, 264);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(48, 17);
            this.labelGenre.TabIndex = 8;
            this.labelGenre.Text = "Genre";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(249, 298);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 13;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(82, 264);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(100, 22);
            this.textBoxGenre.TabIndex = 14;
            // 
            // ChangeTagsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 339);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelArtist);
            this.Controls.Add(this.textBoxAlbum);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxArtist);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelYear);
            this.Name = "ChangeTagsForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAlbum;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxGenre;
    }
}