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

            Main = new TMain
            {
                Commands = new List<string>
                {
                    "[ mc/bot ]( Bot Undang/Info/Statistik/Tautan )",
                    "[ mc/quiz ]( Kuis minecraft :D )",
                    "[ mc/colors ]( Kode warna MC )",
                    "[ mc/uuid {p} ]( Pemain UUID )",
                    "[ mc/ping (IP) ]( Ping a server )",
                    "[ mc/list ]( Daftar server komunitas )",
                    "[ mc/wiki ]( Wiki untuk Items/Mobs/Enchants/Ramuan )",
                    "[ mc/version ]( Info versi minecraft )",
                    "[ mc/skin {p} ]( Kulit pemain )",
                    "[ mc/names {p} ]( Sejarah nama akun MC )",
                    "[ mc/status ]( Mojang status )",
                    "[ mc/get (Teks) ]( Dapatkan prestasi )",
                    "[ mc/playing ]( Orang-orang bermain Minecraft )",
                    "[ mc/user ]( Akun Minecraft Anda, kulit dan statistiknya )",
                    "[ mc/rcon ]( Remote console for your Minecraft server )",
                    "[ mc/hypixel {p} ]( Statistik pemain hypixel )",
                    "[ mc/hive {p} ]( HiveMC player stats )",
                    "[ mc/wynncraft {p} ]( Wynncraft player stats )",
                    "[ mc/admin ]( Perintah admin komunitas )",
                    "[ mc/invite ]( Dapatkan undangan bot )"
                },
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

            Admin = new TAdmin
            {
                Commands = new List<string>
                {
                    "[ mc/lang ]( Tetapkan bahasa komunitas )",
                    "[ mc/mcrole ]( Buat peran Minecraft untuk pengguna terverifikasi )",
                    "[ mc/addserver ]( Tambahkan server MC ke daftar gilda ini )",
                    "[ mc/delserver ]( Hapus server MC dari daftar gilda ini )",
                    "[ mc/setprefix ]( Tetapkan Awalan Khusus )",
                    "[ mc/resetprefix ]( Hapus Awalan Khusus )"
                },
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