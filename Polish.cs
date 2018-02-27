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

            Main = new TMain
            {
                Commands = new List<string>
                {
                    "[ mc/bot ]( Nerw Zapraszam/Informacje/Statystyki/Links )",
                    "[ mc/quiz ]( Quiz Minecrafta :D )",
                    "[ mc/colors ]( Kody kolorów MC )",
                    "[ mc/uuid {p} ]( Gracz UUID )",
                    "[ mc/ping (IP) ]( Pinguj na serwerze )",
                    "[ mc/list ]( Wyświetlaj serwery społeczności )",
                    "[ mc/wiki ]( Wiki dla Przedmiotów/Mobs/Enchants/Potions )",
                    "[ mc/version ]( Informacje o wersji Minecrafta )",
                    "[ mc/skin {p} ]( Skórka gracza )",
                    "[ mc/names {p} ]( Historia nazw kont MC )",
                    "[ mc/status ]( Mojang status )",
                    "[ mc/get (Tekst) ]( Zdobądź osiągnięcie )",
                    "[ mc/playing ]( Ludzie grający w Minecrafta )",
                    "[ mc/user ]( Twoje konto Minecraft, skórka i statystyki )",
                    "[ mc/rcon ]( Remote console for your Minecraft server )",
                    "[ mc/hypixel {p} ]( Statystyki gracza Hypixel )",
                    "[ mc/hive {p} ]( HiveMC player stats )",
                    "[ mc/wynncraft {p} ]( Wynncraft player stats )",
                    "[ mc/admin ]( Polecenia administratora społeczności )",
                    "[ mc/invite ]( Uzyskaj zaproszenie do bota )"
                },
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

            Admin = new TAdmin
            {
                Commands = new List<string>
                {
                    "[ mc/lang ]( Ustaw język społeczności )",
                    "[ mc/mcrole ]( Utwórz rolę Minecraft dla zweryfikowanych użytkowników )",
                    "[ mc/addserver ]( Dodaj serwer MC do tej listy gildii )",
                    "[ mc/delserver ]( Usuń serwer MC z listy gildii )",
                    "[ mc/setprefix ]( Ustaw niestandardowy prefiks )",
                    "[ mc/resetprefix ]( Usuń niestandardowy prefiks )"
                },
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
