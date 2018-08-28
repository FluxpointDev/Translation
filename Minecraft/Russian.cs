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
                Version = "Информация версии Minecraft",
                Rcon = "Удалённая консоль для вашего сервера Minecraft",
                Achievement = "Генератор достижений",
                Playing = "Игроков Minecraft в данный момент",
                List = "Список серверов Minecraft",
                Admin = "Команды для Администратора сервера",
                Invite = "Добавить бота на свой сервер!"
            },

            Main = new TMain
            {
                HelpFooter = "Также здесь есть несколько секретных команд ;)",
                MultiMC = "MultiMC позволяет запускать любые версии игры, также можно легко установить Forge и моды",
                PleaseWait = "Подождите, пожалуйста...",
                ServerAdminUse = "Администратор сервера должен использовать",
                StoleSkin = "Украден скин",
                NameOnlyOne = "Игрок {0} не изменял свой никнейм никогда",
                PlayingMinecraft = "Игроки в Minecraft",
                Hi = "Привет",
                BotDesc = "Если вы нашли неполадки или у вас есть предложения, обращайтесь ко мне",
                First = "Первый"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Эй, ты нашёл секретную команду :D",
                Herobrine = "Всегда следим за тобой...",
                Notch = "Minecraft был создан Нотчем / Маркусом Перссоном"
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
                InvalidUserID = "Неверный идентификатор пользователя",
                UnknownUser = "Не удалось найти игрока",
                NotInServer = "Вы не на сервере",
                SetMCName = "Чтобы настроить использование учетной записи Minecraft"
            },

            AdminCommands = new TAdminCommands
            {
                MCRole = "Создать роль для верифицированных пользователей",
                AutoPost = "Автоматически получать информацию о вашем сервере",
                AddServer = "Добавить Minecraft сервер в список серверов",
                RemoveServer = "Удалить Minecraft сервер из списка",
                SetPrefix = "Установить префикс",
                ResetPrefix = "Удалить префикс"
            },

            Admin = new TAdmin
            {
                WantTranslation = "Хотите перевести бота на другой язык? Напишите нам",
                ChangeLang = "Изменить язык бота",
                UseList = "Используйте mc/list для просмотра списка серверов Minecraft данного Discord сервера",
                AddServer = "Введите тэг, IP и название сервера",
                AddServerAdded = "Сервер {0} добавлен в список",
                AddServerAlready = "Этот сервер уже добавлен",
                DelServerEnter = "Удалить сервер ",
                DelServerNone = "Сервера нет в списке",
                DelServerDeleted = "Сервер {0} из списка серверов",
                PrefixReset = "Префикс сервера сброшен, используйте mc/",
                LanguageSet = "Установлен Русский язык!"
            }

        };
    }
}
