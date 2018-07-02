using RimWorld;
using Verse;

namespace RealMedicine.Operations
{
    public abstract class RealMedicineOperation : RecipeWorker
    {
        internal static Hediff GetBloodLoss(Pawn pawn)
        {
            return pawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.BloodLoss, false);
        }

    }
}