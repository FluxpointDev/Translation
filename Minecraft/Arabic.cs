using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Arabic
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "البوت يتطلب رخصة روابط امبيد",
                AdminOnly = "انت لست مشرف السيرفر",
                PlayerNotFound = "اللاعب {0} غير موجود",
                ApiError = "خطا في واجهة برمجة التطبيقات",
                EnterIP = "ادخل عنوان اي بي",
                InvalidIP = "عنوان الايبي غير صالح",
                Cooldown = "انت في وضع الايقاف لمدة دقيقة",
                EnableQuery = "server.properties في  enable-query سيرفر ماين كرافت لا يحتوي على ",
                ListNoServers = "هذا المجتمع ليس لدية لائحة سيرفرات",
                UnknownArg = "طلب المفعول غير معروف",
                TextLimit = "لا يمكن ان يكون النص اكثر من 22 حرفا/رقما",
                RequireAttachFiles = "البوت يتطلب رخصة ارفاق الملفات",
                UnknownWiki = "حاجة الويكي غير معروفة"
            },

            MainCommands = new TMainCommands
            {
                BotInfo = "معلمومات وحالة البوت",
                Quiz = "مسابقات ماين كرافت",
                Color = "اكواد الوان ماين كرافت",
                NameHistory = "اسم التاريخ",
                UserProfile = "الملف الشخصي للدسكورد",
                Ping = "سرعة سيرفر ماين كرافت",
                Version = "معلومات تحديث ماين كرافت",
                Rcon = "وحدة التحكم لسيرفر ماين كرافت الخاص بك",
                Achievement = "احصل على انجاز",
                Playing = "الناس الذين يلعبون ماين كرافت",
                List = "لائحة سيرفرات المجتمع",
                Admin = "اوامر ادمن المجتمع",
                Invite = "ادخل البوت لسيرفر الدسكورد الخاص بك"
            },

            Main = new TMain
            {
                HelpFooter = ";) هنالك بعض الاومر مخفية كذلك",
                MultiMC = "forge/mods يسمح لك بتعديل و الدخول باصدارت متعددة مع سهولة تحميل MultiMC",
                PleaseWait = "الرجاء الانتظار اثناء اختبار السرعة",
                ServerAdminUse = "يجب استخدام خادم المشرف",
                StoleSkin = "سرقة السكن",
                NameOnlyOne = "اللاعب {0} يحتوي فقط على اسم واحد في التسجيل",
                PlayingMinecraft = "الناس الذين يلعبون ماين كرافت",
                Hi = "مرحبا",
                BotDesc = "اذا كان لديك اي مشكلة او اقتراحات او ترجمة لغات ,راسلني",
                First = "الاول"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = ":D هاي, لقد وجدت امر سري",
                Herobrine = "....دائما اراقبك",
                Notch = "ماين كرافت انشأت بواسطة نوتش الملقب ماركوس بيرسون"
            },

            Wiki = new TWiki
            {
                Blocks = "Blocks",
                Unknown = "غير معروف",
                Player = "لاعب",
                Players = "لاعبين",
                Attack = "هجوم",
                Easy = "سهل",
                Hard = "صعب",
                Health = "صحة",
                Height = "الارتفاع",
                Width = "العرض"
            },

            Profile = new TProfile
            {
                Badges = "الشارات",
                BadgeInfo = "معلومات الشارات",
                InvalidUserID = "اي دي الشخص غير صالح",
                UnknownUser = "لم نستطع العثور على الشخص",
                NotInServer = "انت لست في السيرفر",
                SetMCName = "لكي تضع اسم حسابك في ماين كرافت استخدم"
            },

            AdminCommands = new TAdminCommands
            {
                MCRole = "انشاء رتبة ماين كرافت للذين تم التحقق منهم",
                AutoPost = "الناشر التلقائي لحالة سيرفرك في ماين كرافت",
                AddServer = "اضافة سيرفر ماين كرافت للائحة المجتمع",
                RemoveServer = "ازالة سيرفر ماين كرافت من لائحة المجمتع",
                SetPrefix = "وضع اختصار محدد لهذا البوت",
                ResetPrefix = "مسح الاختصار المحدد"
            },

            Admin = new TAdmin
            {
                WantTranslation = "تريد ترجمة لغة؟ تواصل",
                ChangeLang = "تغيير لغة المجتمع",
                UseList = " لعرض لائحة السيرفرات الخاصة بمجموعتك mc/list استعمل ",
                AddServer = "ادخل اختصار, الايبي و الاسم",
                AddServerAdded = "لقد تمت اضافة {0} الى لائحة السيرفرات",
                AddServerAlready = "هذا السيرفر موجود بالفعل في لائحة السيرفرات",
                DelServerEnter = "حذف السيرفر مع",
                DelServerNone = "السيرفر ليس في قائمة السيرفرات",
                DelServerDeleted = "لقد تمت ازالت {0} من قائمة السيرفرات",
                PrefixReset = "mc/ لقد تم مسح اختصار السيرفر استخدم",
                LanguageSet = "مجموعة لغات المجتمع"
            }
        };
    }
}
