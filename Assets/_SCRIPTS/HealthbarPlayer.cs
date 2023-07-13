using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarPlayer : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Image fillImage;
    private Slider slider;
    private float fillValue;

    void Awake()
    {
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        if (playerHealth != null && slider != null)
        {
            if (playerHealth.currentHealth == playerHealth.maxHealth)
            {
                slider.value = slider.maxValue;
            }
            else
            {
                fillValue = (float)(playerHealth.currentHealth) / playerHealth.maxHealth * 100;
                Debug.Log("Healthbar value: " + slider.value);
                Debug.Log("Fill value: " + fillValue);
                slider.value = fillValue;
            }
        }
    }
}
