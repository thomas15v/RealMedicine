using System.Collections.Generic;
using RimWorld;
using Verse;

namespace RealMedicine.Operations
{
    public class BloodTransfusion : RealMedicineOperation
    {
        public override void ApplyOnPawn(Pawn pawn, BodyPartRecord part, Pawn billDoer, List<Thing> ingredients, Bill bill)
        {
            HealthUtility.AdjustSeverity(pawn, HediffDefOf.BloodLoss, -0.20f);
        }        
    }
}
