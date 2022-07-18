using _049HumeShield.Components;
using Exiled.Events.EventArgs;
using UnityEngine;

namespace _049HumeShield.Handlers
{
    internal class Spawning
    {
        public void OnSpawning(SpawningEventArgs ev)
        {
            if (ev.RoleType == RoleType.Scp049)
            {
                if (ev.Player.GameObject.TryGetComponent<HSController>(out var _))
                    return;

                ev.Player.GameObject.AddComponent<HSController>();
            }

            if (ev.Player.GameObject.TryGetComponent<HSController>(out var Controller))
            {
                Object.Destroy(Controller);
            }
        }
    }
}