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
                NoEmbedPerms = "Недостаточно прав \" Embed Links \"",
                AdminOnly = "Вы не администратор сервера",
                PlayerNotFound = "Игрок {0} не найден",
                ApiError = "Ошибка API",
                EnterIP = "Введите IP",
                InvalidIP = "Неверный IP-адрес",
                Cooldown = "Частое использование команд! Подождите 1 минуту!",
                EnableQuery = "Активируйте функцию 'enable-query' в 'server.properties'",
                ListNoServers = "Этот Discord сервер не имеет серверов Minecraft",
                UnknownArg = "Неизвестный аргумент",
                TextLimit = "Текст не может содержать более 22 символов",
                RequireAttachFiles = "Предоставьте боту права на прикрепление вложений",
                UnknownWiki = "Неизвестный предмет"
            },

            MainCommands = new TMainCommands
            {
                BotInfo = "Информация и статус бота",
                Quiz = "Викторина по Minecraft",
                Color = "Цветовые коды Minecraft",
                NameHistory = "История аккаунта по никнейму",
                UserProfile = "Ваш Mincraft аккаунт, статистика и скин",
                Ping = "Проверка Ping у сервера",
                Version = "Информация о версиях Minecraft",
                Rcon = "Удалённая консоль для вашего сервера Minecraft",
                Achievement = "Генератор достижений",
                Playing = "Количество игроков Minecraft в данный момент",
                List = "Список серверов Minecraft",
                Admin = "Команды для Администратора сервера",
                Invite = "Добавить бота на свой сервер"
            },

            Main = new TMain
            {
                HelpFooter = "Также здесь есть несколько секретных команд ;)",
                MultiMC = "MultiMC позволяет запускать любые версии Minecraft, также можно легко установить Forge и моды",
                PleaseWait = "Подождите, пожалуйста...",
                ServerAdminUse = "Если вы администратор сервера Discord и хотите добавить сервер в этот спискок, используйте команду:",
                StoleSkin = "Украден скин",
                NameOnlyOne = "{0} никогда не изменял свой никнейм",
                PlayingMinecraft = "игроков в Minecraft",
                Hi = "Привет",
                BotDesc = "Если вы нашли неполадки или у вас есть предложения, обращайтесь ко мне",
                First = "Первый"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Эй, ты нашёл секретную команду :D",
                Herobrine = "Всегда следит за тобой...",
                Notch = "Minecraft был создан Нотчем аkа Маркус Перссон"
            },

            Wiki = new TWiki
            {
                Blocks = "блоки",
                Unknown = "неизвестный",
                Player = "Игрок",
                Players = "Игроки",
                Attack = "Атака",
                Easy = "Легкий",
                Hard = "Сложный",
                Health = "Здоровье",
                Height = "Высота",
                Width = "Ширина",
            },

            Profile = new TProfile
            {
                Badges = "Значки",
                BadgeInfo = "Информация о значке",
                InvalidUserID = "Неверный идентификатор пользователя",
                UnknownUser = "Не удалось найти игрока",
                NotInServer = "Вы не на сервере",
                SetMCName = "Для привязки своего Minecraft акканута используйте:"
            },

            AdminCommands = new TAdminCommands
            {
                MCRole = "Создать роль для верифицированных пользователей",
                AutoPost = "Автоматическое получение информации о вашем сервере",
                AddServer = "Добавить Minecraft сервер в список серверов",
                RemoveServer = "Удалить Minecraft сервер из списка",
                SetPrefix = "Установить префикс",
                ResetPrefix = "Сбросить префикс"
            },

            Admin = new TAdmin
            {
                WantTranslation = "Хотите перевести бота на другой язык? Напишите нам",
                ChangeLang = "Изменить язык бота",
                UseList = "Используйте **mc/list** для просмотра списка серверов Minecraft данного Discord сервера",
                AddServer = "Введите тэг, IP и название сервера",
                AddServerAdded = "Сервер {0} добавлен в список",
                AddServerAlready = "Этот сервер уже добавлен",
                DelServerEnter = "Удалить сервер ",
                DelServerNone = "Сервера с таким тегом нет в списке",
                DelServerDeleted = "Сервер {0} удален из списка серверов",
                PrefixReset = "Префикс сервера сброшен, используйте: mc/",
                LanguageSet = "**Установлен Русский язык!**"
            }

        };
    }
}
