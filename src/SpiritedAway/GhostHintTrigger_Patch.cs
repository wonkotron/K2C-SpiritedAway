using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using HarmonyLib.Tools;

namespace SpiritedAway
{
    [HarmonyPatch(typeof(GhostHintTrigger))]
    class GhostHintTrigger_Patch {
        [HarmonyPrefix]
        [HarmonyPatch("Start")]
        static void Start_Prefix(GhostHintTrigger __instance) {
            __instance.IsGhostHintEnabled = false;
        }
    }
}
