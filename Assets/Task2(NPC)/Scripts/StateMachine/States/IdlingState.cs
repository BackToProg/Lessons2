namespace Task2_NPC_.Scripts.StateMachine.States
{
    public class IdlingState : MovementState
    {
        public IdlingState(IStateSwitcher stateSwitcher, Npc npc, NpcStateMachineData data) : base(stateSwitcher, npc, data)
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