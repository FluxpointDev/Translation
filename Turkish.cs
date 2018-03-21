using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Turkish
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "Botun yetkisi yok \" Embed Linki \"",
                AdminOnly = "sen server admini değilsin",
                PlayerNotFound = "Oyuncu {0} Bulunamadi",
                ApiError = "API hatasi",
                EnterIP = "sunucu ipsini gir",
                InvalidIP = "boyle bir ip yok",
                Cooldown = "komutlari tekrar kullanmak için 1 dakka bekle",
                EnableQuery = "Minecraft sunucusu, sunucu.propertiesinde etkinleştirme sorgusu ayarlamadı",
                ListNoServers = "Bu topluluk listede bulunmuyor",
                UnknownArg = "Unknown argument do",
                TextLimit = "yazı limiti 22 olarak ayarlandı",
                RequireAttachFiles = "botun bir resim atmak için yetkisi yok",
                UnknownWiki = "wiki eşyasi bulunamadi"
            },

            MainCommands = new TMainCommands
            {
                BotInfo = "Bot info and stats",
                Quiz = "Minecraft testleri :D",
                Color = "MC renk kodlari",
                NameHistory = "MC hesabi isim geçmisi",
                UserProfile = "Senin minecraft hesabin, cildin ve istatistikler",
                Ping = "serverin pingini gosterir",
                Version = "Minecraft version bilgisi",
                Rcon = "Remote console for your Minecraft server",
                Achievement = "Başarim olarak gosterir",
                Playing = "bu kişi minecraft oynuyormu",
                List = "topluluk serverlerini listeler",
                Admin = "topluluk admini komutlari",
                Invite = "botu davet etmek için kullan"
            },

            Main = new TMain
            {
                HelpFooter = "bazı gizli komutlarda var evlat ;)",
                MultiMC = "MultiMC birden fazla modu ve cild kurulumunu kolaylaştirmanizi sağlar",
                PleaseWait = "Lutfen bekle ben pingliyim",
                ServerAdminUse = "Sadece server admini kullana bilir",
                StoleSkin = "çaldi cilt",
                NameOnlyOne = "Oyuncu {0} sadece 1 isim ile kayitli",
                PlayingMinecraft = "kullanici minecraft oynuyor",
                Hi = "Merhaba",
                BotDesc = "Herhangi bir sorun, öneri veya dil çevirileriniz varsa lütfen bana ulaşın.",
                First = "İlk"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Hey, sen gizli komutlari buldun :D",
                Herobrine = "Herzaman Seni izliyorum...",
                Notch = "Minecraft benim sayemde kuruldu"
            },

            Wiki = new TWiki
            {
                Blocks = "Blok",
                Unknown = "Bulunamadi",
                Player = "Oyuncu",
                Players = "Oyuncular",
                Attack = "Saldırı",
                Easy = "Kolay",
                Hard = "Zor",
                Health = "sağlık",
                Height = "Yukseklik",
                Width = "Genişlik"
            },

            Profile = new TProfile
            {
                Badges = "Başarım",
                BadgeInfo = "Başarım bilgilendirmesi",
                InvalidUserID = "kullanici id si bulunamadi",
                UnknownUser = "Kullanıcı bulunamadı",
                NotInServer = "Sen bir server degilsin",
                SetMCName = "Minecraft Hesabini kullanman için"
            },

            AdminCommands = new TAdminCommands
            {
                MCRole = "minecraft hesabini dogrulayanlar için özel rol yapar",
                AutoPost = "Auto post your Minecraft server status",
                AddServer = "mc serverini eklemene yarar",
                RemoveServer = "mc serverini silmene yarar",
                SetPrefix = "istedigin bir prefixi ayarlar",
                ResetPrefix = "istedigin prefixi siler"
            },

            Admin = new TAdmin
            {
                WantTranslation = "Çevirilen bir dil mi istiyorsunuz? Ulas",
                ChangeLang = "Topluluk dilini değiştir",
                UseList = "Kullan mc/list bu bottaki sunuculari gormek için",
                AddServer = "tag gir, ip ve isim",
                AddServerAdded = "server eklendi {0} guild listesine bak",
                AddServerAlready = "Bu sunucu zaten listede",
                DelServerEnter = "bir sunucu sil",
                DelServerNone = "Bu sunucu listede yok",
                DelServerDeleted = "Server silindi {0} Guild listesine bak",
                PrefixReset = "Server prefix yenilendi kullan mc/",
                LanguageSet = "topluluk dili yenilendi"
            }
        };
    }
}
