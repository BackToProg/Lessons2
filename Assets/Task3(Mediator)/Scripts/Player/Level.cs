using System;
using Task3_Mediator_.Scripts.Configs;

namespace Task3_Mediator_.Scripts.Player
{
    public class Level
    {
        private readonly MainCharacterConfig _config;
        private int _currentLevel;

        public Level(int level)
        {
            _currentLevel = level;
            InitialLevel = level;
        }
        
        public int InitialLevel { get; private set; }
        
        public Action<int> OnLevelChange;

        public void Reset()
        {
            _currentLevel = InitialLevel;
        }

        public void IncreaseLevel()
        {
            _currentLevel++;

            OnLevelChange?.Invoke(_currentLevel);
        }
    }
}