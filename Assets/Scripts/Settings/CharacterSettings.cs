using UnityEngine;

namespace NakusiTest.Settings
{

    [CreateAssetMenu(fileName = "CharacterSettings", menuName = "NakusiTest/Settings/CharacterSettings")]
    public class CharacterSettings : ScriptableObject
    {

        [Header("Спавн")]
        [SerializeField] private SpawnSettings spawn;
       
        [Header("Здоровье")]
        [SerializeField] private int health;

        public SpawnSettings Spawn => spawn;
        public int Health => health;

    }

}