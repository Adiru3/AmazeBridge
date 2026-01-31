# AmazeBridge

AmazeBridge is a fully decentralized, peer-to-peer (P2P) messenger and collaboration tool built on pure C# .NET Framework 4.0. It operates without any central servers, using a UDP mesh network for communication and TCP bridging for tunneling services.

The application is designed as a single source file solution with zero external dependencies, compiling directly into a standalone executable.

## Features

### 🌐 Decentralized Networking
- **Serverless Architecture**: Uses a UDP-based mesh network where every participant acts as a node.
- **Resilient Rooms**: Rooms persist as long as at least one peer is online.
- **P2P Discovery**: Automatic peer discovery within the specified room context.

### 🔒 Security & Privacy
- **Encrypted Configuration**: Local `settings.json` is protected using XOR encryption with a fixed key.
- **Room Security**: Room access is protected via SHA256 password hashing.
- **Traffic Protection**: Chat and signaling packets are encrypted using room-specific keys.
- **Blacklist**: Built-in IP-based blocking system.
- **Contact Mode**: Option to accept messages only from trusted contacts.

### 🎙️ High-Performance Audio
- **Native Implementation**: Direct interaction with `winmm.dll` (WaveIn/WaveOut) for low-latency audio.
- **Voice Features**:
  - Push-to-Talk (Default: `Space`)
  - Voice Activity Controls (Mute/Deafen)
  - Individual Volume Control per peer

### 🚇 TCP Tunneling
- **Local Port Forwarding**: Expose local TCP services to other room members via P2P tunnels.
- **Secure Bridging**: Traffic is tunneled directly between peers.

### 🎨 Native UI (Glassmorphism)
- **Custom GDI+ Rendering**: A unique dark-themed interface with glass-like effects (`#0f172a` base).
- **No Browser Engine**: Pure WinForms implementation for minimal resource usage.
- **Localization**: Full support for English, Russian, Ukrainian, and Turkish.

## Installation

1. Download the latest release or compile from source.
2. Run `AmazeBridge.exe` as Administrator.
3. The application will automatically:
   - Install itself to `C:\Program Files\AmazeBridge\`.
   - Offer to create a Scheduled Task for auto-start on logon.

## Compilation

This project is designed to be compiled with the standard C# compiler included in Windows. No Visual Studio or NuGet packages are required.

**Requirements:**
- .NET Framework 4.0
- Windows OS

**Build Command:**
```powershell
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /target:winexe /out:AmazeBridge.exe /reference:System.Windows.Forms.dll /reference:System.Drawing.dll AmazeBridge.cs
```

## Usage

### Hotkeys
- **Push-to-Talk**: `Space` (Hold to speak)
- **Toggle Mute**: `M`

### Creating a Room
1. Click **Create** in the Rooms tab.
2. Enter a Room Name and Password.
3. Share the Room Name and Password with peers.

### Tunneling
1. In a room, navigate to the **Tunnel** tab.
2. Configure the **Host Port** (the service you want to share) and **Client Port** (where you want to access it).
3. Click **Enable**.

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
