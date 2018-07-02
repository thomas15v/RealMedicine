using Harmony;
using Verse;

namespace RealMedicine.Harmony
{
    public class HediffGiver_BleedingPatch
    {
        [HarmonyPatch(typeof(HediffGiver_Bleeding), "OnIntervalPassed")]
        public static class HediffPath
        {
            static void Postfix(HediffGiver_Bleeding __instance, Pawn pawn, Hediff cause)
            {
                // Reduce pawn blood regen
                HediffSet hediffSet = pawn.health.hediffSet;
                if (hediffSet.BleedRateTotal <= 0.100000001490116){
                    HealthUtility.AdjustSeverity(pawn, __instance.hediff, +0.00016666665f);
                }
            }
        }
    }
}