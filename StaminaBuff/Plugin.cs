using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using StaminaBuff.Patches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaminaBuff
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string modGUID = "catgocri.StaminaBuff";
        private const string modName = "Stamina Buff";
        private const string modVersion = "1.0.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static Plugin Instance;

        internal ManualLogSource logSource;

        void Awake()
        {
            if (Instance == null) { Instance = this; }
            logSource = BepInEx.Logging.Logger.CreateLogSource(modGUID);
            logSource.LogInfo(modName + " has loaded.");
            harmony.PatchAll(typeof(Plugin));
            harmony.PatchAll(typeof(PlayerControllerB_patch));
        }
    }
}
