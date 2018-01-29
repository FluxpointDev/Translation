using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Italian
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "Il bot richiede dei permessi \" Embed Links \"",
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
                    "[ mc/bot ]( Invito del bot/Info/Statistiche/Links )",
                    "[ mc/quiz ]( Minecraft quiz :D )",
                    "[ mc/colors ]( Codici dei Colori MC )",
                    "[ mc/uuid (Player) ]( Player UUID )",
                    "[ mc/ping (IP) ]( Pinga un server )",
                    "[ mc/list ]( Lista dei server della community )",
                    "[ mc/wiki ]( Wiki per Oggetti/Mobs/Incantamenti/Pozioni )",
                    "[ mc/version ]( Info sulla versione di MC )",
                    "[ mc/skin (Player) ]( Skin del Giocatore )",
                    "[ mc/names (Player) ]( Storia del nome dell' account MC )",
                    "[ mc/status ]( Stato della Mojang )",
                    "[ mc/get (Text) ]( Ottieni un achievement )",
                    "[ mc/minime (Player) ]( Minimizza la skin del giocatore )",
                    "[ mc/playing ]( Persone che stanno giocando ad MC )",
                    "[ mc/hypixel (Player) ]( Hypixel player stats )",
                    "[ mc/admin ]( Comandi dell' admin della community )",
                    "[ mc/invite ]( Ottieni l' invito del bot )"
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
                    "[ mc/lang ]( Setta il linguaggio della community )",
                        "[ mc/addserver ]( Aggiungi un server MC a la lista di questa gildad )",
                        "[ mc/delserver ]( Rimuovi un server MC da questo gilda )",
                        "[ mc/setprefix ]( Setta il Custom Prefix )",
                        "[ mc/resetprefix ]( Rimuovi il Custom Prefix )"
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