# AmazeBridge 🌉

<img width="1065" height="685" alt="image" src="https://github.com/user-attachments/assets/ba3440a5-e558-4e2a-8058-c489f48216ce" /> 

**AmazeBridge** is a powerful, single-file P2P tunneling and communication platform tailored for gamers and privacy enthusiasts. It creates a secure encrypted mesh network between peers, allowing for low-latency voice chat, file sharing, and **Game Tunneling** (LAN over Internet) without requiring administrator privileges or driver installation.

![License](https://img.shields.io/github/license/Adiru3/AmazeBridge) ![Platform](https://img.shields.io/badge/platform-Windows-blue) ![Size](https://img.shields.io/badge/size-Single%20EXE-success)

## 🚀 Features

### 🎮 Game Tunneling (Virtual LAN)
*   **Port Forwarding**: Map any TCP/UDP port from your local machine to a remote peer.
*   **Range Support**: Forward entire ranges (e.g., `27000-27050`) for complex games like Counter-Strike or ARK.
*   **No Drivers**: Uses User-Mode TCP/UDP proxying. No admin rights or TAP adapters required.

### 🗣️ Crystal Clear Voice & Chat
*   **High Quality Voice**: Low-latency Opus/MuLaw audio.
*   **Push-to-Talk (PTT)**: Global hotkey support (Default: **K**).
*   **Direct Calling**: Ring specific users with a dedicated call UI.
*   **Voice Messages**: Record and send voice clips directly in the chat.
*   **Private Messaging**: Encrypted PMs to any user in the room.

### 🛡️ Secure & Portable
*   **Zero Install**: A single `.exe` file.
*   **Clean System**: Automatically deploys dependencies (`WebView2`, `NAudio`) to `C:\ProgramData\AmazeBridge`, keeping your desktop clean.
*   **P2P Architecture**: UDP Hole Punching allows connection through most firewalls without manual port forwarding.
*   **Symmetric Relay**: Intelligent fallback for Strict NAT types.

---

## 📚 User Guide & Tutorial

### 1. Hosting a Room
1.  Run `AmazeBridge.exe`.
2.  Click **+ Create Host**.
3.  Set a **Password** for your room (e.g., `mypass123`).
4.  Wait for the status to change to **Host Mode**.
5.  **Share your IP** (displayed in the user list) with your friends.

### 2. Joining a Room
1.  Run `AmazeBridge.exe`.
2.  Click **-> Join Tunnel**.
3.  Enter the **Host's IP Address** (e.g., `192.168.1.5` or their Public IP).
4.  Enter the **Password**.
5.  Click **Join**. You will see the user list populate upon success.

### 3. Using Voice Chat
*   **Talk**: Hold **K** on your keyboard (even if the app is minimized) to speak.
*   **Call**: Right-click a user in the list and select **Call**. They will hear a ringtone and can Accept/Reject.
*   **Voice Note**: Click the Microphone icon in the chat bar to record a clip, click again to send.

### 4. 🎮 How to Play Games (Game Tunnel)
To play a LAN game with a friend (e.g., Minecraft, Terraria, CS 1.6):

**Scenario**: Your friend is hosting a **Minecraft** server on port `25565`.

1.  **Friend (Host)**: Runs the Minecraft Server.
2.  **You (Client)**:
    *   Click **Map Ports (Game)** (Blue Button).
    *   **Remote Peer IP**: Enter your friend's IP from the User List.
    *   **Ports**: Enter `25565`.
    *   Click **Add Rule**.
3.  **Connect**: Open Minecraft -> Multiplayer -> Direct Connect.
4.  **Server Address**: Enter `127.0.0.1:25565`.
5.  **Play!**: AmazeBridge routes the traffic securely to your friend.

---

### 🐧 Linux / Ubuntu
1.  Download the `AmazeBridge` file.
2.  Open Terminal.
3.  Make it executable:
    ```bash
    chmod +x AmazeBridge
    ```
4.  Run it:
    ```bash
    ./AmazeBridge
    ```

### 🍎 macOS
1.  Download `AmazeBridge.Mac.app.zip`.
2.  **Unpack**: Extract the downloaded `.zip` archive completely before proceeding. Do not run the app directly from the archive.
3.  **Permissions**: If the app fails to open, run this in Terminal:
    ```bash
    chmod +x AmazeBridge.Mac.app/Contents/MacOS/AmazeBridge.Mac
    ```
4.  **Launch**: Double-click [AmazeBridge.Mac](cci:7://file:///c:/Users/adiru/Desktop/AmazeBridge-mac/AmazeBridge.Mac.app/Contents/MacOS/AmazeBridge.Mac:0:0-0:0) app.
    *   *Note: If you see "Unidentified Developer", Right-Click -> Select "Open".*

## 🔗 Connect with me
[![YouTube](https://img.shields.io/badge/YouTube-@adiruaim-FF0000?style=for-the-badge&logo=youtube)](https://www.youtube.com/@adiruaim)
[![TikTok](https://img.shields.io/badge/TikTok-@adiruhs-000000?style=for-the-badge&logo=tiktok)](https://www.tiktok.com/@adiruhs)

### 💰 Legacy Crypto
* **BTC:** `bc1qflvetccw7vu59mq074hnvf03j02sjjf9t5dphl`
* **ETH:** `0xf35Afdf42C8bf1C3bF08862f573c2358461e697f`
* **Solana:** `5r2H3R2wXmA1JimpCypmoWLh8eGmdZA6VWjuit3AuBkq`
* **USDT (TRC20):** `TNgFjGzbGxztHDcSHx9DEPmQLxj2dWzozC`
* **USDT (TON):** `UQC5fsX4zON_FgW4I6iVrxVDtsVwrcOmqbjsYA4TrQh3aOvj`

### 🌍 Support Links
[![Donatello](https://img.shields.io/badge/Support-Donatello-orange?style=for-the-badge)](https://donatello.to/Adiru3)
[![Ko-fi](https://img.shields.io/badge/Ko--fi-Support-blue?style=for-the-badge&logo=kofi)](https://ko-fi.com/adiru)
[![Steam](https://img.shields.io/badge/Steam-Trade-blue?style=for-the-badge&logo=steam)](https://steamcommunity.com/tradeoffer/new/?partner=1124211419&token=2utLCl48)
