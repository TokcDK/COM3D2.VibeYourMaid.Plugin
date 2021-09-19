namespace COM3D2.VibeYourMaid.Plugin.Personalities
{
    class Crafty : PersonalityBase
    {
        public override string NameJp => "腹黒";
        public override string NameEn => "Crafty";
        public override string[] reactionVoice => new string[] { "H12_01467.ogg", "H12_01468.ogg", "H12_01475.ogg", "H12_01460.ogg" }; //Crafty

        //性格別声テーブル　腹黒---------------------------------------------------------------
        //弱バイブ　通常
        public override string[][] sLoopVoice20Vibe => new string[][] {
              new string[] { "H12_01213.ogg" , "H12_01214.ogg" , "H12_01221.ogg" , "H12_01222.ogg" },
              new string[] { "H12_01205.ogg" , "H12_01206.ogg" , "H12_01421.ogg" , "H12_01422.ogg" },
              new string[] { "H12_01215.ogg" , "H12_01216.ogg" , "H12_01223.ogg" , "H12_01227.ogg" },
              new string[] { "H12_01207.ogg" , "H12_01208.ogg" , "H12_01423.ogg" , "H12_01424.ogg" },
              new string[] { "H12_01245.ogg" , "H12_01247.ogg" , "H12_01248.ogg" , "H12_01249.ogg" }
              };
        //弱バイブ　フェラ
        public override string[][] sLoopVoice20Fera => new string[][] {
              new string[] { "H12_01253.ogg" , "H12_01254.ogg" , "H12_01261.ogg" , "H12_01262.ogg" },
              new string[] { "H12_01253.ogg" , "H12_01254.ogg" , "H12_01261.ogg" , "H12_01262.ogg" },
              new string[] { "H12_01255.ogg" , "H12_01256.ogg" , "H12_01263.ogg" , "H12_01264.ogg" },
              new string[] { "H12_01255.ogg" , "H12_01256.ogg" , "H12_01263.ogg" , "H12_01264.ogg" },
              new string[] { "H12_01253.ogg" , "H12_01254.ogg" , "H12_01261.ogg" , "H12_01262.ogg" }
              };
        //強バイブ　通常
        public override string[][] sLoopVoice30Vibe => new string[][] {
              new string[] { "H12_01217.ogg" , "H12_01218.ogg" , "H12_01225.ogg" , "H12_01226.ogg" },
              new string[] { "H12_01209.ogg" , "H12_01210.ogg" , "H12_01425.ogg" , "H12_01426.ogg" },
              new string[] { "H12_01219.ogg" , "H12_01220.ogg" , "H12_01227.ogg" , "H12_01228.ogg" },
              new string[] { "H12_01211.ogg" , "H12_01212.ogg" , "H12_01427.ogg" , "H12_01428.ogg" },
              new string[] { "H12_01249.ogg" , "H12_01250.ogg" , "H12_01251.ogg" , "H12_01252.ogg" }
              };
        //強バイブ　フェラ
        public override string[][] sLoopVoice30Fera => new string[][] {
              new string[] { "H12_01257.ogg" , "H12_01258.ogg" , "H12_01265.ogg" , "H12_01266.ogg" },
              new string[] { "H12_01257.ogg" , "H12_01258.ogg" , "H12_01265.ogg" , "H12_01266.ogg" },
              new string[] { "H12_01259.ogg" , "H12_01260.ogg" , "H12_01267.ogg" , "H12_01268.ogg" },
              new string[] { "H12_01259.ogg" , "H12_01260.ogg" , "H12_01267.ogg" , "H12_01268.ogg" },
              new string[] { "H12_01257.ogg" , "H12_01258.ogg" , "H12_01265.ogg" , "H12_01266.ogg" }
              };
        //絶頂　通常
        public override string[][] sOrgasmVoice30Vibe => new string[][] {
              new string[] { "H12_01487.ogg" , "H12_01488.ogg" , "H12_01487.ogg" , "H12_01488.ogg" },
              new string[] { "H12_01488.ogg" , "H12_01663.ogg" , "H12_03082.ogg" , "H12_03084.ogg" ,"H12_03115.ogg" },
              new string[] { "H12_03082.ogg" , "H12_01725.ogg" , "H12_03082.ogg" , "H12_01870.ogg" , "H12_01799.ogg" , "H12_01787.ogg", "H12_01488.ogg" , "H12_01663.ogg" , "H12_03084.ogg" ,"H12_03115.ogg" },
              new string[] { "H12_01487.ogg" , "H12_01665.ogg" , "H12_01870.ogg" , "H12_01799.ogg" , "H12_01725.ogg" , "H12_03084.ogg" , "H12_03096.ogg" , "H12_03115.ogg" , "H12_01663.ogg" , "H12_01787.ogg" , "H12_01666.ogg"  },
              new string[] { "H12_01487.ogg" , "H12_01488.ogg" , "H12_01487.ogg" , "H12_01488.ogg" }
              };
        //絶頂　フェラ
        public override string[][] sOrgasmVoice30Fera => new string[][] {
              new string[] { ".ogg" , ".ogg" , ".ogg" , ".ogg" },
              new string[] { ".ogg" , ".ogg" , ".ogg" , ".ogg" },
              new string[] { ".ogg" , ".ogg" , ".ogg" , ".ogg" },
              new string[] { ".ogg" , ".ogg" , ".ogg" , ".ogg" , ".ogg" , ".ogg" , ".ogg" , ".ogg" },
              new string[] { ".ogg" , ".ogg" , ".ogg" , ".ogg" }
              };
        //停止時
        public override string[] sLoopVoice40Vibe => new string[] { "H12_01529.ogg", "H12_01544.ogg", "H12_01530.ogg", "H12_01545.ogg", "H12_01534.ogg" };
    }
}