using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Polish
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "",
                AdminOnly = "",
                PlayerNotFound = "",
                ApiError = "",
                UnknownItemID = "",
                UnknownMob = "",
                EnterIP = "",
                InvalidIP = "",
                Cooldown = "",
                EnableQuery = "",
                ListNoServers = "",
                UnknownArg = "",
                TextLimit = ""
            },

            Main = new TMain
            {
                Commands = new List<string>
                {
                },
                HelpFooter = "",
                MultiMC = "",
                SkinEditor = "",
                PleaseWait = "",
                ServerAdminUse = "",
                SkinArgs = "",
                StoleSkin = "",
                NameOnlyOne = "",
                PlayingMinecraft = "",
                Hi = "",
                BotDesc = "",
                First = ""
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "",
                Herobrine = "",
                Notch = ""
            },

            Wiki = new TWiki
            {
                Blocks = "",
                Unknown = "",
                Player = "",
                Players = "",
                Attack = "",
                Easy = "",
                Hard = "",
                Health = "",
                Height = "",
                Width = "",
            },

            Admin = new TAdmin
            {
                Commands = new List<string>
                {
                },
                WantTranslation = "",
                ChangeLang = "",
                UseList = "",
                AddServer = "",
                AddServerAdded = "",
                AddServerAlready = "",
                DelServerEnter = "",
                DelServerNone = "",
                DelServerDeleted = "",
                PrefixReset = ""
            }

        };
    }
}