using System;

namespace Task3_Mediator_.Scripts.Player
{
    public class Health
    {
        private int _currentHealth;

        public Health(int healthValue)
        {
            _currentHealth = healthValue;
            InitialHealth = healthValue;
        }
        
        public int InitialHealth { get; private set; }

        public Action<int> OnHealthChanged;
        public Action OnDie;

        public void Reset()
        {
            _currentHealth = InitialHealth;
        }

        public void TakeDamage(int damage)
        {
            _currentHealth = Math.Max(0, _currentHealth - damage);

            if (_currentHealth == 0)
                Die();

            OnHealthChanged?.Invoke(_currentHealth);
        }

        private void Die()
        {
            OnDie?.Invoke();
        }
    }
}
