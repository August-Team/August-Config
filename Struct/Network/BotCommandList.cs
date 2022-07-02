using System;

namespace August.Struct
{
    [Serializable]
    public struct BotCommandList
    {
        public ModuleCommandList[] CommandList;
        public string ModuleName;
    }

    [Serializable]
    public struct ModuleCommandList
    {
        public string Command;
        public string ReturnType;
        public string MethodName;
        public int ArgumentLength;
        public string[] ArugmentType;
    }
}
