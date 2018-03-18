using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Czech
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "Bot vyžaduje oprávnění „vkládat odkazy“",
                AdminOnly = "Nejste administrátorem serveru!",
                PlayerNotFound = "Hráč {0} nebyl nalezen",
                ApiError = "Chyba API",
                EnterIP = "Zadejte IP",
                InvalidIP = "Neplatná IP",
                Cooldown = "Musíte počkat 1 minutu!",
                EnableQuery = "Minecraft server nemá v „server.properties“ nastavené „enable-query“",
                ListNoServers = "Tato komunita nemá uvedena žádný server",
                UnknownArg = "Neznámý argument",
                TextLimit = "Text nemůže být delší jak 22 písmen či čísel",
                RequireAttachFiles = "Bot vyžaduje oprávnění „připojovat soubory“",
                UnknownWiki = "Neznámý předmět wikipedie"
            },

            MainCommands = new TMainCommands
            {
                BotInfo = "Informace a statistiky bota",
                Quiz = "Kvíz z Minecraftu",
                Color = "Barevné kódy v Minecraftu",
                NameHistory = "historie jmen",
                UserProfile = "Uživatelský profil na Discordu",
                Ping = "Ping Minecraft serveru",
                Version = "Informace o Minecraft verzích",
                Rcon = "Vzdálená konzole pro Váš Minecraft server",
                Achievement = "Získat úspěch",
                Playing = "Lidé hrající Minecraft",
                List = "Seznam serverů komunity",
                Admin = "Příkazy admina komunity",
                Invite = "Přidat bota na Váš Discord server"
            },

            Main = new TMain
            {
                HelpFooter = "Nějaké příkazy jsou samozřejmě skryté ;)",
                MultiMC = "MultiMC Vám umožní spravovat a spustit více verzí s lehkou instalací forge/módů",
                PleaseWait = "Počkejte, než získám ping",
                ServerAdminUse = "Admin serveru by měl používat",
                StoleSkin = "Ukrást skin",
                NameOnlyOne = "Hráč {0} má v záznamech pouze 1 jméno",
                PlayingMinecraft = "Lidé hrající Minecraft",
                Hi = "Ahoj",
                BotDesc = "Pokud máte nějaké problémy, nápady či návrhy k překladu, kontaktujte mě",
                First = "První"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Hej, našel jsi tajný příkaz :D",
                Herobrine = "Stálě tě sleduji...",
                Notch = "Minecraf byl vytvořen hráčem Notch aka Markus Persson"
            },

            Wiki = new TWiki
            {
                Blocks = "Bloky",
                Unknown = "Neznámé",
                Player = "Hráč",
                Players = "Hráči",
                Attack = "Útok",
                Easy = "Lehká",
                Hard = "Těžká",
                Health = "Zdraví",
                Height = "Výška",
                Width = "Šířka"
            },

            Profile = new TProfile
            {
                Badges = "Odznaky",
                BadgeInfo = "Informace o odznaku",
                InvalidUserID = "Neznámé ID uživatele",
                UnknownUser = "Uživatele se nepodařilo nalézt",
                NotInServer = "Nejste na serveru",
                SetMCName = "Pro nastavení Vašeho Minecraft účtu použijte"
            },

            AdminCommands = new TAdminCommands
            {
                MCRole = "Vytvořte Minecraft roli pro ověřené uživatele",
                AutoPost = "Automaticky informovat o stavu Vašeho Minecraft serveru",
                AddServer = "Přidat Minecraft server do komunitního seznamu",
                RemoveServer = "Odstranit Minecraft server z komunitního seznamu",
                SetPrefix = "Nastavit botovi vlastní prefix",
                ResetPrefix = "Odstranit z bota vlastní prefix"
            },

            Admin = new TAdmin
            {
                WantTranslation = "Chcete bota přeložit? Kontaktujte",
                ChangeLang = "Změnit jazyk bota",
                UseList = "Použijte mc/list pro seznam doporučených Minecraft serverů",
                AddServer = "Zadejte tag, ip a název",
                AddServerAdded = "Server {0} přidán do seznamu",
                AddServerAlready = "Tento server již je v seznamu",
                DelServerEnter = "Odstranit server s",
                DelServerNone = "Tento server není v seznamu",
                DelServerDeleted = "Server {0} odstraněn ze seznamu",
                PrefixReset = "Prefix serveru resetujete pomocí mc/",
                LanguageSet = "Jazyk bota nastaven"
            }
        };
    }
}
