namespace COM3D2.VibeYourMaid.Plugin.Personalities
{
    class Anesan : PersonalityBase
    {
        public override string NameJp => "姉ちゃん";
        public override string NameEn => "Anesan";

        //性格別声テーブル　お姉ちゃん---------------------------------------------------------------
        //弱バイブ　通常
        public override string[][] sLoopVoice20Vibe => new string[][] {
              new string[] { "s4_08211.ogg" , "s4_08212.ogg" , "s4_08213.ogg" , "s4_08214.ogg" },
              new string[] { "s4_08211.ogg" , "s4_08212.ogg" , "s4_08213.ogg" , "s4_08214.ogg" },
              new string[] { "s4_08211.ogg" , "s4_08212.ogg" , "s4_08213.ogg" , "s4_08214.ogg" },
              new string[] { "s4_08211.ogg" , "s4_08212.ogg" , "s4_08213.ogg" , "s4_08214.ogg" },
              new string[] { "s4_08211.ogg" , "s4_08212.ogg" , "s4_08213.ogg" , "s4_08214.ogg" }
              };
        //弱バイブ　フェラ
        public override string[][] sLoopVoice20Fera => new string[][] {
              new string[] { "S4_08241.ogg" , "S4_08258.ogg" , "S4_08243.ogg" , "S4_08259.ogg" },
              new string[] { "S4_08241.ogg" , "S4_08258.ogg" , "S4_08243.ogg" , "S4_08259.ogg" },
              new string[] { "S4_08241.ogg" , "S4_08258.ogg" , "S4_08243.ogg" , "S4_08259.ogg" },
              new string[] { "S4_08241.ogg" , "S4_08258.ogg" , "S4_08243.ogg" , "S4_08259.ogg" },
              new string[] { "S4_08241.ogg" , "S4_08258.ogg" , "S4_08243.ogg" , "S4_08259.ogg" }
              };
        //強バイブ　通常
        public override string[][] sLoopVoice30Vibe => new string[][] {
              new string[] { "s4_08140.ogg" , "s4_08141.ogg" , "s4_08142.ogg" , "s4_08145.ogg" },
              new string[] { "s4_08140.ogg" , "s4_08141.ogg" , "s4_08142.ogg" , "s4_08145.ogg" },
              new string[] { "s4_08140.ogg" , "s4_08141.ogg" , "s4_08149.ogg" , "s4_08150.ogg" },
              new string[] { "s4_08140.ogg" , "s4_08134.ogg" , "s4_08149.ogg" , "s4_08150.ogg" },
              new string[] { "s4_08211.ogg" , "s4_08212.ogg" , "s4_08213.ogg" , "s4_08214.ogg" }
              };
        //強バイブ　フェラ
        public override string[][] sLoopVoice30Fera => new string[][] {
              new string[] { "S4_08244.ogg" , "S4_08245.ogg" , "S4_08262.ogg" , "S4_08246.ogg" },
              new string[] { "S4_08244.ogg" , "S4_08245.ogg" , "S4_08262.ogg" , "S4_08246.ogg" },
              new string[] { "S4_08244.ogg" , "S4_08245.ogg" , "S4_08262.ogg" , "S4_08246.ogg" },
              new string[] { "S4_08244.ogg" , "S4_08245.ogg" , "S4_08262.ogg" , "S4_08246.ogg" },
              new string[] { "S4_08241.ogg" , "S4_08258.ogg" , "S4_08243.ogg" , "S4_08259.ogg" }
              };
        //絶頂　通常
        public override string[][] sOrgasmVoice30Vibe => new string[][] {
              new string[] { "s4_08348.ogg" , "s4_08354.ogg" , "s4_08365.ogg" , "s4_08374.ogg" },
              new string[] { "s4_08345.ogg" , "s4_08346.ogg" , "s4_08349.ogg" , "s4_08350.ogg" },
              new string[] { "s4_08347.ogg" , "s4_08355.ogg" , "s4_08356.ogg" , "s4_11658.ogg" },
              new string[] { "s4_11684.ogg" , "s4_11677.ogg" , "s4_11680.ogg" , "s4_11683.ogg" , "s4_11661.ogg" , "s4_11659.ogg" , "s4_11654.ogg" , "s4_11660.ogg" },
              new string[] { "s4_08348.ogg" , "s4_08354.ogg" , "s4_08365.ogg" , "s4_08374.ogg" }
              };
        //絶頂　フェラ
        public override string[][] sOrgasmVoice30Fera => new string[][] {
              new string[] { "S4_08359.ogg" , "S4_08358.ogg" , "S4_08368.ogg" },
              new string[] { "S4_08359.ogg" , "S4_08358.ogg" , "S4_08368.ogg" },
              new string[] { "S4_08359.ogg" , "S4_08358.ogg" , "S4_08368.ogg" },
              new string[] { "S4_05728.ogg" , "S4_05726.ogg" , "S4_05680.ogg" , "S4_05668.ogg" },
              new string[] { "S4_08359.ogg" , "S4_08358.ogg" , "S4_08368.ogg" }
              };
        //停止時
        public override string[] sLoopVoice40Vibe => new string[] { "s4_08424.ogg", "s4_08426.ogg", "s4_08427.ogg", "s4_08428.ogg", "s4_08428.ogg" };
    }
}
