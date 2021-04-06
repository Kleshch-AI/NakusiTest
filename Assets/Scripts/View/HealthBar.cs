using UnityEngine;
using UnityEngine.UI;

namespace NakusiTest.View
{

    internal class HealthBar : MonoBehaviour
    {

        [SerializeField] private Slider slider;

        public void SetupMaxHealth(int value)
        {
            slider.maxValue = value;
        }

        public void SetupCurrentHealth(int value)
        {
            slider.value = value;
        }

    }

}