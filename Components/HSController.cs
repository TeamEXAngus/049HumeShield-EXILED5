using Exiled.API.Features;
using PlayerStatsSystem;
using UnityEngine;

namespace _049HumeShield.Components
{
    internal class HSController : MonoBehaviour
    {
        private static Config Configs => _049HumeShield.Instance.Config;

        private Player Player;
        private AhpStat.AhpProcess HumeShieldProcess;
        internal float TimeSinceTakenDamage = 0;

        public void Awake()
        {
            Player = Player.Get(gameObject);

            HumeShieldProcess = Player.ReferenceHub.playerStats.GetModule<AhpStat>()
                .ServerAddProcess(Configs.MaxHumeShield, Configs.MaxHumeShield,
                decay: 0, efficacy: 1, sustain: 0, persistant: true);
        }

        public void Update()
        {
            TimeSinceTakenDamage += Time.deltaTime;

            if (TimeSinceTakenDamage > Configs.HumeShieldRegenDelay && HumeShieldProcess.CurrentAmount < Configs.MaxHumeShield)
            {
                HumeShieldProcess.CurrentAmount += Configs.HumeShieldRegenPerSecond * Time.deltaTime;
            }
        }
    }
}