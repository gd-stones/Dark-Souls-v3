using UnityEngine;
using UnityEngine.UI;

namespace StonesGaming
{
    public class HealthBar : MonoBehaviour
    {
        public Slider slider;

        void Start()
        {
            slider = GetComponent<Slider>();
            slider = GetComponent<Slider>();
        }

        public void SetMaxHealth(float maxHealth)
        {
            slider.maxValue = maxHealth;
            slider.value = maxHealth;
        }

        public void SetCurrentHealth(float currentHealth)
        {
            slider.value = currentHealth;
        }
    }
}
