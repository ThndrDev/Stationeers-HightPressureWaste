# Stationeers mod "HighPressureWaste" for BepInEx.

# Description:  
On Vanilla, the suit stops filling the waste canister when it reaches 4MPA of pressure.
This mod changes this behavior so the suit will keep filling the waste, no matter the canister pressure.

The "Waste Warning" and "Waste Critical" alerts were also changed to consider the max pressure of the canister you're using. The alert will trigger at 80% and 90% of the canister pressure respectively. If it's a normal canister, the warning will appear when it's at 8MPA and Critical will kick in at 9MPA. With smart Canisters, the warning will kick in at 16MPA and critical at 18MPA.

If you ignore the ladie's warnings, the canister will overpressurize and a Rapid Unscheduled Disassembly process will kick in.

# Install Instructions

Step 1 - Subscribe to this mod in the workshop;
Step 2 - This mod uses scripts and it will only work if you use a modloader. Currently it support StationeersMods and BepInEx modloaders. Choose JUST ONE to install and follow the procedures:

* StationeersMods framework, it's the easiest and preffered way to load mods because after the installation, you just need to subscribe to the mod and it will be active. With StationeersMods you'll also get mods update automatically. Learn how to install it here: https://github.com/jixxed/StationeersMods#installation

* BepInEx: If you don't have BepInEx installed, download the x64 version available at https://github.com/BepInEx/BepInEx/releases/tag/v5.4.21 and follow the BepInEx installation instructions but basically you will need to:
   * Drop and unpack it inside Stationeers folder
   * Start the game once to finish installing BepInEx and check if he created the folders called \Stationeers\BepInEx\plugins, if yes, the BepInEx installation is completed.
   * Download the lastest release from https://github.com/ThndrDev/Stationeers-HighPressureWaste/releases/ page.
   * Unpack the dll file inside the folder \BepInEx\plugins
[/list]

# Multiplayer Support

For this mod to work correctly, both client and server must have the mod in the same version.
