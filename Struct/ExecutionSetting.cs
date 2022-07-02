using System;
using System.Threading.Tasks;

namespace August.Struct
{
    /// <summary>
    /// Pair the discord events to framework commands
    /// </summary>
    [Serializable]
    public struct ExecutionSetting
    {
        #region Framework Event
        /// <summary>
        /// Fire when bot is initialized <br />
        /// Called => <seealso cref="Task"/>()
        /// </summary>
        public string[] Initilization;
        /// <summary>
        /// Fire each update tick <br />
        /// Called => <seealso cref="Task"/>()
        /// </summary>
        public string[] Update;
        /// <summary>
        /// Fire before shutdown the bot <br />
        /// Called => <seealso cref="Task"/>()
        /// </summary>
        public string[] Shutdown;
        /// <summary>
        /// Fire when any module is loaded <br />
        /// Called => <seealso cref="Task"/>()
        /// </summary>
        public string[] ModulesLoaded;
        /// <summary>
        /// Fire After any module is unloaded <br />
        /// Called => <seealso cref="Task"/>()
        /// </summary>
        public string[] ModulesUnLoaded;
        /// <summary>
        /// Fire After exit event, before disposing <br />
        /// Called => <seealso cref="Task"/>()
        /// </summary>
        public string[] Exit;
        #endregion

        #region Discord Event
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketGuildUser"/>)
        /// </summary>
        public string[] UserJoined;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketGuild"/>, <seealso cref="SocketUser"/>)
        /// </summary>
        public string[] UserLeft;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketGuild"/>, <seealso cref="SocketUser"/>)
        /// </summary>
        public string[] UserBanned;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketGuild"/>, <seealso cref="SocketUser"/>)
        /// </summary>
        public string[] UserUnBanned;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketUser"/>, <seealso cref="SocketUser"/>)
        /// </summary>
        public string[] UserUpdate;

        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketChannel"/>)
        /// </summary>
        public string[] ChannelCreated;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketChannel"/>)
        /// </summary>
        public string[] ChannelDestroyed;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketChannel"/>, <seealso cref="SocketChannel"/>)
        /// </summary>
        public string[] ChannelUpdated;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketMessage"/>)
        /// </summary>
        public string[] MessageReceived;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketRole"/>)
        /// </summary>
        public string[] RoleCreated;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketRole"/>)
        /// </summary>
        public string[] RoleDeleted;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketRole"/>, <seealso cref="SocketRole"/>)
        /// </summary>
        public string[] RoleUpdated;

        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketGuild"/>)
        /// </summary>
        public string[] JoinedGuild;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketGuild"/>)
        /// </summary>
        public string[] LeftGuild;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketGuild"/>)
        /// </summary>
        public string[] GuildAvailable;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketGuild"/>)
        /// </summary>
        public string[] GuildUnavailable;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketGuild"/>)
        /// </summary>
        public string[] GuildMembersDownloaded; 
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketGuild"/>, <seealso cref="SocketGuild"/>)
        /// </summary>
        public string[] GuildUpdated;

        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketGuildEvent"/>)
        /// </summary>
        public string[] GuildScheduledEventCreated;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketGuildEvent"/>)
        /// </summary>
        public string[] GuildScheduledEventCancelled;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketGuildEvent"/>)
        /// </summary>
        public string[] GuildScheduledEventCompleted;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketGuildEvent"/>)
        /// </summary>
        public string[] GuildScheduledEventStarted;

        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketVoiceServer"/>)
        /// </summary>
        public string[] VoiceServerUpdated;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketSelfUser"/>, <seealso cref="SocketSelfUser"/>)
        /// </summary>
        public string[] CurrentUserUpdated;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketGroupUser"/>)
        /// </summary>
        public string[] RecipientAdded;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketGroupUser"/>)
        /// </summary>
        public string[] RecipientRemoved;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketUser"/>, <seealso cref="SocketPresence"/>, <seealso cref="SocketPresence"/>)
        /// </summary>
        public string[] PresenceUpdated;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketInvite"/>)
        /// </summary>
        public string[] InviteCreated;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketGuildChannel"/>, <seealso cref="String"/>)
        /// </summary>
        public string[] InviteDeleted;


        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketThreadChannel"/>)
        /// </summary>
        public string[] ThreadCreated;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketThreadUser"/>)
        /// </summary>
        public string[] ThreadMemberJoined;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketThreadUser"/>)
        /// </summary>
        public string[] ThreadMemberLeft;

        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketStageChannel"/>)
        /// </summary>
        public string[] StageStarted;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketStageChannel"/>)
        /// </summary>
        public string[] StageEnded;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketStageChannel"/>, <seealso cref="SocketStageChannel"/>)
        /// </summary>
        public string[] StageUpdated;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketStageChannel"/>, <seealso cref="SocketGuildUser"/>)
        /// </summary>
        public string[] RequestToSpeak;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketStageChannel"/>, <seealso cref="SocketGuildUser"/>)
        /// </summary>
        public string[] SpeakerAdded;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketStageChannel"/>, <seealso cref="SocketGuildUser"/>)
        /// </summary>
        public string[] SpeakerRemoved;

        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketCustomSticker"/>)
        /// </summary>
        public string[] GuildStickerCreated;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketCustomSticker"/>, <seealso cref="SocketCustomSticker"/>)
        /// </summary>
        public string[] GuildStickerUpdated;
        /// <summary>
        /// Called => <seealso cref="Task"/>(<seealso cref="SocketCustomSticker"/>)
        /// </summary>
        public string[] GuildStickerDeleted;
        #endregion
    }
}
