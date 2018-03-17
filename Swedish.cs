using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Swedish
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "Bot kräver tillstånd \" Bädda in länkar \"",
                AdminOnly = "Du är inte server Admin",
                PlayerNotFound = "Användare {0} hittades inte",
                ApiError = "API Fel",
                EnterIP = "Skriv en IP",
                InvalidIP = "ogiltlig IP",
                Cooldown = "Du är Tystad i 1 min!",
                EnableQuery = "Minecraft server har inte en aktiverad sökuppsätting av server.properties",
                ListNoServers = "denna servern har inga servar listade",
                UnknownArg = "Okänt argument",
                TextLimit = "kan inte skriva mer än 22 okstäver/nummer",
                RequireAttachFiles = "Bot kräver bifogade filer tillstånd",
                UnknownWiki = "Okänt wiki-objekt"
            },

            Main = new TMain
            {
                HelpFooter = "Det finns några dolda kommandon ;)",
                MultiMC = "MultiMC tillåter dig att hantera och starta flera versioner med enkel smidighet/mods installation )",
                PleaseWait = "Snälla vänta på Ping",
                ServerAdminUse = "Serveradmin bör fixa",
                StoleSkin = "Snå ett skin",
                NameOnlyOne = "användare {0} har bara 1 namn på upppgifterna",
                PlayingMinecraft = "Människor spelar Minecraft",
                Hi = "Hej",
                BotDesc = "Om du har några problem, förslag eller språk översättningar kontakta mig",
                First = "Först"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Hej, du hittade ett hemligt kommand :D",
                Herobrine = "jag ser alltid dig...",
                Notch = "Minecraft är skapat av Notch aka Markus Persson"
            },

            Wiki = new TWiki
            {
                Blocks = "Block",
                Unknown = "Okändt",
                Player = "Användare",
                Players = "Användarna",
                Attack = "Attack",
                Easy = "Enkelt",
                Hard = "Svårt",
                Health = "Hälsa",
                Height = "Höjd",
                Width = "Bredd"
            },

            Profile = new TProfile
            {
                Badges = "bricka",
                BadgeInfo = "Brick infomation",
                InvalidUserID = "Okändt användar ID",
                UnknownUser = "Det gick inte att hitta användaren",
                NotInServer = "Du är inte på servern",
                SetMCName = "För att ställa in ditt Minecraft-konto",
            },

            Admin = new TAdmin
            {
                WantTranslation = "Vill du ha ett språk översatt? kontakta",
                ChangeLang = "Ändra gemenskapsspråk",
                UseList = "använd mc/list för en lista över dessa guilds minecraft-servrar",
                AddServer = "Ange en tagg, ip och namn",
                AddServerAdded = "Tillagd server {0} till guildlistan",
                AddServerAlready = "Den här servern finns redan på listan",
                DelServerEnter = "Ta bort en server med",
                DelServerNone = "Den här servern finns inte på listan",
                DelServerDeleted = "tar väck server {0} från guild listan",
                PrefixReset = "Serverprefix återställning användn mc/",
                LanguageSet = "Gemenskapsspråk"
            }
        };
    }
}
