using Task3_Mediator_.Scripts.Mediator;
using UnityEngine;

namespace Task3_Mediator_.Scripts
{
    public class MediatorBootstrap : MonoBehaviour
    {
        [SerializeField] private GameplayMediator _gameplayMediator;
        [SerializeField] private LevelScreen _levelScreen;

        private void Awake()
        {
            _gameplayMediator.Initialize();
            _levelScreen.Initialize(_gameplayMediator);
            
            _gameplayMediator.StartLevel();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                _gameplayMediator.Level.Character.TakeDamage();
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                _gameplayMediator.Level.Character.ChangeLevel();
            }
        }
    }
}
