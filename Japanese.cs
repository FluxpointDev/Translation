using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Japanese
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "Bot requires permission \" Embed Links \"",
                AdminOnly = "You are not a server admin",
                PlayerNotFound = "Player {0} not found",
                ApiError = "API Error",
                EnterIP = "Enter an IP",
                InvalidIP = "Invalid IP",
                Cooldown = "You are on cooldown for 1 mins!",
                EnableQuery = "Minecraft server does not have enable-query set in server.properties",
                ListNoServers = "This community has no servers listed",
                UnknownArg = "Unknown argument do",
                TextLimit = "Text cannot be more than 22 letters/numbers",
                RequireAttachFiles = "Bot requires attach files permission",
                UnknownWiki = "Unknown wiki item"
            },

            MainCommands = new TMainCommands
            {
                BotInfo = "Bot info and stats",
                Quiz = "Minecraft quiz",
                Color = "Minecraft color codes",
                NameHistory = "name history",
                UserProfile = "Discord user profile",
                Ping = "Ping a Minecraft server",
                Version = "Minecraft version info",
                Rcon = "Remote console for your Minecraft server",
                Achievement = "Get an achievement",
                Playing = "People playing Minecraft",
                List = "List the community servers",
                Admin = "Community admin commands",
                Invite = "Add bot to your Discord server"
            },

            Main = new TMain
            {
                HelpFooter = "There are some hidden commands aswell ;)",
                MultiMC = "MultiMC allows you to manage and launch multiple versions with easy forge/mods installation",
                PleaseWait = "Please wait while I ping",
                ServerAdminUse = "Server admin should use",
                StoleSkin = "Stole a skin",
                NameOnlyOne = "Player {0} only has 1 name on records",
                PlayingMinecraft = "People playing Minecraft",
                Hi = "Hi",
                BotDesc = "If you have any issue, suggestions or language translations please contact me",
                First = "First"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Hey, you found a secret command :D",
                Herobrine = "Always watching you...",
                Notch = "Minecraft was created by Notch aka Markus Persson"
            },

            Wiki = new TWiki
            {
                Blocks = "Blocks",
                Unknown = "Unknown",
                Player = "Player",
                Players = "Players",
                Attack = "Attack",
                Easy = "Easy",
                Hard = "Hard",
                Health = "Health",
                Height = "Height",
                Width = "Width"
            },

            Profile = new TProfile
            {
                Badges = "Badges",
                BadgeInfo = "Badge information",
                InvalidUserID = "Invalid user id",
                UnknownUser = "Could not find user",
                NotInServer = "You are not on the server",
                SetMCName = "To set your Minecraft account use"
            },

            AdminCommands = new TAdminCommands
            {
                MCRole = "Create a Minecraft role for verified users",
                AutoPost = "Auto post your Minecraft server status",
                AddServer = "Add a Minecraft server to the community list",
                RemoveServer = "Remove a Minecraft server from the community list",
                SetPrefix = "Set a custom prefix for the bot",
                ResetPrefix = "Remove the custom prefix"
            },

            Admin = new TAdmin
            {
                WantTranslation = "Want a language translated? Contact",
                ChangeLang = "Change Community Language",
                UseList = "Use mc/list for a list of this guilds minecraft servers",
                AddServer = "Enter a tag, ip and name",
                AddServerAdded = "Added server {0} to the guild list",
                AddServerAlready = "This server is already on the list",
                DelServerEnter = "Delete a server with",
                DelServerNone = "This server is not on the list",
                DelServerDeleted = "Removed server {0} from the guild list",
                PrefixReset = "Server prefix reset use mc/",
                LanguageSet = "Community language set"
            }
        };
    }
}
