using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Hungarian
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "A Bot engedélyt kér \"Linkek beágyazása\"",
                AdminOnly = "Ön nem szerver admin",
                PlayerNotFound = "A (z) {0} játékos nem található",
                ApiError = "API hiba",
                EnterIP = "Írjon be IP-címet",
                InvalidIP = "Érvénytelen IP",
                Cooldown = "Ön 1 percig tartja a cooldownot!",
                EnableQuery = "Az Minecraft kiszolgáló nem rendelkezik engedélyezési lekérdezéssel a server.properties mappában",
                ListNoServers = "Ennek a közösségnek nincs felsorolt szervere",
                UnknownArg = "Ismeretlen érvelés",
                TextLimit = "A szöveg legfeljebb 22 betű / szám lehet",
                RequireAttachFiles = "Botnak csatolni kell a fájlok engedélyezését",
                UnknownWiki = "Ismeretlen wiki tétel"
            },

            MainCommands = new TMainCommands
            {
                BotInfo = "Bot info and stats",
                Quiz = "Minecraft Kviz :D",
                Color = "MC Szinkodok",
                NameHistory = "MC fioknev elozmemyei",
                UserProfile = "Your Minecraft account, skin and stats",
                Ping = "Ping egy kiszolgalot",
                Version = "Minecraft verzloinformaciok",
                Rcon = "Remote console for your Minecraft server",
                Achievement = "Kapjon egy eredmenyt",
                Playing = "Az Minecraft jatekosait",
                List = "Listazza a kozossegi szervereket",
                Admin = "Kozossegi adminisztracios parancsok",
                Invite = "Szerezd meg a flut"
            },

            Main = new TMain
            {
                
                HelpFooter = "Vannak rejtett parancsok is;)",
                MultiMC = "A MultiMC lehetővé teszi több verzió kezelését és elindítását könnyű forge / mods telepítéssel",
                PleaseWait = "Kérem várjon, míg én ping",
                ServerAdminUse = "A szerver adminisztrátornak kell használni",
                StoleSkin = "Megölte a bőrt",
                NameOnlyOne = "A {0} játékosnak csak 1 neve van a rekordokban",
                PlayingMinecraft = "Az Minecraft játékosait",
                Hi = "Szia",
                BotDesc = "Ha bármilyen problémája, javaslata vagy nyelvi fordítása van, forduljon hozzám",
                First = "Első"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Hé, titkos parancsot találtál: D",
                Herobrine = "Mindig figyellek ...",
                Notch = "Az Minecraft-ot Notch vagy Markus Persson hozta létre"
            },

            Wiki = new TWiki
            {
                Blocks = "Blocks",
                Unknown = "Ismeretlen",
                Player = "játékos",
                Players = "játékos",
                Attack = "Támadás",
                Easy = "Könnyen",
                Hard = "Kemény",
                Health = "Egészség",
                Height = "Magasság",
                Width = "Szélesség",
            },

            Profile = new TProfile
            {
                Badges = "Jelvénys",
                BadgeInfo = "Kitűző információk",
                InvalidUserID = "Érvénytelen felhasználói azonosító",
                UnknownUser = "Nem sikerült megtalálni a felhasználót",
                NotInServer = "Nem vagy a szerveren",
                SetMCName = "A Minecraft fiók használatának beállítása"
            },

            AdminCommands = new TAdminCommands
            {
                MCRole = "Create a Minecraft role for verified users",
                AutoPost = "Auto post your Minecraft server status",
                AddServer = "Adjon hozzá MC szervert ehhez a céhlistához",
                RemoveServer = "Távolítson el egy MC kiszolgálót ebből a céhlistából",
                SetPrefix = "Állítsa be az egyéni előtagot",
                ResetPrefix = "Egyedi előtag eltávolítása"
            },

            Admin = new TAdmin
            {
                WantTranslation = "Szeretne egy nyelvet fordítani? Kapcsolatba lépni",
                ChangeLang = "A közösségi nyelv megváltoztatása",
                UseList = "Használja az mc/listot a céhek minecraft szervereinek listájához",
                AddServer = "Adjon meg egy címkét, IP-címet és nevet",
                AddServerAdded = "Hozzáadta a {0} kiszolgálót a céhlistához",
                AddServerAlready = "Ez a kiszolgáló már szerepel a listán",
                DelServerEnter = "Szerver törlése a következővel:",
                DelServerNone = "Ez a kiszolgáló nem a list",
                DelServerDeleted = "Eltávolította a {0} kiszolgálót a céhlistából",
                PrefixReset = "A kiszolgáló előtagjának visszaállítása mc/",
                LanguageSet = "Közösségi nyelv"
            }
        };
    }
}
