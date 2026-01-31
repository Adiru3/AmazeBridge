
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public static class Localization
{
    public static readonly Dictionary<string, Dictionary<string, string>> Table = Build();

    private static Dictionary<string, Dictionary<string, string>> Build()
    {
        Dictionary<string, Dictionary<string, string>> loc = new Dictionary<string, Dictionary<string, string>>();

        Dictionary<string, string> ru = new Dictionary<string, string>();
        ru["rooms"] = "Комнаты";
        ru["contacts"] = "Контакты";
        ru["create_room"] = "Создать";
        ru["join_room"] = "Войти";
        ru["chat"] = "Чат";
        ru["send"] = "Отправить";
        ru["profile"] = "Профиль";
        ru["name"] = "Имя";
        ru["language"] = "Язык";
        ru["save"] = "Сохранить";
        ru["contacts_only"] = "Только контакты";
        ru["audio"] = "Аудио";
        ru["start_call"] = "Старт";
        ru["stop_call"] = "Стоп";
        ru["mute"] = "Mute";
        ru["deafen"] = "Deafen";
        ru["hotkeys"] = "Горячие клавиши";
        ru["key"] = "Клавиша";
        ru["ptt"] = "PTT: удерживай {0}";
        ru["tunnel"] = "Туннель";
        ru["tunnel_port"] = "Локальный порт";
        ru["client_listen_port"] = "Порт клиента";
        ru["enable"] = "Включить";
        ru["set"] = "Применить";
        ru["peers"] = "Участники";
        ru["volume"] = "Громкость";
        ru["blacklist"] = "Черный список";
        ru["add"] = "Добавить";
        ru["remove"] = "Удалить";
        ru["create_room_title"] = "Создать комнату";
        ru["room_name"] = "Название";
        ru["room_password"] = "Пароль";
        ru["join_room_title"] = "Войти в комнату";
        ru["room_id"] = "RoomId (GUID)";
        ru["invalid_roomid"] = "Неверный RoomId";
        ru["user_id"] = "UserId";
        ru["avatar_base64"] = "AvatarBase64";
        ru["room_broadcast"] = "(Комната)";
        ru["scheduler_prompt"] = "Добавить AmazeBridge в Планировщик задач (автозапуск от администратора при входе)?";
        ru["app_title"] = "AmazeBridge";

        Dictionary<string, string> en = new Dictionary<string, string>();
        en["rooms"] = "Rooms";
        en["contacts"] = "Contacts";
        en["create_room"] = "Create";
        en["join_room"] = "Join";
        en["chat"] = "Chat";
        en["send"] = "Send";
        en["profile"] = "Profile";
        en["name"] = "Name";
        en["language"] = "Language";
        en["save"] = "Save";
        en["contacts_only"] = "Contacts only";
        en["audio"] = "Audio";
        en["start_call"] = "Start";
        en["stop_call"] = "Stop";
        en["mute"] = "Mute";
        en["deafen"] = "Deafen";
        en["hotkeys"] = "Hotkeys";
        en["key"] = "Key";
        en["ptt"] = "PTT: hold {0}";
        en["tunnel"] = "Tunnel";
        en["tunnel_port"] = "Host port";
        en["client_listen_port"] = "Client port";
        en["enable"] = "Enable";
        en["set"] = "Apply";
        en["peers"] = "Peers";
        en["volume"] = "Volume";
        en["blacklist"] = "Blacklist";
        en["add"] = "Add";
        en["remove"] = "Remove";
        en["create_room_title"] = "Create room";
        en["room_name"] = "Name";
        en["room_password"] = "Password";
        en["join_room_title"] = "Join room";
        en["room_id"] = "RoomId (GUID)";
        en["invalid_roomid"] = "Invalid RoomId";
        en["user_id"] = "UserId";
        en["avatar_base64"] = "AvatarBase64";
        en["room_broadcast"] = "(Room)";
        en["scheduler_prompt"] = "Add AmazeBridge to Task Scheduler (auto-start as admin on logon)?";
        en["app_title"] = "AmazeBridge";

        Dictionary<string, string> ua = new Dictionary<string, string>();
        ua["rooms"] = "Кімнати";
        ua["contacts"] = "Контакти";
        ua["create_room"] = "Створити";
        ua["join_room"] = "Увійти";
        ua["chat"] = "Чат";
        ua["send"] = "Надіслати";
        ua["profile"] = "Профіль";
        ua["name"] = "Ім'я";
        ua["language"] = "Мова";
        ua["save"] = "Зберегти";
        ua["contacts_only"] = "Лише контакти";
        ua["audio"] = "Аудіо";
        ua["start_call"] = "Старт";
        ua["stop_call"] = "Стоп";
        ua["mute"] = "Mute";
        ua["deafen"] = "Deafen";
        ua["hotkeys"] = "Гарячі клавіші";
        ua["key"] = "Клавіша";
        ua["ptt"] = "PTT: тримай {0}";
        ua["tunnel"] = "Тунель";
        ua["tunnel_port"] = "Порт хоста";
        ua["client_listen_port"] = "Порт клієнта";
        ua["enable"] = "Увімкнути";
        ua["set"] = "Застосувати";
        ua["peers"] = "Учасники";
        ua["volume"] = "Гучність";
        ua["blacklist"] = "Чорний список";
        ua["add"] = "Додати";
        ua["remove"] = "Видалити";
        ua["create_room_title"] = "Створити кімнату";
        ua["room_name"] = "Назва";
        ua["room_password"] = "Пароль";
        ua["join_room_title"] = "Увійти в кімнату";
        ua["room_id"] = "RoomId (GUID)";
        ua["invalid_roomid"] = "Невірний RoomId";
        ua["user_id"] = "UserId";
        ua["avatar_base64"] = "AvatarBase64";
        ua["room_broadcast"] = "(Кімната)";
        ua["scheduler_prompt"] = "Додати AmazeBridge до Планувальника задач (автозапуск від адміністратора при вході)?";
        ua["app_title"] = "AmazeBridge";

        Dictionary<string, string> tr = new Dictionary<string, string>();
        tr["rooms"] = "Odalar";
        tr["contacts"] = "Kişiler";
        tr["create_room"] = "Oluştur";
        tr["join_room"] = "Katıl";
        tr["chat"] = "Sohbet";
        tr["send"] = "Gönder";
        tr["profile"] = "Profil";
        tr["name"] = "İsim";
        tr["language"] = "Dil";
        tr["save"] = "Kaydet";
        tr["contacts_only"] = "Sadece kişiler";
        tr["audio"] = "Ses";
        tr["start_call"] = "Başlat";
        tr["stop_call"] = "Durdur";
        tr["mute"] = "Mute";
        tr["deafen"] = "Deafen";
        tr["hotkeys"] = "Kısayol tuşları";
        tr["key"] = "Tuş";
        tr["ptt"] = "PTT: {0} basılı tut";
        tr["tunnel"] = "Tünel";
        tr["tunnel_port"] = "Host port";
        tr["client_listen_port"] = "İstemci port";
        tr["enable"] = "Etkinleştir";
        tr["set"] = "Uygula";
        tr["peers"] = "Katılımcılar";
        tr["volume"] = "Ses";
        tr["blacklist"] = "Kara liste";
        tr["add"] = "Ekle";
        tr["remove"] = "Sil";
        tr["create_room_title"] = "Oda oluştur";
        tr["room_name"] = "Ad";
        tr["room_password"] = "Şifre";
        tr["join_room_title"] = "Odaya katıl";
        tr["room_id"] = "RoomId (GUID)";
        tr["invalid_roomid"] = "Geçersiz RoomId";
        tr["user_id"] = "UserId";
        tr["avatar_base64"] = "AvatarBase64";
        tr["room_broadcast"] = "(Oda)";
        tr["scheduler_prompt"] = "AmazeBridge Task Scheduler'a eklensin mi (admin olarak otomatik başlat)?";
        tr["app_title"] = "AmazeBridge";

        loc["ru"] = ru;
        loc["en"] = en;
        loc["ua"] = ua;
        loc["tr"] = tr;
        return loc;
    }

    public static string T(string lang, string key)
    {
        if (string.IsNullOrEmpty(lang)) lang = "en";
        Dictionary<string, string> d;
        if (!Table.TryGetValue(lang, out d))
        {
            d = Table["en"];
        }
        string v;
        if (d.TryGetValue(key, out v))
        {
            return v;
        }
        return key;
    }
}

public class AmazeBridge
{
    [STAThread]
    public static void Main(string[] args)
    {
        try
        {
            EnsureAdmin();

            SettingsProvider settingsProvider = new SettingsProvider();
            SettingsProvider.Settings settings = settingsProvider.Load();

            string installedPath = EnsureInstalled(settings.Language);
            if (!string.Equals(installedPath, Application.ExecutablePath, StringComparison.OrdinalIgnoreCase))
            {
                RestartFrom(installedPath, true);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (string.IsNullOrEmpty(settings.UserId))
            {
                settings.UserId = Guid.NewGuid().ToString("D");
                settingsProvider.Save(settings);
            }
            if (string.IsNullOrEmpty(settings.DisplayName))
            {
                settings.DisplayName = Environment.UserName;
                settingsProvider.Save(settings);
            }

            RoomManager roomManager = new RoomManager(settingsProvider, settings);
            NetworkEngine network = new NetworkEngine(settingsProvider, settings, roomManager);
            AudioHandler audio = new AudioHandler(settingsProvider, settings, network, roomManager);

            using (MainForm form = new MainForm(settingsProvider, settings, roomManager, network, audio))
            {
                Application.Run(form);
            }
        }
        catch (Exception ex)
        {
            try
            {
                MessageBox.Show(ex.ToString(), "AmazeBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
            }
        }
    }

    private static bool IsAdmin()
    {
        try
        {
            System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
            System.Security.Principal.WindowsPrincipal principal = new System.Security.Principal.WindowsPrincipal(identity);
            return principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
        }
        catch
        {
            return false;
        }
    }

    private static void EnsureAdmin()
    {
        if (IsAdmin())
        {
            return;
        }

        try
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = Application.ExecutablePath;
            psi.UseShellExecute = true;
            psi.Verb = "runas";
            Process.Start(psi);
        }
        catch
        {
        }
        Environment.Exit(0);
    }

    private static void RestartFrom(string exePath, bool asAdmin)
    {
        try
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = exePath;
            psi.UseShellExecute = true;
            if (asAdmin)
            {
                psi.Verb = "runas";
            }
            Process.Start(psi);
        }
        catch
        {
        }
        Environment.Exit(0);
    }

    private static string EnsureInstalled(string lang)
    {
        string targetDir = "C:\\Program Files\\AmazeBridge";
        string targetExe = Path.Combine(targetDir, "AmazeBridge.exe");

        try
        {
            string current = Application.ExecutablePath;
            string currentDir = Path.GetDirectoryName(current);
            if (currentDir == null)
            {
                return current;
            }

            if (string.Equals(Path.GetFullPath(currentDir).TrimEnd('\\'), Path.GetFullPath(targetDir).TrimEnd('\\'), StringComparison.OrdinalIgnoreCase))
            {
                return current;
            }

            try
            {
                if (!Directory.Exists(targetDir))
                {
                    Directory.CreateDirectory(targetDir);
                }
            }
            catch
            {
            }

            try
            {
                File.Copy(current, targetExe, true);
            }
            catch
            {
                return current;
            }

            try
            {
                DialogResult dr = MessageBox.Show(
                    Localization.T(lang, "scheduler_prompt"),
                    Localization.T(lang, "app_title"),
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    TryCreateScheduledTask(targetExe);
                }
            }
            catch
            {
            }

            return targetExe;
        }
        catch
        {
            return Application.ExecutablePath;
        }
    }

    private static void TryCreateScheduledTask(string exePath)
    {
        try
        {
            string taskName = "AmazeBridge";
            string tr = "\"" + exePath + "\"";

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "schtasks.exe";
            psi.Arguments = string.Format("/Create /TN \"{0}\" /TR {1} /SC ONLOGON /RL HIGHEST /F", taskName, tr);
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process p = Process.Start(psi);
            if (p != null)
            {
                p.WaitForExit(5000);
            }
        }
        catch
        {
        }
    }
}

public class SettingsProvider
{
    [DataContract]
    public class Settings
    {
        [DataMember] public string Language;
        [DataMember] public string UserId;
        [DataMember] public string DisplayName;
        [DataMember] public string AvatarBase64;
        [DataMember] public bool AcceptContactsOnly;
        [DataMember] public List<Contact> Contacts;
        [DataMember] public List<string> Blacklist;
        [DataMember] public List<RoomEntry> Rooms;
        [DataMember] public int UdpPort;
        [DataMember] public string PttKey;
        [DataMember] public string MuteToggleKey;

        public Settings()
        {
            Language = "ru";
            UserId = "";
            DisplayName = "";
            AvatarBase64 = "";
            AcceptContactsOnly = false;
            Contacts = new List<Contact>();
            Blacklist = new List<string>();
            Rooms = new List<RoomEntry>();
            UdpPort = 42424;
            PttKey = "Space";
            MuteToggleKey = "M";
        }
    }

    [DataContract]
    public class Contact
    {
        [DataMember] public string UserId;
        [DataMember] public string DisplayName;
        [DataMember] public string AvatarBase64;

        public Contact()
        {
            UserId = "";
            DisplayName = "";
            AvatarBase64 = "";
        }
    }

    [DataContract]
    public class RoomEntry
    {
        [DataMember] public string RoomId;
        [DataMember] public string Name;
        [DataMember] public string PasswordHash;
        [DataMember] public bool AutoJoin;
        [DataMember] public int TunnelPort;

        public RoomEntry()
        {
            RoomId = "";
            Name = "";
            PasswordHash = "";
            AutoJoin = false;
            TunnelPort = 0;
        }
    }

    private static byte[] FixedXorKey = Encoding.UTF8.GetBytes("AmazeBridge.Fixed.Settings.Key.v1");

    public string GetSettingsPath()
    {
        string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AmazeBridge");
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
        return Path.Combine(dir, "settings.json");
    }

    public Settings Load()
    {
        string path = GetSettingsPath();
        if (!File.Exists(path))
        {
            return new Settings();
        }

        try
        {
            byte[] raw = File.ReadAllBytes(path);
            byte[] jsonBytes = Xor(raw, FixedXorKey);
            using (MemoryStream ms = new MemoryStream(jsonBytes))
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Settings));
                object obj = ser.ReadObject(ms);
                Settings s = obj as Settings;
                if (s == null)
                {
                    return new Settings();
                }
                if (s.Contacts == null) s.Contacts = new List<Contact>();
                if (s.Blacklist == null) s.Blacklist = new List<string>();
                if (s.Rooms == null) s.Rooms = new List<RoomEntry>();
                if (s.UdpPort <= 0) s.UdpPort = 42424;
                if (string.IsNullOrEmpty(s.Language)) s.Language = "ru";
            if (string.IsNullOrEmpty(s.PttKey)) s.PttKey = "Space";
            if (string.IsNullOrEmpty(s.MuteToggleKey)) s.MuteToggleKey = "M";
                return s;
            }
        }
        catch
        {
            return new Settings();
        }
    }

    public void Save(Settings settings)
    {
        string path = GetSettingsPath();
        try
        {
            using (MemoryStream ms = new MemoryStream())
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Settings));
                ser.WriteObject(ms, settings);
                byte[] jsonBytes = ms.ToArray();
                byte[] enc = Xor(jsonBytes, FixedXorKey);
                File.WriteAllBytes(path, enc);
            }
        }
        catch
        {
        }
    }

    public static byte[] Xor(byte[] data, byte[] key)
    {
        if (data == null) return new byte[0];
        if (key == null || key.Length == 0) return data;
        byte[] outBytes = new byte[data.Length];
        int ki = 0;
        for (int i = 0; i < data.Length; i++)
        {
            outBytes[i] = (byte)(data[i] ^ key[ki]);
            ki++;
            if (ki >= key.Length) ki = 0;
        }
        return outBytes;
    }
}

public class RoomManager
{
    public class Room
    {
        public Guid RoomId;
        public string Name;
        public string PasswordHash;
        public byte[] RoomKey;
        public int TunnelPort;
        public Dictionary<string, Peer> Peers;
        public List<ChatMessage> Chat;

        public Room()
        {
            RoomId = Guid.Empty;
            Name = "";
            PasswordHash = "";
            RoomKey = new byte[0];
            TunnelPort = 0;
            Peers = new Dictionary<string, Peer>();
            Chat = new List<ChatMessage>();
        }
    }

    public class Peer
    {
        public string UserId;
        public string DisplayName;
        public IPEndPoint EndPoint;
        public DateTime LastSeenUtc;
        public float Volume;
        public bool Muted;

        public Peer()
        {
            UserId = "";
            DisplayName = "";
            EndPoint = null;
            LastSeenUtc = DateTime.MinValue;
            Volume = 1.0f;
            Muted = false;
        }
    }

    public class ChatMessage
    {
        public DateTime Utc;
        public string UserId;
        public string DisplayName;
        public string Text;

        public ChatMessage()
        {
            Utc = DateTime.UtcNow;
            UserId = "";
            DisplayName = "";
            Text = "";
        }
    }

    private readonly SettingsProvider _settingsProvider;
    private SettingsProvider.Settings _settings;
    private readonly object _sync = new object();
    private readonly Dictionary<Guid, Room> _rooms = new Dictionary<Guid, Room>();
    private Guid _activeRoomId = Guid.Empty;

    public event Action RoomsChanged;
    public event Action<Guid> RoomUpdated;

    public RoomManager(SettingsProvider settingsProvider, SettingsProvider.Settings settings)
    {
        _settingsProvider = settingsProvider;
        _settings = settings;

        for (int i = 0; i < _settings.Rooms.Count; i++)
        {
            SettingsProvider.RoomEntry re = _settings.Rooms[i];
            Guid id;
            if (Guid.TryParse(re.RoomId, out id))
            {
                Room r = new Room();
                r.RoomId = id;
                r.Name = re.Name;
                r.PasswordHash = re.PasswordHash;
                r.RoomKey = DeriveRoomKey(id, re.PasswordHash);
                r.TunnelPort = re.TunnelPort;
                _rooms[id] = r;
                if (_activeRoomId == Guid.Empty && re.AutoJoin)
                {
                    _activeRoomId = id;
                }
            }
        }
    }

    public SettingsProvider.Settings GetSettings()
    {
        return _settings;
    }

    public Guid GetActiveRoomId()
    {
        lock (_sync)
        {
            return _activeRoomId;
        }
    }

    public void SetActiveRoom(Guid roomId)
    {
        bool changed = false;
        lock (_sync)
        {
            if (_activeRoomId != roomId)
            {
                _activeRoomId = roomId;
                changed = true;
            }
        }
        if (changed && RoomsChanged != null)
        {
            RoomsChanged();
        }
    }

    public List<Room> GetRoomsSnapshot()
    {
        List<Room> list = new List<Room>();
        lock (_sync)
        {
            foreach (KeyValuePair<Guid, Room> kv in _rooms)
            {
                list.Add(CloneRoomShallow(kv.Value));
            }
        }
        return list;
    }

    public Room GetRoom(Guid roomId)
    {
        lock (_sync)
        {
            Room r;
            if (_rooms.TryGetValue(roomId, out r))
            {
                return r;
            }
            return null;
        }
    }

    public byte[] GetRoomKey(Guid roomId)
    {
        lock (_sync)
        {
            Room r;
            if (_rooms.TryGetValue(roomId, out r))
            {
                return r.RoomKey;
            }
            return new byte[0];
        }
    }

    public string GetRoomPasswordHash(Guid roomId)
    {
        lock (_sync)
        {
            Room r;
            if (_rooms.TryGetValue(roomId, out r))
            {
                return r.PasswordHash;
            }
            return "";
        }
    }

    public Room CreateRoom(string name, string password)
    {
        Guid id = Guid.NewGuid();
        string passHash = Sha256Hex(password);
        Room room = new Room();
        room.RoomId = id;
        room.Name = name;
        room.PasswordHash = passHash;
        room.RoomKey = DeriveRoomKey(id, passHash);
        room.TunnelPort = 0;

        lock (_sync)
        {
            _rooms[id] = room;
            _activeRoomId = id;
        }

        SettingsProvider.RoomEntry re = new SettingsProvider.RoomEntry();
        re.RoomId = id.ToString("D");
        re.Name = name;
        re.PasswordHash = passHash;
        re.AutoJoin = true;
        re.TunnelPort = 0;

        lock (_sync)
        {
            for (int i = 0; i < _settings.Rooms.Count; i++)
            {
                _settings.Rooms[i].AutoJoin = false;
            }
            _settings.Rooms.Add(re);
            _settingsProvider.Save(_settings);
        }

        if (RoomsChanged != null)
        {
            RoomsChanged();
        }
        return room;
    }

    public Room JoinRoom(string name, string password, Guid roomId)
    {
        string passHash = Sha256Hex(password);
        Room room = new Room();
        room.RoomId = roomId;
        room.Name = name;
        room.PasswordHash = passHash;
        room.RoomKey = DeriveRoomKey(roomId, passHash);

        lock (_sync)
        {
            _rooms[roomId] = room;
            _activeRoomId = roomId;
        }

        SettingsProvider.RoomEntry re = new SettingsProvider.RoomEntry();
        re.RoomId = roomId.ToString("D");
        re.Name = name;
        re.PasswordHash = passHash;
        re.AutoJoin = true;
        re.TunnelPort = 0;

        lock (_sync)
        {
            for (int i = 0; i < _settings.Rooms.Count; i++)
            {
                _settings.Rooms[i].AutoJoin = false;
            }
            bool exists = false;
            for (int i = 0; i < _settings.Rooms.Count; i++)
            {
                if (string.Equals(_settings.Rooms[i].RoomId, re.RoomId, StringComparison.OrdinalIgnoreCase))
                {
                    _settings.Rooms[i] = re;
                    exists = true;
                    break;
                }
            }
            if (!exists)
            {
                _settings.Rooms.Add(re);
            }
            _settingsProvider.Save(_settings);
        }

        if (RoomsChanged != null)
        {
            RoomsChanged();
        }
        return room;
    }

    public void AddOrUpdatePeer(Guid roomId, string userId, string displayName, IPEndPoint ep)
    {
        lock (_sync)
        {
            Room room;
            if (!_rooms.TryGetValue(roomId, out room))
            {
                return;
            }

            Peer peer;
            if (!room.Peers.TryGetValue(userId, out peer))
            {
                peer = new Peer();
                peer.UserId = userId;
                peer.DisplayName = displayName;
                peer.EndPoint = ep;
                peer.LastSeenUtc = DateTime.UtcNow;
                peer.Volume = 1.0f;
                room.Peers[userId] = peer;
            }
            else
            {
                peer.DisplayName = displayName;
                peer.EndPoint = ep;
                peer.LastSeenUtc = DateTime.UtcNow;
            }
        }

        if (RoomUpdated != null)
        {
            RoomUpdated(roomId);
        }
    }

    public List<Peer> GetPeersSnapshot(Guid roomId)
    {
        lock (_sync)
        {
            Room room;
            if (!_rooms.TryGetValue(roomId, out room))
            {
                return new List<Peer>();
            }
            List<Peer> list = new List<Peer>();
            foreach (KeyValuePair<string, Peer> kv in room.Peers)
            {
                Peer p = kv.Value;
                Peer np = new Peer();
                np.UserId = p.UserId;
                np.DisplayName = p.DisplayName;
                np.EndPoint = p.EndPoint;
                np.LastSeenUtc = p.LastSeenUtc;
                np.Volume = p.Volume;
                np.Muted = p.Muted;
                list.Add(np);
            }
            return list;
        }
    }

    public void SetPeerVolume(Guid roomId, string userId, float volume)
    {
        if (userId == null) return;
        if (volume < 0.0f) volume = 0.0f;
        if (volume > 2.0f) volume = 2.0f;
        lock (_sync)
        {
            Room room;
            if (!_rooms.TryGetValue(roomId, out room))
            {
                return;
            }
            Peer p;
            if (room.Peers.TryGetValue(userId, out p))
            {
                p.Volume = volume;
            }
        }
        if (RoomUpdated != null)
        {
            RoomUpdated(roomId);
        }
    }

    public void SetPeerMuted(Guid roomId, string userId, bool muted)
    {
        if (userId == null) return;
        lock (_sync)
        {
            Room room;
            if (!_rooms.TryGetValue(roomId, out room))
            {
                return;
            }
            Peer p;
            if (room.Peers.TryGetValue(userId, out p))
            {
                p.Muted = muted;
            }
        }
        if (RoomUpdated != null)
        {
            RoomUpdated(roomId);
        }
    }

    public bool TryGetPeer(Guid roomId, string userId, out Peer peer)
    {
        peer = null;
        if (userId == null) return false;
        lock (_sync)
        {
            Room room;
            if (!_rooms.TryGetValue(roomId, out room))
            {
                return false;
            }
            Peer p;
            if (!room.Peers.TryGetValue(userId, out p))
            {
                return false;
            }
            peer = p;
            return true;
        }
    }

    public IPEndPoint GetPeerEndpoint(Guid roomId, string userId)
    {
        Peer p;
        if (TryGetPeer(roomId, userId, out p))
        {
            return p.EndPoint;
        }
        return null;
    }

    public void AddChat(Guid roomId, string userId, string displayName, string text)
    {
        lock (_sync)
        {
            Room room;
            if (!_rooms.TryGetValue(roomId, out room))
            {
                return;
            }
            ChatMessage m = new ChatMessage();
            m.Utc = DateTime.UtcNow;
            m.UserId = userId;
            m.DisplayName = displayName;
            m.Text = text;
            room.Chat.Add(m);
            if (room.Chat.Count > 500)
            {
                room.Chat.RemoveAt(0);
            }
        }

        if (RoomUpdated != null)
        {
            RoomUpdated(roomId);
        }
    }

    public List<ChatMessage> GetChatSnapshot(Guid roomId)
    {
        lock (_sync)
        {
            Room room;
            if (!_rooms.TryGetValue(roomId, out room))
            {
                return new List<ChatMessage>();
            }
            return new List<ChatMessage>(room.Chat);
        }
    }

    public void SetTunnelPort(Guid roomId, int port)
    {
        lock (_sync)
        {
            Room room;
            if (_rooms.TryGetValue(roomId, out room))
            {
                room.TunnelPort = port;
            }
            for (int i = 0; i < _settings.Rooms.Count; i++)
            {
                Guid id;
                if (Guid.TryParse(_settings.Rooms[i].RoomId, out id) && id == roomId)
                {
                    _settings.Rooms[i].TunnelPort = port;
                    break;
                }
            }
            _settingsProvider.Save(_settings);
        }
        if (RoomUpdated != null)
        {
            RoomUpdated(roomId);
        }
    }

    public static string Sha256Hex(string s)
    {
        if (s == null) s = "";
        byte[] bytes = Encoding.UTF8.GetBytes(s);
        using (SHA256 sha = SHA256.Create())
        {
            byte[] hash = sha.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder(hash.Length * 2);
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }

    private static byte[] DeriveRoomKey(Guid roomId, string passwordHash)
    {
        byte[] a = roomId.ToByteArray();
        byte[] b = Encoding.UTF8.GetBytes(passwordHash ?? "");
        byte[] all = new byte[a.Length + b.Length];
        Buffer.BlockCopy(a, 0, all, 0, a.Length);
        Buffer.BlockCopy(b, 0, all, a.Length, b.Length);
        using (SHA256 sha = SHA256.Create())
        {
            return sha.ComputeHash(all);
        }
    }

    private static Room CloneRoomShallow(Room r)
    {
        Room c = new Room();
        c.RoomId = r.RoomId;
        c.Name = r.Name;
        c.PasswordHash = r.PasswordHash;
        c.RoomKey = r.RoomKey;
        c.TunnelPort = r.TunnelPort;
        foreach (KeyValuePair<string, Peer> kv in r.Peers)
        {
            Peer p = kv.Value;
            Peer np = new Peer();
            np.UserId = p.UserId;
            np.DisplayName = p.DisplayName;
            np.EndPoint = p.EndPoint;
            np.LastSeenUtc = p.LastSeenUtc;
            np.Volume = p.Volume;
            np.Muted = p.Muted;
            c.Peers[np.UserId] = np;
        }
        c.Chat = new List<ChatMessage>(r.Chat);
        return c;
    }
}

public class NetworkEngine
{
    public enum PacketType : byte
    {
        DISCOVERY = 1,
        DISCOVERY_ACK = 2,
        CHAT = 3,
        AUDIO = 4,
        TUNNEL_ADVERTISE = 5,
        TUNNEL_DATA = 6,
        TUNNEL_OPEN = 7,
        TUNNEL_CLOSE = 8
    }

    private const ushort Magic = 0x4241;
    private const byte Version = 1;

    private readonly SettingsProvider _settingsProvider;
    private SettingsProvider.Settings _settings;
    private readonly RoomManager _rooms;

    private UdpClient _udp;
    private IPEndPoint _any;
    private Thread _rxThread;
    private Thread _txThread;
    private volatile bool _running;

    private readonly Queue<Action> _txQueue = new Queue<Action>();
    private readonly object _txSync = new object();
    private readonly Dictionary<Guid, TunnelHost> _tunnels = new Dictionary<Guid, TunnelHost>();
    private readonly Dictionary<Guid, TunnelClientProxy> _tunnelClients = new Dictionary<Guid, TunnelClientProxy>();
    private readonly Dictionary<Guid, IPEndPoint> _tunnelHostByRoom = new Dictionary<Guid, IPEndPoint>();
    private readonly Dictionary<Guid, int> _tunnelHostPortByRoom = new Dictionary<Guid, int>();

    public event Action<string> Log;

    public NetworkEngine(SettingsProvider settingsProvider, SettingsProvider.Settings settings, RoomManager rooms)
    {
        _settingsProvider = settingsProvider;
        _settings = settings;
        _rooms = rooms;
        _any = new IPEndPoint(IPAddress.Any, 0);

        Start();
    }

    public void Dispose()
    {
        Stop();
    }

    public void Start()
    {
        if (_running) return;
        _running = true;

        try
        {
            _udp = new UdpClient();
            _udp.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            _udp.Client.Bind(new IPEndPoint(IPAddress.Any, _settings.UdpPort));
            _udp.EnableBroadcast = true;
        }
        catch (Exception ex)
        {
            RaiseLog("UDP bind failed: " + ex.Message);
            _running = false;
            return;
        }

        _rxThread = new Thread(RxLoop);
        _rxThread.IsBackground = true;
        _rxThread.Start();

        _txThread = new Thread(TxLoop);
        _txThread.IsBackground = true;
        _txThread.Start();

        Thread discovery = new Thread(DiscoveryLoop);
        discovery.IsBackground = true;
        discovery.Start();
    }

    public void Stop()
    {
        _running = false;
        try
        {
            if (_udp != null)
            {
                _udp.Close();
            }
        }
        catch
        {
        }
    }

    private void RaiseLog(string s)
    {
        if (Log != null)
        {
            Log(s);
        }
    }

    private void EnqueueTx(Action a)
    {
        lock (_txSync)
        {
            _txQueue.Enqueue(a);
            Monitor.PulseAll(_txSync);
        }
    }

    private void TxLoop()
    {
        while (_running)
        {
            Action a = null;
            lock (_txSync)
            {
                if (_txQueue.Count == 0)
                {
                    Monitor.Wait(_txSync, 250);
                }
                if (_txQueue.Count > 0)
                {
                    a = _txQueue.Dequeue();
                }
            }
            if (a != null)
            {
                try
                {
                    a();
                }
                catch
                {
                }
            }
        }
    }

    private void DiscoveryLoop()
    {
        while (_running)
        {
            try
            {
                List<RoomManager.Room> rooms = _rooms.GetRoomsSnapshot();
                for (int i = 0; i < rooms.Count; i++)
                {
                    RoomManager.Room r = rooms[i];
                    SendDiscovery(r.RoomId, r.Name, r.PasswordHash);
                    if (r.TunnelPort > 0)
                    {
                        SendTunnelAdvertise(r.RoomId, r.TunnelPort);
                    }
                }
            }
            catch
            {
            }
            Thread.Sleep(1500);
        }
    }

    private void RxLoop()
    {
        while (_running)
        {
            try
            {
                byte[] data = _udp.Receive(ref _any);
                HandlePacket(_any, data);
            }
            catch (SocketException)
            {
                Thread.Sleep(50);
            }
            catch
            {
                Thread.Sleep(50);
            }
        }
    }

    private bool IsBlacklisted(string ip)
    {
        try
        {
            for (int i = 0; i < _settings.Blacklist.Count; i++)
            {
                if (string.Equals(_settings.Blacklist[i], ip, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
        }
        catch
        {
        }
        return false;
    }

    private bool IsContact(string userId)
    {
        try
        {
            for (int i = 0; i < _settings.Contacts.Count; i++)
            {
                if (string.Equals(_settings.Contacts[i].UserId, userId, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
        }
        catch
        {
        }
        return false;
    }

    private void HandlePacket(IPEndPoint ep, byte[] data)
    {
        if (data == null || data.Length < 2 + 1 + 1 + 16 + 16 + 4)
        {
            return;
        }
        string ip = "";
        try
        {
            ip = ep.Address.ToString();
        }
        catch
        {
        }
        if (!string.IsNullOrEmpty(ip) && IsBlacklisted(ip))
        {
            return;
        }

        try
        {
            using (MemoryStream ms = new MemoryStream(data))
            using (BinaryReader br = new BinaryReader(ms))
            {
                ushort magic = br.ReadUInt16();
                if (magic != Magic) return;
                byte ver = br.ReadByte();
                if (ver != Version) return;
                PacketType type = (PacketType)br.ReadByte();
                Guid roomId = new Guid(br.ReadBytes(16));
                Guid senderId = new Guid(br.ReadBytes(16));
                int len = br.ReadInt32();
                if (len < 0 || len > 1024 * 1024) return;
                if (ms.Length - ms.Position < len) return;
                byte[] payload = br.ReadBytes(len);

                string senderIdStr = senderId.ToString("D");
                if (_settings.AcceptContactsOnly)
                {
                    if (!IsContact(senderIdStr) && !string.Equals(senderIdStr, _settings.UserId, StringComparison.OrdinalIgnoreCase))
                    {
                        if (type != PacketType.DISCOVERY && type != PacketType.DISCOVERY_ACK)
                        {
                            return;
                        }
                    }
                }

                if (type != PacketType.DISCOVERY && type != PacketType.DISCOVERY_ACK)
                {
                    byte[] key = _rooms.GetRoomKey(roomId);
                    if (key != null && key.Length > 0)
                    {
                        payload = SettingsProvider.Xor(payload, key);
                    }
                }

                if (type == PacketType.DISCOVERY)
                {
                    HandleDiscovery(ep, roomId, senderId, payload, false);
                }
                else if (type == PacketType.DISCOVERY_ACK)
                {
                    HandleDiscovery(ep, roomId, senderId, payload, true);
                }
                else if (type == PacketType.CHAT)
                {
                    HandleChat(ep, roomId, senderId, payload);
                }
                else if (type == PacketType.AUDIO)
                {
                    HandleAudio(ep, roomId, senderId, payload);
                }
                else if (type == PacketType.TUNNEL_ADVERTISE)
                {
                    HandleTunnelAdvertise(ep, roomId, senderId, payload);
                }
                else if (type == PacketType.TUNNEL_DATA)
                {
                    HandleTunnelData(ep, roomId, senderId, payload);
                }
                else if (type == PacketType.TUNNEL_OPEN)
                {
                    HandleTunnelOpen(ep, roomId, senderId, payload);
                }
                else if (type == PacketType.TUNNEL_CLOSE)
                {
                    HandleTunnelClose(ep, roomId, senderId, payload);
                }
            }
        }
        catch
        {
        }
    }

    private void HandleDiscovery(IPEndPoint ep, Guid roomId, Guid senderId, byte[] payload, bool isAck)
    {
        try
        {
            string passHashLocal = _rooms.GetRoomPasswordHash(roomId);
            if (string.IsNullOrEmpty(passHashLocal))
            {
                return;
            }

            using (MemoryStream ms = new MemoryStream(payload))
            using (BinaryReader br = new BinaryReader(ms))
            {
                string roomName = ReadString(br);
                string senderName = ReadString(br);
                string passHashRemote = ReadString(br);

                if (!string.Equals(passHashLocal, passHashRemote, StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }

                _rooms.AddOrUpdatePeer(roomId, senderId.ToString("D"), senderName, new IPEndPoint(ep.Address, _settings.UdpPort));

                if (!isAck)
                {
                    EnqueueTx(delegate { SendDiscoveryAck(roomId, roomName, passHashLocal, ep); });
                }
            }
        }
        catch
        {
        }
    }

    private void HandleChat(IPEndPoint ep, Guid roomId, Guid senderId, byte[] payload)
    {
        try
        {
            using (MemoryStream ms = new MemoryStream(payload))
            using (BinaryReader br = new BinaryReader(ms))
            {
                string senderName = ReadString(br);
                string text = ReadString(br);
                _rooms.AddOrUpdatePeer(roomId, senderId.ToString("D"), senderName, new IPEndPoint(ep.Address, _settings.UdpPort));
                _rooms.AddChat(roomId, senderId.ToString("D"), senderName, text);
            }
        }
        catch
        {
        }
    }

    private void HandleAudio(IPEndPoint ep, Guid roomId, Guid senderId, byte[] payload)
    {
        if (payload == null || payload.Length == 0) return;
        if (OnAudioFrame != null)
        {
            OnAudioFrame(roomId, senderId.ToString("D"), payload);
        }
    }

    private void HandleTunnelAdvertise(IPEndPoint ep, Guid roomId, Guid senderId, byte[] payload)
    {
        try
        {
            using (MemoryStream ms = new MemoryStream(payload))
            using (BinaryReader br = new BinaryReader(ms))
            {
                int port = br.ReadInt32();
                if (port <= 0 || port > 65535) return;
                if (!string.Equals(senderId.ToString("D"), _settings.UserId, StringComparison.OrdinalIgnoreCase))
                {
                    IPEndPoint host = new IPEndPoint(ep.Address, _settings.UdpPort);
                    lock (_tunnelHostByRoom)
                    {
                        _tunnelHostByRoom[roomId] = host;
                        _tunnelHostPortByRoom[roomId] = port;
                    }
                    TunnelClientProxy proxy = null;
                    lock (_tunnelClients)
                    {
                        _tunnelClients.TryGetValue(roomId, out proxy);
                    }
                    if (proxy != null)
                    {
                        proxy.SetHost(host, port);
                    }
                }
            }
        }
        catch
        {
        }
    }

    private void HandleTunnelData(IPEndPoint ep, Guid roomId, Guid senderId, byte[] payload)
    {
        try
        {
            using (MemoryStream ms = new MemoryStream(payload))
            using (BinaryReader br = new BinaryReader(ms))
            {
                Guid tunnelId = new Guid(br.ReadBytes(16));
                int channel = br.ReadInt32();
                byte direction = br.ReadByte();
                int dataLen = br.ReadInt32();
                if (dataLen < 0 || dataLen > 64 * 1024) return;
                byte[] chunk = br.ReadBytes(dataLen);

                if (direction == 1)
                {
                    TunnelClientProxy proxy = null;
                    lock (_tunnelClients)
                    {
                        _tunnelClients.TryGetValue(roomId, out proxy);
                    }
                    if (proxy != null)
                    {
                        proxy.OnDataFromHost(channel, chunk);
                    }
                    return;
                }

                TunnelHost host;
                lock (_tunnels)
                {
                    _tunnels.TryGetValue(tunnelId, out host);
                }
                if (host == null)
                {
                    return;
                }
                host.Touch();
                host.OnDataFromClient(roomId, senderId, ep, channel, chunk);
            }
        }
        catch
        {
        }
    }

    private void HandleTunnelOpen(IPEndPoint ep, Guid roomId, Guid senderId, byte[] payload)
    {
        try
        {
            using (MemoryStream ms = new MemoryStream(payload))
            using (BinaryReader br = new BinaryReader(ms))
            {
                Guid tunnelId = new Guid(br.ReadBytes(16));
                int channel = br.ReadInt32();
                int servicePort = br.ReadInt32();
                if (servicePort <= 0 || servicePort > 65535) return;

                TunnelHost host;
                lock (_tunnels)
                {
                    if (!_tunnels.TryGetValue(tunnelId, out host))
                    {
                        host = new TunnelHost(this, servicePort);
                        _tunnels[tunnelId] = host;
                    }
                    else
                    {
                        host.SetLocalPort(servicePort);
                    }
                }

                host.Touch();
                host.OnOpenFromClient(roomId, senderId, ep, channel, servicePort);
            }
        }
        catch
        {
        }
    }

    private void HandleTunnelClose(IPEndPoint ep, Guid roomId, Guid senderId, byte[] payload)
    {
        try
        {
            using (MemoryStream ms = new MemoryStream(payload))
            using (BinaryReader br = new BinaryReader(ms))
            {
                Guid tunnelId = new Guid(br.ReadBytes(16));
                int channel = br.ReadInt32();

                TunnelHost host;
                lock (_tunnels)
                {
                    _tunnels.TryGetValue(tunnelId, out host);
                }
                if (host != null)
                {
                    host.OnCloseFromClient(roomId, senderId, ep, channel);
                }
            }
        }
        catch
        {
        }
    }

    public delegate void AudioFrameHandler(Guid roomId, string userId, byte[] pcm);
    public event AudioFrameHandler OnAudioFrame;

    public void SendChat(Guid roomId, string text)
    {
        if (string.IsNullOrEmpty(text)) return;
        byte[] payload;
        using (MemoryStream ms = new MemoryStream())
        using (BinaryWriter bw = new BinaryWriter(ms))
        {
            WriteString(bw, _settings.DisplayName);
            WriteString(bw, text);
            payload = ms.ToArray();
        }
        SendToRoom(roomId, PacketType.CHAT, payload);
        _rooms.AddChat(roomId, _settings.UserId, _settings.DisplayName, text);
    }

    public void SendAudioFrame(Guid roomId, byte[] pcm)
    {
        if (pcm == null || pcm.Length == 0) return;
        SendToRoom(roomId, PacketType.AUDIO, pcm);
    }

    public void SendAudioFrameToPeer(Guid roomId, byte[] pcm, IPEndPoint peer)
    {
        if (pcm == null || pcm.Length == 0) return;
        if (peer == null) return;
        SendDirect(roomId, PacketType.AUDIO, pcm, peer);
    }

    public void SendDiscovery(Guid roomId, string roomName, string passwordHash)
    {
        byte[] payload;
        using (MemoryStream ms = new MemoryStream())
        using (BinaryWriter bw = new BinaryWriter(ms))
        {
            WriteString(bw, roomName);
            WriteString(bw, _settings.DisplayName);
            WriteString(bw, passwordHash);
            payload = ms.ToArray();
        }
        SendBroadcast(roomId, PacketType.DISCOVERY, payload);
    }

    public void SendDiscoveryAck(Guid roomId, string roomName, string passwordHash, IPEndPoint remote)
    {
        byte[] payload;
        using (MemoryStream ms = new MemoryStream())
        using (BinaryWriter bw = new BinaryWriter(ms))
        {
            WriteString(bw, roomName);
            WriteString(bw, _settings.DisplayName);
            WriteString(bw, passwordHash);
            payload = ms.ToArray();
        }
        SendDirect(roomId, PacketType.DISCOVERY_ACK, payload, remote);
    }

    public Guid EnsureTunnelHost(Guid roomId, int localPort)
    {
        Guid tunnelId = roomId;
        lock (_tunnels)
        {
            TunnelHost host;
            if (_tunnels.TryGetValue(tunnelId, out host))
            {
                host.SetLocalPort(localPort);
                return tunnelId;
            }
            host = new TunnelHost(this, localPort);
            _tunnels[tunnelId] = host;
            return tunnelId;
        }
    }

    public void EnableTunnelClient(Guid roomId, int localListenPort)
    {
        if (localListenPort <= 0 || localListenPort > 65535) return;
        TunnelClientProxy proxy;
        lock (_tunnelClients)
        {
            if (_tunnelClients.TryGetValue(roomId, out proxy))
            {
                proxy.SetListenPort(localListenPort);
                return;
            }
            proxy = new TunnelClientProxy(this, roomId, localListenPort);
            _tunnelClients[roomId] = proxy;
        }

        IPEndPoint host;
        int port;
        if (TryGetTunnelHost(roomId, out host, out port))
        {
            proxy.SetHost(host, port);
        }
        proxy.Start();
    }

    private bool TryGetTunnelHost(Guid roomId, out IPEndPoint host, out int port)
    {
        host = null;
        port = 0;
        lock (_tunnelHostByRoom)
        {
            if (_tunnelHostByRoom.TryGetValue(roomId, out host))
            {
                _tunnelHostPortByRoom.TryGetValue(roomId, out port);
                return true;
            }
        }
        return false;
    }

    public void SendTunnelAdvertise(Guid roomId, int localPort)
    {
        byte[] payload;
        using (MemoryStream ms = new MemoryStream())
        using (BinaryWriter bw = new BinaryWriter(ms))
        {
            bw.Write(localPort);
            payload = ms.ToArray();
        }
        SendToRoom(roomId, PacketType.TUNNEL_ADVERTISE, payload);
    }

    public void SendTunnelData(Guid roomId, Guid tunnelId, int channel, byte direction, byte[] chunk, IPEndPoint explicitPeer)
    {
        if (chunk == null) chunk = new byte[0];
        byte[] payload;
        using (MemoryStream ms = new MemoryStream())
        using (BinaryWriter bw = new BinaryWriter(ms))
        {
            bw.Write(tunnelId.ToByteArray());
            bw.Write(channel);
            bw.Write(direction);
            bw.Write(chunk.Length);
            bw.Write(chunk);
            payload = ms.ToArray();
        }
        if (explicitPeer != null)
        {
            SendDirect(roomId, PacketType.TUNNEL_DATA, payload, explicitPeer);
        }
        else
        {
            SendToRoom(roomId, PacketType.TUNNEL_DATA, payload);
        }
    }

    public void SendTunnelOpen(Guid roomId, int channel, int servicePort, IPEndPoint host)
    {
        byte[] payload;
        using (MemoryStream ms = new MemoryStream())
        using (BinaryWriter bw = new BinaryWriter(ms))
        {
            bw.Write(roomId.ToByteArray());
            bw.Write(channel);
            bw.Write(servicePort);
            payload = ms.ToArray();
        }
        SendDirect(roomId, PacketType.TUNNEL_OPEN, payload, host);
    }

    public void SendTunnelClose(Guid roomId, int channel, IPEndPoint host)
    {
        byte[] payload;
        using (MemoryStream ms = new MemoryStream())
        using (BinaryWriter bw = new BinaryWriter(ms))
        {
            bw.Write(roomId.ToByteArray());
            bw.Write(channel);
            payload = ms.ToArray();
        }
        SendDirect(roomId, PacketType.TUNNEL_CLOSE, payload, host);
    }

    private void SendToRoom(Guid roomId, PacketType type, byte[] payload)
    {
        RoomManager.Room room = _rooms.GetRoom(roomId);
        if (room == null) return;
        List<IPEndPoint> peers = new List<IPEndPoint>();
        foreach (KeyValuePair<string, RoomManager.Peer> kv in room.Peers)
        {
            RoomManager.Peer p = kv.Value;
            if (p.EndPoint != null)
            {
                peers.Add(p.EndPoint);
            }
        }
        for (int i = 0; i < peers.Count; i++)
        {
            IPEndPoint ep = peers[i];
            SendDirect(roomId, type, payload, ep);
        }

        SendBroadcast(roomId, type, payload);
    }

    private void SendBroadcast(Guid roomId, PacketType type, byte[] payload)
    {
        IPEndPoint ep = new IPEndPoint(IPAddress.Broadcast, _settings.UdpPort);
        SendDirect(roomId, type, payload, ep);
    }

    private void SendDirect(Guid roomId, PacketType type, byte[] payload, IPEndPoint ep)
    {
        if (!_running) return;
        if (payload == null) payload = new byte[0];

        byte[] finalPayload = payload;
        if (type != PacketType.DISCOVERY && type != PacketType.DISCOVERY_ACK)
        {
            byte[] key = _rooms.GetRoomKey(roomId);
            if (key != null && key.Length > 0)
            {
                finalPayload = SettingsProvider.Xor(payload, key);
            }
        }

        byte[] packet;
        using (MemoryStream ms = new MemoryStream())
        using (BinaryWriter bw = new BinaryWriter(ms))
        {
            bw.Write(Magic);
            bw.Write(Version);
            bw.Write((byte)type);
            bw.Write(roomId.ToByteArray());
            Guid sid;
            if (!Guid.TryParse(_settings.UserId, out sid))
            {
                sid = Guid.Empty;
            }
            bw.Write(sid.ToByteArray());
            bw.Write(finalPayload.Length);
            bw.Write(finalPayload);
            packet = ms.ToArray();
        }

        EnqueueTx(delegate
        {
            try
            {
                _udp.Send(packet, packet.Length, ep);
            }
            catch
            {
            }
        });
    }

    private static void WriteString(BinaryWriter bw, string s)
    {
        if (s == null) s = "";
        byte[] b = Encoding.UTF8.GetBytes(s);
        bw.Write(b.Length);
        bw.Write(b);
    }

    private static string ReadString(BinaryReader br)
    {
        int len = br.ReadInt32();
        if (len < 0 || len > 1024 * 1024) return "";
        byte[] b = br.ReadBytes(len);
        return Encoding.UTF8.GetString(b);
    }

    private class TunnelHost
    {
        private readonly NetworkEngine _net;
        private readonly object _sync = new object();
        private int _localPort;
        private DateTime _lastSeenUtc;

        private readonly Dictionary<int, TcpBridge> _bridges = new Dictionary<int, TcpBridge>();

        public TunnelHost(NetworkEngine net, int localPort)
        {
            _net = net;
            _localPort = localPort;
            _lastSeenUtc = DateTime.UtcNow;
        }

        public void Touch()
        {
            _lastSeenUtc = DateTime.UtcNow;
        }

        public void SetLocalPort(int p)
        {
            if (p <= 0 || p > 65535) return;
            _localPort = p;
        }

        public void SetRemote(IPEndPoint ep, int port)
        {
            
        }

        public void OnOpenFromClient(Guid roomId, Guid senderId, IPEndPoint senderEp, int channel, int servicePort)
        {
            TcpBridge b = null;
            lock (_sync)
            {
                if (!_bridges.TryGetValue(channel, out b))
                {
                    b = new TcpBridge(_net, roomId, senderEp, channel, servicePort);
                    _bridges[channel] = b;
                }
            }
        }

        public void OnCloseFromClient(Guid roomId, Guid senderId, IPEndPoint senderEp, int channel)
        {
            TcpBridge b = null;
            lock (_sync)
            {
                if (_bridges.TryGetValue(channel, out b))
                {
                    _bridges.Remove(channel);
                }
            }
            if (b != null)
            {
                b.Close();
            }
        }

        public void OnDataFromClient(Guid roomId, Guid senderId, IPEndPoint senderEp, int channel, byte[] chunk)
        {
            TcpBridge b = null;
            lock (_sync)
            {
                _bridges.TryGetValue(channel, out b);
            }
            if (b != null)
            {
                b.WriteFromClient(chunk);
            }
        }

        private class TcpBridge
        {
            private readonly NetworkEngine _net;
            private readonly Guid _roomId;
            private readonly IPEndPoint _peer;
            private readonly int _channel;
            private readonly int _localPort;

            private TcpClient _tcp;
            private NetworkStream _ns;
            private Thread _rx;
            private volatile bool _running;

            public TcpBridge(NetworkEngine net, Guid roomId, IPEndPoint peer, int channel, int localPort)
            {
                _net = net;
                _roomId = roomId;
                _peer = peer;
                _channel = channel;
                _localPort = localPort;
                Start();
            }

            public void Close()
            {
                _running = false;
                try
                {
                    if (_ns != null) _ns.Close();
                }
                catch
                {
                }
                try
                {
                    if (_tcp != null) _tcp.Close();
                }
                catch
                {
                }
            }

            private void Start()
            {
                try
                {
                    _tcp = new TcpClient();
                    _tcp.Connect("127.0.0.1", _localPort);
                    _ns = _tcp.GetStream();
                    _running = true;
                    _rx = new Thread(RxLoop);
                    _rx.IsBackground = true;
                    _rx.Start();
                }
                catch
                {
                    _running = false;
                }
            }

            public void WriteFromClient(byte[] chunk)
            {
                if (!_running) return;
                try
                {
                    if (chunk != null && chunk.Length > 0)
                    {
                        _ns.Write(chunk, 0, chunk.Length);
                        _ns.Flush();
                    }
                }
                catch
                {
                    _running = false;
                }
            }

            private void RxLoop()
            {
                byte[] buf = new byte[8192];
                while (_running)
                {
                    int read = 0;
                    try
                    {
                        read = _ns.Read(buf, 0, buf.Length);
                    }
                    catch
                    {
                        read = 0;
                    }
                    if (read <= 0)
                    {
                        _running = false;
                        break;
                    }
                    byte[] chunk = new byte[read];
                    Buffer.BlockCopy(buf, 0, chunk, 0, read);
                    _net.SendTunnelData(_roomId, _roomId, _channel, 1, chunk, _peer);
                }
                try
                {
                    if (_ns != null) _ns.Close();
                }
                catch
                {
                }
                try
                {
                    if (_tcp != null) _tcp.Close();
                }
                catch
                {
                }
            }
        }
    }

    private class TunnelClientProxy
    {
        private readonly NetworkEngine _net;
        private readonly Guid _roomId;
        private readonly object _sync = new object();
        private int _listenPort;
        private volatile bool _running;
        private Thread _acceptThread;
        private TcpListener _listener;

        private IPEndPoint _host;
        private int _servicePort;
        private int _nextChannel;
        private readonly Dictionary<int, ClientBridge> _bridges;

        public TunnelClientProxy(NetworkEngine net, Guid roomId, int listenPort)
        {
            _net = net;
            _roomId = roomId;
            _listenPort = listenPort;
            _nextChannel = 1;
            _bridges = new Dictionary<int, ClientBridge>();
        }

        public void SetHost(IPEndPoint host, int servicePort)
        {
            _host = host;
            _servicePort = servicePort;
        }

        public void SetListenPort(int listenPort)
        {
            _listenPort = listenPort;
        }

        public void Start()
        {
            if (_running) return;
            _running = true;
            try
            {
                _listener = new TcpListener(IPAddress.Loopback, _listenPort);
                _listener.Start();
            }
            catch
            {
                _running = false;
                return;
            }

            _acceptThread = new Thread(AcceptLoop);
            _acceptThread.IsBackground = true;
            _acceptThread.Start();
        }

        public void OnDataFromHost(int channel, byte[] chunk)
        {
            ClientBridge b = null;
            lock (_sync)
            {
                _bridges.TryGetValue(channel, out b);
            }
            if (b != null)
            {
                b.WriteFromHost(chunk);
            }
        }

        private void AcceptLoop()
        {
            while (_running)
            {
                TcpClient c = null;
                try
                {
                    c = _listener.AcceptTcpClient();
                }
                catch
                {
                    Thread.Sleep(50);
                    continue;
                }
                if (c == null) continue;

                IPEndPoint host = _host;
                int sp = _servicePort;
                if (host == null || sp <= 0)
                {
                    try { c.Close(); } catch { }
                    continue;
                }

                int ch;
                lock (_sync)
                {
                    ch = _nextChannel;
                    _nextChannel++;
                    if (_nextChannel < 1) _nextChannel = 1;
                }

                ClientBridge bridge = new ClientBridge(_net, _roomId, host, sp, ch, c);
                lock (_sync)
                {
                    _bridges[ch] = bridge;
                }
                bridge.Start();
            }
        }

        private class ClientBridge
        {
            private readonly NetworkEngine _net;
            private readonly Guid _roomId;
            private readonly IPEndPoint _host;
            private readonly int _servicePort;
            private readonly int _channel;
            private readonly TcpClient _client;
            private NetworkStream _ns;
            private Thread _rx;
            private volatile bool _running;

            public ClientBridge(NetworkEngine net, Guid roomId, IPEndPoint host, int servicePort, int channel, TcpClient client)
            {
                _net = net;
                _roomId = roomId;
                _host = host;
                _servicePort = servicePort;
                _channel = channel;
                _client = client;
            }

            public void Start()
            {
                try
                {
                    _ns = _client.GetStream();
                    _running = true;
                    _net.SendTunnelOpen(_roomId, _channel, _servicePort, _host);
                    _rx = new Thread(RxLoop);
                    _rx.IsBackground = true;
                    _rx.Start();
                }
                catch
                {
                    _running = false;
                    try { _client.Close(); } catch { }
                }
            }

            public void WriteFromHost(byte[] chunk)
            {
                if (!_running) return;
                try
                {
                    if (chunk != null && chunk.Length > 0)
                    {
                        _ns.Write(chunk, 0, chunk.Length);
                        _ns.Flush();
                    }
                }
                catch
                {
                    _running = false;
                }
            }

            private void RxLoop()
            {
                byte[] buf = new byte[8192];
                while (_running)
                {
                    int read = 0;
                    try
                    {
                        read = _ns.Read(buf, 0, buf.Length);
                    }
                    catch
                    {
                        read = 0;
                    }
                    if (read <= 0)
                    {
                        _running = false;
                        break;
                    }
                    byte[] chunk = new byte[read];
                    Buffer.BlockCopy(buf, 0, chunk, 0, read);
                    _net.SendTunnelData(_roomId, _roomId, _channel, 0, chunk, _host);
                }
                try
                {
                    _net.SendTunnelClose(_roomId, _channel, _host);
                }
                catch
                {
                }
                try
                {
                    if (_ns != null) _ns.Close();
                }
                catch
                {
                }
                try
                {
                    _client.Close();
                }
                catch
                {
                }
            }
        }
    }
}

public class AudioHandler
{
    private readonly SettingsProvider _settingsProvider;
    private SettingsProvider.Settings _settings;
    private readonly NetworkEngine _net;
    private readonly RoomManager _rooms;

    private readonly object _sync = new object();

    private volatile bool _callEnabled;
    private volatile bool _muteMic;
    private volatile bool _deafen;
    private volatile bool _pushToTalk;
    private Guid _roomId;
    private string _directTargetUserId;

    private WaveIn _waveIn;
    private WaveOut _waveOut;

    public event Action<string> Log;

    public AudioHandler(SettingsProvider settingsProvider, SettingsProvider.Settings settings, NetworkEngine net, RoomManager rooms)
    {
        _settingsProvider = settingsProvider;
        _settings = settings;
        _net = net;
        _rooms = rooms;
        _roomId = Guid.Empty;

        _net.OnAudioFrame += NetOnAudioFrame;
    }

    private void RaiseLog(string s)
    {
        if (Log != null)
        {
            Log(s);
        }
    }

    public void SetRoom(Guid roomId)
    {
        _roomId = roomId;
    }

    public void SetDirectTarget(string userId)
    {
        if (string.IsNullOrEmpty(userId))
        {
            _directTargetUserId = null;
            return;
        }
        _directTargetUserId = userId;
    }

    public void SetPushToTalk(bool enabled)
    {
        _pushToTalk = enabled;
    }

    public void SetMute(bool mute)
    {
        _muteMic = mute;
    }

    public void SetDeafen(bool deafen)
    {
        _deafen = deafen;
    }

    public void StartCall()
    {
        lock (_sync)
        {
            if (_callEnabled) return;
            _callEnabled = true;
            try
            {
                if (_waveOut == null)
                {
                    _waveOut = new WaveOut();
                    _waveOut.Open(8000, 16, 1);
                }
                if (_waveIn == null)
                {
                    _waveIn = new WaveIn();
                    _waveIn.Open(8000, 16, 1);
                    _waveIn.Data += WaveInData;
                    _waveIn.Start();
                }
            }
            catch (Exception ex)
            {
                RaiseLog("Audio start failed: " + ex.Message);
            }
        }
    }

    public void StopCall()
    {
        lock (_sync)
        {
            _callEnabled = false;
            try
            {
                if (_waveIn != null)
                {
                    _waveIn.Stop();
                    _waveIn.Dispose();
                    _waveIn = null;
                }
            }
            catch
            {
            }
            try
            {
                if (_waveOut != null)
                {
                    _waveOut.Dispose();
                    _waveOut = null;
                }
            }
            catch
            {
            }
        }
    }

    private void WaveInData(byte[] pcm)
    {
        if (!_callEnabled) return;
        if (_roomId == Guid.Empty) return;
        if (_muteMic) return;
        if (!_pushToTalk) return;

        string direct = _directTargetUserId;
        if (!string.IsNullOrEmpty(direct))
        {
            IPEndPoint ep = _rooms.GetPeerEndpoint(_roomId, direct);
            if (ep != null)
            {
                _net.SendAudioFrameToPeer(_roomId, pcm, ep);
                return;
            }
        }
        _net.SendAudioFrame(_roomId, pcm);
    }

    private void NetOnAudioFrame(Guid roomId, string userId, byte[] pcm)
    {
        if (!_callEnabled) return;
        if (_deafen) return;
        if (_roomId != roomId) return;
        try
        {
            RoomManager.Peer p;
            if (_rooms.TryGetPeer(roomId, userId, out p))
            {
                if (p.Muted)
                {
                    return;
                }
                float vol = p.Volume;
                if (vol < 0.0f) vol = 0.0f;
                if (vol > 2.0f) vol = 2.0f;
                pcm = ApplyVolumePcm16Mono(pcm, vol);
            }

            lock (_sync)
            {
                if (_waveOut != null)
                {
                    _waveOut.Play(pcm);
                }
            }
        }
        catch
        {
        }
    }

    private static byte[] ApplyVolumePcm16Mono(byte[] pcm, float volume)
    {
        if (pcm == null) return new byte[0];
        if (volume == 1.0f) return pcm;
        if (pcm.Length < 2) return pcm;
        byte[] outBuf = new byte[pcm.Length];
        for (int i = 0; i + 1 < pcm.Length; i += 2)
        {
            short s = (short)(pcm[i] | (pcm[i + 1] << 8));
            int v = (int)(s * volume);
            if (v > short.MaxValue) v = short.MaxValue;
            if (v < short.MinValue) v = short.MinValue;
            short ns = (short)v;
            outBuf[i] = (byte)(ns & 0xFF);
            outBuf[i + 1] = (byte)((ns >> 8) & 0xFF);
        }
        return outBuf;
    }

    private class WaveIn : IDisposable
    {
        public delegate void DataHandler(byte[] pcm);
        public event DataHandler Data;

        private IntPtr _hwi;
        private WaveHdr[] _hdrs;
        private byte[][] _bufs;
        private volatile bool _running;
        private WaveInProc _proc;
        private int _bufferSize;

        public void Open(int sampleRate, short bits, short channels)
        {
            _bufferSize = 3200;
            WAVEFORMATEX fmt = new WAVEFORMATEX();
            fmt.wFormatTag = 1;
            fmt.nChannels = channels;
            fmt.nSamplesPerSec = sampleRate;
            fmt.wBitsPerSample = bits;
            fmt.nBlockAlign = (short)(channels * (bits / 8));
            fmt.nAvgBytesPerSec = fmt.nSamplesPerSec * fmt.nBlockAlign;
            fmt.cbSize = 0;

            _proc = new WaveInProc(WaveInCallback);
            int res = waveInOpen(out _hwi, 0, ref fmt, _proc, IntPtr.Zero, 0x00030000);
            if (res != 0)
            {
                throw new InvalidOperationException("waveInOpen failed: " + res);
            }

            _hdrs = new WaveHdr[3];
            _bufs = new byte[3][];
            for (int i = 0; i < _hdrs.Length; i++)
            {
                _bufs[i] = new byte[_bufferSize];
                _hdrs[i] = new WaveHdr();
                _hdrs[i].lpData = Marshal.AllocHGlobal(_bufferSize);
                Marshal.Copy(_bufs[i], 0, _hdrs[i].lpData, _bufferSize);
                _hdrs[i].dwBufferLength = _bufferSize;
                _hdrs[i].dwFlags = 0;
                waveInPrepareHeader(_hwi, ref _hdrs[i], Marshal.SizeOf(typeof(WaveHdr)));
                waveInAddBuffer(_hwi, ref _hdrs[i], Marshal.SizeOf(typeof(WaveHdr)));
            }
        }

        public void Start()
        {
            _running = true;
            waveInStart(_hwi);
        }

        public void Stop()
        {
            _running = false;
            if (_hwi != IntPtr.Zero)
            {
                waveInStop(_hwi);
                waveInReset(_hwi);
            }
        }

        private void WaveInCallback(IntPtr hwi, int msg, IntPtr inst, IntPtr hdrPtr, IntPtr reserved)
        {
            if (!_running) return;
            if (msg != 0x3C0) return;
            try
            {
                WaveHdr hdr = (WaveHdr)Marshal.PtrToStructure(hdrPtr, typeof(WaveHdr));
                int len = (int)hdr.dwBytesRecorded;
                if (len > 0 && len <= _bufferSize)
                {
                    byte[] pcm = new byte[len];
                    Marshal.Copy(hdr.lpData, pcm, 0, len);
                    if (Data != null)
                    {
                        Data(pcm);
                    }
                }
                waveInAddBuffer(_hwi, ref hdr, Marshal.SizeOf(typeof(WaveHdr)));
            }
            catch
            {
            }
        }

        public void Dispose()
        {
            try
            {
                Stop();
            }
            catch
            {
            }

            try
            {
                if (_hdrs != null)
                {
                    for (int i = 0; i < _hdrs.Length; i++)
                    {
                        try
                        {
                            waveInUnprepareHeader(_hwi, ref _hdrs[i], Marshal.SizeOf(typeof(WaveHdr)));
                        }
                        catch
                        {
                        }
                        try
                        {
                            if (_hdrs[i].lpData != IntPtr.Zero)
                            {
                                Marshal.FreeHGlobal(_hdrs[i].lpData);
                            }
                        }
                        catch
                        {
                        }
                    }
                }
            }
            catch
            {
            }
            try
            {
                if (_hwi != IntPtr.Zero)
                {
                    waveInClose(_hwi);
                    _hwi = IntPtr.Zero;
                }
            }
            catch
            {
            }
        }
    }

    private class WaveOut : IDisposable
    {
        private IntPtr _hwo;
        private WAVEFORMATEX _fmt;
        private readonly object _sync = new object();

        public void Open(int sampleRate, short bits, short channels)
        {
            _fmt = new WAVEFORMATEX();
            _fmt.wFormatTag = 1;
            _fmt.nChannels = channels;
            _fmt.nSamplesPerSec = sampleRate;
            _fmt.wBitsPerSample = bits;
            _fmt.nBlockAlign = (short)(channels * (bits / 8));
            _fmt.nAvgBytesPerSec = _fmt.nSamplesPerSec * _fmt.nBlockAlign;
            _fmt.cbSize = 0;

            int res = waveOutOpen(out _hwo, 0, ref _fmt, IntPtr.Zero, IntPtr.Zero, 0);
            if (res != 0)
            {
                throw new InvalidOperationException("waveOutOpen failed: " + res);
            }
        }

        public void Play(byte[] pcm)
        {
            if (pcm == null || pcm.Length == 0) return;
            lock (_sync)
            {
                if (_hwo == IntPtr.Zero) return;

                IntPtr data = Marshal.AllocHGlobal(pcm.Length);
                Marshal.Copy(pcm, 0, data, pcm.Length);
                WaveHdr hdr = new WaveHdr();
                hdr.lpData = data;
                hdr.dwBufferLength = pcm.Length;
                hdr.dwFlags = 0;
                waveOutPrepareHeader(_hwo, ref hdr, Marshal.SizeOf(typeof(WaveHdr)));
                waveOutWrite(_hwo, ref hdr, Marshal.SizeOf(typeof(WaveHdr)));

                ThreadPool.QueueUserWorkItem(delegate
                {
                    int waited = 0;
                    while ((hdr.dwFlags & 0x00000001) == 0 && waited < 2000)
                    {
                        Thread.Sleep(10);
                        waited += 10;
                    }
                    try
                    {
                        waveOutUnprepareHeader(_hwo, ref hdr, Marshal.SizeOf(typeof(WaveHdr)));
                    }
                    catch
                    {
                    }
                    try
                    {
                        Marshal.FreeHGlobal(data);
                    }
                    catch
                    {
                    }
                });
            }
        }

        public void Dispose()
        {
            lock (_sync)
            {
                try
                {
                    if (_hwo != IntPtr.Zero)
                    {
                        waveOutReset(_hwo);
                    }
                }
                catch
                {
                }
                try
                {
                    if (_hwo != IntPtr.Zero)
                    {
                        waveOutClose(_hwo);
                        _hwo = IntPtr.Zero;
                    }
                }
                catch
                {
                }
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct WAVEFORMATEX
    {
        public short wFormatTag;
        public short nChannels;
        public int nSamplesPerSec;
        public int nAvgBytesPerSec;
        public short nBlockAlign;
        public short wBitsPerSample;
        public short cbSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct WaveHdr
    {
        public IntPtr lpData;
        public int dwBufferLength;
        public int dwBytesRecorded;
        public IntPtr dwUser;
        public int dwFlags;
        public int dwLoops;
        public IntPtr lpNext;
        public IntPtr reserved;
    }

    private delegate void WaveInProc(IntPtr hwi, int msg, IntPtr inst, IntPtr hdr, IntPtr reserved);

    [DllImport("winmm.dll")]
    private static extern int waveInOpen(out IntPtr phwi, int uDeviceID, ref WAVEFORMATEX pwfx, WaveInProc dwCallback, IntPtr dwInstance, int fdwOpen);
    [DllImport("winmm.dll")]
    private static extern int waveInPrepareHeader(IntPtr hwi, ref WaveHdr pwh, int cbwh);
    [DllImport("winmm.dll")]
    private static extern int waveInUnprepareHeader(IntPtr hwi, ref WaveHdr pwh, int cbwh);
    [DllImport("winmm.dll")]
    private static extern int waveInAddBuffer(IntPtr hwi, ref WaveHdr pwh, int cbwh);
    [DllImport("winmm.dll")]
    private static extern int waveInStart(IntPtr hwi);
    [DllImport("winmm.dll")]
    private static extern int waveInStop(IntPtr hwi);
    [DllImport("winmm.dll")]
    private static extern int waveInReset(IntPtr hwi);
    [DllImport("winmm.dll")]
    private static extern int waveInClose(IntPtr hwi);

    [DllImport("winmm.dll")]
    private static extern int waveOutOpen(out IntPtr phwo, int uDeviceID, ref WAVEFORMATEX pwfx, IntPtr dwCallback, IntPtr dwInstance, int fdwOpen);
    [DllImport("winmm.dll")]
    private static extern int waveOutPrepareHeader(IntPtr hwo, ref WaveHdr pwh, int cbwh);
    [DllImport("winmm.dll")]
    private static extern int waveOutUnprepareHeader(IntPtr hwo, ref WaveHdr pwh, int cbwh);
    [DllImport("winmm.dll")]
    private static extern int waveOutWrite(IntPtr hwo, ref WaveHdr pwh, int cbwh);
    [DllImport("winmm.dll")]
    private static extern int waveOutReset(IntPtr hwo);
    [DllImport("winmm.dll")]
    private static extern int waveOutClose(IntPtr hwo);
}

public class MainForm : Form
{
    private readonly SettingsProvider _settingsProvider;
    private SettingsProvider.Settings _settings;
    private readonly RoomManager _rooms;
    private readonly NetworkEngine _net;
    private readonly AudioHandler _audio;

    private Dictionary<string, Dictionary<string, string>> _loc;
    private string _lang;

    private Panel _left;
    private Panel _center;
    private Panel _right;
    private Panel _footer;

    private TabControl _leftTabs;
    private ListBox _roomList;
    private AvatarListBox _contactsList;

    private TabControl _tabs;
    private RichTextBox _chat;
    private TextBox _chatInput;
    private Button _send;

    private Button _btnCreateRoom;
    private Button _btnJoinRoom;

    private CheckBox _cbContactsOnly;
    private TextBox _tbName;
    private ComboBox _cbLang;
    private Button _btnSaveProfile;

    private Button _btnStartCall;
    private Button _btnStopCall;
    private ComboBox _cbCallTarget;
    private CheckBox _cbMute;
    private CheckBox _cbDeafen;
    private Label _lblPtt;
    private bool _pttHeld;

    private NumericUpDown _numTunnelPort;
    private Button _btnSetTunnel;

    private NumericUpDown _numTunnelClientPort;
    private Button _btnEnableTunnelClient;

    private ListBox _peerList;
    private TrackBar _peerVolume;
    private CheckBox _peerMute;

    private ListBox _blacklistList;
    private TextBox _blacklistInput;
    private Button _btnBlacklistAdd;
    private Button _btnBlacklistRemove;

    private Button _btnContactAdd;
    private Button _btnContactRemove;

    private TextBox _tbPttKey;
    private TextBox _tbMuteKey;
    private Button _btnSaveHotkeys;

    private System.Windows.Forms.Timer _uiTimer;

    public MainForm(SettingsProvider settingsProvider, SettingsProvider.Settings settings, RoomManager rooms, NetworkEngine net, AudioHandler audio)
    {
        _settingsProvider = settingsProvider;
        _settings = settings;
        _rooms = rooms;
        _net = net;
        _audio = audio;

        _lang = settings.Language;
        BuildLocalization();

        Text = "AmazeBridge";
        StartPosition = FormStartPosition.CenterScreen;
        Width = 1300;
        Height = 800;
        MinimumSize = new Size(1100, 700);
        BackColor = Color.FromArgb(0x0f, 0x17, 0x2a);
        ForeColor = Color.White;
        KeyPreview = true;
        DoubleBuffered = true;

        BuildLayout();
        BindEvents();

        _uiTimer = new System.Windows.Forms.Timer();
        _uiTimer.Interval = 700;
        _uiTimer.Tick += delegate { RefreshUi(); };
        _uiTimer.Start();

        RefreshUi();
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        base.OnClosing(e);
        try
        {
            _audio.StopCall();
        }
        catch
        {
        }
        try
        {
            _settingsProvider.Save(_settings);
        }
        catch
        {
        }
    }

    private void BuildLocalization()
    {
        _loc = Localization.Table;
    }

    private string T(string key)
    {
        Dictionary<string, string> d;
        if (!_loc.TryGetValue(_lang, out d))
        {
            d = _loc["en"];
        }
        string v;
        if (d.TryGetValue(key, out v))
        {
            return v;
        }
        return key;
    }

    private void BuildLayout()
    {
        _left = new GlassPanel();
        _center = new GlassPanel();
        _right = new GlassPanel();
        _footer = new GlassPanel();

        _left.Dock = DockStyle.Left;
        _left.Width = 260;
        _center.Dock = DockStyle.Fill;
        _right.Dock = DockStyle.Right;
        _right.Width = 320;
        _footer.Dock = DockStyle.Bottom;
        _footer.Height = 52;

        Controls.Add(_center);
        Controls.Add(_right);
        Controls.Add(_left);
        Controls.Add(_footer);

        Label lRooms = MakeHeader(T("rooms"));
        lRooms.Dock = DockStyle.Top;
        _left.Controls.Add(lRooms);

        FlowLayoutPanel roomBtns = new FlowLayoutPanel();
        roomBtns.Dock = DockStyle.Top;
        roomBtns.Height = 40;
        roomBtns.FlowDirection = FlowDirection.LeftToRight;
        roomBtns.WrapContents = false;
        roomBtns.Padding = new Padding(8, 6, 8, 6);

        _btnCreateRoom = MakeButton(T("create_room"));
        _btnJoinRoom = MakeButton(T("join_room"));
        _btnCreateRoom.Width = 110;
        _btnJoinRoom.Width = 110;
        roomBtns.Controls.Add(_btnCreateRoom);
        roomBtns.Controls.Add(_btnJoinRoom);
        _left.Controls.Add(roomBtns);

        _leftTabs = new TabControl();
        _leftTabs.Dock = DockStyle.Fill;
        _leftTabs.Font = new Font("Segoe UI", 10.0f, FontStyle.Regular);
        _left.Controls.Add(_leftTabs);

        TabPage tabRooms = new TabPage(T("rooms"));
        tabRooms.BackColor = Color.FromArgb(16, 23, 42);
        tabRooms.ForeColor = Color.White;
        _leftTabs.TabPages.Add(tabRooms);

        TabPage tabContacts = new TabPage(T("contacts"));
        tabContacts.BackColor = Color.FromArgb(16, 23, 42);
        tabContacts.ForeColor = Color.White;
        _leftTabs.TabPages.Add(tabContacts);

        _roomList = new ListBox();
        _roomList.Dock = DockStyle.Fill;
        _roomList.BackColor = Color.FromArgb(24, 32, 56);
        _roomList.ForeColor = Color.White;
        _roomList.BorderStyle = BorderStyle.None;
        _roomList.Font = new Font("Segoe UI", 10.0f, FontStyle.Regular);
        tabRooms.Controls.Add(_roomList);

        _contactsList = new AvatarListBox();
        _contactsList.Dock = DockStyle.Fill;
        _contactsList.BackColor = Color.FromArgb(24, 32, 56);
        _contactsList.ForeColor = Color.White;
        _contactsList.BorderStyle = BorderStyle.None;
        _contactsList.Font = new Font("Segoe UI", 10.0f, FontStyle.Regular);
        tabContacts.Controls.Add(_contactsList);

        _tabs = new TabControl();
        _tabs.Dock = DockStyle.Fill;
        _tabs.Appearance = TabAppearance.Normal;
        _tabs.Font = new Font("Segoe UI", 10.0f, FontStyle.Regular);
        _center.Controls.Add(_tabs);

        TabPage tabChat = new TabPage(T("chat"));
        tabChat.BackColor = Color.FromArgb(16, 23, 42);
        tabChat.ForeColor = Color.White;
        _tabs.TabPages.Add(tabChat);

        _chat = new RichTextBox();
        _chat.Dock = DockStyle.Fill;
        _chat.ReadOnly = true;
        _chat.BackColor = Color.FromArgb(13, 19, 36);
        _chat.ForeColor = Color.White;
        _chat.BorderStyle = BorderStyle.None;
        _chat.Font = new Font("Consolas", 10.0f, FontStyle.Regular);
        tabChat.Controls.Add(_chat);

        Panel chatBottom = new Panel();
        chatBottom.Dock = DockStyle.Bottom;
        chatBottom.Height = 54;
        chatBottom.Padding = new Padding(10);
        chatBottom.BackColor = Color.FromArgb(14, 20, 38);
        tabChat.Controls.Add(chatBottom);

        _chatInput = new TextBox();
        _chatInput.BorderStyle = BorderStyle.FixedSingle;
        _chatInput.Font = new Font("Segoe UI", 10.0f, FontStyle.Regular);
        _chatInput.BackColor = Color.FromArgb(24, 32, 56);
        _chatInput.ForeColor = Color.White;
        _chatInput.Dock = DockStyle.Fill;
        chatBottom.Controls.Add(_chatInput);

        _send = MakeButton(T("send"));
        _send.Dock = DockStyle.Right;
        _send.Width = 120;
        chatBottom.Controls.Add(_send);

        Label lProfile = MakeHeader(T("profile"));
        lProfile.Dock = DockStyle.Top;
        _right.Controls.Add(lProfile);

        Panel profile = new Panel();
        profile.Dock = DockStyle.Top;
        profile.Height = 140;
        profile.Padding = new Padding(12);
        profile.BackColor = Color.FromArgb(16, 23, 42);
        _right.Controls.Add(profile);

        Label ln = MakeLabel(T("name"));
        ln.Location = new Point(12, 12);
        ln.Width = 120;
        profile.Controls.Add(ln);

        _tbName = new TextBox();
        _tbName.Text = _settings.DisplayName;
        _tbName.Location = new Point(12, 36);
        _tbName.Width = 280;
        _tbName.BackColor = Color.FromArgb(24, 32, 56);
        _tbName.ForeColor = Color.White;
        _tbName.BorderStyle = BorderStyle.FixedSingle;
        profile.Controls.Add(_tbName);

        Label ll = MakeLabel(T("language"));
        ll.Location = new Point(12, 70);
        ll.Width = 120;
        profile.Controls.Add(ll);

        _cbLang = new ComboBox();
        _cbLang.DropDownStyle = ComboBoxStyle.DropDownList;
        _cbLang.Items.Add("ua");
        _cbLang.Items.Add("ru");
        _cbLang.Items.Add("en");
        _cbLang.Items.Add("tr");
        _cbLang.SelectedItem = _lang;
        _cbLang.Location = new Point(12, 92);
        _cbLang.Width = 110;
        _cbLang.BackColor = Color.FromArgb(24, 32, 56);
        _cbLang.ForeColor = Color.White;
        profile.Controls.Add(_cbLang);

        _cbContactsOnly = new CheckBox();
        _cbContactsOnly.Text = T("contacts_only");
        _cbContactsOnly.Checked = _settings.AcceptContactsOnly;
        _cbContactsOnly.ForeColor = Color.White;
        _cbContactsOnly.Location = new Point(140, 92);
        _cbContactsOnly.Width = 160;
        profile.Controls.Add(_cbContactsOnly);

        _btnSaveProfile = MakeButton(T("save"));
        _btnSaveProfile.Location = new Point(220, 118);
        _btnSaveProfile.Width = 72;
        _btnSaveProfile.Height = 26;
        profile.Controls.Add(_btnSaveProfile);

        Label lAudio = MakeHeader(T("audio"));
        lAudio.Dock = DockStyle.Top;
        _right.Controls.Add(lAudio);

        Panel audio = new Panel();
        audio.Dock = DockStyle.Top;
        audio.Height = 180;
        audio.Padding = new Padding(12);
        audio.BackColor = Color.FromArgb(16, 23, 42);
        _right.Controls.Add(audio);

        _btnStartCall = MakeButton(T("start_call"));
        _btnStopCall = MakeButton(T("stop_call"));
        _btnStartCall.Width = 120;
        _btnStopCall.Width = 120;
        _btnStartCall.Location = new Point(12, 12);
        _btnStopCall.Location = new Point(152, 12);
        audio.Controls.Add(_btnStartCall);
        audio.Controls.Add(_btnStopCall);

        _cbMute = new CheckBox();
        _cbMute.Text = T("mute");
        _cbMute.ForeColor = Color.White;
        _cbMute.Location = new Point(12, 52);
        _cbMute.Width = 120;
        audio.Controls.Add(_cbMute);

        _cbDeafen = new CheckBox();
        _cbDeafen.Text = T("deafen");
        _cbDeafen.ForeColor = Color.White;
        _cbDeafen.Location = new Point(152, 52);
        _cbDeafen.Width = 120;
        audio.Controls.Add(_cbDeafen);

        _lblPtt = MakeLabel(T("ptt"));
        _lblPtt.Location = new Point(12, 82);
        _lblPtt.Width = 280;
        audio.Controls.Add(_lblPtt);

        Label lTarget = MakeLabel(T("contacts"));
        lTarget.Location = new Point(12, 106);
        lTarget.Width = 280;
        audio.Controls.Add(lTarget);

        _cbCallTarget = new ComboBox();
        _cbCallTarget.DropDownStyle = ComboBoxStyle.DropDownList;
        _cbCallTarget.Location = new Point(12, 128);
        _cbCallTarget.Width = 260;
        _cbCallTarget.BackColor = Color.FromArgb(24, 32, 56);
        _cbCallTarget.ForeColor = Color.White;
        audio.Controls.Add(_cbCallTarget);

        Label lTunnel = MakeHeader(T("tunnel"));
        lTunnel.Dock = DockStyle.Top;
        _right.Controls.Add(lTunnel);

        Panel tunnel = new Panel();
        tunnel.Dock = DockStyle.Top;
        tunnel.Height = 170;
        tunnel.Padding = new Padding(12);
        tunnel.BackColor = Color.FromArgb(16, 23, 42);
        _right.Controls.Add(tunnel);

        Label ltp = MakeLabel(T("tunnel_port"));
        ltp.Location = new Point(12, 12);
        ltp.Width = 280;
        tunnel.Controls.Add(ltp);

        _numTunnelPort = new NumericUpDown();
        _numTunnelPort.Minimum = 0;
        _numTunnelPort.Maximum = 65535;
        _numTunnelPort.Value = 0;
        _numTunnelPort.Location = new Point(12, 36);
        _numTunnelPort.Width = 110;
        tunnel.Controls.Add(_numTunnelPort);

        _btnSetTunnel = MakeButton(T("set"));
        _btnSetTunnel.Location = new Point(152, 34);
        _btnSetTunnel.Width = 120;
        tunnel.Controls.Add(_btnSetTunnel);

        Label lcp = MakeLabel(T("client_listen_port"));
        lcp.Location = new Point(12, 74);
        lcp.Width = 280;
        tunnel.Controls.Add(lcp);

        _numTunnelClientPort = new NumericUpDown();
        _numTunnelClientPort.Minimum = 0;
        _numTunnelClientPort.Maximum = 65535;
        _numTunnelClientPort.Value = 0;
        _numTunnelClientPort.Location = new Point(12, 98);
        _numTunnelClientPort.Width = 110;
        tunnel.Controls.Add(_numTunnelClientPort);

        _btnEnableTunnelClient = MakeButton(T("enable"));
        _btnEnableTunnelClient.Location = new Point(152, 96);
        _btnEnableTunnelClient.Width = 120;
        tunnel.Controls.Add(_btnEnableTunnelClient);

        Label lPeers = MakeHeader(T("peers"));
        lPeers.Dock = DockStyle.Top;
        _right.Controls.Add(lPeers);

        Panel peers = new Panel();
        peers.Dock = DockStyle.Top;
        peers.Height = 230;
        peers.Padding = new Padding(12);
        peers.BackColor = Color.FromArgb(16, 23, 42);
        _right.Controls.Add(peers);

        _peerList = new ListBox();
        _peerList.Location = new Point(12, 12);
        _peerList.Size = new Size(280, 100);
        _peerList.BackColor = Color.FromArgb(24, 32, 56);
        _peerList.ForeColor = Color.White;
        _peerList.BorderStyle = BorderStyle.None;
        peers.Controls.Add(_peerList);

        Label lVol = MakeLabel(T("volume"));
        lVol.Location = new Point(12, 122);
        lVol.Width = 120;
        peers.Controls.Add(lVol);

        _peerVolume = new TrackBar();
        _peerVolume.Location = new Point(12, 144);
        _peerVolume.Width = 280;
        _peerVolume.Minimum = 0;
        _peerVolume.Maximum = 200;
        _peerVolume.TickFrequency = 25;
        _peerVolume.Value = 100;
        peers.Controls.Add(_peerVolume);

        _peerMute = new CheckBox();
        _peerMute.Text = T("mute");
        _peerMute.ForeColor = Color.White;
        _peerMute.Location = new Point(12, 188);
        _peerMute.Width = 120;
        peers.Controls.Add(_peerMute);

        Label lSec = MakeHeader(T("blacklist"));
        lSec.Dock = DockStyle.Top;
        _right.Controls.Add(lSec);

        Panel bl = new Panel();
        bl.Dock = DockStyle.Fill;
        bl.Padding = new Padding(12);
        bl.BackColor = Color.FromArgb(16, 23, 42);
        _right.Controls.Add(bl);

        _blacklistList = new ListBox();
        _blacklistList.Location = new Point(12, 12);
        _blacklistList.Size = new Size(280, 90);
        _blacklistList.BackColor = Color.FromArgb(24, 32, 56);
        _blacklistList.ForeColor = Color.White;
        _blacklistList.BorderStyle = BorderStyle.None;
        bl.Controls.Add(_blacklistList);

        _blacklistInput = new TextBox();
        _blacklistInput.Location = new Point(12, 110);
        _blacklistInput.Width = 120;
        _blacklistInput.BackColor = Color.FromArgb(24, 32, 56);
        _blacklistInput.ForeColor = Color.White;
        _blacklistInput.BorderStyle = BorderStyle.FixedSingle;
        bl.Controls.Add(_blacklistInput);

        _btnBlacklistAdd = MakeButton(T("add"));
        _btnBlacklistAdd.Location = new Point(152, 108);
        _btnBlacklistAdd.Width = 68;
        bl.Controls.Add(_btnBlacklistAdd);

        _btnBlacklistRemove = MakeButton(T("remove"));
        _btnBlacklistRemove.Location = new Point(224, 108);
        _btnBlacklistRemove.Width = 68;
        bl.Controls.Add(_btnBlacklistRemove);

        _btnContactAdd = MakeButton(T("add"));
        _btnContactAdd.Location = new Point(12, 142);
        _btnContactAdd.Width = 68;
        bl.Controls.Add(_btnContactAdd);

        _btnContactRemove = MakeButton(T("remove"));
        _btnContactRemove.Location = new Point(86, 142);
        _btnContactRemove.Width = 68;
        bl.Controls.Add(_btnContactRemove);

        Label lHotkeys = MakeHeader(T("hotkeys"));
        lHotkeys.Dock = DockStyle.Top;
        _right.Controls.Add(lHotkeys);

        Panel hotkeys = new Panel();
        hotkeys.Dock = DockStyle.Top;
        hotkeys.Height = 100;
        hotkeys.Padding = new Padding(12);
        hotkeys.BackColor = Color.FromArgb(16, 23, 42);
        _right.Controls.Add(hotkeys);

        Label lPttKey = MakeLabel("PTT " + T("key"));
        lPttKey.Location = new Point(12, 12);
        lPttKey.Width = 120;
        hotkeys.Controls.Add(lPttKey);

        _tbPttKey = new TextBox();
        _tbPttKey.Location = new Point(140, 10);
        _tbPttKey.Width = 80;
        _tbPttKey.Text = _settings.PttKey;
        _tbPttKey.BackColor = Color.FromArgb(24, 32, 56);
        _tbPttKey.ForeColor = Color.White;
        _tbPttKey.BorderStyle = BorderStyle.FixedSingle;
        hotkeys.Controls.Add(_tbPttKey);

        Label lMuteKey = MakeLabel(T("mute") + " " + T("key"));
        lMuteKey.Location = new Point(12, 42);
        lMuteKey.Width = 120;
        hotkeys.Controls.Add(lMuteKey);

        _tbMuteKey = new TextBox();
        _tbMuteKey.Location = new Point(140, 40);
        _tbMuteKey.Width = 80;
        _tbMuteKey.Text = _settings.MuteToggleKey;
        _tbMuteKey.BackColor = Color.FromArgb(24, 32, 56);
        _tbMuteKey.ForeColor = Color.White;
        _tbMuteKey.BorderStyle = BorderStyle.FixedSingle;
        hotkeys.Controls.Add(_tbMuteKey);

        _btnSaveHotkeys = MakeButton(T("save"));
        _btnSaveHotkeys.Location = new Point(230, 40);
        _btnSaveHotkeys.Width = 72;
        hotkeys.Controls.Add(_btnSaveHotkeys);

        FlowLayoutPanel footerLinks = new FlowLayoutPanel();
        footerLinks.Dock = DockStyle.Fill;
        footerLinks.FlowDirection = FlowDirection.LeftToRight;
        footerLinks.WrapContents = false;
        footerLinks.Padding = new Padding(12, 14, 12, 12);
        _footer.Controls.Add(footerLinks);

        LinkLabel github = new LinkLabel();
        github.Text = "github.com/adiru3";
        github.LinkColor = Color.Cyan;
        github.ActiveLinkColor = Color.FromArgb(0, 255, 120);
        github.VisitedLinkColor = Color.Cyan;
        github.AutoSize = true;
        github.LinkClicked += delegate { OpenUrl("https://github.com/adiru3"); };
        footerLinks.Controls.Add(github);

        Label sep = MakeLabel("   |");
        sep.AutoSize = true;
        sep.ForeColor = Color.FromArgb(140, 200, 255);
        footerLinks.Controls.Add(sep);

        LinkLabel donate = new LinkLabel();
        donate.Text = "Donate";
        donate.LinkColor = Color.Cyan;
        donate.ActiveLinkColor = Color.FromArgb(0, 255, 120);
        donate.VisitedLinkColor = Color.Cyan;
        donate.AutoSize = true;
        donate.LinkClicked += delegate { OpenUrl("https://adiru3.github.io/Donate/"); };
        footerLinks.Controls.Add(donate);
    }

    private void BindEvents()
    {
        _rooms.RoomUpdated += delegate (Guid id) { BeginInvoke((MethodInvoker)delegate { if (_rooms.GetActiveRoomId() == id) RefreshChat(); RefreshRoomList(); }); };
        _rooms.RoomsChanged += delegate { BeginInvoke((MethodInvoker)delegate { RefreshRoomList(); }); };

        _roomList.SelectedIndexChanged += delegate
        {
            RoomListItem item = _roomList.SelectedItem as RoomListItem;
            if (item != null)
            {
                _rooms.SetActiveRoom(item.RoomId);
                _audio.SetRoom(item.RoomId);
                RefreshChat();
                RoomManager.Room r = _rooms.GetRoom(item.RoomId);
                if (r != null)
                {
                    _numTunnelPort.Value = r.TunnelPort;
                }
            }
        };

        _send.Click += delegate { DoSendChat(); };
        _chatInput.KeyDown += delegate (object s, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                DoSendChat();
            }
        };

        _btnCreateRoom.Click += delegate { ShowCreateRoomDialog(); };
        _btnJoinRoom.Click += delegate { ShowJoinRoomDialog(); };

        _btnSaveProfile.Click += delegate { SaveProfile(); };
        _cbLang.SelectedIndexChanged += delegate { SaveProfile(); };

        _btnStartCall.Click += delegate { _audio.StartCall(); };
        _btnStopCall.Click += delegate { _audio.StopCall(); };
        _cbMute.CheckedChanged += delegate { _audio.SetMute(_cbMute.Checked); };
        _cbDeafen.CheckedChanged += delegate { _audio.SetDeafen(_cbDeafen.Checked); };

        _cbCallTarget.SelectedIndexChanged += delegate
        {
            object sel = _cbCallTarget.SelectedItem;
            PeerListItem pli = sel as PeerListItem;
            if (pli == null || string.IsNullOrEmpty(pli.UserId))
            {
                _audio.SetDirectTarget(null);
            }
            else
            {
                _audio.SetDirectTarget(pli.UserId);
            }
        };

        _btnSetTunnel.Click += delegate
        {
            Guid rid = _rooms.GetActiveRoomId();
            if (rid == Guid.Empty) return;
            int port = (int)_numTunnelPort.Value;
            _rooms.SetTunnelPort(rid, port);
            if (port > 0)
            {
                _net.EnsureTunnelHost(rid, port);
            }
        };

        _btnEnableTunnelClient.Click += delegate
        {
            Guid rid = _rooms.GetActiveRoomId();
            if (rid == Guid.Empty) return;
            int port = (int)_numTunnelClientPort.Value;
            if (port > 0)
            {
                _net.EnableTunnelClient(rid, port);
            }
        };

        _peerList.SelectedIndexChanged += delegate { SyncPeerControlsFromSelection(); };
        _peerVolume.Scroll += delegate { ApplyPeerControlsToSelection(); };
        _peerMute.CheckedChanged += delegate { ApplyPeerControlsToSelection(); };

        _btnBlacklistAdd.Click += delegate { AddBlacklist(); };
        _btnBlacklistRemove.Click += delegate { RemoveSelectedBlacklist(); };
        _btnContactAdd.Click += delegate { AddContactDialog(); };
        _btnContactRemove.Click += delegate { RemoveSelectedContact(); };
        _btnSaveHotkeys.Click += delegate { SaveHotkeys(); };

        KeyDown += delegate (object s, KeyEventArgs e)
        {
            Keys pttKey = ParseKey(_settings.PttKey);
            Keys muteKey = ParseKey(_settings.MuteToggleKey);
            
            if (e.KeyCode == pttKey)
            {
                _pttHeld = true;
                _audio.SetPushToTalk(true);
            }
            else if (e.KeyCode == muteKey)
            {
                // Toggle mute
                _cbMute.Checked = !_cbMute.Checked;
            }
        };
        KeyUp += delegate (object s, KeyEventArgs e)
        {
            Keys pttKey = ParseKey(_settings.PttKey);
            
            if (e.KeyCode == pttKey)
            {
                _pttHeld = false;
                _audio.SetPushToTalk(false);
            }
        };
    }

    private void SaveProfile()
    {
        try
        {
            if (!string.IsNullOrEmpty(_tbName.Text))
            {
                _settings.DisplayName = _tbName.Text.Trim();
            }
            object sel = _cbLang.SelectedItem;
            if (sel != null)
            {
                _lang = sel.ToString();
                _settings.Language = _lang;
            }
            _settings.AcceptContactsOnly = _cbContactsOnly.Checked;
            _settingsProvider.Save(_settings);

            BuildLocalization();
            ApplyLocalizationToUi();
        }
        catch
        {
        }
    }

    private void ApplyLocalizationToUi()
    {
        _btnCreateRoom.Text = T("create_room");
        _btnJoinRoom.Text = T("join_room");
        _send.Text = T("send");
        _cbContactsOnly.Text = T("contacts_only");
        _btnSaveProfile.Text = T("save");
        _btnStartCall.Text = T("start_call");
        _btnStopCall.Text = T("stop_call");
        _cbMute.Text = T("mute");
        _cbDeafen.Text = T("deafen");
        _lblPtt.Text = string.Format(T("ptt"), _settings.PttKey);
        _btnSetTunnel.Text = T("set");
        if (_btnEnableTunnelClient != null) _btnEnableTunnelClient.Text = T("enable");
        if (_peerMute != null) _peerMute.Text = T("mute");
        if (_btnBlacklistAdd != null) _btnBlacklistAdd.Text = T("add");
        if (_btnBlacklistRemove != null) _btnBlacklistRemove.Text = T("remove");
        if (_btnContactAdd != null) _btnContactAdd.Text = T("add");
        if (_btnContactRemove != null) _btnContactRemove.Text = T("remove");
        if (_btnSaveHotkeys != null) _btnSaveHotkeys.Text = T("save");
        if (_tabs.TabPages.Count > 0)
        {
            _tabs.TabPages[0].Text = T("chat");
        }
        if (_leftTabs != null && _leftTabs.TabPages.Count >= 2)
        {
            _leftTabs.TabPages[0].Text = T("rooms");
            _leftTabs.TabPages[1].Text = T("contacts");
        }
    }

    private void RefreshUi()
    {
        RefreshRoomList();
        RefreshContactsList();
        RefreshPeersUi();
        RefreshBlacklist();
        RefreshChat();
    }

    private void RefreshContactsList()
    {
        if (_contactsList == null) return;
        List<ContactListItem> items = new List<ContactListItem>();
        for (int i = 0; i < _settings.Contacts.Count; i++)
        {
            SettingsProvider.Contact c = _settings.Contacts[i];
            ContactListItem it = new ContactListItem(c.UserId, c.DisplayName, c.AvatarBase64);
            items.Add(it);
        }
        _contactsList.BeginUpdate();
        _contactsList.Items.Clear();
        for (int i = 0; i < items.Count; i++)
        {
            _contactsList.Items.Add(items[i]);
        }
        _contactsList.EndUpdate();
    }

    private void RefreshBlacklist()
    {
        if (_blacklistList == null) return;
        _blacklistList.BeginUpdate();
        _blacklistList.Items.Clear();
        for (int i = 0; i < _settings.Blacklist.Count; i++)
        {
            _blacklistList.Items.Add(_settings.Blacklist[i]);
        }
        _blacklistList.EndUpdate();
    }

    private void RefreshPeersUi()
    {
        if (_peerList == null) return;
        Guid rid = _rooms.GetActiveRoomId();
        List<RoomManager.Peer> peers = _rooms.GetPeersSnapshot(rid);
        List<PeerListItem> items = new List<PeerListItem>();
        for (int i = 0; i < peers.Count; i++)
        {
            RoomManager.Peer p = peers[i];
            items.Add(new PeerListItem(p.UserId, p.DisplayName, p.Volume, p.Muted));
        }

        object prev = _peerList.SelectedItem;
        string prevId = null;
        PeerListItem pli = prev as PeerListItem;
        if (pli != null) prevId = pli.UserId;

        _peerList.BeginUpdate();
        _peerList.Items.Clear();
        for (int i = 0; i < items.Count; i++)
        {
            _peerList.Items.Add(items[i]);
        }
        _peerList.EndUpdate();

        if (!string.IsNullOrEmpty(prevId))
        {
            for (int i = 0; i < _peerList.Items.Count; i++)
            {
                PeerListItem x = _peerList.Items[i] as PeerListItem;
                if (x != null && string.Equals(x.UserId, prevId, StringComparison.OrdinalIgnoreCase))
                {
                    _peerList.SelectedIndex = i;
                    break;
                }
            }
        }

        if (_cbCallTarget != null)
        {
            object sel = _cbCallTarget.SelectedItem;
            string selId = null;
            PeerListItem selItem = sel as PeerListItem;
            if (selItem != null) selId = selItem.UserId;

            _cbCallTarget.BeginUpdate();
            _cbCallTarget.Items.Clear();
            _cbCallTarget.Items.Add(new PeerListItem(null, T("room_broadcast"), 1.0f, false));
            for (int i = 0; i < items.Count; i++)
            {
                _cbCallTarget.Items.Add(items[i]);
            }
            _cbCallTarget.EndUpdate();

            int newIndex = 0;
            if (!string.IsNullOrEmpty(selId))
            {
                for (int i = 0; i < _cbCallTarget.Items.Count; i++)
                {
                    PeerListItem x = _cbCallTarget.Items[i] as PeerListItem;
                    if (x != null && string.Equals(x.UserId, selId, StringComparison.OrdinalIgnoreCase))
                    {
                        newIndex = i;
                        break;
                    }
                }
            }
            _cbCallTarget.SelectedIndex = newIndex;
        }

        SyncPeerControlsFromSelection();
    }

    private void SyncPeerControlsFromSelection()
    {
        PeerListItem sel = _peerList.SelectedItem as PeerListItem;
        if (sel == null)
        {
            _peerVolume.Value = 100;
            _peerMute.Checked = false;
            return;
        }
        int v = (int)(sel.Volume * 100.0f);
        if (v < _peerVolume.Minimum) v = _peerVolume.Minimum;
        if (v > _peerVolume.Maximum) v = _peerVolume.Maximum;
        _peerVolume.Value = v;
        _peerMute.Checked = sel.Muted;
    }

    private void ApplyPeerControlsToSelection()
    {
        PeerListItem sel = _peerList.SelectedItem as PeerListItem;
        if (sel == null) return;
        Guid rid = _rooms.GetActiveRoomId();
        float vol = _peerVolume.Value / 100.0f;
        _rooms.SetPeerVolume(rid, sel.UserId, vol);
        _rooms.SetPeerMuted(rid, sel.UserId, _peerMute.Checked);
    }

    private void AddBlacklist()
    {
        string ip = _blacklistInput.Text;
        if (string.IsNullOrEmpty(ip)) return;
        ip = ip.Trim();
        IPAddress addr;
        if (!IPAddress.TryParse(ip, out addr))
        {
            return;
        }
        for (int i = 0; i < _settings.Blacklist.Count; i++)
        {
            if (string.Equals(_settings.Blacklist[i], ip, StringComparison.OrdinalIgnoreCase))
            {
                return;
            }
        }
        _settings.Blacklist.Add(ip);
        _settingsProvider.Save(_settings);
        _blacklistInput.Text = "";
        RefreshBlacklist();
    }

    private void RemoveSelectedBlacklist()
    {
        object sel = _blacklistList.SelectedItem;
        if (sel == null) return;
        string ip = sel.ToString();
        for (int i = _settings.Blacklist.Count - 1; i >= 0; i--)
        {
            if (string.Equals(_settings.Blacklist[i], ip, StringComparison.OrdinalIgnoreCase))
            {
                _settings.Blacklist.RemoveAt(i);
            }
        }
        _settingsProvider.Save(_settings);
        RefreshBlacklist();
    }

    private void AddContactDialog()
    {
        using (Form f = new Form())
        {
            f.Text = T("contacts");
            f.StartPosition = FormStartPosition.CenterParent;
            f.Width = 480;
            f.Height = 320;
            f.FormBorderStyle = FormBorderStyle.FixedDialog;
            f.MaximizeBox = false;
            f.MinimizeBox = false;
            f.BackColor = Color.FromArgb(16, 23, 42);
            f.ForeColor = Color.White;

            Label lid = MakeLabel(T("user_id"));
            lid.Location = new Point(12, 12);
            lid.Width = 440;
            f.Controls.Add(lid);
            TextBox tbId = new TextBox();
            tbId.Location = new Point(12, 34);
            tbId.Width = 440;
            tbId.BackColor = Color.FromArgb(24, 32, 56);
            tbId.ForeColor = Color.White;
            tbId.BorderStyle = BorderStyle.FixedSingle;
            f.Controls.Add(tbId);

            Label ln = MakeLabel(T("name"));
            ln.Location = new Point(12, 66);
            ln.Width = 440;
            f.Controls.Add(ln);
            TextBox tbName = new TextBox();
            tbName.Location = new Point(12, 88);
            tbName.Width = 440;
            tbName.BackColor = Color.FromArgb(24, 32, 56);
            tbName.ForeColor = Color.White;
            tbName.BorderStyle = BorderStyle.FixedSingle;
            f.Controls.Add(tbName);

            Label lav = MakeLabel(T("avatar_base64"));
            lav.Location = new Point(12, 120);
            lav.Width = 440;
            f.Controls.Add(lav);
            TextBox tbAv = new TextBox();
            tbAv.Location = new Point(12, 142);
            tbAv.Size = new Size(440, 90);
            tbAv.Multiline = true;
            tbAv.ScrollBars = ScrollBars.Vertical;
            tbAv.BackColor = Color.FromArgb(24, 32, 56);
            tbAv.ForeColor = Color.White;
            tbAv.BorderStyle = BorderStyle.FixedSingle;
            f.Controls.Add(tbAv);

            Button ok = MakeButton("OK");
            ok.Location = new Point(380, 242);
            ok.DialogResult = DialogResult.OK;
            f.Controls.Add(ok);

            if (f.ShowDialog(this) == DialogResult.OK)
            {
                string id = tbId.Text.Trim();
                string name = tbName.Text.Trim();
                string av = tbAv.Text.Trim();
                if (string.IsNullOrEmpty(id)) return;
                for (int i = 0; i < _settings.Contacts.Count; i++)
                {
                    if (string.Equals(_settings.Contacts[i].UserId, id, StringComparison.OrdinalIgnoreCase))
                    {
                        _settings.Contacts[i].DisplayName = name;
                        _settings.Contacts[i].AvatarBase64 = av;
                        _settingsProvider.Save(_settings);
                        RefreshContactsList();
                        return;
                    }
                }
                SettingsProvider.Contact c = new SettingsProvider.Contact();
                c.UserId = id;
                c.DisplayName = name;
                c.AvatarBase64 = av;
                _settings.Contacts.Add(c);
                _settingsProvider.Save(_settings);
                RefreshContactsList();
            }
        }
    }

    private void RemoveSelectedContact()
    {
        ContactListItem sel = _contactsList.SelectedItem as ContactListItem;
        if (sel == null) return;
        for (int i = _settings.Contacts.Count - 1; i >= 0; i--)
        {
            if (string.Equals(_settings.Contacts[i].UserId, sel.UserId, StringComparison.OrdinalIgnoreCase))
            {
                _settings.Contacts.RemoveAt(i);
            }
        }
        _settingsProvider.Save(_settings);
        RefreshContactsList();
    }

    private void SaveHotkeys()
    {
        try
        {
            _settings.PttKey = _tbPttKey.Text.Trim();
            _settings.MuteToggleKey = _tbMuteKey.Text.Trim();
            _settingsProvider.Save(_settings);
        }
        catch
        {
        }
    }

    private Keys ParseKey(string keyName)
    {
        if (string.IsNullOrEmpty(keyName)) return Keys.None;
        try
        {
            return (Keys)Enum.Parse(typeof(Keys), keyName, true);
        }
        catch
        {
            return Keys.None;
        }
    }

    private void RefreshRoomList()
    {
        Guid active = _rooms.GetActiveRoomId();
        List<RoomManager.Room> rooms = _rooms.GetRoomsSnapshot();
        List<RoomListItem> items = new List<RoomListItem>();
        for (int i = 0; i < rooms.Count; i++)
        {
            RoomManager.Room r = rooms[i];
            int peers = 0;
            if (r.Peers != null) peers = r.Peers.Count;
            items.Add(new RoomListItem(r.RoomId, string.Format("{0}  ({1})", r.Name, peers)));
        }

        RoomListItem selected = null;
        _roomList.BeginUpdate();
        _roomList.Items.Clear();
        for (int i = 0; i < items.Count; i++)
        {
            _roomList.Items.Add(items[i]);
            if (items[i].RoomId == active)
            {
                selected = items[i];
            }
        }
        _roomList.EndUpdate();

        if (selected != null)
        {
            _roomList.SelectedItem = selected;
        }
        else if (_roomList.Items.Count > 0)
        {
            _roomList.SelectedIndex = 0;
        }
    }

    private void RefreshChat()
    {
        Guid active = _rooms.GetActiveRoomId();
        if (active == Guid.Empty)
        {
            _chat.Text = "";
            return;
        }
        List<RoomManager.ChatMessage> msgs = _rooms.GetChatSnapshot(active);
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < msgs.Count; i++)
        {
            RoomManager.ChatMessage m = msgs[i];
            sb.Append("[");
            sb.Append(m.Utc.ToLocalTime().ToString("HH:mm:ss"));
            sb.Append("] ");
            sb.Append(m.DisplayName);
            sb.Append(": ");
            sb.AppendLine(m.Text);
        }
        string newText = sb.ToString();
        if (!string.Equals(_chat.Text, newText, StringComparison.Ordinal))
        {
            int sel = _chat.SelectionStart;
            _chat.Text = newText;
            _chat.SelectionStart = _chat.TextLength;
            _chat.ScrollToCaret();
        }
    }

    private void DoSendChat()
    {
        string text = _chatInput.Text;
        if (string.IsNullOrEmpty(text)) return;
        Guid active = _rooms.GetActiveRoomId();
        if (active == Guid.Empty) return;
        _chatInput.Text = "";
        _net.SendChat(active, text);
        RefreshChat();
    }

    private void ShowCreateRoomDialog()
    {
        using (Form f = new Form())
        {
            f.Text = T("create_room_title");
            f.StartPosition = FormStartPosition.CenterParent;
            f.Width = 420;
            f.Height = 220;
            f.FormBorderStyle = FormBorderStyle.FixedDialog;
            f.MaximizeBox = false;
            f.MinimizeBox = false;
            f.BackColor = Color.FromArgb(16, 23, 42);
            f.ForeColor = Color.White;

            Label ln = MakeLabel(T("room_name"));
            ln.Location = new Point(12, 12);
            ln.Width = 380;
            f.Controls.Add(ln);
            TextBox tbName = new TextBox();
            tbName.Location = new Point(12, 34);
            tbName.Width = 380;
            tbName.BackColor = Color.FromArgb(24, 32, 56);
            tbName.ForeColor = Color.White;
            f.Controls.Add(tbName);

            Label lp = MakeLabel(T("room_password"));
            lp.Location = new Point(12, 70);
            lp.Width = 380;
            f.Controls.Add(lp);
            TextBox tbPass = new TextBox();
            tbPass.Location = new Point(12, 92);
            tbPass.Width = 380;
            tbPass.UseSystemPasswordChar = true;
            tbPass.BackColor = Color.FromArgb(24, 32, 56);
            tbPass.ForeColor = Color.White;
            f.Controls.Add(tbPass);

            Button ok = MakeButton("OK");
            ok.Location = new Point(312, 130);
            ok.DialogResult = DialogResult.OK;
            f.Controls.Add(ok);

            if (f.ShowDialog(this) == DialogResult.OK)
            {
                string name = tbName.Text.Trim();
                string pass = tbPass.Text;
                if (string.IsNullOrEmpty(name)) return;
                RoomManager.Room room = _rooms.CreateRoom(name, pass);
                _audio.SetRoom(room.RoomId);
                RefreshUi();
            }
        }
    }

    private void ShowJoinRoomDialog()
    {
        using (Form f = new Form())
        {
            f.Text = T("join_room_title");
            f.StartPosition = FormStartPosition.CenterParent;
            f.Width = 420;
            f.Height = 270;
            f.FormBorderStyle = FormBorderStyle.FixedDialog;
            f.MaximizeBox = false;
            f.MinimizeBox = false;
            f.BackColor = Color.FromArgb(16, 23, 42);
            f.ForeColor = Color.White;

            Label ln = MakeLabel(T("room_name"));
            ln.Location = new Point(12, 12);
            ln.Width = 380;
            f.Controls.Add(ln);
            TextBox tbName = new TextBox();
            tbName.Location = new Point(12, 34);
            tbName.Width = 380;
            tbName.BackColor = Color.FromArgb(24, 32, 56);
            tbName.ForeColor = Color.White;
            f.Controls.Add(tbName);

            Label lid = MakeLabel(T("room_id"));
            lid.Location = new Point(12, 70);
            lid.Width = 380;
            f.Controls.Add(lid);
            TextBox tbId = new TextBox();
            tbId.Location = new Point(12, 92);
            tbId.Width = 380;
            tbId.BackColor = Color.FromArgb(24, 32, 56);
            tbId.ForeColor = Color.White;
            f.Controls.Add(tbId);

            Label lp = MakeLabel(T("room_password"));
            lp.Location = new Point(12, 128);
            lp.Width = 380;
            f.Controls.Add(lp);
            TextBox tbPass = new TextBox();
            tbPass.Location = new Point(12, 150);
            tbPass.Width = 380;
            tbPass.UseSystemPasswordChar = true;
            tbPass.BackColor = Color.FromArgb(24, 32, 56);
            tbPass.ForeColor = Color.White;
            f.Controls.Add(tbPass);

            Button ok = MakeButton("OK");
            ok.Location = new Point(312, 188);
            ok.DialogResult = DialogResult.OK;
            f.Controls.Add(ok);

            if (f.ShowDialog(this) == DialogResult.OK)
            {
                string name = tbName.Text.Trim();
                string pass = tbPass.Text;
                string idStr = tbId.Text.Trim();
                Guid rid;
                if (string.IsNullOrEmpty(name)) return;
                if (!Guid.TryParse(idStr, out rid))
                {
                    MessageBox.Show(T("invalid_roomid"), "AmazeBridge", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                RoomManager.Room room = _rooms.JoinRoom(name, pass, rid);
                _audio.SetRoom(room.RoomId);
                RefreshUi();
            }
        }
    }

    private static void OpenUrl(string url)
    {
        try
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = url;
            psi.UseShellExecute = true;
            Process.Start(psi);
        }
        catch
        {
        }
    }

    private static Label MakeHeader(string text)
    {
        Label l = new Label();
        l.Text = text;
        l.Height = 34;
        l.TextAlign = ContentAlignment.MiddleLeft;
        l.Padding = new Padding(12, 0, 12, 0);
        l.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
        l.ForeColor = Color.FromArgb(190, 220, 255);
        l.BackColor = Color.FromArgb(18, 26, 48);
        return l;
    }

    private static Label MakeLabel(string text)
    {
        Label l = new Label();
        l.Text = text;
        l.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
        l.ForeColor = Color.FromArgb(200, 230, 255);
        l.BackColor = Color.Transparent;
        return l;
    }

    private static Button MakeButton(string text)
    {
        Button b = new Button();
        b.Text = text;
        b.FlatStyle = FlatStyle.Flat;
        b.FlatAppearance.BorderSize = 1;
        b.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 200);
        b.BackColor = Color.FromArgb(18, 35, 64);
        b.ForeColor = Color.White;
        b.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        b.Height = 28;
        return b;
    }

    private class RoomListItem
    {
        public Guid RoomId;
        public string Text;
        public RoomListItem(Guid id, string text)
        {
            RoomId = id;
            Text = text;
        }
        public override string ToString()
        {
            return Text;
        }
    }

    private class PeerListItem
    {
        public string UserId;
        public string DisplayName;
        public float Volume;
        public bool Muted;
        public PeerListItem(string userId, string displayName, float volume, bool muted)
        {
            UserId = userId;
            DisplayName = displayName;
            Volume = volume;
            Muted = muted;
        }
        public override string ToString()
        {
            if (string.IsNullOrEmpty(UserId))
            {
                return DisplayName;
            }
            string m = Muted ? " [M]" : "";
            return DisplayName + m;
        }
    }

    private class ContactListItem
    {
        public string UserId;
        public string DisplayName;
        public string AvatarBase64;
        public ContactListItem(string userId, string displayName, string avatarBase64)
        {
            UserId = userId;
            DisplayName = displayName;
            AvatarBase64 = avatarBase64;
        }
        public override string ToString()
        {
            string name = DisplayName;
            if (string.IsNullOrEmpty(name)) name = UserId;
            return name;
        }
    }

    private class AvatarListBox : ListBox
    {
        public AvatarListBox()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            ItemHeight = 44;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index < 0 || e.Index >= Items.Count)
            {
                return;
            }

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle r = e.Bounds;

            ContactListItem item = Items[e.Index] as ContactListItem;
            string text = item != null ? item.ToString() : Items[e.Index].ToString();
            string base64 = item != null ? item.AvatarBase64 : null;

            Rectangle avatarRect = new Rectangle(r.X + 8, r.Y + 6, 32, 32);
            DrawAvatar(g, avatarRect, base64, text);

            using (SolidBrush b = new SolidBrush(ForeColor))
            {
                g.DrawString(text, Font, b, r.X + 48, r.Y + 12);
            }

            e.DrawFocusRectangle();
        }

        private static void DrawAvatar(Graphics g, Rectangle rect, string base64, string fallback)
        {
            Image img = null;
            if (!string.IsNullOrEmpty(base64))
            {
                try
                {
                    byte[] bytes = Convert.FromBase64String(base64);
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        img = Image.FromStream(ms);
                    }
                }
                catch
                {
                    img = null;
                }
            }

            using (GraphicsPath p = new GraphicsPath())
            {
                p.AddEllipse(rect);
                using (SolidBrush bg = new SolidBrush(Color.FromArgb(40, 0, 255, 220)))
                {
                    g.FillPath(bg, p);
                }
                if (img != null)
                {
                    try
                    {
                        g.SetClip(p);
                        g.DrawImage(img, rect);
                        g.ResetClip();
                    }
                    catch
                    {
                        g.ResetClip();
                    }
                    try
                    {
                        img.Dispose();
                    }
                    catch
                    {
                    }
                }
                else
                {
                    string initials = "?";
                    if (!string.IsNullOrEmpty(fallback))
                    {
                        initials = fallback.Trim();
                        if (initials.Length > 2) initials = initials.Substring(0, 2);
                    }
                    using (StringFormat sf = new StringFormat())
                    {
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;
                        using (SolidBrush tb = new SolidBrush(Color.White))
                        {
                            g.DrawString(initials, new Font("Segoe UI", 9.0f, FontStyle.Bold), tb, rect, sf);
                        }
                    }
                }
                using (Pen border = new Pen(Color.FromArgb(120, 0, 255, 220), 1.2f))
                {
                    g.DrawEllipse(border, rect);
                }
            }
        }
    }

    private class GlassPanel : Panel
    {
        public GlassPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle r = new Rectangle(6, 6, Width - 12, Height - 12);
            if (r.Width <= 0 || r.Height <= 0) return;

            using (GraphicsPath path = RoundedRect(r, 18))
            {
                using (SolidBrush bg = new SolidBrush(Color.FromArgb(90, 20, 30, 58)))
                {
                    g.FillPath(bg, path);
                }
                using (Pen border = new Pen(Color.FromArgb(120, 0, 255, 220), 1.2f))
                {
                    g.DrawPath(border, path);
                }
            }

            using (Pen glow = new Pen(Color.FromArgb(40, 0, 255, 220), 6.0f))
            {
                glow.LineJoin = LineJoin.Round;
                Rectangle rr = new Rectangle(10, 10, Width - 20, Height - 20);
                if (rr.Width > 0 && rr.Height > 0)
                {
                    using (GraphicsPath p2 = RoundedRect(rr, 18))
                    {
                        g.DrawPath(glow, p2);
                    }
                }
            }
        }

        private static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int d = radius * 2;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}

