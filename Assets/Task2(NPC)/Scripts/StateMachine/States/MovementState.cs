using UnityEngine;

namespace Task2_NPC_.Scripts.StateMachine.States
{
    public abstract class MovementState : IState
    {
        protected readonly IStateSwitcher StateSwitcher;
        protected readonly NpcStateMachineData StateMachineData;
        
        private readonly Npc _npc;

        public MovementState(IStateSwitcher stateSwitcher, Npc npc, NpcStateMachineData data)
        {
            StateSwitcher = stateSwitcher;
            _npc = npc;
            StateMachineData = data;
        }

        protected InputHandler Input => _npc.InputHandler;
        protected CharacterController CharacterController => _npc._CharacterController;
        protected IPoint Target => Input.MoveTarget;

        public virtual void Enter()
        {
            Debug.Log(GetType());
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
            MoveTowardsTarget(StateMachineData.Target);
        }

        protected bool IsTargetReached(Vector3 targetPosition, out Vector3 offset)
        {
            offset = targetPosition - _npc.transform.position;
            
            return offset.magnitude < 0.1f;
        }

        private void MoveTowardsTarget(IPoint target)
        {
            if (target == null)
                return;
            
            if (IsTargetReached(target.Position, out Vector3 offset)) 
                return;
            
            offset = offset.normalized * StateMachineData.Speed;
            CharacterController.Move(offset * Time.deltaTime);
        }
    }
}