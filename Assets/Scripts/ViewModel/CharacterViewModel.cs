using NakusiTest.Model;
using NakusiTest.View;
using UnityEngine;
using UniRx;

namespace NakusiTest.ViewModel
{

    [RequireComponent(typeof(Character))]
    internal class CharacterViewModel : MonoBehaviour
    {

        [SerializeField] private HealthBar healthBar;
         private ICharacter model;

        private void Start()
        {
            var characterHealth = GameManager.Instance.GameSettings.CharacterSettings.Health;
            healthBar.SetupMaxHealth(characterHealth);
            healthBar.SetupCurrentHealth(characterHealth);

            model = gameObject.GetComponent<ICharacter>();
            model.healthAsObservable.Subscribe(healthBar.SetupCurrentHealth).AddTo(this);
        }

    }

}