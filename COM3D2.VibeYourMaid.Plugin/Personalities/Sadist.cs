namespace COM3D2.VibeYourMaid.Plugin.Personalities
{
    class Sadist : PersonalityBase
    {
        public override string NameJp => "ドＳ";
        public override string NameEn => "Sadist";

        //性格別声テーブル　ドＳ---------------------------------------------------------------
        //弱バイブ　通常
        public override string[][] sLoopVoice20Vibe => new string[][] {
              new string[] { "S6_02244.ogg" , "S6_02180.ogg" , "S6_02181.ogg" , "S6_02245.ogg" },
              new string[] { "S6_02179.ogg" , "S6_02243.ogg" , "S6_02246.ogg" , "S6_02182.ogg" },
              new string[] { "S6_02179.ogg" , "S6_02183.ogg" , "S6_02246.ogg" , "S6_02247.ogg" },
              new string[] { "S6_02183.ogg" , "S6_02184.ogg" , "S6_02246.ogg" , "S6_02247.ogg" },
              new string[] { "S6_02179.ogg" , "S6_02180.ogg" , "S6_02181.ogg" , "S6_02182.ogg" }
              };
        //弱バイブ　フェラ
        public override string[][] sLoopVoice20Fera => new string[][] {
              new string[] { "S6_02219.ogg" , "S6_02220.ogg" , "S6_02221.ogg" , "S6_02222.ogg" },
              new string[] { "S6_02219.ogg" , "S6_02220.ogg" , "S6_02221.ogg" , "S6_02222.ogg" },
              new string[] { "S6_02219.ogg" , "S6_02220.ogg" , "S6_02221.ogg" , "S6_02222.ogg" },
              new string[] { "S6_02219.ogg" , "S6_02220.ogg" , "S6_02221.ogg" , "S6_02222.ogg" },
              new string[] { "S6_02219.ogg" , "S6_02220.ogg" , "S6_02221.ogg" , "S6_02222.ogg" }
              };
        //強バイブ　通常
        public override string[][] sLoopVoice30Vibe => new string[][] {
              new string[] { "S6_02183.ogg" , "S6_02184.ogg" , "S6_02246.ogg" , "S6_02247.ogg" },
              new string[] { "S6_02183.ogg" , "S6_02184.ogg" , "S6_02246.ogg" , "S6_02247.ogg" },
              new string[] { "S6_02248.ogg" , "S6_02184.ogg" , "S6_02185.ogg" , "S6_02249.ogg" },
              new string[] { "S6_02249.ogg" , "S6_02250.ogg" , "S6_02185.ogg" , "S6_02186.ogg" },
              new string[] { "S6_02243.ogg" , "S6_02244.ogg" , "S6_02245.ogg" , "S6_02246.ogg" }
              };
        //強バイブ　フェラ
        public override string[][] sLoopVoice30Fera => new string[][] {
              new string[] { "S6_02223.ogg" , "S6_02224.ogg" , "S6_02225.ogg" , "S6_02226.ogg" },
              new string[] { "S6_02223.ogg" , "S6_02224.ogg" , "S6_02225.ogg" , "S6_02226.ogg" },
              new string[] { "S6_02223.ogg" , "S6_02224.ogg" , "S6_02225.ogg" , "S6_02226.ogg" },
              new string[] { "S6_02223.ogg" , "S6_02224.ogg" , "S6_02225.ogg" , "S6_02226.ogg" },
              new string[] { "S6_02219.ogg" , "S6_02220.ogg" , "S6_02221.ogg" , "S6_02222.ogg" }
              };
        //絶頂　通常
        public override string[][] sOrgasmVoice30Vibe => new string[][] {
              new string[] { "s6_01744.ogg" , "s6_02700.ogg" , "s6_02450.ogg" , "s6_02357.ogg" },
              new string[] { "S6_28847.ogg" , "S6_28853.ogg" , "S6_28814.ogg" , "S6_02397.ogg" },
              new string[] { "S6_28817.ogg" , "S6_02398.ogg" , "S6_02399.ogg" , "s6_02402.ogg" },
              new string[] { "S6_09048.ogg" , "S6_01984.ogg" , "S6_01988.ogg" , "S6_01991.ogg" , "S6_02000.ogg" , "S6_01996.ogg" , "S6_01997.ogg" , "S6_01998.ogg" , "S6_01999.ogg" , "S6_02001.ogg" , "s6_05796.ogg" , "s6_05797.ogg" , "s6_05798.ogg" , "s6_05799.ogg" , "s6_05800.ogg" , "s6_05801.ogg" },
              new string[] { "s6_01744.ogg" , "s6_02700.ogg" , "s6_02450.ogg" , "s6_02357.ogg" }
              };
        //絶頂　フェラ
        public override string[][] sOrgasmVoice30Fera => new string[][] {
              new string[] { "S6_28832.ogg" , "s6_02403.ogg" , "S6_28835.ogg" },
              new string[] { "S6_28835.ogg" , "s6_02403.ogg" , "s6_02404.ogg" },
              new string[] { "S6_28838.ogg" , "s6_02404.ogg" , "s6_02405.ogg" },
              new string[] { "S6_02420.ogg" , "S6_08109.ogg" , "S6_08112.ogg" , "S6_08114.ogg" , "s6_02404.ogg" , "s6_02405.ogg"  },
              new string[] { "S6_28832.ogg" , "s6_02403.ogg" , "S6_28835.ogg" }
              };
        //停止時
        public override string[] sLoopVoice40Vibe => new string[] { "s6_02477.ogg", "s6_02478.ogg", "s6_02479.ogg", "s6_02481.ogg", "s6_02480.ogg" };
    }
}
