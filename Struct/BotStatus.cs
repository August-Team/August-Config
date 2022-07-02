using System;

namespace August.Struct
{
    [Serializable]
    public struct BotStatus
    {
        public string Name;
        public string ProfileUrl;
        public string UserID;
        public string Path;
        public string[] GuildIDs;
        public int BotState;
        public int ConnectionState;
        public int LoginState;
        public bool IsVaild;
    }
}
