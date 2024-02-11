using Task2_NPC_.Scripts.StateMachine.States.Configs;
using UnityEngine;

namespace Task2_NPC_.Scripts.StateMachine.States
{
    public class WalkingState : MovementState
    {
        private readonly WalkingStateConfig _config;

        public WalkingState(IStateSwitcher stateSwitcher, Npc npc, NpcStateMachineData data) : base(stateSwitcher, npc,
            data)
            => _config = npc.Config.WalkingStateConfig;

        public override void Enter()
        {
            base.Enter();

            StateMachineData.Speed = _config.Speed;
        }

        public override void Update()
        {
            base.Update();

            bool isPointReached = IsTargetReached(StateMachineData.Target.Position, out Vector3 offset);

            if (isPointReached && StateMachineData.Target is HomePoint)
            {
                StateSwitcher.SwitchState<IdlingState>();
            }

            if (isPointReached && StateMachineData.Target is WorkPoint)
            {
                StateSwitcher.SwitchState<WorkingState>();
            }
        }
    }
}
