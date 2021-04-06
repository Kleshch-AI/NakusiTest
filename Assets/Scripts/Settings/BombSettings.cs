using UnityEngine;

namespace NakusiTest.Settings
{

    [CreateAssetMenu(fileName = "BombSettings", menuName = "NakusiTest/Settings/BombSettings")]
    public class BombSettings : ScriptableObject
    {

        [Header("Спавн")]
        [SerializeField] private SpawnSettings spawn;

        [Header("Радиус взрыва")]
        [SerializeField] private float radius;

        [Header("Урон в эпицентре")]
        [SerializeField] private float maxDamage;

        public SpawnSettings Spawn => spawn;
        public float Radius => radius;
        public float MaxDamage => maxDamage;

    }

}