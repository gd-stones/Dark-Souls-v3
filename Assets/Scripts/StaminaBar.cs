using UnityEngine;
using UnityEngine.UI;

namespace StonesGaming
{
    public class StaminaBar : MonoBehaviour
    {
        public Slider slider;

        void Start()
        {
            slider = GetComponent<Slider>();
        }

        public void SetMaxStamina(float maxStamina)
        {
            slider.maxValue = maxStamina;
            slider.value = maxStamina;
        }

        public void SetCurrentStamina(float currentStamina)
        {
            slider.value = currentStamina;
        }
    }
}