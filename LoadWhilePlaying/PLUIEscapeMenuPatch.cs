using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace LoadWhilePlaying
{
    [HarmonyPatch(typeof(PLInGameLoadMenu), "ClickLoad")]
    internal class PLInGameLoadMenuPatch
    {
        [HarmonyPrefix]
        public static void Prefix()
        {
            PLNetworkManager.Instance.GameOver(false);
        }
    }

    [HarmonyPatch(typeof(PLUIEscapeMenu), "Update")]
    internal class PLUIEscapeMenuPatch
    {
        public static bool loadCommandGiven = false;
        
        [HarmonyPostfix]
        public static void Postfix(PLUIEscapeMenu __instance)
        {
            if(loadCommandGiven)
            {
                loadCommandGiven = false;
                __instance.OnClick_Load();
            }
        }
    }
}
