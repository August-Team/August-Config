using System;

namespace August.Struct
{
    /// <summary>
    /// Pair the discord events to framework commands
    /// </summary>
    [Serializable]
    public struct ExecutionSetting
    {
        /// <summary>
        /// Fire when bot is initialized
        /// </summary>
        public string[] Initilization;
        /// <summary>
        /// Fire each update tick
        /// </summary>
        public string[] Update;
        /// <summary>
        /// Fire before shutdown the bot
        /// </summary>
        public string[] Shutdown;

        public string[] GuildMemberJoin;
        public string[] GuildMemberLeft;
        public string[] MemberJoinedGuild;
        public string[] MemberLeftGuild;
        public string[] GuildInviteCreated;
        public string[] GuildInviteDelete;
        public string[] VoiceStateChanged;
    }
}
