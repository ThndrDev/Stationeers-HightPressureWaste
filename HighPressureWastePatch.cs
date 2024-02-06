using HarmonyLib;
using JetBrains.Annotations;
using UnityEngine;
using Assets.Scripts.Objects.Clothing;
using Assets.Scripts.UI;
using SimpleSpritePacker;

namespace HighPressureWaste
{
    [HarmonyPatch(typeof(Suit))]
    class Patch_Suit_Waste
    {
        [HarmonyPatch("Awake")]
        [HarmonyPostfix]
        [UsedImplicitly]
        static private void GetWasteMaxPressurePatch(Suit __instance)
        {
            __instance.WasteMaxPressure = 60000f;
        }
    }

    [HarmonyPatch(typeof(StatusUpdates), nameof(StatusUpdates.IsWasteCaution))]
    class Patch_StatusUpdates_IsWasteCaution
    {
        static bool Prefix(StatusUpdates __instance, Suit ____suit, ref bool __result)
        {
            __result = !__instance.IsWasteCritical() && ____suit != null && ____suit.WasteTank && ____suit.WasteTank.Pressure >= ____suit.WasteTank.MaxPressure * 0.8f;
            return false;
        }
    }

    [HarmonyPatch(typeof(StatusUpdates), nameof(StatusUpdates.IsWasteCritical))]
    class Patch_StatusUpdates_IsWasteCritical
    {
        static bool Prefix(Suit ____suit,ref bool __result)
        {
            __result = ____suit != null && (!____suit.WasteTank || ____suit.WasteTank.IsBroken || ____suit.WasteTank.Pressure >= ____suit.WasteTank.MaxPressure * 0.9f);
            return false;
        }
    }
}