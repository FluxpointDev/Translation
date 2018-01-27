public static class _Trans
{
    public static class Main
    {
        public static TList HelpList = new TList()
            {
                // Leave the [ mc/command ] alone do the ( )
                EN = new string[] 
                {
                    "[ mc/bot ]( Bot Invite/Info/Stats/Links )",
                    "[ mc/quiz ]( Minecraft quiz :D )",
                    "[ mc/colors ]( MC color codes )",
                    "[ mc/uuid (Player) ]( Player UUID )",
                    "[ mc/ping (IP) ]( Ping a server )",
                    "[ mc/list ]( List community servers )",
                    "[ mc/wiki ]( Wiki for Items/Mobs/Enchants/Potions )",
                    "[ mc/version ]( Minecraft version info )",
                    "[ mc/skin (Player) ]( Player skin )",
                    "[ mc/names (Player) ]( MC account name history )",
                    "[ mc/status ]( Mojang status )",
                    "[ mc/get (Text) ]( Get an achievement )",
                    "[ mc/minime (Player) ]( Minify player skin )",
                    "[ mc/playing ]( People playing Minecraft )",
                    "[ mc/admin ]( Community admin commands )",
                    "[ mc/invite ]( Get the bot invite )"
                }
            };

            public static TString Error_NoEmbedPerms = new TString()
            {
                EN = "Bot requires permission \" Embed Links \""
            };

            public static TString Help_FooterHiddenCommands = new TString()
            {
                EN = "There are some hidden commands aswell ;)"
            };

            public static TString Commands = new TString()
            {
                EN = "Commands"
            };

            public static TString Links = new TString()
            {
                EN = "Links"
            };

            public static TString MultiMC = new TString()
            {
                EN = "MultiMC allows you to manage and launch multiple versions with easy forge/mods installation"

            };

            public static TString ColorCodes = new TString()
            {
                EN = "Minecraft Color Codes"
            };

            public static TString Error_PlayerNotFound = new TString()
            {
                EN = "Player {0} not found"
            };

            #region PingCommand
            public static TString Error_EnterIP = new TString()
            {
                EN = "Enter an IP"
            };
            public static TString Error_IPMain = new TString()
            {
                EN = "You really think that would work?"
            };
            public static TString Error_IPRouter = new TString()
            {
                EN = "Minecraft servers don't run on routers DUH"
            };
            public static TString Error_IPZero = new TString()
            {
                EN = "Not enough zeros?"
            };
            public static TString Error_IPGoogle = new TString()
            {
                EN = "This is for minecraft servers not google :("
            };
            public static TString Error_IPYoutube = new TString()
            {
                EN = "This is for minecraft servers not youtube :("
            };
            public static TString Error_IPMyWeb = new TString()
            {
                EN = "Trying to ping my own website :D"
            };
            public static TString Error_IPBlocked = new TString()
            {
                EN = "Minecraft server has blocked the ping"
            };
            public static TString Error_EnableQuery = new TString()
            {
                EN = "Minecraft server does not have enable-query set in server.properties"
            };
            public static TString Error_IPInvalid = new TString()
            {
                EN = "This is not a valid ip"
            };
            public static TString Error_Cooldown = new TString()
            {
                EN = "You are on cooldown for 1 mins!"
            };
            public static TString Ping_PleaseWait = new TString()
            {
                EN = "Please wait while I ping"
            };
            public static TString Ping_ServerLoading = new TString()
            {
                EN = "Server is loading!"
            };
            public static TString Players = new TString()
            {
                EN = "Players"
            };
            public static TString Ping_ServerOffline = new TString()
            {
                EN = "Server is offline"
            };
            #endregion

            public static TString List_NoServers = new TString()
            {
                EN = "This community has no servers listed"
            };
            public static TString List_GuildAdmin = new TString()
            {
                EN = "Guild administrators should use"
            };
            public static TString Servers = new TString()
            {
                EN = "Servers"
            };

            #region InfoCommand
            public static TString Info_MCSales = new TString()
            {
                EN = "Minecraft Account Sales"
            };
            public static TString Info_SalesError = new TString()
            {
                EN = "Stats may be slightly off due to caching"
            };
            public static TString Error_Api = new TString()
            {
                EN = "API Error"
            };
            #endregion

            #region SkinCommand
            public static TString Skin_Args = new TString()
            {
                EN = "(Player) | head | cube | full | steal"
            };
            public static TString Skin_Stole = new TString()
            {
                EN = "Stole a skin"
            };
            public static TString Error_UnknownArg = new TString()
            {
                EN = "Unknown argument do"
            };
            #endregion

            #region NameCommand
            public static TString Player = new TString()
            {
                EN = "Player"
            };
            public static TString Name_OneOnly = new TString()
            {
                EN = "Player {0} only has 1 name on records"
            };
            public static TString First = new TString()
            {
                EN = "First"
            };
            public static TString Name_PlayerNotFoundNames = new TString()
            {
                EN = "Player {0} not found, please use the current players name"
            };
            #endregion

            #region StatusCommand
            public static TString Status_Mojang = new TString()
            {
                EN = "Mojang Status"
            };
            public static TString Status_MojangAccounts = new TString()
            {
                EN = "Mojang accounts"
            };
            public static TString Status_MojangAuthServers = new TString()
            {
                EN = "Mojang auth servers"
            };
            public static TString Status_MojangAuthService = new TString()
            {
                EN = "Mojang auth service"
            };
            public static TString Status_MojangSessions = new TString()
            {
                EN = "Mojang sessions"
            };
            public static TString Status_MinecraftSessions = new TString()
            {
                EN = "Minecraft.net sessions"
            };
            public static TString Status_MinecraftSkins = new TString()
            {
                EN = "Minecraft.net skins"
            };
            public static TString Status_MinecraftTextures = new TString()
            {
                EN = "Minecraft.net textures"
            };
            #endregion

            public static TString PeoplePlayingMinecraft = new TString()
            {
                EN = "People playing Minecraft [Discord]"
            };
            public static TString Text = new TString()
            {
                EN = "Text"
            };
            public static TString Hi = new TString()
            {
                EN = "Hi"
            };
            public static TString Get_ErrorLimit = new TString()
            {
                EN = "Text cannot be more than 22 letters/numbers"
            };
            public static TString OnlineSkinEditor = new TString()
            {
                EN = "Online Skin Editor"
            };

            #region BotCommand
            public static TString Bot_Desc = new TString()
            {
                EN = "If you have any issue, suggestions or language translations please contact me"
            };
            public static TString Bot_Footer = new TString()
            {
                EN = "Bot owner commands do not count to the command count above also some of them are secret ones you have to find"
            };
            public static TString Bot_Owner = new TString()
            {
                EN = "Bot Owner"
            };
            public static TString Language = new TString()
            {
                EN = "Language"
            };
            public static TString Bot_Lib = new TString()
            {
                EN = "Library"
            };
            public static TString Stats = new TString()
            {
                EN = "Stats"
            };
            public static TString Guilds = new TString()
            {
                EN = "Guilds"
            };

            public static TString Uptime = new TString()
            {
                EN = "Uptime"
            };

            public static TString Bot_Invite = new TString()
            {
                EN = "Bot Invite"
            };

            public static TString Bot_ListGuilds = new TString()
            {
                EN = "Bot List Guilds"
            };
            #endregion

            public static TString Info = new TString()
            {
                EN = "Info"
            };
            public static TString Unknown = new TString()
            {
                EN = "Unknown"
            };
            public static TString Health = new TString()
            {
                EN = "Health"
            };
            public static TString Height = new TString()
            {
                EN = "Height"
            };
            public static TString Width = new TString()
            {
                EN = "Width"
            };
            public static TString Type = new TString()
            {
                EN = "Type"
            };
            public static TString Version = new TString()
            {
                EN = "Version"
            };
            public static TString Attack = new TString()
            {
                EN = "Attack"
            };
            public static TString Easy = new TString()
            {
                EN = "Easy"
            };
            public static TString Normal = new TString()
            {
                EN = "Normal"
            };
            public static TString Hard = new TString()
            {
                EN = "Hard"
            };
        }
       public static class Wiki
        {
            public static TString Error_UnknownItemID = new TString()
            {
                EN = "Cannot find item name or ID"
            };
            public static TString Error_UnknownMob = new TString()
            {
                EN = "Cannot find mob name"
            };
            public static TString blocks = new TString()
            {
                EN = "blocks"
            };
            public static TString Fist_Attack = new TString()
            {
                EN = "Fist Attack"
            };
        }
        public static class Hidden
        {
            public static TString Wallpaper = new TString()
            {
                EN = "Wallpaper"
            };
            public static TString ForgecraftWiki = new TString()
            {
                EN = "Wiki And Forgecraft Users"
            };
            public static TString BukkitNews = new TString()
            {
                EN = "Bukkit News"
            };
            public static TString FoundSecretCommand = new TString()
            {
                EN = "Hey, you found a secret command :D"
            };
            public static TString MinecraftClassic = new TString()
            {
                EN = "Minecraft classic was the second phase of developent in 2009 that allowed players to play in the browser using java on the minecraft.net website which was primarly used to build things"
            };
            public static TString Forgecraft = new TString()
            {
                EN = "Forgecraft is the set of private whitelisted servers for mod developers to gather and beta-test their mods in a private environment. Many YouTubers and live-streamers also gather on the server to interact with the mod developers, help play-test the mods, and create videos to let the general public know what the mod developers are doing."
            };
            public static TString ForgecraftWallpaper = new TString()
            {
                EN = "Forgecraft Wallpaper"
            };
            public static TString Bukkit = new TString()
            {
                EN = "RIP Bukkit you will be missed along with other server solutions..."
            };
            public static TString Direwolf20 = new TString()
            {
                EN = "Direwolf20 is a popular youtuber known for his lets plays and mod tutorials on modded minecraft. He also plays on a private server called Forgecraft with a bunch of mod developers and other youtubers with his friends Soaryn and Pahimar"
            };
            public static TString Herobrine = new TString()
            {
                EN = "Always watching you..."
            };
            public static TString Entity303 = new TString()
            {
                EN = "A minecraft creepy pasta of a former Mojang employee who was fired by Notch and now want revenge"
            };
            public static TString Israphel = new TString()
            {
                EN = "The best youtube minecraft series that will never die in our hearts... 2010 - 2012 RIP Yogscast"
            };
            public static TString Notch = new TString()
            {
                EN = "Minecraft was created by Notch aka Markus Persson"
            };
        }

        public static class Admin
        {
            public static TList Commands = new TList()
            {
                EN = new string[]
                {
                    "[ mc/lang ]( Set the community language )",
                    "[ mc/addserver ]( Add a MC server to this guild list )",
                    "[ mc/delserver ]( Remove a MC server from this guild list )",
                    "[ mc/setprefix ]( Set Custom Prefix )",
                    "[ mc/resetprefix ]( Remove Custom Prefix )"
                }
            };
            public static TString LanguageTranslate = new TString()
            {
                EN = "Want a language translates? Contact"
            };
            public static TString Error_NoData = new TString()
            {
                EN = "Could not find guild data contact xXBuilderBXx#9113"
            };
            public static TString AdminCommands = new TString()
            {
                EN = "Guild Admin Commands"
            };
            public static TString AdminOnly = new TString()
            {
                EN = "You are not a guild admin"
            };
            public static TString UseList = new TString()
            {
                EN = "Use mc/list for a list of this guilds minecraft servers"
            };
            public static TString AddServer = new TString()
            {
                EN = "Enter a tag, ip and name"
            };
            public static TString AddServer_Already = new TString()
            {
                EN = "This server is already on the list"
            };
            public static TString AddServer_Added = new TString()
            {
                EN = "Added server {0} to the guild list"
            };
            
            public static TString DelServer_Enter = new TString()
            {
                EN = "Delete a server with"
            };
            public static TString DelServer_None = new TString()
            {
                EN = "This server is not on the list"
            };
            public static TString DelServer_Deleted = new TString()
            {
                EN = "Removed server {0} from the guild list"
            };

            public static TString ChangeLang = new TString()
            {
                EN = "Change Community Language"
            };
        }
    }
