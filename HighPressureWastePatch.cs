using HarmonyLib;
using JetBrains.Annotations;
using UnityEngine;
using Assets.Scripts.Objects.Clothing;
using Assets.Scripts.UI;
using Assets.Scripts.Atmospherics;
using TMPro;
using Assets.Scripts.Objects.Entities;

namespace HighPressureWaste
{
    [HarmonyPatch(typeof(Suit))]
    class Patch_Suit_Waste
    {
        [HarmonyPatch("get_WasteMaxPressure")]
        [UsedImplicitly]
        [HarmonyPrefix]
        private static bool WasteMaxPressurePatch(ref PressurekPa __result)
        {
            __result = new PressurekPa(60000);
            return false;
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

    [HarmonyPatch(typeof(StatusUpdates))]
    class Patch_StatusUpdates_HandleIconUpdates
    {
        [HarmonyPatch("HandleIconUpdates")]
        [UsedImplicitly]
        [HarmonyPostfix]
        private static void patch_HandleIconUpdates(StatusUpdates __instance, Human ____human)
        { 
            TMP_Text textWaste = __instance.TextWaste;
            ISuit suit = ____human.Suit;
            textWaste.text = Mathf.Round((((suit != null) ? suit.AsThing : null) && suit.WasteTank) ? ((suit.WasteTank.Pressure / suit.WasteTank.MaxPressure).ToFloat() * 100f) : 0f).ToString();
            textWaste.text += "%"; 
        }
    }
}