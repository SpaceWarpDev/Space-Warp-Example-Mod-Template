using SpaceWarp.API.Configuration;

namespace SpaceWarpExampleMod;

[ModConfig]
[JsonObject(MemberSerialization.OptOut)]
class ExampleConfig {
    [ConfigField("pi")]
    [ConfigDefaultValue(3.14159)]
    public double pi;

    [ConfigSection("section")]
    [ConfigField("e")]
    [ConfigDefaultValue(2.71)]
    public double e;

    [ConfigSection("section/a")]
    [ConfigField("2")]
    [ConfigDefaultValue(2)]
    public int two;
}