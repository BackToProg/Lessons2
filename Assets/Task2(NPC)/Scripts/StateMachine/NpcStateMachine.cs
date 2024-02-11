using System.Collections.Generic;
using System.Linq;
using Task2_NPC_.Scripts.StateMachine.States;

namespace Task2_NPC_.Scripts.StateMachine
{
    public class NpcStateMachine : IStateSwitcher
    {
        private List<IState> _states;
        private IState _currentState;

        public NpcStateMachine(Npc npc)
        {
            NpcStateMachineData data = new NpcStateMachineData();
            
            _states = new List<IState>()
            {
                new IdlingState(this, npc, data),
                new WalkingState(this, npc, data),
                new WorkingState(this, npc, data),
            };

            _currentState = _states[0];
            _currentState.Enter();
        }

        public void SwitchState<T>() where T : IState
        {
            IState state = _states.FirstOrDefault(state => state is T);

            if (state == null) 
                return;
            
            _currentState?.Exit();
            _currentState = state;
            _currentState.Enter();
        }

        public void HandleInput() => _currentState.HandleInput();

        public void Update() => _currentState.Update();
    }
}