using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Finnish
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "Botti tarvitsee oikeuden \" Embed Links \"",
                AdminOnly = "Et ole palvelimen ylläpitäjä",
                PlayerNotFound = "Pelaajaa {0} ei löydetty",
                ApiError = "API Virhe",
                EnterIP = "Syötä IP-osoite",
                InvalidIP = "Virheellinen IP-osoite",
                Cooldown = "Olet jäähyllä 1min!",
                EnableQuery = "Minecraft serverillä ei ole enable-query asetettu tiedostossa server.properties",
                ListNoServers = "Tämä discord-palvelin ei omista palvelinlistaa! :(",
                UnknownArg = "Tuntematon argumentti",
                TextLimit = "Teksti ei voi olla pidempi kuin 22 kirjainta/numeroa",
                RequireAttachFiles = "Botti vaatii attach files Oikeuden",
                UnknownWiki = "Wiki ei omista tätä"
            },

            MainCommands = new TMainCommands
            {
                BotInfo = "Botin info ja status",
                Quiz = "Minecraft Kysely",
                Color = "Minecraft värikoodit",
                NameHistory = "Mimihistoria",
                UserProfile = "Discord käyttäjä profiili",
                Ping = "Pinggaa minecraft serveri",
                Version = "Minecraft version tiedot",
                Rcon = "Hallitse Serverisi konsolia etäältä",
                Achievement = "Tee oma saavutus",
                Playing = "Pelaamassa minecraftia",
                List = "Palvelimeen lisätyt minecraft serverit",
                Admin = "Palvelimen admin komennot",
                Invite = "Lisää botti palvelimellesi!"
            },

            Main = new TMain
            {
                HelpFooter = "Botti omistaa salaisia komentoja o-O",
                MultiMC = "MultiMC antaa sinun hallita ja käynnistää monia versioita helposti forgen/modeja!",
                PleaseWait = "Odota kun pinggaan",
                ServerAdminUse = "Server admin should use",
                StoleSkin = "Varasta skin",
                NameOnlyOne = "Pelaajalla {0} on vain 1 nimi historiassa",
                PlayingMinecraft = "Pelaajia pelaamassa minecraftia",
                Hi = "Hei",
                BotDesc = "Jos sinulla on jotain ongelmia, ehdoituksia tai kieli käännöksiä ota yheteyttä minuun",
                First = "eka"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Omg. Salanen komento o_O",
                Herobrine = "Katson fidgetspinneriä.",
                Notch = "Minecraftin teki Notch aka Markus Persson"
            },

            Wiki = new TWiki
            {
                Blocks = "Palikat",
                Unknown = "Tuntematon",
                Player = "Pelaaja",
                Players = "Pelaajat",
                Attack = "Hyökkäys",
                Easy = "Helppo",
                Hard = "Vaikea",
                Health = "Elämä",
                Height = "Korkeus",
                Width = "Leveys"
            },

            Profile = new TProfile
            {
                Badges = "Kunniamerkit",
                BadgeInfo = "Kunniamerkkien tiedot",
                InvalidUserID = "Virheellinen käyttäjän id",
                UnknownUser = "Pelaajaa ei löydetty",
                NotInServer = "Et ole serverillä!",
                SetMCName = " asettaa Minecraft käyttäjän"
            },

            AdminCommands = new TAdminCommands
            {
                MCRole = "Luo rooli vahvistetuille jäsenille",
                AutoPost = "Julkaise automaattisesti palvelimen tilastoja",
                AddServer = "Lisää serveri yhteisön listalle",
                RemoveServer = "Poista serveri yhteisön listalta",              
				SetPrefix = "Muuta botin prefixiä",
                ResetPrefix = "Poista muutettu prefix"
            },

            Admin = new TAdmin
            {
                WantTranslation = "Haluatko kääntää bottia jollekin kielelle? Ota yheteyttä discorissa!",
                ChangeLang = "Vaihda kieli joksikin",
                UseList = "Tee mc/list että näät listan minecraft servereistä jotka on palvelimelle lisätty",
                AddServer = "Syötä Merkki, ip ja nimi",
                AddServerAdded = "Lisätty serveri {0} Palvelimen listalle",
                AddServerAlready = "Serveri on lisätty jo listaan!",
                DelServerEnter = "Poista serveri",
                DelServerNone = "Tämä serveri ei ole listalla",
                DelServerDeleted = "Serveri {0} poistettu palvelimen listalta",
                PrefixReset = "Palvelimen prefixin palautus mc/",
                LanguageSet = "Palvelimen kieli muutettu"
            }
        };
    }
}
