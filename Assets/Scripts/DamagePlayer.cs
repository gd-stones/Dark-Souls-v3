using UnityEngine;

namespace StonesGaming
{
    public class DamagePlayer : MonoBehaviour
    {
        public int damage = 25;

         void OnTriggerEnter(Collider other)
        {
            PlayerStats playerStats = other.GetComponent<PlayerStats>();
            
            if (playerStats != null)
            {
                playerStats.TakeDamage(damage);
            }
        }
    }
}