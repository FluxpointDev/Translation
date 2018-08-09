using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Indonesian
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "Bot membutuhkan izin \" Embed Tautan \"",
                AdminOnly = "Anda bukan admin server",
                PlayerNotFound = "Pemain {0} tidak ditemukan",
                ApiError = "Kesalahan API",
                EnterIP = "Masukkan IP",
                InvalidIP = "IP tidak valid",
                Cooldown = "Anda berada di cooldown selama 1 menit!",
                EnableQuery = "Server Minecraft tidak memiliki enable-query yang ditetapkan di server.properties",
                ListNoServers = "Komunitas ini tidak memiliki server yang terdaftar",
                UnknownArg = "Argumen yang tidak diketahui lakukan",
                TextLimit = "Teks tidak boleh lebih dari 22 huruf/angka",
                RequireAttachFiles = "Bot membutuhkan izin melampirkan file",
                UnknownWiki = "Item wiki tidak diketahui"
            },

            MainCommands = new TMainCommands
            {
                BotInfo = "Bot info and stats",
                Quiz = "Kuis minecraft :D",
                Color = "Kode warna MC",
                NameHistory = "Sejarah nama akun MC",
                UserProfile = "Akun Minecraft Anda, kulit dan statistiknya",
                Ping = "Ping a server",
                Version = "Info versi minecraft",
                Rcon = "Remote console for your Minecraft server",
                Achievement = "Dapatkan prestasi",
                Playing = "Orang-orang bermain Minecraft",
                List = "Daftar server komunitas",
                Admin = "Perintah admin komunitas",
                Invite = "Dapatkan undangan bot"
            },

            Main = new TMain
            {
                HelpFooter = "Ada beberapa perintah tersembunyi juga ;)",
                MultiMC = "MultiMC memungkinkan Anda mengelola dan meluncurkan beberapa versi dengan instalasi forge/mods yang mudah",
                PleaseWait = "Mohon tunggu sementara aku ping",
                ServerAdminUse = "Admin server harus menggunakan",
                StoleSkin = "Mencuri kulit",
                NameOnlyOne = "Pemain {0} hanya memiliki 1 nama pada catatan",
                PlayingMinecraft = "Orang-orang bermain Minecraft",
                Hi = "Hai",
                BotDesc = "Jika ada masalah, saran atau terjemahan bahasa silahkan hubungi saya",
                First = "Pertama"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Hei, kamu menemukan perintah rahasia :D",
                Herobrine = "Selalu memperhatikanmu...",
                Notch = "Minecraft diciptakan oleh Notch alias Markus Persson"
            },

            Wiki = new TWiki
            {
                Blocks = "Blok",
                Unknown = "Tidak diketahui",
                Player = "Pemain",
                Players = "Pemain",
                Attack = "Menyerang",
                Easy = "Mudah",
                Hard = "Keras",
                Health = "Kesehatan",
                Height = "Tinggi",
                Width = "Lebar"
            },

            Profile = new TProfile
            {
                Badges = "Lencana",
                BadgeInfo = "Informasi lencana",
                InvalidUserID = "ID pengguna tidak valid",
                UnknownUser = "Tidak dapat menemukan pengguna",
                NotInServer = "Anda tidak berada di server",
                SetMCName = "Untuk mengatur penggunaan akun Minecraft Anda"
            },

            AdminCommands = new TAdminCommands
            {
                MCRole = "Buat peran Minecraft untuk pengguna terverifikasi",
                AutoPost = "Auto post your Minecraft server status",
                AddServer = "Tambahkan server MC ke daftar gilda ini",
                RemoveServer = "Hapus server MC dari daftar gilda ini",
                SetPrefix = "Tetapkan Awalan Khusus",
                ResetPrefix = "Hapus Awalan Khusus"
            },

            Admin = new TAdmin
            {
                WantTranslation = "Ingin bahasa diterjemahkan? Kontak",
                ChangeLang = "Ubah Bahasa Komunitas",
                UseList = "Gunakan mc/list untuk daftar server minecraft guild ini",
                AddServer = "Masukkan tag, ip dan nama",
                AddServerAdded = "Server yang ditambahkan {0} ke daftar guild",
                AddServerAlready = "Server ini sudah masuk dalam daftar",
                DelServerEnter = "Hapus server dengan",
                DelServerNone = "Server ini tidak ada dalam daftar",
                DelServerDeleted = "Server yang dihapus {0} dari daftar guild",
                PrefixReset = "Server prefix reset menggunakan mc/",
                LanguageSet = "Set bahasa komunitas"
            }
        };
    }
}
