using System;

namespace Task2_NPC_.Scripts.StateMachine
{
    public class NpcStateMachineData
    {
        public IPoint Target;

        private float _speed;

        public float Speed
        {
            get => _speed;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                _speed = value;
            }
        }

    }
}