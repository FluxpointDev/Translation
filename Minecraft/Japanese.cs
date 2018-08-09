using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Japanese
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            
                NoEmbedPerms = "Botto ni wa akusesu kyoka ga hitsuyō\ rinku o umekomu\",
                AdminOnly = "Anata wa sābā kanrishade wa arimasen",
                PlayerNotFound = "Purēyā {0 } ga mitsukarimasen",
                ApiError = "Api erā",
                EnterIP = "IP o nyūryoku shite kudasai",
                InvalidIP = "Mukōna IP",
                Cooldown = "Anata wa 1-funkan no kūrudaun-chūdesu!",
                EnableQuery = "Minecraft sābā wa server. Puropati ni inēburu - query o settei shite imasen",
                ListNoServers = "Kono komyuniti ni wa sābā ga risuto sa rete imasen",
                UnknownArg = "Fumeina hikisū do",
                TextLimit = "Tekisuto wa 22 moji/ sūji ikadenakereba narimasen",
                RequireAttachFiles = "Bot ga fairu o tenpu suruhitsuyōgāru",
                UnknownWiki = "Fumeina u~ikki aitemu"
            },

            MainCommands = new TMainCommands
            {
                BotInfo = "Botto jōhō to tōkei jōhō",
                Quiz = "Minikurafutokuizu",
                Color = "Minecraft karākōdo",
                NameHistory = "Namae no rekishi",
                UserProfile = "Yūzāpurofairu o fuitchi",
                Ping = "Minikurafutosābā ni pingu o jikkō suru",
                Version = "Minecraft no bājon jōhō",
                Rcon = "Anata no Minecraft sābā-yō no rimōtokonsōru",
                Achievement = "Tassei o eru",
                Playing = "Mainkurafuto o purei shite iru hito",
                List = "Komyunitisābā o ichiran hyōji suru",
                Admin = "Komyuniti kanri komando",
                Invite = "Anata no Discord sābā ni botto o tsuika suru"
            },

            Main = new TMain
            {
                HelpFooter = "Ikutsu ka no kakusareta komando mo arimasu ;)",
                MultiMC = "MultiMC o shiyō suru to, kantan'na tanzō/ kaizō no insutōru de fukusū no bājon o kanri oyobi kidō dekimasu",
                PleaseWait = "Watashi ga pingu shite iru ma omachikudasai",
                ServerAdminUse = "Sābā kanrisha ga shiyō suru hitsuyō ga arimasu",
                StoleSkin = "Hada o nusunda",
                NameOnlyOne = "Pureiyā {0 } wa rekōdo ni 1tsu no namae shika motte imasen",
                PlayingMinecraft = "Mainkurafuto o purei shite iru hito",
                Hi = "Kon'nichiwa~",
                BotDesc = "Mondai, teian, gengo hon'yaku ga aru baai wa, watashi ni renraku shite kudasai",
                First = "Saisho"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Nē, anata wa himitsu no komando o mitsuketa :D",
                Herobrine = "Itsumo anata o mite...",
                Notch = "Minecraft wa notchi aka Markus Persson ni yotte sakusei sa remashita"
            },

            Wiki = new TWiki
            {
                Blocks = "Burokku",
                Unknown = "Michi no",
                Player = "Purēyā",
                Players = "Pureiyā",
                Attack = "Kōgeki",
                Easy = "Kantan",
                Hard = "Hādo",
                Health = "Kenkō",
                Height = "Taka-sa",
                Width = "Haba"
            },

            Profile = new TProfile
            {
                Badges = "Bajji",
                BadgeInfo = "Bajji jōhō",
                InvalidUserID = "Yūzā ID ga mukōdesu",
                UnknownUser = "Yūzā o mitsukeru koto ga dekimasendeshita",
                NotInServer = "Anata wa sābā ni imasen",
                SetMCName = "Anata no minikurafutoakaunto no shiyō o settei suru ni wa"
            },

            AdminCommands = new TAdminCommands
            {
                MCRole = "Kenshō-zumi yūzā no tame no Minecraft rōru no sakusei",
                AutoPost = "Minecraft sābā no sutētasu o jidō tōkō suru",
                AddServer = "Minecraft sābā o komyuniti risuto ni tsuika suru",
                RemoveServer = "Komyuniti risuto kara Minecraft sābā o sakujo suru",
                SetPrefix = "Botto no kasutamupurefikkusu o settei suru",
                ResetPrefix = "Kasutamupurefikkusu o sakujo suru"
            },

            Admin = new TAdmin
            {
                WantTranslation = "Gengo o hon'yaku shitaidesu ka? Sesshoku",
                ChangeLang = "Komyuniti gengo no henkō",
                UseList = "Kono girudo no minikurafutosāba no risuto ni tsuite wa, mc/ list o shiyō shite kudasai",
                AddServer = "Tagu, IP, namae o nyūryoku shite kudasai",
                AddServerAdded = "Girudo risuto ni sābā {0 } o tsuika shimashita",
                AddServerAlready = "Kono sābā wa sudeni risuto ni haitte imasu",
                DelServerEnter = "De no sābā no sakujov",
                DelServerNone = "Kono sābā wa risuto ni arimasen",
                DelServerDeleted = "Girudo risuto kara sābā {0 } o sakujo shimashita",
                PrefixReset = "Sāba no purefikkusu o risettosuru ni wa mc/",
                LanguageSet = "Komyuniti gengo setto"
            }
        };
    }
}
