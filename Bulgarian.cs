using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Bulgarian
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "Ботът изисква разрешение за \" Вграждане на връзки \"",
                AdminOnly = "Вие не сте администратор на сървъра",
                PlayerNotFound = "Играча {0} не е намерен",
                ApiError = "API Грешка",
                EnterIP = "Въведете IP адрес",
                InvalidIP = "Невалиден IP адрес",
                Cooldown = "Пробвайте отново след 1 минута!",
                EnableQuery = "Minecraft сървърът няма зададен enable-query в server.properties",
                ListNoServers = "Тази общност няма добавени сървъри",
                UnknownArg = "Неизвестен аргумент",
                TextLimit = "Текстът не може да бъде повече от 22 букви/цифри",
                RequireAttachFiles = "Ботът изисква разрешение за прикачване на файлове",
                UnknownWiki = "Неизвестен елемент от Уики"
            },

            MainCommands = new TMainCommands
            {
                BotInfo = "Бот информация и статистика",
                Quiz = "Тест за Minecraft",
                Color = "Minecraft кодове на цветове",
                NameHistory = "история на имената",
                UserProfile = "Потребителски профил в Discord",
                Ping = "Ping сървър на Minecraft",
                Version = "Информация за версията на Minecraft",
                Rcon = "Дистанционна конзола за вашия Minecraft сървър",
                Achievement = "Постигнете постижение",
                Playing = "Хора, които играят Minecraft",
                List = "Списък със сървърите на общността",
                Admin = "Команди на администратора на общността",
                Invite = "Добавете бот към вашия сървър Discord"
            },

            Main = new TMain
            {
                HelpFooter = "Има и скрити команди ;)",
                MultiMC = "MultiMC ви позволява да управлявате и стартирате няколко версии с лесна инсталация на forge и модове",
                PleaseWait = "Моля, изчакайте...",
                ServerAdminUse = "Администраторът на сървъра трябва да използва",
                StoleSkin = "Stole a skin",
                NameOnlyOne = "Играча {0} има само 1 име в записите",
                PlayingMinecraft = "Хора, които играят Minecraft",
                Hi = "Здрасти",
                BotDesc = "Ако имате някакви проблеми, предложения или езикови преводи, моля свържете се с мен",
                First = "Първи"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Хей, намерихте тайна команда :D",
                Herobrine = "Винаги ви гледам...",
                Notch = "Minecraft е създаден от Notch, известен още като Markus Persson"
            },

            Wiki = new TWiki
            {
                Blocks = "Блокове",
                Unknown = "Неизвестен",
                Player = "Играч",
                Players = "Играчи",
                Attack = "Атака",
                Easy = "Лесно",
                Hard = "Трудно",
                Health = "Здраве",
                Height = "Височина",
                Width = "Широчина"
            },

            Profile = new TProfile
            {
                Badges = "Значки",
                BadgeInfo = "Информация за значката",
                InvalidUserID = "Невалидно ID на потребителя",
                UnknownUser = "Потребителят не e намерен",
                NotInServer = "Вие не сте на сървъра",
                SetMCName = "За да настроите профила си в Minecraft, използвайте"
            },

            AdminCommands = new TAdminCommands
            {
                MCRole = "Създайте Minecraft роля за проверени потребители",
                AutoPost = "Автоматично публикуване на състоянието на Minecraft сървъра",
                AddServer = "Добавете Minecraft сървър в списъка на общността",
                RemoveServer = "Премахнете Minecraft сървър от списъка на общността",
                SetPrefix = "Задайте персонализиран префикс за бота",
                ResetPrefix = "Премахнете персонализираният префикс за бота"
            },

            Admin = new TAdmin
            {
                WantTranslation = "Искате бота да е преведен на вашият език? Свържете се",
                ChangeLang = "Промяна на езика на общността",
                UseList = "Използвайте mc/list за списък с Minecraft сървъри на тази общност",
                AddServer = "Въведете таг, IP адрес и име",
                AddServerAdded = "Добавен сървър {0} към списъка на общността",
                AddServerAlready = "Този сървър вече е в списъка",
                DelServerEnter = "Изтриване на сървър с",
                DelServerNone = "Този сървър не съществува в списъка",
                DelServerDeleted = "Успешно премахнахте {0} от списъка с Minecraft сървъри на общността",
                PrefixReset = "Използване на префикс mc/",
                LanguageSet = "Езикът на общността обновен"
            }
        };
    }
}
