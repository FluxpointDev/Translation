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
                RequireAttachFiles = "Bot requires attach files permission", 
                UnknownWiki = "Unknown wiki item"
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

            Admin = new TAdmin
            {
                LanguageSet = "Community language set"
            }
        };
    }
}
