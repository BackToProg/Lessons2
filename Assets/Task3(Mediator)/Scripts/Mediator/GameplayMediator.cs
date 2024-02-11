using Task3_Mediator_.Scripts.Player;

using UnityEngine;

namespace Task3_Mediator_.Scripts.Mediator
{
    public class GameplayMediator : MonoBehaviour
    {
        [SerializeField] private Character _character;
        [SerializeField] private LevelScreen _levelScreen;

        public void Initialize() => Level = new Level(_character);
        
        public Level Level { get; private set; }

        private void OnEnable()
        {
            _character.Health.OnHealthChanged += OnHealthChange;
            _character.Health.OnDie += OnDie;
            _character.Level.OnLevelChange += OnLevelChange;
        }

        private void OnDisable()
        {
            _character.Health.OnHealthChanged -= OnHealthChange;
            _character.Health.OnDie -= OnDie;
            _character.Level.OnLevelChange -= OnLevelChange;
        }

        public void RestartLevel()
        {
            StartLevel();
            Time.timeScale = 1;
        }
        
        public void StartLevel()
        {
            Level.Restart();
            _levelScreen.ResetDate(_character.Health.InitialHealth, _character.Level.InitialLevel);
            _levelScreen.HideRestartButton();
        }
        
        private void OnLevelChange(int levelValue) =>  _levelScreen.ChangeLevelText(levelValue);

        private void OnDie()
        {
            _levelScreen.ShowRestartButton();
            Time.timeScale = 0;
        }

        private void OnHealthChange(int healthValue) => _levelScreen.ChangeHealthText(healthValue);

    }
}
