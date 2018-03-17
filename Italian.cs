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
                AdminOnly = "Non sei un amministratore del server",
                PlayerNotFound = "Giocatore {0} Non trovato",
                ApiError = "Errore dell' API",
                EnterIP = "Inserisci l' IP",
                InvalidIP = "IP non valido",
                Cooldown = "Tu sei in cooldown per 1 minuto!",
                EnableQuery = "Il server minecraft non ha abilita-query settata nel server.properties",
                ListNoServers = "Questa community non ha un server",
                UnknownArg = "argomento sconosciuto",
                TextLimit = "Le scritte non posso avere più di 22 caratteri/numberi",
                RequireAttachFiles = "Bot richiede il permesso per i file allegati",
                UnknownWiki = "Elemento wiki sconosciuto"
            },

            Main = new TMain
            {
                HelpFooter = "Ci sono dei pure dei comandi segreti ;)",
                MultiMC = "MultiMC ti permette di gestire e avviare più versioni di minecraft Con facile installazione di forge/mods",
                PleaseWait = "Perfavore aspetta mentre sto pingando",
                ServerAdminUse = "L'amministratore del server dovrebbe usare",
                StoleSkin = "Ruba una skin",
                NameOnlyOne = "Giocatore {0} ha un solo nome registrato",
                PlayingMinecraft = "Persone che stanno giocando a minecraft",
                Hi = "Ciao",
                BotDesc = "Se tu hai qualche problema, suggerimenti o traduzioni perfavore contattami",
                First = "Primo"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "hey, Hai trovato un comando segreto :D",
                Herobrine = "Ti sto guardando...",
                Notch = "Minecraft è stato creato da Notch alias Markus Persson"
            },

            Wiki = new TWiki
            {
                Blocks = "blocchi",
                Unknown = "Sconosciuto",
                Player = "Giocatore",
                Players = "Giocatori",
                Attack = "Attacco",
                Easy = "Facile",
                Hard = "Difficile",
                Health = "Vita",
                Height = "Altezza",
                Width = "Peso",
            },

            Profile = new TProfile
            {
                Badges = "Badges",
                BadgeInfo = "Informazioni sul badge",
                InvalidUserID = "ID utente non valido",
                UnknownUser = "Impossibile trovare l'utente",
                NotInServer = "Non sei sul server",
                SetMCName = "Usa il tuo account Minecraft"
            },

            Admin = new TAdmin
            {
                WantTranslation = "Vuoi tradurre un linguaggio? Contattami",
                ChangeLang = "Cambia il linguaggio della communuty",
                UseList = "usa mc/list per una lista dei server MC di questa gilda",
                AddServer = "Inserisci la tag, IP e nome",
                AddServerAdded = "Server aggiunto {0} alla lista della gilda",
                AddServerAlready = "Questo server è già nella lista",
                DelServerEnter = "Elimina un server con",
                DelServerNone = "Questo server non è sulla lista",
                DelServerDeleted = "Server rimosso {0} dalla lista della gilda",
                PrefixReset = "Il prefisso del server ripristina l'uso mc/",
                LanguageSet = "Set di lingue comunitarie"
            }

        };
    }
}