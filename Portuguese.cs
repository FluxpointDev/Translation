using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Portuguese
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "O BOT precisa da permissão \" Inserir Links \"",
                AdminOnly = "Você não é um administrador do servidor",
                PlayerNotFound = "Jogador {0} não encontrado",
                ApiError = "API Error",
                EnterIP = "Insere um IP",
                InvalidIP = "IP inválido",
                Cooldown = "Estás em cooldown por 1 minuto!",
                EnableQuery = "Este Servidor de Minecraft tem de ativar o enable-query em server.properties",
                ListNoServers = "Esta Comunidade não tem Servidores listados",
                UnknownArg = "Argumento desconhecido",
                TextLimit = "O texto não pode ter mais que 22 caracteres",
                RequireAttachFiles = "Bot requer permissão de anexar arquivos",
                UnknownWiki = "Unknown wiki item"
            },

            Main = new TMain
            {
                Commands = new List<string>
                {
                    "[ mc/bot ]( Bot Convite/Info/Status/Links )",
                    "[ mc/quiz ]( Minecraft Quiz :D )",
                    "[ mc/colors ]( Códigos das Cores MC )",
                    "[ mc/uuid {p} ]( UUID do Jogador )",
                    "[ mc/ping (IP) ]( Ping do Servidor )",
                    "[ mc/list ]( Lista de servidores da comunidade )",
                    "[ mc/wiki ]( Wiki de Items/Mobs/Enchants/Potions )",
                    "[ mc/version ]( Minecraft version info )",
                    "[ mc/skin {p} ]( Skin do Jogador )",
                    "[ mc/names {p} ]( Histórico de Nomes MC )",
                    "[ mc/status ]( Mojang Status )",
                    "[ mc/get (Texto) ]( Obter uma Conquista )",
                    "[ mc/playing ]( Pessoas a Jogar Minecraft )",
                    "[ mc/user ]( Your Minecraft account, skin and stats )",
                    "[ mc/rcon ]( Remote console for your Minecraft server )",
                    "[ mc/hypixel {p} ]( Hypixel player stats )",
                    "[ mc/hive {p} ]( HiveMC player stats )",
                    "[ mc/wynncraft {p} ]( Wynncraft player stats )",
                    "[ mc/admin ]( Comandos de administração da comunidade )",
                    "[ mc/invite ]( Convite do BOT )"
                },
                HelpFooter = "Também há alguns comandos ocultos ;)",
                MultiMC = "MultiMC permite administrar e lançar várias versões com instação fácil de Forge/Mods",
                PleaseWait = "Espera até eu conseguir o Ping",
                ServerAdminUse = "O administrador do servidor deve usar",
                StoleSkin = "Roubar uma Skin",
                NameOnlyOne = "O jogador {0} possui apenas 1 nome nos registros",
                PlayingMinecraft = "Pessoas a Jogar Minecraft",
                Hi = "Olá",
                BotDesc = "Se tiveres algum problema, sugestão ou tradução, contacta-me",
                First = "Primeiro"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Hey, encontraste um comando secreto :D",
                Herobrine = "Sempre observando-te...",
                Notch = "O Minecraft foi criado pelo Notch aka Markus Persson"
            },

            Wiki = new TWiki
            {
                Blocks = "blocos",
                Unknown = "Desconhecido",
                Player = "Jogador",
                Players = "Jogadores",
                Attack = "Atacar",
                Easy = "Fácil",
                Hard = "Díficil",
                Health = "Vida",
                Height = "Altura",
                Width = "Largura",
            },

            Profile = new TProfile
            {
                Badges = "Distintivos",
                BadgeInfo = "Informação do distintivo",
                InvalidUserID = "ID do usuário inválido",
                UnknownUser = "Não foi possível encontrar o usuário",
                NotInServer = "Você não está no servidor",
                SetMCName = "Para configurar seu uso da conta Minecraft"
            },

            Admin = new TAdmin
            {
                Commands = new List<string>
                {
                    "[ mc/lang ]( Muda a linguagem do BOT )",
                    "[ mc/addserver ]( Adicionar um Servidor de Minecraft á lista )",
                    "[ mc/delserver ]( Remove um Servidor de Minecraft da lista )",
                    "[ mc/setprefix ]( Set Custom Prefix )",
                    "[ mc/resetprefix ]( Remove Custom Prefix )"
                },
                WantTranslation = "Pretendes uma tradução? Contacta",
                ChangeLang = "Mudar a Linguagem do BOT",
                UseList = "Usa mc/list para veres a lista de Servidores de Minecraft",
                AddServer = "Coloca uma tag, ip e nome",
                AddServerAdded = "Servidor adicionado {0} á lista de Servidores",
                AddServerAlready = "Este Servidor já está na lista",
                DelServerEnter = "Eliminar um Servidor com",
                DelServerNone = "Este Servidor não está na lista",
                DelServerDeleted = "Servidor removido {0} da lista de Servidores",
                PrefixReset = "Uso de redefinição do prefixo do servidor mc/",
                LanguageSet = "Conjunto de idiomas da comunidade"
            }

        };
    }
}