using UnityEngine;

namespace Task2_NPC_.Scripts.StateMachine.States
{
    public class WorkingState : BehavingState
    {
        public WorkingState(IStateSwitcher stateSwitcher, Npc npc, NpcStateMachineData stateMachineData) : base(stateSwitcher, npc, stateMachineData)
        {
        }

        public override void Enter()
        {
            base.Enter();
            
            StateMachineData.Speed = 0;
            Input.ClearMoveTarget();
        }

        public override void Update()
        {
            base.Update();
            
            if (StateMachineData.Target == null)
                return;
            
            StateSwitcher.SwitchState<WalkingState>();
        }
    }
}
