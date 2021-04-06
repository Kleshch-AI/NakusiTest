using NakusiTest.Utils;
using UnityEngine;

namespace NakusiTest.Model
{

    internal class Bomb : MonoBehaviour
    {

        private float radius;
        private float maxDamage;

        private void Start()
        {
            radius = GameManager.Instance.GameSettings.BombSettings.Radius;
            maxDamage = GameManager.Instance.GameSettings.BombSettings.MaxDamage;
        }

        private void OnCollisionEnter(Collision other)
        {
            Explode();
        }

        private void Explode()
        {
            var nearestColliders = Physics.OverlapSphere(transform.position, radius);
            foreach (var collider in nearestColliders)
            {
                if (!TagUtils.IsCharacter(collider.tag)) continue;

                var direction = (collider.transform.position - transform.position).normalized;
                Physics.Raycast(transform.position, direction, out var hit, 1000);

                if (TagUtils.IsWall(hit.collider.tag)) continue;

                var character = collider.gameObject.GetComponent<Character>();
                if (character == null) continue;

                var distance = Vector3.Distance(character.gameObject.transform.position, transform.position);
                var damage = Mathf.RoundToInt(maxDamage * (1f / distance));
                character.TakeDamage(damage);
            }

            Destroy(gameObject);
        }

    }

}