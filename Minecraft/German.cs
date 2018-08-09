using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class German
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "Bot benötigt die Erlaubnis \" Einbetten von Links \"",
                AdminOnly = "Sie sind kein Serveradministrator",
                PlayerNotFound = "Spieler {0} nicht gefunden",
                ApiError = "API-Fehler",
                EnterIP = "Gib eine IP-Adresse ein",
                InvalidIP = "Ungültige IP-Adresse",
                Cooldown = "Du bist für 1 Minute auf Abklingzeit!",
                EnableQuery = "Der Minecraft-Server erlaubt keine Abfrage von Außen. Er hat enable-query nicht in server.properties aktiviert",
                ListNoServers = "Diese Community hat keine Server aufgeführt",
                UnknownArg = "Unbekanntes Argument",
                TextLimit = "Text kann nicht mehr als 22 Buchstaben/Zahlen enthalten",
                RequireAttachFiles = "Der Bot benötigt die Berechtigung zum Anhängen von Dateien",
                UnknownWiki = "Unbekannter Wiki-Eintrag"
            },

            MainCommands = new TMainCommands
            {
                BotInfo = "Bot info and stats",
                Quiz = "Minecraft Quiz :D",
                Color = "MC-Farbcodes",
                NameHistory = "MC-Kontoname Historie",
                UserProfile = "Your Minecraft account, skin and stats",
                Ping = "Ping einen Server",
                Version = "Minecraft version info",
                Rcon = "Remote console for your Minecraft server",
                Achievement = "Hol dir eine Errungenschaft",
                Playing = "Menschen, die gerade spielen",
                List = "Serverliste der Gilde",
                Admin = "Gildenadmin-Befehle",
                Invite = "Hol dir die Bot-Einladung"
            },

            Main = new TMain
            {
                HelpFooter = "Es gibt auch einige versteckte Befehle ;)",
                MultiMC = "MultiMC ermöglicht es, mit einfacher Forge- und Mod-Installation, mehrere Versionen zu verwalten und zu starten",
                PleaseWait = "Bitte warte, während ich pinge",
                ServerAdminUse = "Server-Admin sollte verwenden",
                StoleSkin = "Einen Skin gestohlen",
                NameOnlyOne = "Spieler {0} hat nur 1 Namen in den Datensätzen",
                PlayingMinecraft = "Leute spielen Minecraft",
                Hi = "Hallo",
                BotDesc = "Wenn du Fragen oder Vorschläge haben solltest oder du mit der Übersetzung helfen möchtest, kontaktiere mich bitte",
                First = "Zuerst"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Hey, du hast einen geheimen Befehl gefunden :D",
                Herobrine = "Er hat dich im Auge...",
                Notch = "Minecraft wurde von Notch aka Markus Persson kreiert"
            },

            Wiki = new TWiki
            {
                Blocks = "Blöcke",
                Unknown = "Unbekannt",
                Player = "Spieler",
                Players = "Spieler",
                Attack = "Attacke",
                Easy = "Einfach",
                Hard = "Schwer",
                Health = "Gesundheit",
                Height = "Höhe",
                Width = "Breite",
            },

            Profile = new TProfile
            {
                Badges = "Abzeichen",
                BadgeInfo = "Ausweis informationen",
                InvalidUserID = "Ungültige Benutzer-Id",
                UnknownUser = "Benutzer konnte nicht gefunden werden",
                NotInServer = "Sie sind nicht auf dem Server",
                SetMCName = "Um dein Minecraft-Konto zu verwenden, verwende"
            },

            AdminCommands = new TAdminCommands
            {
                MCRole = "Create a Minecraft role for verified users",
                AutoPost = "Auto post your Minecraft server status",
                AddServer = "Füge der Serverliste der Gilde einen MC-Server hinzu",
                RemoveServer = "Entferne einen MC-Server aus der Serverliste der Gilde",
                SetPrefix = "Set Custom Prefix",
                ResetPrefix = "Remove Custom Prefix"
            },

            Admin = new TAdmin
            {
                WantTranslation = "Du willst mit der Übersetzung helfen? Kontaktiere",
                ChangeLang = "Sprache ändern",
                UseList = "Verwende mc/list für eine Liste der Gilden-Minecraft-Server",
                AddServer = "Gib einen Tag, eine IP-Adresse und einen Namen ein",
                AddServerAdded = "Server {0} zur Gildenliste hinzugefügt",
                AddServerAlready = "Dieser Server befindet sich bereits auf der Liste",
                DelServerEnter = "Lösche einen Server mit",
                DelServerNone = "Dieser Server ist nicht auf der Liste",
                DelServerDeleted = "Server {0} aus der Gildenliste entfernt",
                PrefixReset = "Server-Präfix wird zurückgesetzt mc/",
                LanguageSet = "Community-Sprache festgelegt"
            }

        };
    }
}
