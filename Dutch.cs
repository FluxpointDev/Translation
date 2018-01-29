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
                BotDesc = ""
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "",
                MinecraftClassic = "",
                Forgecraft = "",
                Bukkit = "",
                Direwolf20 = "",
                Herobrine = "",
                Entity303 = "",
                Israphel = "",
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
                    "[ mc/lang ]( Stel de taal in )",
                        "[ mc/addserver ]( Voegt een Minecraft server toe aan de lijst )",
                        "[ mc/delserver ]( Verwijderd een Minecraft server van de lijst )",
                        "[ mc/setprefix ]( Zet een eigen prefix )",
                        "[ mc/resetprefix ]( Verwijderd de eigen prefix )"
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