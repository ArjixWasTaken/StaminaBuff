using BepInEx;
using BepInEx.Logging;
using GameNetcodeStuff;
using HarmonyLib;

namespace StaminaBuff;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    readonly Harmony _harmony = new(MyPluginInfo.PLUGIN_GUID);
    private readonly ManualLogSource _log = new(MyPluginInfo.PLUGIN_GUID);

    private void Awake()
    {
        _harmony.PatchAll();

        _log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_NAME} is loaded!");
    }

    [HarmonyPatch]
    class Patches
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(PlayerControllerB), "LateUpdate")]
        static void StaminaPatch(ref float ___sprintMeter, ref bool ___isWalking)
        {
            if (___isWalking) { ___sprintMeter += 0.0005f; }
        }
    }
}
