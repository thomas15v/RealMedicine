using System.Collections.Generic;
using RimWorld;
using Verse;

namespace RealMedicine.Operations
{
    public class BloodTransfusion : RecipeWorker
    {
        public override void ApplyOnPawn(Pawn pawn, BodyPartRecord part, Pawn billDoer, List<Thing> ingredients, Bill bill)
        {
            var diff = GetBloodLoss(pawn);
            if (diff == null) return;
            diff.Severity = diff.Severity - 0.5f;
        }

        private static Hediff GetBloodLoss(Pawn pawn)
        {
            return pawn.health.hediffSet.hediffs.Find(hediff => hediff.def.defName == "BloodLoss");;
        }

        public override string GetLabelWhenUsedOn(Pawn pawn, BodyPartRecord part)
        {
            return GetBloodLoss(pawn) == null ? null : base.GetLabelWhenUsedOn(pawn, part);
        }
        
        
    }
}