using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Dutch
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "Bot heeft permissions nodig \" Embed Links \"",
                AdminOnly = "U bent geen serverbeheerder",
                PlayerNotFound = "Player {0} niet gevonden",
                ApiError = "API Error",
                EnterIP = "Geef een IP op",
                InvalidIP = "Ongeldige IP",
                Cooldown = "Wacht op de cooldown van 1 minuut",
                EnableQuery = "Minecraft server heeft geen enable-query aangezet in server.properties",
                ListNoServers = "Deze community heeft geen opgeslagen servers",
                UnknownArg = "Onbekend Argument",
                TextLimit = "De tekst mag niet meer dan 22 letters/nummers bevatten",
                RequireAttachFiles = "Bot vereist toestemming voor bijlagebestanden",
                UnknownWiki = "Onbekend wiki-item"
            },

            MainCommands = new TMainCommands
            {
                BotInfo = "Bot info and stats",
                Quiz = "Minecraft quiz :D",
                Color = "MC color codes",
                NameHistory = "MC account naam historie",
                UserProfile = "Your Minecraft account, skin and stats",
                Ping = "Ping a server",
                Version = "Minecraft versie informatie",
                Rcon = "Remote console for your Minecraft server",
                Achievement = "Krijg een achievement",
                Playing = "Members die Minecraft spelers",
                List = "List community servers",
                Admin = "Community admin commands",
                Invite = "Krijg een bot invite"
            },

            Main = new TMain
            {
                HelpFooter = "Er zijn ook een aantal verstopte commands ;)",
                MultiMC = "MultiMC Geeft jou de optie om meerdere versies te spelen met een forge/mods installatie",
                PleaseWait = "Wacht even terwijl er wordt gepingt",
                ServerAdminUse = "Serverbeheerder zou moeten gebruiken",
                StoleSkin = "Steel een skin",
                NameOnlyOne = "Player {0} heeft maar 1 name",
                PlayingMinecraft = "Members die Minecraft spelen",
                Hi = "Hoi",
                BotDesc = "Als je problemen hebt, suggesties of kunt vertalen, neem dan contact met me op",
                First = "Eerste"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Hey! Je hebt een geheime command gevonden! :D",
                Herobrine = "Houd je altijd in de gaten...",
                Notch = "Minecraft is gemaakt door Notch aka Markus Persson"
            },

            Wiki = new TWiki
            {
                Blocks = "Blocks",
                Unknown = "Onbekend",
                Player = "Speler",
                Players = "Spelers",
                Attack = "Aanval",
                Easy = "Gemakkelijk",
                Hard = "Hard",
                Health = "Gezondheid",
                Height = "Hoogte",
                Width = "Breedte",
            },

            Profile = new TProfile
            {
                Badges = "Badges",
                BadgeInfo = "Badge information",
                InvalidUserID = "Ongeldige gebruikersnaam",
                UnknownUser = "Kon de gebruiker niet vinden",
                NotInServer = "U bevindt zich niet op de server",
                SetMCName = "Om uw Minecraft-account te gebruiken"
            },

            AdminCommands = new TAdminCommands
            {
                MCRole = "Create a Minecraft role for verified users",
                AutoPost = "Auto post your Minecraft server status",
                AddServer = "Voegt een Minecraft server toe aan de lijst",
                RemoveServer = "Verwijderd een Minecraft server van de lijst",
                SetPrefix = "Zet een eigen prefix",
                ResetPrefix = "Verwijderd de eigen prefix"
            },

            Admin = new TAdmin
            {
                WantTranslation = "Wil je een bepaalde taal vertalen? Neem contact met me op",
                ChangeLang = "Verander de taal van de bot",
                UseList = "Gebruik mc/list om de opgeslagen servers te bekijken",
                AddServer = "Geeft een Tag, IP en naam op",
                AddServerAdded = "server {0} toegevoegd aan de lijst",
                AddServerAlready = "Deze server staat al op de lijst",
                DelServerEnter = "Verwijder een server",
                DelServerNone = "Deze server staat niet op de lijst",
                DelServerDeleted = "Server {0} is verwijderd van de lijst",
                PrefixReset = "Server prefix reset use mc/",
                LanguageSet = "Gemeenschapstaal ingesteld"
            }

        };
    }
}
