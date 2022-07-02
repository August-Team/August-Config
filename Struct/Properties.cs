using System;

namespace August.Struct
{
    /// <summary>
    /// Framework properties will effect the internal mechnism
    /// </summary>
    [Serializable]
    public struct Properties
    {
        /// <summary>
        /// Each update tick seconds
        /// </summary>
        public int UpdateMilliseconds;
        /// <summary>
        /// Clean login session at begining
        /// </summary>
        public bool ResetSessionAtRestart;
        /// <summary>
        /// Login all bot at the begining
        /// </summary>
        public bool DefaultLoginAll;

        /// <summary>
        /// Default properties setting data
        /// </summary>
        public static Properties Default
        {
            get
            {
                return new Properties()
                {
                    UpdateMilliseconds = 10000,
                    ResetSessionAtRestart = true,
                    DefaultLoginAll = true,
                };
            }
        }
    }
}
