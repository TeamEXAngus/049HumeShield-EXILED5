using Exiled.API.Features;
using PlayerStatsSystem;
using UnityEngine;
namespace _049HumeShield.Components
{
    internal class HSController : MonoBehaviour
    {
        private static Config Configs => _049HumeShield.Instance.Config;

        internal AhpStat.AhpProcess HumeShieldProcess;

        public void Awake()
        {
            Player Player = Player.Get(gameObject);

            HumeShieldProcess = Player.ReferenceHub.playerStats.GetModule<AhpStat>()
                .ServerAddProcess(Configs.MaxHumeShield, Configs.MaxHumeShield,
                decay: -Configs.HumeShieldRegenPerSecond, efficacy: 1, sustain: 0, persistant: true);
        }
    }
}