using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] float health;
    [SerializeField] float maxHealth;

    [SerializeField] Slider slider;

    private void Awake()
    {
        maxHealth = health;
    }

    void Start()
    {
        UpdateUI();
    }

    public void Damage(float attack)
    {
        health -= attack;

        UpdateUI();
    }

    public void UpdateUI()
    {
        slider.value = health / maxHealth;
    }
}
