namespace COM3D2.VibeYourMaid.Plugin.Personalities
{
    public abstract class PersonalityBase
    {
        public virtual string NameJp => "デフォルト";
        public virtual string NameEn => "";

        public virtual string[][] sLoopVoice20Vibe => new string[][] { };
        public virtual string[][] sLoopVoice20Fera => new string[][] { };
        public virtual string[][] sLoopVoice30Vibe => new string[][] { };
        public virtual string[][] sLoopVoice30Fera => new string[][] { };
        public virtual string[][] sOrgasmVoice30Vibe => new string[][] { };
        public virtual string[][] sOrgasmVoice30Fera => new string[][] { };
        public virtual string[] sLoopVoice40Vibe => new string[] { };
    }
}
