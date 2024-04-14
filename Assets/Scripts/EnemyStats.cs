using UnityEngine;

namespace StonesGaming
{
    public class EnemyStats : MonoBehaviour
    {
        public int healthLevel = 10;
        public int maxHealth;
        public int currentHealth;

        Animator animator;

        void Awake()
        {
            animator = GetComponentInChildren<Animator>();
        }

         void Start()
        {
            maxHealth = SetMaxHealthFromHeatlthLevel();
            currentHealth = maxHealth;
        }

         int SetMaxHealthFromHeatlthLevel()
        {
            maxHealth = healthLevel * 10;
            return maxHealth;
        }

        public void TakeDamage(int damage)
        {
            currentHealth -= damage;
            animator.Play("Damage_01");

            if (currentHealth <= 0)
            {
                currentHealth = 0;
                animator.Play("Dead_01");
            }
        }
    }
}
