# Stationeers mod "HighPressureWaste" for BepInEx.

# Description:  
This mod changes the suit to remove the max pressure the suit it can store in a waste canister. With this mod, your suit will keep pumping as long as you have a waste canister. You'll hear "Waste Warning" at 80% the max canister pressure and "Waste Critical at 90% the max pressure the canister you're using can hold. If you're using smart canister, that means:

With normal canister, 8MPA for "warning" and 9MPA for "Critical";
With Smart Canister, 16MPA for "warning" and 18MPA for "critical";

If you ignore them, the suit will still keep pumping to waste, even past the pressure limit of the canister, and if you don't empty or exchange the canister in time, ofc it will explode. 

# Install Instructions

[b]Step 1[/b] - Subscribe to this mod in the workshop;
[b]Step 2[/b] - This mod uses scripts and it will only work if you use a modloader. Currently it support StationeersMods and BepInEx modloaders. Choose JUST ONE to install and follow the procedures:
[list]
[*] StationeersMods framework, it's the easiest and preffered way to load mods because after the installation, you just need to subscribe to the mod and it will be active. With StationeersMods you'll also get mods update automatically. Learn how to install it here: https://github.com/jixxed/StationeersMods#installation

[*] BepInEx: If you don't have BepInEx installed, download the x64 version available at https://github.com/BepInEx/BepInEx/releases/tag/v5.4.21 and follow the BepInEx installation instructions but basically you will need to:
[-]Drop and unpack it inside Stationeers folder
[-]Start the game once to finish installing BepInEx and check if he created the folders called \Stationeers\BepInEx\plugins, if yes, the BepInEx installation is completed.
[-]Download the lastest release from https://github.com/ThndrDev/Stationeers-HighPressureWaste/releases/ page.
Unpack the dll file inside the folder \BepInEx\plugins
[/list]

# Multiplayer Support

For this mod to work correctly, both client and server must have the mod in the same version.