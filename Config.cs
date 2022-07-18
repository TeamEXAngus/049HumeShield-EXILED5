using Exiled.API.Interfaces;
using System.ComponentModel;

namespace _049HumeShield
{
    internal class Config : IConfig
    {
        [Description("Whether or not the plugin is enabled")]
        public bool IsEnabled { get; set; } = true;

        [Description("The max Hume Shield for SCP-049")]
        public ushort MaxHumeShield { get; set; } = 500;

        [Description("The amount of Hume Shield which SCP-049 regens per second")]
        public ushort HumeShieldRegenPerSecond { get; set; } = 25;

        [Description("The number of seconds that must pass after SCP-049 last takes damage before Hume Shield begins regenerating")]
        public ushort HumeShieldRegenDelay { get; set; } = 25;
    }
}