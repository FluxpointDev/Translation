using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class French
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "Bot nécessite l'autorisatio \" Liens incrémentés \"",
                AdminOnly = "Vous n'êtes pas un administrateur de serveur",
                PlayerNotFound = "Joueur {0} pas trouvé",
                ApiError = "Erreur API",
                EnterIP = "Entrez une adresse IP",
                InvalidIP = "IP invalide",
                Cooldown = "Vous êtes en pause pendant 1 minutes!",
                EnableQuery = "Le serveur Minecraft n'a pas activé la requête dans server.properties",
                ListNoServers = "Cette communauté n'a aucun serveur répertorié",
                UnknownArg = "Argument inconnu",
                TextLimit = "Le texte ne peut pas dépasser 22 lettres/nombres",
                RequireAttachFiles = "Bot nécessite l'autorisation de joindre des fichiers",
                UnknownWiki = "Article wiki inconnu"
            },

            Main = new TMain
            {
                Commands = new List<string>
                {
                    "[ mc/bot ]( Bot Inviter/Info/Stats/Liens )",
                    "[ mc/quiz ]( Essai de Minecraft :D )",
                    "[ mc/colors ]( Codes de couleur MC )",
                    "[ mc/uuid {p} ]( Joueur UUID )",
                    "[ mc/ping (IP) ]( Faire un ping sur un serveur )",
                    "[ mc/list ]( Liste des serveurs communautaires )",
                    "[ mc/wiki ]( Wiki for Items/Mobs/Enchants/Potions )",
                    "[ mc/version ]( Minecraft version info )",
                    "[ mc/skin {p} ]( Skin du joueur )",
                    "[ mc/names {p} ]( Historique des nom de compte MC )",
                    "[ mc/status ]( Status des serveur de Mojange )",
                    "[ mc/get (Texte) ]( Obtenir une réussite )",
                    "[ mc/playing ]( Les gens qui jouent à Minecraft )",
                    "[ mc/user ]( Your Minecraft account, skin and stats )",
                    "[ mc/rcon ]( Remote console for your Minecraft server )",
                    "[ mc/hypixel {p} ]( Hypixel player stats )",
                    "[ mc/hive {p} ]( HiveMC player stats )",
                    "[ mc/wynncraft {p} ]( Wynncraft player stats )",
                    "[ mc/admin ]( Commandes d'administration de la communauté )",
                    "[ mc/invite ]( Obtenir l'invitation de bot )"
                },
                HelpFooter = "Il y a aussi des commandes cachées ;)",
                MultiMC = "MultiMC vous permet de gérer et de lancer plusieurs versions avec une installation facile de forge / mods",
                PleaseWait = "Patientez pendant que je ping",
                ServerAdminUse = "L'administrateur du serveur doit utiliser",
                StoleSkin = "Roule une skin",
                NameOnlyOne = "Le joueur {0} n'a qu'un nom sur les enregistrements",
                PlayingMinecraft = "Les gens qui jouent à Minecraft",
                Hi = "salut",
                BotDesc = "Si vous avez un problème, des suggestions ou des traductions linguistiques, contactez-moi",
                First = "Premier"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Hé, vous avez trouvé une commande secrète :D",
                Herobrine = "Te regarde toujours...",
                Notch = "Minecraft a été créé par Notch aka Markus Persson"
            },

            Wiki = new TWiki
            {
                Blocks = "blocs",
                Unknown = "Inconnu",
                Player = "Joueur",
                Players = "Joueurs",
                Attack = "Attaque",
                Easy = "Facile",
                Hard = "Hard",
                Health = "Santé",
                Height = "la taille",
                Width = "Largeur",
            },

            Profile = new TProfile
            {
                Badges = "Badges",
                BadgeInfo = "Informations sur le badge",
                InvalidUserID = "Identifiant invalide",
                UnknownUser = "Impossible de trouver l'utilisateur",
                NotInServer = "Vous n'êtes pas sur le serveur",
                SetMCName = "Pour définir l'utilisation de votre compte Minecraft"
            },

            Admin = new TAdmin
            {
                Commands = new List<string>
                {
                    "[ mc/lang ]( Définir la langue de la communauté )",
                    "[ mc/mcrole ]( Create a Minecraft role for verified users )",
                    "[ mc/addserver ]( Ajouter un serveur MC à cette liste de guilde )",
                    "[ mc/delserver ]( Supprimez un serveur MC de cette liste de guilde )",
                    "[ mc/setprefix ]( Set Custom Prefix )",
                    "[ mc/resetprefix ]( Remove Custom Prefix )"
                },
                WantTranslation = "Vous voulez une langue traduire? Contact",
                ChangeLang = "Changer la langue de la communauté",
                UseList = "Utilisez mc/list pour une liste de ces serveurs minecraft de guilde",
                AddServer = "Entrez une étiquette, un ip et un nom",
                AddServerAdded = "Serveur ajouté {0} à la liste de guilde",
                AddServerAlready = "Ce serveur est déjà sur la liste",
                DelServerEnter = "Supprimer un serveur avec",
                DelServerNone = "Ce serveur n'est pas sur la liste",
                DelServerDeleted = "Serveur supprimé {0} de la liste de guilde",
                PrefixReset = "Réinitialisation du préfixe de serveur mc/",
                LanguageSet = "Ensemble de langues communautaires"
            }
        };
    }
}
