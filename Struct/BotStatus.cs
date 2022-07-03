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

        public static bool operator==(BotStatus a, BotStatus b)
        {
            return a.Name == b.Name &&
                a.ProfileUrl == b.ProfileUrl &&
                a.UserID == b.UserID &&
                a.Path == b.Path &&
                a.BotState == b.BotState &&
                a.ConnectionState == b.ConnectionState &&
                a.LoginState == b.LoginState &&
                a.IsVaild == b.IsVaild;
        }

        public static bool operator!=(BotStatus a, BotStatus b)
        {
            return a.Name != b.Name ||
                a.ProfileUrl != b.ProfileUrl ||
                a.UserID != b.UserID ||
                a.Path != b.Path ||
                a.BotState != b.BotState ||
                a.ConnectionState != b.ConnectionState ||
                a.LoginState != b.LoginState ||
                a.IsVaild != b.IsVaild;
        }
    }
}
