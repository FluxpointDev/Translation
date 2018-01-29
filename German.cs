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
                UnknownItemID = "Artikelname oder ID kann nicht gefunden werden",
                UnknownMob = "Mob mit diesem Namen konnte nicht gefunden werden",
                EnterIP = "Gib eine IP-Adresse ein",
                InvalidIP = "Ungültige IP-Adresse",
                Cooldown = "Du bist für 1 Minute auf Abklingzeit!",
                EnableQuery = "Der Minecraft-Server erlaubt keine Abfrage von Außen. Er hat enable-query nicht in server.properties aktiviert",
                ListNoServers = "Diese Community hat keine Server aufgeführt",
                UnknownArg = "Unbekanntes Argument",
                TextLimit = "Text kann nicht mehr als 22 Buchstaben/Zahlen enthalten"
            },

            Main = new TMain
            {
                Commands = new List<string>
                {
                     "[ mc/bot ]( Bot Einladen/Info/Stats/Links )",
                    "[ mc/quiz ]( Minecraft Quiz :D )",
                    "[ mc/colors ]( MC-Farbcodes )",
                    "[ mc/uuid (Spieler) ]( Spieler UUID )",
                    "[ mc/ping (IP) ]( Ping einen Server )",
                    "[ mc/list ]( Serverliste der Gilde )",
                    "[ mc/wiki ]( Wiki für Items/Mobs/Verzauberungen/Tränke )",
                    "[ mc/version ]( Minecraft version info )",
                    "[ mc/skin (Spieler) ]( Spieler-Skin )",
                    "[ mc/names (Spieler) ]( MC-Kontoname Historie )",
                    "[ mc/status ]( Mojang-Status )",
                    "[ mc/get (Text) ]( Hol dir eine Errungenschaft )",
                    "[ mc/minime (Spieler) ]( Skin verkleiner )",
                    "[ mc/playing ]( Menschen, die gerade spielen )",
                    "[ mc/hypixel (Player) ]( Hypixel player stats )",
                    "[ mc/admin ]( Gildenadmin-Befehle )",
                    "[ mc/invite ]( Hol dir die Bot-Einladung )"
                },
                HelpFooter = "Es gibt auch einige versteckte Befehle ;)",
                MultiMC = "MultiMC ermöglicht es, mit einfacher Forge- und Mod-Installation, mehrere Versionen zu verwalten und zu starten",
                SkinEditor = "Online Skin-Editor",
                PleaseWait = "Bitte warte, während ich pinge",
                ServerAdminUse = "Server-Admin sollte verwenden",
                SkinArgs = "(Spieler) | Kopf | Würfel | voll | stehlen",
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

            Admin = new TAdmin
            {
                Commands = new List<string>
                {
                     "[ mc/lang ]( Wähle die Sprache der Gilde)",
                        "[ mc/addserver ]( Füge der Serverliste der Gilde einen MC-Server hinzu )",
                        "[ mc/delserver ]( Entferne einen MC-Server aus der Serverliste der Gilde )",
                        "[ mc/setprefix ]( Set Custom Prefix )",
                        "[ mc/resetprefix ]( Remove Custom Prefix )"
                },
                WantTranslation = "Du willst mit der Übersetzung helfen? Kontaktiere",
                ChangeLang = "Sprache ändern",
                UseList = "Verwende mc/list für eine Liste der Gilden-Minecraft-Server",
                AddServer = "Gib einen Tag, eine IP-Adresse und einen Namen ein",
                AddServerAdded = "Server {0} zur Gildenliste hinzugefügt",
                AddServerAlready = "Dieser Server befindet sich bereits auf der Liste",
                DelServerEnter = "Lösche einen Server mit",
                DelServerNone = "Dieser Server ist nicht auf der Liste",
                DelServerDeleted = "Server {0} aus der Gildenliste entfernt",
                PrefixReset = "Server-Präfix wird zurückgesetzt mc/"
            }

        };
    }
}