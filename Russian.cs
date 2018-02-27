using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Russian
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "Требуются права \" Embed Links \"",
                AdminOnly = "Вы не администратор сервера",
                PlayerNotFound = "Игрок {0} не найден",
                ApiError = "Ошибка API",
                EnterIP = "Введите IP",
                InvalidIP = "Недопустимый IP-адрес",
                Cooldown = "Вы на кулдауне на 1 минуту!",
                EnableQuery = "Этот сервер не имеет определённой отметки 'enable-query' в 'server.properties'",
                ListNoServers = "Это сообщество не имеет серверов",
                UnknownArg = "Неизвестный аргумент",
                TextLimit = "Текст не может содержать более 22 символов",
                RequireAttachFiles = "Bot требует наличия прикрепленных файлов",
                UnknownWiki = "Неизвестный элемент"
            },

            Main = new TMain
            {
                Commands = new List<string>
                {
                    "[ mc/bot ]( Основная информация о боте: приглашение/статистика/ссылки )",
                    "[ mc/quiz ]( Викторина :D )",
                    "[ mc/colors ]( Коды цветов )",
                    "[ mc/uuid {p} ]( UUID игрока )",
                    "[ mc/ping (IP) ]( Пинг сервера )",
                    "[ mc/list ]( Список серверов сообщества )",
                    "[ mc/wiki ]( Вики: информация о мобах/предметах/зачарованиях и т.д. )",
                    "[ mc/version ]( Minecraft version info )",
                    "[ mc/skin {p} ]( Скин игрока )",
                    "[ mc/names {p} ]( История имён аккаунта )",
                    "[ mc/status ]( Статус Mojang )",
                    "[ mc/get (текст) ]( Генератор достижений )",
                    "[ mc/playing ]( Сколько людей играют в Minecraft на данный момент )",
                    "[ mc/user ]( Your Minecraft account, skin and stats )",
                    "[ mc/rcon ]( Remote console for your Minecraft server )",
                    "[ mc/hypixel {p} ]( Hypixel player stats )",
                    "[ mc/hive {p} ]( HiveMC player stats )",
                    "[ mc/wynncraft {p} ]( Wynncraft player stats )",
                    "[ mc/admin ]( Команды администратора сообщества )",
                    "[ mc/invite ]( Ссылка на добавление бота на свой сервер )"
                },
                HelpFooter = "Также здесь есть несколько секретных команд ;)",
                MultiMC = "MultiMC позволяет запускать любые версии игры, также можно легко установить Forge и моды",
                PleaseWait = "Подождите, пожалуйста...",
                ServerAdminUse = "Администратор сервера должен использовать",
                StoleSkin = "Украден скин",
                NameOnlyOne = "Игрок {0} имеет только 1 имя в записях",
                PlayingMinecraft = "Игроки в Minecraft",
                Hi = "Привет",
                BotDesc = "Если вы нашли неполадки или у вас есть предложения, обращайтесь ко мне",
                First = "Первый"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Эй, ты нашёл секретную команду :D",
                Herobrine = "Всегда следим за тобой...",
                Notch = "Minecraft был создан Нотчем aka Маркусом Перссоном"
            },

            Wiki = new TWiki
            {
                Blocks = "блоки",
                Unknown = "неизвестный",
                Player = "Игрок",
                Players = "Игроки",
                Attack = "Атака",
                Easy = "Легко",
                Hard = "Жесткий",
                Health = "Здоровье",
                Height = "Высота",
                Width = "Ширина",
            },

            Profile = new TProfile
            {
                Badges = "Значки",
                BadgeInfo = "Информация о значке",
                InvalidUserID = "Недопустимый идентификатор пользователя",
                UnknownUser = "Не удалось найти пользователя",
                NotInServer = "Вы не на сервере",
                SetMCName = "Чтобы настроить использование учетной записи Minecraft"
            },

            Admin = new TAdmin
            {
                Commands = new List<string>
                {
                    "[ mc/lang ]( Установить язык сервера )",
                    "[ mc/mcrole ]( Create a Minecraft role for verified users )",
                    "[ mc/addserver ]( Добавить MC сервер в список серверов )",
                    "[ mc/delserver ]( Удалить MC сервер из списка)",
                    "[ mc/setprefix ]( Set Custom Prefix )",
                    "[ mc/resetprefix ]( Remove Custom Prefix )"
                },
                WantTranslation = "Хотите перевести бота на другой язык? Соединитесь с нами",
                ChangeLang = "Изменить язык сервера",
                UseList = "Используйте mc/list для списка серверов в майнкрафте для данной гильдии",
                AddServer = "Введите тэг, IP и название",
                AddServerAdded = "Добавлен сервер {0} в список серверов",
                AddServerAlready = "Этот сервер уже добавлен",
                DelServerEnter = "Удалить сервер с",
                DelServerNone = "Сервера нет в списке",
                DelServerDeleted = "Удалён сервер {0} из списка серверов данной гильдии",
                PrefixReset = "Использовать префикс сервера mc/",
                LanguageSet = "Набор языка сообщества"
            }

        };
    }
}