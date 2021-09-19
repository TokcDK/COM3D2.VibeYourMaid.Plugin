namespace COM3D2.VibeYourMaid.Plugin.Personalities
{
    class Genki : PersonalityBase
    {
        public override string NameJp => "僕っ娘";
        public override string NameEn => "Genki";
        public override string[] reactionVoice => new string[] { "s5_04264.ogg", "s5_04258.ogg", "s5_04256.ogg", "s5_04255.ogg" }; //Genki

        //性格別声テーブル　ボクっ娘---------------------------------------------------------------
        //弱バイブ　通常
        public override string[][] sLoopVoice20Vibe => new string[][] {
              new string[] { "s5_04127.ogg" , "s5_04129.ogg" , "s5_04130.ogg" , "s5_04131.ogg" },
              new string[] { "s5_04127.ogg" , "s5_04048.ogg" , "s5_04130.ogg" , "s5_04048.ogg" },
              new string[] { "s5_04133.ogg" , "s5_04134.ogg" , "s5_04047.ogg" , "s5_04048.ogg" },
              new string[] { "s5_04133.ogg" , "s5_04134.ogg" , "s5_04047.ogg" , "s5_04131.ogg" },
              new string[] { "s5_04133.ogg" , "s5_04134.ogg" , "s5_04047.ogg" , "s5_04131.ogg" }
              };
        //弱バイブ　フェラ
        public override string[][] sLoopVoice20Fera => new string[][] {
              new string[] { "S5_04163.ogg" , "S5_04162.ogg" , "S5_04179.ogg" , "S5_04181.ogg" },
              new string[] { "S5_04163.ogg" , "S5_04162.ogg" , "S5_04179.ogg" , "S5_04181.ogg" },
              new string[] { "S5_04163.ogg" , "S5_04162.ogg" , "S5_04179.ogg" , "s5_04174.ogg" },
              new string[] { "S5_04163.ogg" , "S5_04162.ogg" , "S5_04179.ogg" , "s5_04174.ogg" },
              new string[] { "S5_04163.ogg" , "S5_04162.ogg" , "S5_04179.ogg" , "s5_04174.ogg" }
              };
        //強バイブ　通常
        public override string[][] sLoopVoice30Vibe => new string[][] {
              new string[] { "s5_04133.ogg" , "s5_04058.ogg" , "s5_04055.ogg" , "s5_04050.ogg" },
              new string[] { "s5_04133.ogg" , "s5_04058.ogg" , "s5_04055.ogg" , "s5_04050.ogg" },
              new string[] { "s5_04051.ogg" , "s5_04055.ogg" , "s5_04054.ogg" , "s5_04052.ogg" },
              new string[] { "s5_04055.ogg" , "s5_04061.ogg" , "s5_04054.ogg" , "s5_04052.ogg" },
              new string[] { "s5_04133.ogg" , "s5_04134.ogg" , "s5_04047.ogg" , "s5_04131.ogg" }
              };
        //強バイブ　フェラ
        public override string[][] sLoopVoice30Fera => new string[][] {
              new string[] { "S5_04093.ogg" , "S5_04094.ogg" , "S5_04102.ogg" , "S5_04100.ogg" },
              new string[] { "S5_04093.ogg" , "S5_04094.ogg" , "S5_04102.ogg" , "S5_04100.ogg" },
              new string[] { "S5_04093.ogg" , "S5_04094.ogg" , "S5_04102.ogg" , "S5_04100.ogg" },
              new string[] { "S5_04093.ogg" , "S5_04094.ogg" , "S5_04102.ogg" , "S5_04100.ogg" },
              new string[] { "S5_04163.ogg" , "S5_04162.ogg" , "S5_04179.ogg" , "s5_04174.ogg" }
              };
        //絶頂　通常
        public override string[][] sOrgasmVoice30Vibe => new string[][] {
              new string[] { "s5_04264.ogg" , "s5_04258.ogg" , "s5_04256.ogg" , "s5_04255.ogg" },
              new string[] { "s5_04265.ogg" , "s5_04270.ogg" , "s5_04267.ogg" , "s5_04268.ogg" },
              new string[] { "s5_04266.ogg" , "s5_18375.ogg" , "s5_18380.ogg" , "s5_18393.ogg" },
              new string[] { "s5_18379.ogg" , "s5_18380.ogg" , "s5_18382.ogg" , "s5_18384.ogg" , "s5_18385.ogg" , "s5_18400.ogg" , "s5_18402.ogg" , "s5_18119.ogg" },
              new string[] { "s5_04264.ogg" , "s5_04258.ogg" , "s5_04256.ogg" , "s5_04255.ogg" }
              };
        //絶頂　フェラ
        public override string[][] sOrgasmVoice30Fera => new string[][] {
              new string[] { "s5_04271.ogg" , "s5_04272.ogg" , "s5_04273.ogg" },
              new string[] { "s5_04271.ogg" , "s5_04272.ogg" , "s5_04273.ogg" },
              new string[] { "s5_04271.ogg" , "s5_04272.ogg" , "s5_04273.ogg" },
              new string[] { "S5_07752.ogg" , "S5_07753.ogg" , "s5_04273.ogg" , "s5_04271.ogg" },
              new string[] { "s5_04271.ogg" , "s5_04272.ogg" , "s5_04273.ogg" }
              };
        //停止時
        public override string[] sLoopVoice40Vibe => new string[] { "s5_04127.ogg", "s5_04129.ogg", "s5_04131.ogg", "s5_04134.ogg", "s5_04134.ogg" };
    }
}
