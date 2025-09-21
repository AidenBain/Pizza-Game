using UnityEngine;
using UnityEngine.UI;

public class HealthBarManager : MonoBehaviour
{
    private Slider healthSlider;

    void Start()
    {
        healthSlider = GetComponent<Slider>();
    }

    public void UpdateHealth(float newValue)
    {
        healthSlider.value = newValue;
    }
}
