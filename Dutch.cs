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

            Main = new TMain
            {
                Commands = new List<string>
                {
                    "[ mc/bot ]( Bot Invite/Info/Stats/Links )",
                    "[ mc/quiz ]( Minecraft quiz :D )",
                    "[ mc/colors ]( MC color codes )",
                    "[ mc/uuid (Player) ]( Player UUID )",
                    "[ mc/ping (IP) ]( Ping a server )",
                    "[ mc/list ]( List community servers )",
                    "[ mc/wiki ]( Wiki voor Items/Mobs/Enchants/Potions )",
                    "[ mc/version ]( Minecraft versie informatie )",
                    "[ mc/skin (Player) ]( Player skin )",
                    "[ mc/names (Player) ]( MC account naam historie )",
                    "[ mc/status ]( Mojang status )",
                    "[ mc/get (Text) ]( Krijg een achievement )",
                    "[ mc/minime (Player) ]( Mini player skin )",
                    "[ mc/playing ]( Members die Minecraft spelers )",
                    "[ mc/hypixel (Player) ]( Hypixel player stats )",
                    "[ mc/admin ]( Community admin commands )",
                    "[ mc/invite ]( Krijg een bot invite )"
                },
                HelpFooter = "Er zijn ook een aantal verstopte commands ;)",
                MultiMC = "MultiMC Geeft jou de optie om meerdere versies te spelen met een forge/mods installatie",
                SkinEditor = "Online Skin Editor",
                PleaseWait = "Wacht even terwijl er wordt gepingt",
                ServerAdminUse = "Serverbeheerder zou moeten gebruiken",
                SkinArgs = "(Player) | head | cube | full | steal",
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

            Admin = new TAdmin
            {
                Commands = new List<string>
                {
                    "[ mc/lang ]( Stel de taal in )",
                        "[ mc/addserver ]( Voegt een Minecraft server toe aan de lijst )",
                        "[ mc/delserver ]( Verwijderd een Minecraft server van de lijst )",
                        "[ mc/setprefix ]( Zet een eigen prefix )",
                        "[ mc/resetprefix ]( Verwijderd de eigen prefix )"
                },
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