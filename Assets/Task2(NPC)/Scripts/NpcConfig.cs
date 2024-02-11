using Task2_NPC_.Scripts.StateMachine.States.Configs;
using UnityEngine;

namespace Task2_NPC_.Scripts
{
    [CreateAssetMenu(menuName = "Configs/NpcConfig", fileName = "NpcConfig")]
    public class NpcConfig : ScriptableObject
    {
        [SerializeField] private WalkingStateConfig _walkingStateConfig;

        public WalkingStateConfig WalkingStateConfig => _walkingStateConfig;
    }
}