using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Polish
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "Bot wymaga pozwolenia \" Umieść linki \"",
                AdminOnly = "Nie jesteś administratorem serwera",
                PlayerNotFound = "Gracz {0} nie znaleziono",
                ApiError = "Błąd interfejsu API",
                EnterIP = "Wprowadź adres IP",
                InvalidIP = "Nieprawidłowy adres IP",
                Cooldown = "Masz czas odnowienia przez 1 minutę!",
                EnableQuery = "Serwer Minecraft nie ma włączonego zapytania w pliku server.properties",
                ListNoServers = "Ta społeczność nie ma wymienionych serwerów",
                UnknownArg = "Nieznany argument zrobić",
                TextLimit = "Tekst nie może zawierać więcej niż 22 liter/cyfr",
                RequireAttachFiles = "Bot wymaga dołączenia uprawnień do plików",
                UnknownWiki = "Nieznany element wiki"
            },

            MainCommands = new TMainCommands
            {
                BotInfo = "Bot info and stats",
                Quiz = "Quiz Minecrafta :D",
                Color = "Kody kolorów MC",
                NameHistory = "Historia nazw kont MC",
                UserProfile = "Twoje konto Minecraft, skórka i statystyki",
                Ping = "Pinguj na serwerze",
                Version = "Informacje o wersji Minecrafta",
                Rcon = "Remote console for your Minecraft server",
                Achievement = "Zdobądź osiągnięcie",
                Playing = "Ludzie grający w Minecrafta",
                List = "Wyświetlaj serwery społeczności",
                Admin = "Polecenia administratora społeczności",
                Invite = "Uzyskaj zaproszenie do bota"
            },

            Main = new TMain
            {
                HelpFooter = "Istnieją również ukryte polecenia ;)",
                MultiMC = "MultiMC pozwala zarządzać i uruchamiać wiele wersji dzięki prostej instalacji forge/mods",
                PleaseWait = "Poczekaj, aż wykonam ping",
                ServerAdminUse = "Administrator serwera powinien użyć",
                StoleSkin = "Ukradnij skórę",
                NameOnlyOne = "Gracz {0} ma tylko 1 nazwisko w rekordach",
                PlayingMinecraft = "Ludzie grający w Minecrafta",
                Hi = "cześć",
                BotDesc = "Jeśli masz jakieś problemy, sugestie lub tłumaczenia językowe, skontaktuj się ze mną",
                First = "Pierwszy"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Hej, znalazłeś tajne polecenie :D",
                Herobrine = "Zawsze cię obserwuję...",
                Notch = "Minecraft został stworzony przez Notcha znanego jako Markus Persson"
            },

            Wiki = new TWiki
            {
                Blocks = "Bloki",
                Unknown = "Nieznany",
                Player = "Gracz",
                Players = "Gracze",
                Attack = "Atak",
                Easy = "Łatwo",
                Hard = "Ciężko",
                Health = "Zdrowie",
                Height = "Wysokość",
                Width = "Szerokość"
            },

            Profile = new TProfile
            {
                Badges = "Odznaki",
                BadgeInfo = "Informacje o znaczkach",
                InvalidUserID = "Nieprawidłowy identyfikator użytkownika",
                UnknownUser = "Nie można znaleźć użytkownika",
                NotInServer = "Nie jesteś na serwerze",
                SetMCName = "Aby ustawić korzystanie z konta Minecraft"
            },

            AdminCommands = new TAdminCommands
            {
                MCRole = "Utwórz rolę Minecraft dla zweryfikowanych użytkowników",
                AutoPost = "Auto post your Minecraft server status",
                AddServer = "Dodaj serwer MC do tej listy gildii",
                RemoveServer = "Usuń serwer MC z listy gildii",
                SetPrefix = "Ustaw niestandardowy prefiks",
                ResetPrefix = "Usuń niestandardowy prefiks"
            },

            Admin = new TAdmin
            {
                WantTranslation = "Chcesz przetłumaczyć język? Kontakt",
                ChangeLang = "Zmień język społeczności",
                UseList = "Użyj mc/list, aby wyświetlić listę serwerów minecraft gildii",
                AddServer = "Wprowadź tag, adres IP i nazwę",
                AddServerAdded = "Dodano serwer {0} do listy gildii",
                AddServerAlready = "Ten serwer jest już na liście",
                DelServerEnter = "Usuń serwer za pomocą",
                DelServerNone = "Tego serwera nie ma na liście",
                DelServerDeleted = "Usunięty serwer {0} z listy gildii",
                PrefixReset = "Resetowanie prefiksu serwera za pomocą mc/",
                LanguageSet = "Zestaw języka wspólnotowego"
            }
        };
    }
}
