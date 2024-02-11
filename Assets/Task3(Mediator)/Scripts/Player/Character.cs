using Task3_Mediator_.Scripts.Configs;
using UnityEngine;

namespace Task3_Mediator_.Scripts.Player
{
    public class Character : MonoBehaviour
    {
        [SerializeField] private CharacterConfig _config;

        public Health Health { get; private set; }
        public Level Level { get; private set; }

        public MainCharacterConfig MainCharacterConfig => _config.MainCharacterConfig;

        public void Awake()
        {
            Health = new Health(MainCharacterConfig.Health);
            Level = new Level(MainCharacterConfig.Level);
        }

        public void TakeDamage()
        {
            int damage = MainCharacterConfig.Damage;
            Health.TakeDamage(damage);
        }

        public void ChangeLevel()
        {
            Level.IncreaseLevel();
        }

        public void ResetData()
        {
            Health.Reset();
            Level.Reset();
        }
    }
}