namespace COM3D2.VibeYourMaid.Plugin.Personalities
{
    class Yandere : PersonalityBase
    {
        public override string NameJp => "ヤンデレ";
        public override string NameEn => "Yandere";
        public override string[] reactionVoice => new string[] { "s3_02908.ogg", "s3_02950.ogg", "s3_02923.ogg", "s3_02932.ogg" }; //Yandere

        //性格別声テーブル　ヤンデレ---------------------------------------------------------------
        //弱バイブ　通常
        public override string[][] sLoopVoice20Vibe => new string[][] {
              new string[] { "s3_02767.ogg" , "s3_02768.ogg" , "s3_02769.ogg" , "s3_02770.ogg" },
              new string[] { "s3_02767.ogg" , "s3_02768.ogg" , "s3_02769.ogg" , "s3_02770.ogg" },
              new string[] { "s3_02767.ogg" , "s3_02768.ogg" , "s3_02769.ogg" , "s3_02770.ogg" },
              new string[] { "s3_02767.ogg" , "s3_02768.ogg" , "s3_02769.ogg" , "s3_02770.ogg" },
              new string[] { "s3_02767.ogg" , "s3_02768.ogg" , "s3_02769.ogg" , "s3_02770.ogg" }
              };
        //弱バイブ　フェラ
        public override string[][] sLoopVoice20Fera => new string[][] {
              new string[] { "S3_02833.ogg" , "S3_02818.ogg" , "S3_02835.ogg" , "S3_02820.ogg" },
              new string[] { "S3_02833.ogg" , "S3_02818.ogg" , "S3_02835.ogg" , "S3_02820.ogg" },
              new string[] { "S3_02833.ogg" , "S3_02818.ogg" , "S3_02835.ogg" , "S3_02820.ogg" },
              new string[] { "S3_02833.ogg" , "S3_02818.ogg" , "S3_02835.ogg" , "S3_02820.ogg" },
              new string[] { "S3_02833.ogg" , "S3_02818.ogg" , "S3_02835.ogg" , "S3_02820.ogg" }
              };

        //強バイブ　通常
        public override string[][] sLoopVoice30Vibe => new string[][] {
              new string[] { "s3_02797.ogg" , "s3_02798.ogg" , "s3_02691.ogg" , "s3_02796.ogg" },
              new string[] { "s3_02797.ogg" , "s3_02798.ogg" , "s3_02691.ogg" , "s3_02796.ogg" },
              new string[] { "s3_02797.ogg" , "s3_02798.ogg" , "s3_02691.ogg" , "s3_02796.ogg" },
              new string[] { "s3_02797.ogg" , "s3_02798.ogg" , "s3_02691.ogg" , "s3_02796.ogg" },
              new string[] { "s3_02767.ogg" , "s3_02768.ogg" , "s3_02769.ogg" , "s3_02770.ogg" }
              };
        //強バイブ　フェラ
        public override string[][] sLoopVoice30Fera => new string[][] {
              new string[] { "S3_02836.ogg" , "S3_02837.ogg" , "S3_02822.ogg" , "S3_02838.ogg" },
              new string[] { "S3_02836.ogg" , "S3_02837.ogg" , "S3_02822.ogg" , "S3_02838.ogg" },
              new string[] { "S3_02836.ogg" , "S3_02837.ogg" , "S3_02822.ogg" , "S3_02838.ogg" },
              new string[] { "S3_02836.ogg" , "S3_02837.ogg" , "S3_02822.ogg" , "S3_02838.ogg" },
              new string[] { "S3_02833.ogg" , "S3_02818.ogg" , "S3_02835.ogg" , "S3_02820.ogg" }
              };
        //絶頂　通常
        public override string[][] sOrgasmVoice30Vibe => new string[][] {
              new string[] { "s3_02908.ogg" , "s3_02950.ogg" , "s3_02923.ogg" , "s3_02932.ogg" },
              new string[] { "s3_02909.ogg" , "s3_02910.ogg" , "s3_02915.ogg" , "s3_02914.ogg" },
              new string[] { "s3_02905.ogg" , "s3_02906.ogg" , "s3_02907.ogg" , "s3_05540.ogg" },
              new string[] { "s3_05657.ogg" , "s3_05658.ogg" , "s3_05659.ogg" , "s3_05660.ogg" , "s3_05661.ogg" , "s3_05678.ogg" , "s3_05651.ogg" , "s3_05656.ogg" },
              new string[] { "s3_02908.ogg" , "s3_02950.ogg" , "s3_02923.ogg" , "s3_02932.ogg" }
              };
        //絶頂　フェラ
        public override string[][] sOrgasmVoice30Fera => new string[][] {
              new string[] { "S3_02919.ogg" , "S3_02918.ogg" , "S3_02928.ogg" },
              new string[] { "S3_02919.ogg" , "S3_02918.ogg" , "S3_02928.ogg" },
              new string[] { "S3_02919.ogg" , "S3_02918.ogg" , "S3_02928.ogg" },
              new string[] { "S3_03084.ogg" , "S3_03184.ogg" , "S3_03162.ogg" , "S3_18748.ogg" },
              new string[] { "S3_02919.ogg" , "S3_02918.ogg" , "S3_02928.ogg" }
              };
        //停止時
        public override string[] sLoopVoice40Vibe => new string[] { "S3_02964.ogg", "S3_02964.ogg", "S3_02965.ogg", "S3_02966.ogg", "S3_02966.ogg" };
    }
}
