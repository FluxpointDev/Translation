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
                NoEmbedPerms = "Bot nécessite l'autorisation \" Liens incrémentés \"",
                AdminOnly = "Vous n'êtes pas un administrateur du serveur",
                PlayerNotFound = "Joueur {0} non-trouvé",
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

            MainCommands = new TMainCommands
            {
                BotInfo = "Bot infos et stats",
                Quiz = "Quiz de Minecraft :D",
                Color = "Codes de couleur MC",
                NameHistory = "Historique des nom de compte MC",
                UserProfile = "Votre compte Minecraft, skin et stats",
                Ping = "Savoir le ping d'un serveur",
                Version = "Minecraft version info",
                Rcon = "Console à distance pour votre serveur Minecraft",
                Achievement = "Obtenir une réussite",
                Playing = "Les joueurs qui jouent à Minecraft",
                List = "Liste des serveurs communautaires",
                Admin = "Commandes d'administration de la communauté",
                Invite = "Obtenir l'invitation de bot"
            },

            Main = new TMain
            {
                HelpFooter = "Il y a aussi des commandes cachées ;)",
                MultiMC = "MultiMC vous permet de gérer et de lancer plusieurs versions avec une installation facile de forge / mods",
                PleaseWait = "Patientez pendant que je ping",
                ServerAdminUse = "L'administrateur du serveur doit utiliser",
                StoleSkin = "Roule une skin",
                NameOnlyOne = "Le joueur {0} n'a qu'un nom dans les enregistrements",
                PlayingMinecraft = "Les joueurs qui jouent à Minecraft",
                Hi = "salut",
                BotDesc = "Si vous avez un problème, des suggestions ou des traductions linguistiques, contactez-moi",
                First = "Premier"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Hé, vous avez trouvé une commande secrète :D",
                Herobrine = "Te regarde toujours...",
                Notch = "Minecraft a été créé par Notch alias Markus Persson"
            },

            Wiki = new TWiki
            {
                Blocks = "blocs",
                Unknown = "Inconnu",
                Player = "Joueur",
                Players = "Joueurs",
                Attack = "Attaque",
                Easy = "Facile",
                Hard = "Difficile",
                Health = "Santé",
                Height = "Taille",
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

            AdminCommands = new TAdminCommands
            {
                MCRole = "Créez un rôle Minecraft pour les utilisateurs vérifiés",
                AutoPost = "Poste automatiquement le statut de votre serveur Minecraft",
                AddServer = "Ajouter un serveur MC à cette liste de guilde",
                RemoveServer = "Supprimez un serveur MC de cette liste de guilde",
                SetPrefix = "Créer un Prefix personalisé",
                ResetPrefix = "Enlever un Prefix personalisé"
            },

            Admin = new TAdmin
            {
                WantTranslation = "Vous voulez traduire une langue ? Contactez xXBuilderBXx#8265",
                ChangeLang = "Changer la langue de la communauté",
                UseList = "Utilisez mc/list pour une liste de ces serveurs minecraft de guilde",
                AddServer = "Entrez des initiales, un ip et un nom",
                AddServerAdded = "Serveur ajouté {0} à la liste de serveurs",
                AddServerAlready = "Ce serveur est déjà sur la liste",
                DelServerEnter = "Supprimer un serveur avec",
                DelServerNone = "Ce serveur n'est pas sur la liste",
                DelServerDeleted = "Serveur supprimé {0} de la liste de guilde",
                PrefixReset = "Réinitialisation du préfix de serveur mc/",
                LanguageSet = "Ensemble de langues communautaires"
            }
        };
    }
}
