using Task2_NPC_.Scripts.StateMachine.States;

namespace Task2_NPC_.Scripts.StateMachine
{
    public interface IStateSwitcher
    {
        void SwitchState<T>() where T : IState;
    }
}