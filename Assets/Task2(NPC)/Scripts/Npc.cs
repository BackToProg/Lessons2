using Task2_NPC_.Scripts.StateMachine;
using UnityEngine;

namespace Task2_NPC_.Scripts
{
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(InputHandler))]
    public class Npc : MonoBehaviour
    {
        [SerializeField] private NpcConfig _config;
        
        private InputHandler _inputHandler;
        private NpcStateMachine _stateMachine;
        private CharacterController _characterController;

        public CharacterController _CharacterController => _characterController;
        public InputHandler InputHandler => _inputHandler;
        public NpcConfig Config => _config;

        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
            _inputHandler = GetComponent<InputHandler>();
            _stateMachine = new NpcStateMachine(this);
        }

        private void Update()
        {
            _stateMachine.HandleInput();
            _stateMachine.Update();
        }
    }
}