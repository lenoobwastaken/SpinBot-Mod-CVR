using System;
using HighlightPlus;
using UnityEngine;
using MelonLoader;
using System.Threading.Tasks;
using ABI_RC.Core.Player;
using System.Collections;
using DarkRift;

namespace CVRSPinBot
{
    public static class BuildInfo
    {
        public const string Name = "SpinBot";
        public const string Description = "SpinBot Mod for CVR";
        public const string Author = "Lenoob and CVRMG";
        public const string Company = "CVRMG";
        public const string Version = "1.0.0";
        public const string DownloadLink = null;

    }
    public class Main : MelonMod
    {

        public static int State2 = 0;

        public override void OnApplicationStart()
        {
            MelonLogger.Msg("CTRL + P to toggle spin bot");
        }
        public override void OnUpdate()
        {
            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.P))
            {
                switch (State2)
                {
                    case 1:
                      State2 = 0;
                      return;
                    case 0:
                     State2 = 1;
                    default:
                     break;
                }
                //  MelonCoroutines.Start(joe());
            }

            if (State2 == 1)
            {
                GameObject.Find("_PLAYERLOCAL").transform.Rotate(0, 2f, 0);
            }
        }
    }
}
