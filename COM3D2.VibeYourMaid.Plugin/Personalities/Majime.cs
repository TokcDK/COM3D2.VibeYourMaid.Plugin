




namespace COM3D2.VibeYourMaid.Plugin.Personalities
{
    class Majime : PersonalityBase
    {
        public override string NameJp => "真面目";
        public override string NameEn => "Majime";

        //性格別声テーブル　真面目---------------------------------------------------------------
        //弱バイブ　通常
        public override string[][] sLoopVoice20Vibe => new string[][] {
              new string[] { "H1_00225.ogg" , "H1_00226.ogg" , "H1_08952.ogg" , "H1_08953.ogg" },
              new string[] { "H1_00241.ogg" , "H1_00242.ogg" , "H1_00401.ogg" , "H1_00402.ogg" },
              new string[] { "H1_00227.ogg" , "H1_00228.ogg" , "H1_08954.ogg" , "H1_08955.ogg" },
              new string[] { "H1_00243.ogg" , "H1_00244.ogg" , "H1_00403.ogg" , "H1_00404.ogg" },
              new string[] { "H1_00257.ogg" , "H1_00258.ogg" , "H1_00259.ogg" , "H1_00260.ogg" }
              };
        //弱バイブ　フェラ
        public override string[][] sLoopVoice20Fera => new string[][] {
              new string[] { "H1_00265.ogg" , "H1_00266.ogg" , "H1_00273.ogg" , "H1_00274.ogg" },
              new string[] { "H1_00265.ogg" , "H1_00266.ogg" , "H1_00273.ogg" , "H1_00274.ogg" },
              new string[] { "H1_00267.ogg" , "H1_00268.ogg" , "H1_00275.ogg" , "H1_00276.ogg" },
              new string[] { "H1_00267.ogg" , "H1_00268.ogg" , "H1_00275.ogg" , "H1_00276.ogg" },
              new string[] { "H1_00265.ogg" , "H1_00266.ogg" , "H1_00273.ogg" , "H1_00274.ogg" }
              };
        //強バイブ　通常
        public override string[][] sLoopVoice30Vibe => new string[][] {
              new string[] { "H1_00229.ogg" , "H1_00230.ogg" , "H1_08956.ogg" , "H1_08957.ogg" },
              new string[] { "H1_00245.ogg" , "H1_00246.ogg" , "H1_00405.ogg" , "H1_00406.ogg" },
              new string[] { "H1_00231.ogg" , "H1_00232.ogg" , "H1_08958.ogg" , "H1_08959.ogg" },
              new string[] { "H1_00247.ogg" , "H1_00248.ogg" , "H1_00407.ogg" , "H1_00408.ogg" },
              new string[] { "H1_00262.ogg" , "H1_00263.ogg" , "H1_00264.ogg" , "H1_00261.ogg" }
              };
        //強バイブ　フェラ
        public override string[][] sLoopVoice30Fera => new string[][] {
              new string[] { "H1_00269.ogg" , "H1_00270.ogg" , "H1_00277.ogg" , "H1_00278.ogg" },
              new string[] { "H1_00269.ogg" , "H1_00270.ogg" , "H1_00277.ogg" , "H1_00278.ogg" },
              new string[] { "H1_00271.ogg" , "H1_00272.ogg" , "H1_00279.ogg" , "H1_00280.ogg" },
              new string[] { "H1_00271.ogg" , "H1_00272.ogg" , "H1_00279.ogg" , "H1_00280.ogg" },
              new string[] { "H1_00269.ogg" , "H1_00270.ogg" , "H1_00277.ogg" , "H1_00278.ogg" }
              };
        //絶頂　通常
        public override string[][] sOrgasmVoice30Vibe => new string[][] {
              new string[] { "H1_11482.ogg" , "H1_13858.ogg" , "H1_13879.ogg" , "H1_13918.ogg" },
              new string[] { "H1_11492.ogg" , "H1_11514.ogg" , "H1_10519.ogg" , "H1_10516.ogg" },
              new string[] { "H1_11427.ogg" , "H1_11513.ogg" , "H1_05640.ogg" , "H1_09232.ogg" },
              new string[] { "H1_11425.ogg" , "H1_11424.ogg" , "H1_11427.ogg" , "H1_09232.ogg" , "H1_10397.ogg" , "H1_11645.ogg" , "H1_11654.ogg" , "H1_11747.ogg" , "H1_10313.ogg" , "H1_11254.ogg" , "H1_11402.ogg" , "H1_09829.ogg" , "H1_04547.ogg" , "H1_12675.ogg" , "H1_01477.ogg" , "H1_00739.ogg" , "H1_06987.ogg" , "H1_13138.ogg" , "H1_13372.ogg" , "H1_12929.ogg" , "H1_11404.ogg" , "H1_05638.ogg" , "H1_09837.ogg" , "H1_03615.ogg" , "H1_11513.ogg" , "H1_05640.ogg" },
              new string[] { "H1_10493.ogg" , "H1_10482.ogg" , "H1_10523.ogg" , "H1_10732.ogg" }
              };
        //絶頂　フェラ
        public override string[][] sOrgasmVoice30Fera => new string[][] {
              new string[] { ".ogg" , ".ogg" , ".ogg" , ".ogg" },
              new string[] { ".ogg" , ".ogg" , ".ogg" , ".ogg" },
              new string[] { "H1_09840.ogg" , ".ogg" , ".ogg" , ".ogg" },
              new string[] { "H1_12857.ogg" , ".ogg" , ".ogg" , ".ogg" , ".ogg" , ".ogg" , ".ogg" , ".ogg" },
              new string[] { ".ogg" , ".ogg" , ".ogg" , ".ogg" }
              };
        //停止時
        public override string[] sLoopVoice40Vibe => new string[] { "H1_00305.ogg", "H1_08979.ogg", "H1_08980.ogg", "H1_08982.ogg", "H1_00313.ogg" };
    }
}
