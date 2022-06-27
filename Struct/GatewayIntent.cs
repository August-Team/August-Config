using System;

namespace August.Struct
{
    /// <summary>
    /// Discord bot intent setting
    /// </summary>
    [Serializable]
    public struct GatewayIntent
    {
        public bool Guilds;
        public bool GuildMembers;
        public bool GuildBans;
        public bool GuildEmojis;
        public bool GuildIntegrations;
        public bool GuildWebhooks;
        public bool GuildInvites;
        public bool GuildVoiceStates;
        public bool GuildPresences;
        public bool GuildMessages;
        public bool GuildMessageReactions;
        public bool GuildMessageTyping;
        public bool DirectMessages;
        public bool DirectMessageReactions;
        public bool DirectMessageTyping;
        public bool GuildScheduledEvents;
        public bool AllUnprivileged;
        public bool All;

        public static GatewayIntent Default
        {
            get
            {
                return new GatewayIntent()
                {
                    Guilds = false,
                    GuildMembers = false,
                    GuildBans = false,
                    GuildEmojis = false,
                    GuildIntegrations = false,
                    GuildWebhooks = false,
                    GuildInvites = false,
                    GuildVoiceStates = false,
                    GuildPresences = false,
                    GuildMessages = false,
                    GuildMessageReactions = false,
                    GuildMessageTyping = false,
                    DirectMessages = false,
                    DirectMessageReactions = false,
                    DirectMessageTyping = false,
                    GuildScheduledEvents = false,
                    AllUnprivileged = true,
                    All = false
                };
            }
        }
    }
}
