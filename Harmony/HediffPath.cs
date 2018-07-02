using Harmony;
using Verse;

namespace RealMedicine.Harmony
{
    [HarmonyPatch(typeof(Hediff), "get_TendableNow")]
    public static class HediffPath
    {
        static bool Postfix(bool __result, Hediff __instance)
        {
            // This blocks tending of internal parts for vanilla rimworld items.
            if (__instance.Part != null)
            {
                return __result && __instance.Part.depth != BodyPartDepth.Inside;
            }

            return __result;
        }
    }
}