using System;
using Health;
using UnityEngine;

namespace Enemy
{
    public class EnemyBase : MonoBehaviour
    {
        public int damage = 10;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log(collision.transform.name);
            
            var health = collision.gameObject.GetComponent<HealthBase>();
            
            
            if (health != null)
            {
                health.Damage(damage);
            }
        }
    }
}
