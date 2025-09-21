using UnityEngine;
using UnityEngine.UI;

public class HealthBarManager : MonoBehaviour
{
    private Slider healthSlider;

    public void UpdateHealth(float newValue)
    {
        healthSlider.value = newValue;
    }
}
