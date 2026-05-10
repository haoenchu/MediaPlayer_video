using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true; // 開啟多選功能
                                    // 設定過濾器，包含多種媒體格式
            ofd.Filter = "影片檔案|*.mp4;*.avi;*.wmv|所有檔案|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // 關鍵：不要執行 lstPlaylist.Items.Clear()，這樣就能累加

                foreach (string file in ofd.FileNames)
                {
                    // 選擇性功能：檢查清單中是否已經有這個檔案，避免重複加入
                    if (!lstPlaylist.Items.Contains(file))
                    {
                        lstPlaylist.Items.Add(file);
                    }
                }

                // 如果原本清單是空的，且現在有東西了，就自動播放剛加入的第一首
                if (lstPlaylist.SelectedIndex == -1 && lstPlaylist.Items.Count > 0)
                {
                    lstPlaylist.SelectedIndex = 0;
                    wmpVideo.URL = lstPlaylist.SelectedItem.ToString();
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.play(); // 播放
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.pause(); // 暫停
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.stop(); // 停止
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wmpVideo.uiMode = "none";
        }

        private void lstPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstPlaylist_DoubleClick(object sender, EventArgs e)
        {
            if (lstPlaylist.SelectedItem != null)
            {
                // 將播放器的 URL 設定為清單中選取的檔案路徑 [cite: 403]
                wmpVideo.URL = lstPlaylist.SelectedItem.ToString();
                wmpVideo.Ctlcontrols.play(); 
    }
        }

        private void picPlay_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.play(); // 播放
        }

        private void picPause_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.pause(); // 暫停
        }

        private void picStop_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.stop(); // 停止
        }
    }
}
