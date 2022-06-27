using System;

namespace August.Struct
{
    /// <summary>
    /// Bot profile setting <br />
    /// The most important file
    /// </summary>
    [Serializable]
    public struct BotSetting
    {
        /// <summary>
        /// Bot name, will effect console output message
        /// </summary>
        public string Name;
        /// <summary>
        /// Bot Token
        /// </summary>
        public string Token;
        /// <summary>
        /// Syntax for specified the command
        /// </summary>
        public char Syntax;
        /// <summary>
        /// Prefix for specified the command
        /// </summary>
        public string Prefix;
        /// <summary>
        /// Console color code, Range from 0 - 16 <br />
        /// <see href="https://docs.microsoft.com/en-us/dotnet/api/system.consolecolor?view=net-6.0">Reference</see>
        /// </summary>
        public int Color;
        /// <summary>
        /// Log level for filter out the message, Range from 0 - 5 <br />
        /// 0: Output all <br />
        /// 5: Output only most important message
        /// </summary>
        public int Loglevel;
        /// <summary>
        /// Output intent warning
        /// </summary>
        public bool GatewayIntentWarning;
        /// <summary>
        /// Loading modules name, Check your mods folder <br />
        /// The filename must contain extension
        /// </summary>
        public string[] LoadMods;

        public static BotSetting Default
        {
            get
            {
                return new BotSetting()
                {
                    Color = 11
                };
            }
        }
    }
}
