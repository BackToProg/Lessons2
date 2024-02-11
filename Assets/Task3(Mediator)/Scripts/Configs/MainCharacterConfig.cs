using System;
using UnityEngine;

namespace Task3_Mediator_.Scripts.Configs
{
    [Serializable]
    public class MainCharacterConfig
    {
        [SerializeField, Range(0, 100)] private int _health;
        [SerializeField, Range(1, 100)] private int _defaultTakeDamage;
        [SerializeField] private int _level;

        public int Health => _health;
        public int Level => _level;
        public int Damage => _defaultTakeDamage;
    }
}