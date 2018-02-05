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
                RequireAttachFiles = "Botnak csatolni kell a fájlok engedélyezését", 
                UnknownWiki = "Ismeretlen wiki tétel"
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
                LanguageSet = "Közösségi nyelv"
            }
        };
    }
}
