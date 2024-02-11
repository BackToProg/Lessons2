using System;
using UnityEngine;

namespace Task2_NPC_.Scripts.StateMachine.States.Configs
{
    [Serializable]
    public class WalkingStateConfig
    {
        [SerializeField, Range(0, 10)] private float _speed;

        public float Speed => _speed;
        
       // [field: SerializeField] public float Speed { get; private set; }
    }
}