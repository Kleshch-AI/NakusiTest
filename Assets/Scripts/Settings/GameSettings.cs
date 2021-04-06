using UnityEngine;

namespace NakusiTest.Settings
{

    [CreateAssetMenu(fileName = "GameSettings", menuName = "NakusiTest/Settings/GameSettings")]
    public class GameSettings : ScriptableObject
    {

        [Header("Задержка перед симуляцией")]
        [SerializeField] private float spawnDelay;

        [Header("Бомбы")]
        [SerializeField] private BombSettings bombSettings;

        [Header("Персонажи")]
        [SerializeField] private CharacterSettings characterSettings;

        public BombSettings BombSettings => bombSettings;
        public CharacterSettings CharacterSettings => characterSettings;
        public float SpawnDelay => spawnDelay;

    }

}