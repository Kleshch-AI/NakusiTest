using NakusiTest.Settings;

namespace NakusiTest.Model
{

    internal class CharacterSpawner : SpawnerFromPlane
    {

        protected override SpawnSettings GetSettings()
        {
            return GameManager.Instance.GameSettings.CharacterSettings.Spawn;
        }
       
    }

}