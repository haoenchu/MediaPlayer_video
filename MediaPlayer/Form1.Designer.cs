namespace MediaPlayer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.wmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.lstPlaylist = new System.Windows.Forms.ListBox();
            this.picStop = new System.Windows.Forms.PictureBox();
            this.picPause = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.wmpVideo);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 639);
            this.panel2.TabIndex = 2;
            // 
            // wmpVideo
            // 
            this.wmpVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpVideo.Enabled = true;
            this.wmpVideo.Location = new System.Drawing.Point(0, 0);
            this.wmpVideo.Name = "wmpVideo";
            this.wmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideo.OcxState")));
            this.wmpVideo.Size = new System.Drawing.Size(1166, 639);
            this.wmpVideo.TabIndex = 0;
            this.wmpVideo.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picStop);
            this.panel1.Controls.Add(this.picPause);
            this.panel1.Controls.Add(this.picPlay);
            this.panel1.Controls.Add(this.btnBrowser);
            this.panel1.Location = new System.Drawing.Point(12, 648);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(1166, 92);
            this.panel1.TabIndex = 3;
            // 
            // btnBrowser
            // 
            this.btnBrowser.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowser.Cursor = System.Windows.Forms.Cursors.No;
            this.btnBrowser.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBrowser.Location = new System.Drawing.Point(3, 3);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBrowser.Size = new System.Drawing.Size(131, 86);
            this.btnBrowser.TabIndex = 0;
            this.btnBrowser.Text = "瀏覽";
            this.btnBrowser.UseVisualStyleBackColor = false;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // lstPlaylist
            // 
            this.lstPlaylist.BackColor = System.Drawing.Color.PapayaWhip;
            this.lstPlaylist.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstPlaylist.FormattingEnabled = true;
            this.lstPlaylist.HorizontalScrollbar = true;
            this.lstPlaylist.ItemHeight = 24;
            this.lstPlaylist.Location = new System.Drawing.Point(1201, 0);
            this.lstPlaylist.Name = "lstPlaylist";
            this.lstPlaylist.Size = new System.Drawing.Size(233, 752);
            this.lstPlaylist.TabIndex = 4;
            this.lstPlaylist.SelectedIndexChanged += new System.EventHandler(this.lstPlaylist_SelectedIndexChanged);
            this.lstPlaylist.DoubleClick += new System.EventHandler(this.lstPlaylist_DoubleClick);
            // 
            // picStop
            // 
            this.picStop.Image = global::MediaPlayer.Properties.Resources.stop;
            this.picStop.Location = new System.Drawing.Point(364, 7);
            this.picStop.Name = "picStop";
            this.picStop.Size = new System.Drawing.Size(71, 82);
            this.picStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picStop.TabIndex = 6;
            this.picStop.TabStop = false;
            this.picStop.Click += new System.EventHandler(this.picStop_Click);
            // 
            // picPause
            // 
            this.picPause.Image = global::MediaPlayer.Properties.Resources.pause;
            this.picPause.Location = new System.Drawing.Point(267, 6);
            this.picPause.Name = "picPause";
            this.picPause.Size = new System.Drawing.Size(67, 83);
            this.picPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPause.TabIndex = 5;
            this.picPause.TabStop = false;
            this.picPause.Click += new System.EventHandler(this.picPause_Click);
            // 
            // picPlay
            // 
            this.picPlay.Image = global::MediaPlayer.Properties.Resources.play;
            this.picPlay.Location = new System.Drawing.Point(171, 7);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(71, 82);
            this.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPlay.TabIndex = 4;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1434, 752);
            this.Controls.Add(this.lstPlaylist);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "多媒體播放器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private AxWMPLib.AxWindowsMediaPlayer wmpVideo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.ListBox lstPlaylist;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox picPause;
        private System.Windows.Forms.PictureBox picStop;
    }
}

