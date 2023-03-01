
// Import the Space Warp mod API
using SpaceWarp.API.Mods;

namespace ExampleMod;

// Define our mod class with the [MainMod] attribute
[MainMod]
public class ExampleModMod : Mod {
    // This is our second stage initialization function, all assets and dependencies should be loaded by now.
    public override void OnInitialized() {
        // The mod class contains an Info and Logger class
        Logger.Info($"{Info.name} OnInitialized()");
    }
}
