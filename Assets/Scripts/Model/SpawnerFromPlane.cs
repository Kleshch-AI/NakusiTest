using NakusiTest.Settings;
using UnityEngine;

namespace NakusiTest.Model
{

    internal abstract class SpawnerFromPlane : MonoBehaviour
    {

        [SerializeField] protected GameObject spawnPlane;

        protected SpawnSettings settings;
        private float countdown;
        private Vector3 spawnDist;

        private void Start()
        {
            settings = GetSettings();

            var bounds = spawnPlane.GetComponent<MeshRenderer>().bounds;
            spawnDist = new Vector3
            (
                bounds.size.x / 2f,
                settings.Prefab.transform.position.y,
                bounds.size.z / 2f
            );

            countdown = GameManager.Instance.GameSettings.SpawnDelay;
        }

        private void Update()
        {
            countdown -= Time.deltaTime;

            if (countdown <= 0)
            {
                Spawn();
                countdown = settings.SpawnInterval;
            }
        }

        protected abstract SpawnSettings GetSettings();

        protected virtual void Spawn()
        {
            var pos = PickRandomPointOnSpawnPlane();
            var newObject = Instantiate(settings.Prefab, pos, Quaternion.identity, transform);
        }

        private Vector3 PickRandomPointOnSpawnPlane()
        {
            var randomDist = new Vector3
            (
                Random.Range(-spawnDist.x, spawnDist.x),
                spawnDist.y,
                Random.Range(-spawnDist.z, spawnDist.z)
            );

            return spawnPlane.transform.position + randomDist;
        }

    }

}