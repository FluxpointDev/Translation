using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Chinese
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "Bot需要許可 \" 遷入連結 \"",
                AdminOnly = "Hey! 你不是管理員 不要再嘗試了!!",
                PlayerNotFound = "並無 {0} 玩家的資料",
                ApiError = "API錯誤",
                EnterIP = "請輸入IP",
                InvalidIP = "無效的IP",
                Cooldown = "需要杯冷水嗎? :P,請1分鐘後 再試一次",
                EnableQuery = "此Minecraft伺服器未在server.properties開啟enable-query",
                ListNoServers = "社團中沒有任何的伺服器列表 :(",
                UnknownArg = "未知的說法",
                TextLimit = "不可輸入超過22個數字/文字",
                RequireAttachFiles = "Bot需要 附加文件 的許可",
                UnknownWiki = "未知的wiki項目"
            },

            MainCommands = new TMainCommands
            {
                BotInfo = "Bot的資訊",
                Quiz = "Minecraft 測驗",
                Color = "Minecraft 顏色代碼",
                NameHistory = "Minecraft名字的歷史",
                UserProfile = "Discord 用戶資訊",
                Ping = "測試Minecraft伺服器的Ping值",
                Version = "Minecraft版本",
                Rcon = "遠端控制你的Minecraft伺服器",
                Achievement = "獲得成就",
                Playing = "Minecraft 玩家人數",
                List = "伺服器列表",
                Admin = "管理員指令",
                Invite = "新增Bot到你的伺服器裡"
            },

            Main = new TMain
            {
                HelpFooter = "還有一些隱藏的指令,等著你去發現 ;)",
                MultiMC = "MultiMC 幫助你管理和啟動多個版本,以及幫助你輕鬆的開模組伺服器",
                PleaseWait = "Ping值測試中,請稍後",
                ServerAdminUse = "Server admin should use",
                StoleSkin = "偷了skin",
                NameOnlyOne = " {0} 的帳號,從出生到現在,只有一個名字",
                PlayingMinecraft = "個玩家 正在玩Minecraft",
                Hi = "Hi",
                BotDesc = "如果你有任何問題,建議,或想要翻譯 請與我聯繫 :D ",
                First = "First"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "嘿,你找到了隱藏的指令 :D",
                Herobrine = "Always watching you...",
                Notch = "Minecraft是由 Notch aka Markus Persson 所製作"
            },

            Wiki = new TWiki
            {
                Blocks = "方塊",
                Unknown = "未知",
                Player = "玩家",
                Players = "玩家",
                Attack = "攻擊",
                Easy = "簡單",
                Hard = "困難",
                Health = "血量",
                Height = "高度",
                Width = "寬度"
            },

            Profile = new TProfile
            {
                Badges = "徽章",
                BadgeInfo = "徽章訊息",
                InvalidUserID = "無效的用戶ID",
                UnknownUser = "無法找到此用戶",
                NotInServer = "你並未在伺服器當中",
                SetMCName = "想要驗證你的帳號? 使用"
            },

            AdminCommands = new TAdminCommands
            {
                MCRole = "創建身分組給已在Minecraft驗證過的用戶",
                AutoPost = "自動發布你的Minecraft伺服器狀態",
                AddServer = "新增Minecraft伺服器至社團列表中",
                RemoveServer = "刪除此社團的列表",
                SetPrefix = "設定自定義前綴",
                ResetPrefix = "刪除自訂義前綴"
            },

            Admin = new TAdmin
            {
                WantTranslation = "你想要幫忙翻譯嗎? 請聯繫",
                ChangeLang = "更換社團的語言",
                UseList = "使用 mc/list 來查詢此社團的伺服器列表",
                AddServer = "請輸入一個TAG,IP以及 名稱",
                AddServerAdded = "已新增 {0} 至社團的伺服器列表中",
                AddServerAlready = "已在社團的伺服器列表中",
                DelServerEnter = "刪除",
                DelServerNone = "這個伺服器並未在Server列表中",
                DelServerDeleted = "已從列表中 {0} 刪除伺服器",
                PrefixReset = "已重設前綴 請使用mc/",
                LanguageSet = "語言已設定"
            }
        };
    }
}
