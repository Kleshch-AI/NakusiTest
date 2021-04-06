using UnityEngine;
using UniRx;
using System;

namespace NakusiTest.Model
{

    internal class Character : MonoBehaviour, ICharacter
    {

        private IntReactiveProperty health = new IntReactiveProperty();

        IObservable<int> ICharacter.healthAsObservable => health;

        private void Start()
        {
            health.Value = GameManager.Instance.GameSettings.CharacterSettings.Health;
        }

        internal void TakeDamage(int damage)
        {
            health.Value -= damage;
            if (health.Value <= 0) Destroy(gameObject);
        }

    }

}