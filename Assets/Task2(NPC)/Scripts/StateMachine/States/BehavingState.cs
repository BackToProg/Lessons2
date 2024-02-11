using UnityEngine;

namespace Task2_NPC_.Scripts.StateMachine.States
{
    public abstract class BehavingState : IState
    {
        protected readonly IStateSwitcher StateSwitcher;
        protected readonly NpcStateMachineData StateMachineData;
        
        private readonly Npc _npc;

        protected BehavingState(IStateSwitcher stateSwitcher, Npc npc, NpcStateMachineData stateMachineData)
        {
            StateSwitcher = stateSwitcher;
            StateMachineData = stateMachineData;
            _npc = npc;
        }

        protected InputHandler Input => _npc.InputHandler;
        protected IPoint Target => Input.MoveTarget;
        
        public virtual void Enter()
        {
            Debug.Log(GetType());
            StateMachineData.Target = null;
        }

        public virtual void Exit()
        {
            
        }

        public virtual void HandleInput()
        {
            StateMachineData.Target = Target;
        }

        public virtual void Update()
        {
          
        }
    }
}