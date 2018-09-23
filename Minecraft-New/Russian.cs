using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Russian
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                APIError = "Ошибка в API",
                NoList = "В этом Discord сервере, не добавлены сервера Minecraft",
                NotVoted = "Вы не проголосовали за бота",
                PlayerNotFound = "Игрок не найден",
                NoAttachFiles = "Бот не имеет прав на прикрепление файлов"
            },

            Misc = new TMisc
            {
                Stats = "Статистика",
                Software = "Программа",
                List = "Список",
                Yes = "Да",
                No = "Нет",
                Server = "Сервер",
                Status = "Статус",
                Connected = "Подключение",
                Blocks = "Блоки",
                Unknown = "Неизвестно",
                Player = "Игрок",
                Players = "Игроки",
                Attack = "Атака",
                Easy = "Легкий",
                Hard = "Сложный",
                Health = "Здоровье",
                Height = "Высота",
                Width = "Ширина",
                Download = "Скачать"
            },

            MainCommands = new TMainCommands
            {
                UserCmd = "Профиль пользователя",
                VerifyCmd = "Подтвердите свой профиль",
                BotCmd = "Информация о боте",
                ColorCmd = "Цветовые кода Minecraft",
                QuizCmd = "Minecraft викторина",
                ListCmd = "Список серверов",
                UUIDCmd = "Информация о игроке по UUID",
                SkinCmd = "Получить скин игрока",
                NamesCmd = "Получить информацию о смене никнеймов",
                GetCmd = "Сгенерировать достижение Minecraft",
                ChangelogCmd = "Изменения в Minecraft",
                GalleryCmd = "Баннеры и картинки",
                VersionCmd = "Информация о версии Minecraft",
                RconCmd = "Удаленная консоль для вашего Minecraft сервера",
                WikiCmd = "Minecraft wiki",
                AdminCmd = "Команды для настройки бота",
                InviteCmd = "Пригласать бота на свой сервер",
                Footer = "Также есть несколько секретных команд",
                MultiMC = "позволяет управлять и загружать новые версии Minecraft, а также легко устанавливать моды"
            },

            Main = new TMain
            {
                HaveIssues = "Если у вас есть вопросы свяжитесь со мной в Discord",
                playerstats = "статистика игрока",
                GetStats = "Получить статистику игрока на",
                PlayingInfo = "Количество игроков в Minecraft",
                WantListed = "Хотите, чтобы ваш сервер Minecraft был здесь? Используйте"
            },

            Gallery = new TGallery
            {
                BannerRandom = "Получить рандомный баннер",
                BannerName = "Получить баннер по имени",
                ArtRandom = "Получить рандомную картинку",
                WallpaperRandom = "Получить рандомные обои"
            },

            Ping = new TPing
            {
                Java = "Задержка Minecraft сервера",
                PE = "Задержка Pocket Edition сервера",
                Full = "Задержка Minecraft сервера и список игроков играющие на нём",
                Banner = "Баннерная версия задержки",
                EnterIP = "Укажите IP адрес сервера",
                Wait = "Подождите, сбор информации о задержке",
                NoEnableQuery = "На сервере не включен пераметр enable-query, включите его в server.properties",
                InvalidIP = "Неверный IP адрес",
                InvalidPort = "Неверный порт",
                OnCooldown = "Частое выполнение команд! Подожите 1 минуту",
                NoPlayers = "Нет игроков онлайн"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Ты нашел секретную команду :D",
                Herobrine = "Всегда смотрит за тобой...",
                Notch = "Minecraft создан Notch aka Марку Перссон"
            },

            Rcon = new TRcon
            {
                Title = "Удаленная консоль",
                Info = "Позволяет использовать команды на сервере Minecraft прямо из Discord",
                NotSetup = "Удаленная консоль не подключена",
                Execute = "Запускайте команды на сервере используя",

                ConfigCmd = "Посмотреть настройки",
                BlacklistCmd = "Команды занесенные в чёрный список доступны только владельцу сервера",
                AccessCmd = "Дать доступ другим пользователям",
                EnableCmd = "Включить удаленную консоль",
                DisableCmd = "Выключить удаленную консоль",
                FixCmd = "Попытка установить соединение",
                ResetCmd = "Удалить настройки удаленной консоли",

                AccessList = "Список доступа",
                AccessOwner = "Комманды для полного доступа и настройки",
                AccessAdmin = "Доступ к командам не занесённые в чёрный список",
                AccessMod = "Доступ только к коммандам kick и ban",
                CommandBlacklist = "Команды занесенные в черный список",
                BlacklistInfo = "Только владелец может использовать команды занесенные в черный список",
                Enabled = "Удаленная консоль включена",
                Disabled = "Удаленная консоль выключена",
                FixAttempt = "Переподключение к удаленной консоли",
                ResetConfirm = "Чтобы подтвердить сброс, используйте",
                Reset = "Настройки удаленной консоли удалены"
            },

            Badges = new TBadges
            {
                Owner = "Владелец бота",
                MobHunter = "Эксперт по знаниям в мобах",
                Translator = "Помощь в переводе бота",
                Verified = "Имеет лицензионный аккаунт Minecraft",
                Voted = "Проголосовал за бота",
                PlayedOn = "Играл на"
            },

            User = new TUser
            {
                NotVerified = "Этот пользователь не имеет лицензионного аккаунта Minecraft, для привязки используйте",
                LastPlayed = "В последний раз играл на;",
                Badges = "Значки",
                BadgesInfo = "Информация о значках",
                NoBadges = "У вас нет значков"
            },

            Verify = new TVerify
            {
                Title = "Привязка аккаунта Minecraft",
                Info = "Привяжите свой лицензионный аккаунт Minecraft",
                Step1 = "Загружите Minecraft 1.12.2",
                Step2 = "Зайдите на сервер",
                Step3 = "Введите в Discord"
            },

            AdminCommands = new TAdminCommands
            {
               AddCmd = "Добавить Minecraft сервер в список",
               AutopostCmd = "Автоматическая отправка информации о сервере",
               DelCmd = "Удалить Minecraft сервер из списка",
               LangCmd = "Изменить язык",
               ResetPrefixCmd = "Сбросить префикс бота",
               RoleCmd = "Создать Minecraft роль для подтвержденных пользователей",
               SetPrefixCmd = "Установить кастомный префикс"
            },

            Admin = new TAdmin
            {
               NotAdmin = "Вы не администратор сервера",
               LangSet = "Язык установлен на",
               PrefixSet = "Кастомный префикс утсановлен на",
               ChooseToRemove = "Выберите номер сервера для удаления",
               EnterName = "Укажите имя сервера",
               WantToAdd = "Вы хотите добавить сервер? да/нет",
               GlobalList = "Укажите здесь, хотите ли вы чтобы сервер Minecraft был в публичном доступе",
               PrefixReset = "Кастомный префикс удален, испрользуйте",
               AlreadyAdded = "Этот сервер уже есть в списке",
               ServerAdded = "Сервер был добавлен",
               ServerRemoved = "Сервер удален",
               WantTranslated = "Хотиет помочь в переводе? Свяжитесь со мной в Discord"
            }
        };
    }
}
