
using SpaceWarp.API.Configuration;
using Newtonsoft.Json;
namespace ExampleMod;

// Define our config class with the [ModConfig] attribute
[ModConfig]
[JsonObject(MemberSerialization.OptOut)]
public class ExampleModConfig {
    [ConfigField("funny number")]
    [ConfigDefaultValue(69)]
    public int funny_number;
}
