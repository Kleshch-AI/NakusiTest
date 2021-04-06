using UnityEngine;

namespace NakusiTest.Settings
{

    [CreateAssetMenu(fileName = "SpawnSettings", menuName = "NakusiTest/Settings/SpawnSettings")]
    public class SpawnSettings : ScriptableObject
    {

        [Header("Префаб")]
        [SerializeField] private GameObject prefab;
        
        [Header("Интервал создания")]
        [SerializeField] private float spawnInterval;

        public float SpawnInterval => spawnInterval;
        public GameObject Prefab => prefab;

    }

}