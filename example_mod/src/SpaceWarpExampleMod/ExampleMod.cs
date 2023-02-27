using SpaceWarp.API.Mods;
using SpaceWarp.API.AssetBundles;
using SpaceWarp.API.Configuration;
using SpaceWarp.API.Managers;
using UnityEngine;
namespace SpaceWarpExampleMod;

[MainMod]
public class ExampleMod : Mod {
    // OnInitialized is called after a mod has been initialized and its assets have been loaded
    public override void OnInitialized() {

        // Mods have a Logger field that is set up by space warp
        Logger.Info("OnInitialized() for Example Mod");


        // Load the configuration
        if (ManagerLocator.TryGet(out ConfigurationManager configManager)) {
            if (configManager.TryGet(Info.mod_id, out var config)) {
                ExampleConfig cfg = (ExampleConfig)config.configObject;
                Logger.Info($"pi = {cfg.pi}");
                Logger.Info($"e = {cfg.e}");
                Logger.Info($"2 = {cfg.two}");
            } else {
                Logger.Warn($"Failed to find configuration for {Info.mod_id}");
            }
        } else {
            Logger.Error($"Failed to find configuration manager");
        }


        // Load an asset bundle file
        // Also mods have an Info field that reflects the modinfo.json file
        if (ResourceManager.TryGetAsset($"{Info.mod_id}/test/test.png",out Texture2D tex)) {
            Logger.Info($"successfully loaded {Info.mod_id}/test/test.png - w = {tex.width}, h = {tex.height}");
        } else {
            Logger.Warn($"unable to load {Info.mod_id}/test/test.png");
        }
        
    }
}