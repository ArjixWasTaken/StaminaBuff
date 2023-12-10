using GameNetcodeStuff;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaminaBuff.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerB_patch
    {
        [HarmonyPatch("LateUpdate")]
        [HarmonyPostfix]
        static void StaminaPatch(ref float ___sprintMeter, ref bool ___isWalking)
        {
            if (___isWalking) { ___sprintMeter += 0.0005f; }
        }
    }
}
