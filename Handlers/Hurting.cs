using _049HumeShield.Components;
using Exiled.Events.EventArgs;

namespace _049HumeShield.Handlers
{
    internal class Hurting
    {
        internal void OnHurting(HurtingEventArgs ev)
        {
            if (ev.Target.Role != RoleType.Scp049)
                return;

            var HSController = ev.Target.GameObject.GetComponent<HSController>();
            HSController.HumeShieldProcess.SustainTime = _049HumeShield.Instance.Config.HumeShieldRegenDelay;
        }
    }
}