using NakusiTest.Settings;
using UnityEngine;

namespace NakusiTest.Model
{

    internal class GameManager : MonoBehaviour
    {

        [SerializeField] private GameSettings gameSettings;

        internal static GameManager Instance { get; private set; }

        internal GameSettings GameSettings => gameSettings;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(this);
            }
            else
            {
                Instance = this;
            }
        }

    }

}