using System;
using LabApi.Features;
using LabApi.Loader.Features.Plugins;
using LabApi.Loader.Features.Plugins.Enums;

namespace Sometimes_EventNoRP
{
    public class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "Sometimes-EventNoRP";
        public override string Author { get; } = "Kiore";
        public override string Description { get; } = "A plugin that launches a NoRP game at a random time of day.";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredApiVersion { get; } = new Version(LabApiProperties.CompiledVersion);
        public override LoadPriority Priority { get; } = LoadPriority.Medium;

        public override void Enable()
        {
        }
        public override void Disable()
        {
        }
    }
}