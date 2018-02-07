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

            Main = new TMain
            {
                Commands = new List<string>
                {
                    "[ mc/bot ]( Bot Invite/Info/Statisztika/Linkek )",
                    "[ mc/quiz ]( Minecraft Kviz :D )",
                    "[ mc/colors ]( MC Szinkodok )",
                    "[ mc/uuid (játékos) ]( játékos UUID )",
                    "[ mc/ping (IP) ]( Ping egy kiszolgalot )",
                    "[ mc/list ]( Listazza a kozossegi szervereket )",
                    "[ mc/wiki ]( Wiki az elemek/mobok/varazslok/bajitalok szamara )",
                    "[ mc/version ]( Minecraft verzloinformaciok )",
                    "[ mc/skin ( játékos ) ]( Jatekos bor )",
                    "[ mc/names ( játékos ) ]( MC fioknev elozmemyei )",
                    "[ mc/status ]( Mojang allapot )",
                    "[ mc/get (Text) ]( Kapjon egy eredmenyt )",
                    "[ mc/minime ( játékos ) ]( Minify player skin )",
                    "[ mc/playing ]( Az Minecraft jatekosait )",
                    "[ mc/hypixel ( játékos ) ]( Hypixel player stats )",
                    "[ mc/admin ]( Kozossegi adminisztracios parancsok )",
                    "[ mc/invite ]( Szerezd meg a flut )"
                },
                HelpFooter = "Vannak rejtett parancsok is;)",
                MultiMC = "A MultiMC lehetővé teszi több verzió kezelését és elindítását könnyű forge / mods telepítéssel",
                SkinEditor = "Online bőrszerkesztő",
                PleaseWait = "Kérem várjon, míg én ping",
                ServerAdminUse = "A szerver adminisztrátornak kell használni",
                SkinArgs = "(Lejátszó) | fej | kocka teljes | lop",
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

            Admin = new TAdmin
            {
                Commands = new List<string>
                {
                    "[ mc/lang ]( Állítsa be a közösségi nyelvet )",
                    "[ mc/addserver ]( Adjon hozzá MC szervert ehhez a céhlistához )",
                    "[ mc/delserver ]( Távolítson el egy MC kiszolgálót ebből a céhlistából )",
                    "[ mc/setprefix ]( Állítsa be az egyéni előtagot )",
                    "[ mc/resetprefix ]( Egyedi előtag eltávolítása )"
                },
                WantTranslation = "Szeretne egy nyelvet fordítani? Kapcsolatba lépni",
                ChangeLang = "A közösségi nyelv megváltoztatása",
                UseList = "Használja az mc / listot a céhek minecraft szervereinek listájához",
                AddServer = "Adjon meg egy címkét, IP-címet és nevet",
                AddServerAdded = "Hozzáadta a {0} kiszolgálót a céhlistához",
                AddServerAlready = "Ez a kiszolgáló már szerepel a listán",
                DelServerEnter = "Szerver törlése a következővel:",
                DelServerNone = "Ez a kiszolgáló nem a list",
                DelServerDeleted = "Eltávolította a {0} kiszolgálót a céhlistából",
                PrefixReset = "A kiszolgáló előtagjának visszaállítása mc /",
                LanguageSet = "Közösségi nyelv"
            }
        };
    }
}
