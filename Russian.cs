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