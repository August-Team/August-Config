using System;

namespace August.Struct
{
    /// <summary>
    /// Bot setting collection
    /// </summary>
    [Serializable]
    public class BotSettings
    {
        /// <summary>
        /// Bot intent setting
        /// </summary>
        public GatewayIntent intent;
        /// <summary>
        /// Execute dict for discord events to framework commands
        /// </summary>
        public ExecutionSetting execute;
        /// <summary>
        /// Bot profile
        /// </summary>
        public BotSetting setting;
        /// <summary>
        /// Bot prefix absolute path
        /// </summary>
        public string prefixPath;
    }
}
