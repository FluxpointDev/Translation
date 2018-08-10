using Bot.Data;
using Newtonsoft.Json.Linq;
using System;
using static Bot.Translations.TranslationClasses;

namespace Bot.Translations
{
    public class _Trans
    {
        public TError Error;
        public TFeature Feature;
        public TMain Main;
        public TMisc Misc;
        public TProfile Profile;
        public TDJ DJ;
        public TAdminCommands AdminCommands;
        public TAdmin Admin;
        /// <summary>
        /// Check for missing translations
        /// </summary>
        public void Check(string Name)
        {
            foreach (JProperty property in JObject.FromObject(this).Properties())
            {
                if (string.IsNullOrEmpty(property.Value.ToString()))
                    _Bot.Log.Warn("Translation", $"NULL {Name}.{property.Name}");
                else if (property.HasValues)
                {
                    foreach (JProperty p in property.Value)
                    {
                        if (string.IsNullOrEmpty(p.Value.ToString()))
                            _Bot.Log.Warn("Translation", $"NULL {Name}.{property.Name}.{p.Name}");
                    }
                }
            }
            _Data.Translate.Add(Name.ToLower(), this);
        }
    }

    public class TranslationClasses
    {
        public class TError
        {
            /// <summary>
            /// Bot has been locked
            /// </summary>
            public string Locked;

            /// <summary>
            /// Queue is empty
            /// </summary>
            public string QueueEmpty;

            /// <summary>
            /// Unknown option entered
            /// </summary>
            public string UnknownOption;

            /// <summary>
            /// Bot is not in a voice channel
            /// </summary>
            public string BotNotInVoice;

            /// <summary>
            /// User is not in a voice channel
            /// </summary>
            public string UserNotInVoice;

            /// <summary>
            /// User is not in the same voice channel
            /// </summary>
            public string UserNotSameVoice;

            /// <summary>
            /// User is in same voice channel
            /// </summary>
            public string UserSameVoice;

            /// <summary>
            /// User is not a DJ
            /// </summary>
            public string NotDJ;

            /// <summary>
            /// User is not an Admin
            /// </summary>
            public string NotAdmin;

            /// <summary>
            /// No music is playing
            /// </summary>
            public string NoMusic;

            /// <summary>
            /// No access to command
            /// </summary>
            public string NoAccess;

            /// <summary>
            /// No view voice channel perms
            /// </summary>
            public string NoViewPerms;

            /// <summary>
            /// No connect voice channel perms
            /// </summary>
            public string NoJoinPerms;

            /// <summary>
            /// No speak voice channel perms
            /// </summary>
            public string NoSpeakPerms;

            /// <summary>
            /// Already playing music for another user
            /// </summary>
            public string OtherUser;

            /// <summary>
            /// User does not have Manage Messages perm
            /// </summary>
            public string NoManageMessagesPerm;

            /// <summary>
            /// Invalid number entered
            /// </summary>
            public string InvalidNumber;

            /// <summary>
            /// Move number is the same
            /// </summary>
            public string SameNumber;

            /// <summary>
            /// Volume cannot be more than 150
            /// </summary>
            public string VolMoreThan;

            /// <summary>
            /// Could not play song
            /// </summary>
            public string CouldNotPlay;

            /// <summary>
            /// Could not find song
            /// </summary>
            public string UnknownSong;

            /// <summary>
            /// Unknown global song
            /// </summary>
            public string UnknownGlobal;

            /// <summary>
            /// You are already in the same voice channel
            /// </summary>
            public string SameVoice;

            /// <summary>
            /// Music already playing
            /// </summary>
            public string AlreadyPlaying;

            /// <summary>
            /// Music already paused
            /// </summary>
            public string AlreadyPaused;
        }

        public class TFeature
        {
            public string Loop;
            public string Shuffle;
            public string VoteSkip;
        }

        public class TMain
        {
            public string PlayTip;
            public string StopAndLeave;
            public string StopAndClear;
            public string QueueCleared;
            public string ChooseNumber;
            public string SpotifyTip;
            public string GettingSongs;
        }

        public class TMisc
        {
            public string Info;
            public string Music;
            public string User;
            public string Admin;
            public string Song;
            public string Stats;
            public string Volume;
            public string Shuffle;
            public string Loop;
            public string Locked;
            public string Queue;
            public string Stopped;
            public string Playing;
            public string Paused;
            public string Skipped;
            public string VoteSkip;
            public string VoteSkipped;
            public string ForceSkipped;
            public string Next;
            public string NextSong;
            public string MusicPaused;
            public string MusicResumed;
        }

        public class TProfile
        {

           
        }

        public class TDJ
        {
            public string LoopEnabled;
            public string LoopDisabled;
            public string ShuffleEnabled;
            public string ShuffleDisabled;
            public string LockInfo;
            public string ForceStop;
            public string ForceSkip;
            public string ForceClear;
            public string ForceLeave;
            public string LockEnabled;
            public string LockDisabled;
            public string MoveInfo;
            public string RemoveInfo;
            public string VoteSkipInfo;
            public string VoteSkipEnabled;
            public string VoteSkipDisabled;
            public string RemovedSong;
            public string MovedSong;
        }

        public class TAdminCommands
        {

        }

        public class TAdmin
        {
            
        }
    }
}
