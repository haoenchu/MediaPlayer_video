# 🎬 BeePlayer - 多功能媒體播放器 (Media Edition)

這是一個基於 **C# Windows Forms** 開發的高彈性影音播放器。本專案透過整合 `AxWMPLib` (Windows Media Player ActiveX) 組件，實現了自定義介面與動態播放清單功能。
<img width="800" height="400" alt="image" src="https://github.com/user-attachments/assets/145e669d-2466-49b4-ae4b-6fea15eee79f" />


## 🌟 特別功能

### 1. 智慧播放清單 (Cumulative Playlist)
* **多選載入 (Multiselect)**：支援一次選取多個影音檔案並同步加入清單。
* **累加逻辑**：新加入的檔案會自動追加至 `lstPlaylist` 末端，且具備 `Contains` 檢查機制，防止重複加入相同的檔案路徑。
* **快速切換**：支援雙擊清單項目立即切換影片，並具備自動初始化播放功能（當清單為空時自動載入首位）。


---
## 📖 使用說明

1. **瀏覽與加入**：點擊 `btnBrowser` 並選取影片。清單會自動記錄檔案的完整路徑。
2. **切換影片**：在 `lstPlaylist` (清單框) 上連點兩下左鍵，播放器會立即更新內容並開始播放。
3. **控制控制**：
    * 點擊下方的 **播放**、**暫停** 或 **停止** 圖片/按鈕。
    * 影片會顯示在中央的播放視窗中，且不會出現多餘的銀色控制列。

---

## ⌨️ 關鍵程式碼段落：播放清單累加邏輯

```csharp
foreach (string file in ofd.FileNames)
{
    // 檢查清單中是否已經有這個檔案，避免重複加入
    if (!lstPlaylist.Items.Contains(file))
    {
        lstPlaylist.Items.Add(file);
    }
}

// 雙擊清單播放
wmpVideo.URL = lstPlaylist.SelectedItem.ToString();
wmpVideo.Ctlcontrols.play();
