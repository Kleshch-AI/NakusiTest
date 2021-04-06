using NakusiTest.Settings;

namespace NakusiTest.Model
{

    internal class BombSpawner : SpawnerFromPlane
    {

        protected override SpawnSettings GetSettings()
        {
            return GameManager.Instance.GameSettings.BombSettings.Spawn;
        }
       
    }

}