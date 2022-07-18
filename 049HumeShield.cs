using Exiled.API.Features;
using PlayerHandler = Exiled.Events.Handlers.Player;
using System;

namespace _049HumeShield
{
    internal class _049HumeShield : Plugin<Config>
    {
        internal static _049HumeShield Instance;

        public override Version RequiredExiledVersion { get; } = new Version(5, 2, 1);
        public override Version Version { get; } = new Version(1, 0, 0);

        public override string Name { get; } = "Alpha Zombie";
        public override string Author { get; } = "TeamEXAngus#5525";

        private Handlers.Spawning spawning;

        public _049HumeShield()
        {
            Instance = this;
        }

        public override void OnEnabled()
        {
            spawning = new();

            PlayerHandler.Spawning += spawning.OnSpawning;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            PlayerHandler.Spawning -= spawning.OnSpawning;

            spawning = null;

            base.OnDisabled();
        }
    }
}