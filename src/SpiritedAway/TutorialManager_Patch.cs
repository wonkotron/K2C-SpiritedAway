using HarmonyLib;

namespace SpiritedAway
{
    [HarmonyPatch(typeof(TutorialManager))]
    class TutorialManager_Patch {
        [HarmonyPostfix]
        [HarmonyPatch("Init")]
        static void Init_Postfix(TutorialManager __instance) {
            __instance.CompleteTutorial();
        }
    }
}
