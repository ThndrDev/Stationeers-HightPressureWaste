using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;
using UnityEngine;

namespace HighPressureWaste
{
    [BepInPlugin("HighPressureWaste", "HighPressureWaste", "0.1.0.0")]    
    public class HighPressureWastePlugin : BaseUnityPlugin
    {
        public static HighPressureWastePlugin Instance;
        public void Log(string line)
        {
            Debug.Log("[HighPressureWaste]: " + line);
        }

        private void Awake()
        {
            HighPressureWastePlugin.Instance = this;
            Log("Hello World");
            var harmony = new Harmony("net.ThndrDev.stationeers.HighPressureWaste");
            harmony.PatchAll();
            Log("Patch succeeded");
        }
    }
}