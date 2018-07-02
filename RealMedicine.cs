using System.Reflection;
using Harmony;
using Verse;

namespace RealMedicine
{
  public class Controller : Mod
  {
    
    private static HarmonyInstance _harmony = null;

    private static HarmonyInstance Instance => _harmony ?? (_harmony = _harmony = HarmonyInstance.Create("thomas15v.RealMedicine"));

    public Controller(ModContentPack content) : base(content)
    {
      Log.Message("Applying patches");
      Instance.PatchAll(Assembly.GetExecutingAssembly());
    }
  }
}