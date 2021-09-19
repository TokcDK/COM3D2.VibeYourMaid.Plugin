namespace COM3D2.VibeYourMaid.Plugin.Personalities
{
    class Pride : PersonalityBase
    {
        public override string NameJp => "ツンデレ";
        public override string NameEn => "Pride";

        public override string[] reactionVoice => new string[] { "s0_01898.ogg", "s0_01899.ogg", "s0_01902.ogg", "s0_01900.ogg" }; //Pride

        //性格別声テーブル　ツンデレ---------------------------------------------------------------
        //弱バイブ　通常
        public override string[][] sLoopVoice20Vibe => new string[][] {
              new string[] { "s0_01236.ogg" , "s0_01237.ogg" , "s0_01238.ogg" , "s0_01239.ogg" },
              new string[] { "s0_01236.ogg" , "s0_01237.ogg" , "s0_01238.ogg" , "s0_01239.ogg" },
              new string[] { "s0_01236.ogg" , "s0_01237.ogg" , "s0_01238.ogg" , "s0_01239.ogg" },
              new string[] { "s0_01236.ogg" , "s0_01237.ogg" , "s0_01238.ogg" , "s0_01239.ogg" },
              new string[] { "s0_01236.ogg" , "s0_01237.ogg" , "s0_01238.ogg" , "s0_01239.ogg" }
              };
        //弱バイブ　フェラ
        public override string[][] sLoopVoice20Fera => new string[][] {
              new string[] { "S0_01383.ogg" , "S0_01367.ogg" , "S0_01384.ogg" , "S0_01369.ogg" },
              new string[] { "S0_01383.ogg" , "S0_01367.ogg" , "S0_01384.ogg" , "S0_01369.ogg" },
              new string[] { "S0_01383.ogg" , "S0_01367.ogg" , "S0_01384.ogg" , "S0_01369.ogg" },
              new string[] { "S0_01383.ogg" , "S0_01367.ogg" , "S0_01384.ogg" , "S0_01369.ogg" },
              new string[] { "S0_01383.ogg" , "S0_01367.ogg" , "S0_01384.ogg" , "S0_01369.ogg" }
              };
        //強バイブ　通常
        public override string[][] sLoopVoice30Vibe => new string[][] {
              new string[] { "s0_01326.ogg" , "s0_01327.ogg" , "s0_01330.ogg" , "s0_01331.ogg" },
              new string[] { "s0_01326.ogg" , "s0_01327.ogg" , "s0_01330.ogg" , "s0_01331.ogg" },
              new string[] { "s0_01326.ogg" , "s0_01327.ogg" , "s0_01330.ogg" , "s0_01331.ogg" },
              new string[] { "s0_01326.ogg" , "s0_01327.ogg" , "s0_01330.ogg" , "s0_01331.ogg" },
              new string[] { "s0_01236.ogg" , "s0_01237.ogg" , "s0_01238.ogg" , "s0_01239.ogg" }
              };
        //強バイブ　フェラ
        public override string[][] sLoopVoice30Fera => new string[][] {
              new string[] { "S0_01385.ogg" , "S0_01371.ogg" , "S0_01386.ogg" , "S0_01387.ogg" },
              new string[] { "S0_01385.ogg" , "S0_01371.ogg" , "S0_01386.ogg" , "S0_01387.ogg" },
              new string[] { "S0_01385.ogg" , "S0_01371.ogg" , "S0_01386.ogg" , "S0_01387.ogg" },
              new string[] { "S0_01385.ogg" , "S0_01371.ogg" , "S0_01386.ogg" , "S0_01387.ogg" },
              new string[] { "S0_01383.ogg" , "S0_01367.ogg" , "S0_01384.ogg" , "S0_01369.ogg" }
              };
        //絶頂　通常
        public override string[][] sOrgasmVoice30Vibe => new string[][] {
              new string[] { "s0_01898.ogg" , "s0_01899.ogg" , "s0_01902.ogg" , "s0_01900.ogg" },
              new string[] { "s0_01913.ogg" , "s0_01918.ogg" , "s0_01919.ogg" , "s0_01917.ogg" },
              new string[] { "s0_09072.ogg" , "s0_09070.ogg" , "s0_09099.ogg" , "s0_09059.ogg" },
              new string[] { "s0_09067.ogg" , "s0_09068.ogg" , "s0_09069.ogg" , "s0_09071.ogg" , "s0_09085.ogg" , "s0_09086.ogg" , "s0_09087.ogg" , "s0_09091.ogg" },
              new string[] { "s0_01898.ogg" , "s0_01899.ogg" , "s0_01902.ogg" , "s0_01900.ogg" }
              };
        //絶頂　フェラ
        public override string[][] sOrgasmVoice30Fera => new string[][] {
              new string[] { "S0_01922.ogg" , "S0_01920.ogg" , "S0_01921.ogg" },
              new string[] { "S0_01922.ogg" , "S0_01920.ogg" , "S0_01921.ogg" },
              new string[] { "S0_01922.ogg" , "S0_01920.ogg" , "S0_01921.ogg" },
              new string[] { "S0_11361.ogg" , "S0_01931.ogg" , "S0_11350.ogg" , "S0_11349.ogg" },
              new string[] { "S0_01922.ogg" , "S0_01920.ogg" , "S0_01921.ogg" }
              };
        //停止時
        public override string[] sLoopVoice40Vibe => new string[] { "S0_01967.ogg", "S0_01967.ogg", "S0_01968.ogg", "S0_01969.ogg", "S0_01969.ogg" };

    }
}
