using Task3_Mediator_.Scripts.Configs;
using UnityEngine;

namespace Task3_Mediator_.Scripts.Player
{
    [CreateAssetMenu(menuName = "Configs/CharacterConfig", fileName = "CharacterConfig")]
    public class CharacterConfig : ScriptableObject
    {
        [SerializeField] private MainCharacterConfig _mainCharacterConfig;

        public MainCharacterConfig MainCharacterConfig => _mainCharacterConfig;

    }
}