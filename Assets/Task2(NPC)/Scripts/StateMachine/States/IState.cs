namespace Task2_NPC_.Scripts.StateMachine.States
{
    public interface IState
    {
        void Enter();
        void Exit();
        void HandleInput();
        void Update();
    }
}