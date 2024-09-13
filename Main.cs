using HarmonyLib;

[HarmonyPatch]
public class RemoveCheatConsequence
{
    
[HarmonyPatch]
    public class FunniRankPatch
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(GameStateManager), "CanSubmitScores", MethodType.Getter)]
        static void ScoresSubmission(ref bool __result) => __result = true;
    }
}