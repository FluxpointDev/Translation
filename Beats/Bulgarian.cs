using static Bot.Translations.TranslationClasses;

namespace Bot.Translations
{
    public class Bulgarian
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                Locked = "Бота е заключен само за DJ/Admin",
                QueueEmpty = "Опашката е празна",
                UnknownOption = "Неизвестна опция",
                NotAdmin = "Вие не сте Администратор",
                BotNotInVoice = "Бота не е в гласов канал",
                UserNotInVoice = "Вие не сте в гласов канал",
                UserNotSameVoice = "Вие не сте в същия гласов канал като бота",
                NotDJ = "Вие не сте DJ/Admin",
                NoMusic = "Бота не изпълнява никаква музика",
                NoAccess = "Нямате достъп до тази команда",
                NoJoinPerms = "Бота няма разрешение да се присъедини към гласовия канал",
                NoSpeakPerms = "Бота няма разрешение да говори в гласовия канал",
                NoViewPerms = "Бота няма разрешение да преглежда гласовия канал",
                UserSameVoice = "Вече сте в един и същ гласов канал",
                OtherUser = "Вече изпълнявам музика за друг потребител",
                NoManageMessagesPerm = "Нямате разрешение за Управление на Съобщенията",
                InvalidNumber = "Въведен е невалиден номер",
                SameNumber = "Не можете да преместите песен на същата позиция",
                VolMoreThan = "Силата на звука не може да бъде повече от 150",
                CouldNotPlay = "Песента не можа да бъде изпълнена",
                UnknownSong = "Не можах да намеря",
                UnknownGlobal = "Неизвестна глобална песен",
                AlreadyPlaying = "Музиката вече се изпълнява",
                AlreadyPaused = "Музиката вече е на пауза",
                SameVoice = "Вече сте в един и същ гласов канал"
            },

            Feature = new TFeature
            {
                Loop = "Преминалите песни ще бъдат добавени към опашката и ще бъдат изпълнени отново",
                Shuffle = "Изберете произволна песен от опашката за следваща",
                VoteSkip = "Пусни гласуване за пропускане на текущата песен"
            },

            Main = new TMain
            {
                PlayTip = "Пусни песен или добави в опашката за изпълнение",
                StopAndClear = "Музиката е спряна и опашката изчистена",
                StopAndLeave = "Музиката е спряна, бота напуска гласовия канал",
                QueueCleared = "Опашката за изпълнение е изчистена",
                ChooseNumber = "Изберете число",
                GettingSongs = "Свалям песните моля изчакайте",
                SpotifyTip = "Албуми и плейлисти от Spotify зареждат по-бавно"
            },

            Misc = new TMisc
            {
                Admin = "Админ",
                Info = "Информация",
                Music = "Музика",
                User = "Потребител",
                Song = "Песен",
                Locked = "Заключен",
                Loop = "Повтаряне",
                Queue = "Опашка",
                Shuffle = "Разбъркване",
                Stats = "Статистика",
                Volume = "Сила на звука",
                Stopped = "Спрян",
                Playing = "Изпълнява се",
                Paused = "Пауза",
                ForceSkipped = "Принудително пропусната",
                VoteSkip = "Гласуване за пропускане",
                Skipped = "Пропусната",
                VoteSkipped = "Пропусната с гласуване",
                Next = "Следващ",
                NextSong = "Следваща песен",
                MusicPaused = "Музиката е на пауза",
                MusicResumed = "Музиката бе възобновена"
            },

            Profile = new TProfile
            {

            },

            AdminCommands = new TAdminCommands
            {

            },

            DJ = new TDJ
            {
                LoopDisabled = "Повтарянето е изключено",
                LoopEnabled = "Повтарянето е включено",
                ShuffleDisabled = "Разбъркването е изключено",
                ShuffleEnabled = "Разбъркването е включено",
                LockInfo = "Заключете бота, така че само DJ/Admin могат да пускат, пропускат, паузират",
                ForceClear = "Опашката е изчистена",
                ForceLeave = "Бота беше принуден да напусне гласовия канал",
                ForceSkip = "Музиката е пропусната",
                ForceStop = "Музиката е спряна",
                LockEnabled = "Бота е заключен само за DJ/Admin",
                LockDisabled = "Бота е отключен",
                MoveInfo = "Преместване на песни в опашката",
                RemoveInfo = "Премахване на песен от опашката",
                VoteSkipInfo = "Активирайте функцията за пропускане с гласове, при която само 40% или повече от потребителите са нужни за да пропуснат текущата песен",
                VoteSkipDisabled = "Пропускането с гласове е изключено",
                VoteSkipEnabled = "Пропускането с гласове е включено",
                RemovedSong = "Песента беше премахната от опашката",
                MovedSong = "Песента беше преместена"
            },

            Admin = new TAdmin
            {
               
            }
        };
    }
}
