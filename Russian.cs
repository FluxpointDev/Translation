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
                AdminOnly = "Вы не администратор",
                PlayerNotFound = "Игрок {0} не найден",
                ApiError = "Ошибка API",
                UnknownItemID = "",
                UnknownMob = "",
                EnterIP = "Введите IP",
                InvalidIP = "",
                Cooldown = "Вы на кулдауне на 1 минуту!",
                EnableQuery = "Этот сервер не имеет определённой отметки 'enable-query' в 'server.properties'",
                ListNoServers = "Это сообщество не имеет серверов",
                UnknownArg = "Неизвестный аргумент",
                TextLimit = "Текст не может содержать более 22 символов"
            },

            Main = new TMain
            {
                Commands = new List<string>
                {
                    "[ mc/bot ]( Основная информация о боте: приглашение/статистика/ссылки )",
                    "[ mc/quiz ]( Викторина :D )",
                    "[ mc/colors ]( Коды цветов )",
                    "[ mc/uuid (игрок) ]( UUID игрока )",
                    "[ mc/ping (IP) ]( Пинг сервера )",
                    "[ mc/list ]( Список серверов сообщества )",
                    "[ mc/wiki ]( Вики: информация о мобах/предметах/зачарованиях и т.д. )",
                    "[ mc/version ]( Minecraft version info )",
                    "[ mc/skin (игрок) ]( Скин игрока )",
                    "[ mc/names (игрок) ]( История имён аккаунта )",
                    "[ mc/status ]( Статус Mojang )",
                    "[ mc/get (текст) ]( Генератор достижений )",
                    "[ mc/minime (игрок) ]( Минимизировать скин игрока )",
                    "[ mc/playing ]( Сколько людей играют в Minecraft на данный момент )",
                    "[ mc/hypixel (Player) ]( Hypixel player stats )",
                    "[ mc/admin ]( Команды администратора сообщества )",
                    "[ mc/invite ]( Ссылка на добавление бота на свой сервер )"
                },
                HelpFooter = "Также здесь есть несколько секретных команд ;)",
                MultiMC = "MultiMC позволяет запускать любые версии игры, также можно легко установить Forge и моды",
                SkinEditor = "Онлайн редактор скинов",
                PleaseWait = "Подождите, пожалуйста...",
                ServerAdminUse = "",
                SkinArgs = "(игрок) | голова | куб | полный | украсть",
                StoleSkin = "Украден скин",
                NameOnlyOne = "Игрок {0} имеет только 1 имя в записях",
                PlayingMinecraft = "Игроки в Minecraft",
                Hi = "Привет",
                BotDesc = "Если вы нашли неполадки или у вас есть предложения, обращайтесь ко мне"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "",
                MinecraftClassic = "",
                Forgecraft = "",
                Bukkit = "",
                Direwolf20 = "",
                Herobrine = "",
                Entity303 = "",
                Israphel = "",
                Notch = ""
            },

            Wiki = new TWiki
            {
                Blocks = "",
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

            Admin = new TAdmin
            {
                Commands = new List<string>
                {
                    "[ mc/lang ]( Установить язык сервера )",
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
                PrefixReset = ""
            }

        };
    }
}