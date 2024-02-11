using UnityEngine;

namespace Task3_Mediator_.Scripts.Player
{
    public class InputHandler : MonoBehaviour
    {
        [SerializeField] private Character _character;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                 int damage = _character.MainCharacterConfig.Damage;
                _character.Health.TakeDamage(damage);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                _character.Level.IncreaseLevel();
            }
        }
    }
}
