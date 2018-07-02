using System.Collections.Generic;
using RimWorld;
using Verse;

namespace RealMedicine.Operations
{
    public class BloodTransfusion : RecipeWorker
    {
        public override void ApplyOnPawn(Pawn pawn, BodyPartRecord part, Pawn billDoer, List<Thing> ingredients, Bill bill)
        {
            var diff = pawn.health.hediffSet.hediffs.Find(hediff => hediff.def.defName == "BloodLoss");
            if (diff == null) return;
            diff.Severity = diff.Severity - 0.5f;
        }
    }
}