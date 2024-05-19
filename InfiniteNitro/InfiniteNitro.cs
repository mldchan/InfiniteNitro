using HutongGames.PlayMaker;
using JetBrains.Annotations;
using MSCLoader;
using UnityEngine;

namespace InfiniteNitro
{
    [UsedImplicitly]
    public class InfiniteNitro : Mod
    {
        public override string ID => "InfiniteNitro";
        public override string Version => "1.0";
        public override string Author => "アカツキ";

        public override void ModSetup()
        {
            base.ModSetup();
            
            SetupFunction(Setup.Update, On_Update);
        }

        private void On_Update()
        {
            var n2o = GameObject.Find("n2o bottle(Clone)/Dynamics");
            if (n2o != null && n2o.activeSelf)
            {
                n2o.GetPlayMaker("Pressure").GetVariable<FsmFloat>("Fluid").Value = 5;
            }
        }
    }
}