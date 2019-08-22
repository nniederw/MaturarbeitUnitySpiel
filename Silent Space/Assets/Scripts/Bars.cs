using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bars : MonoBehaviour
{
    private static GameObject healthBar;
    private static GameObject energyBar;
    private static GameObject energyShieldBar;

    void Start()
    {
        healthBar = GameObject.Find("HealthBar");
        energyBar = GameObject.Find("EnergyBar");
        energyShieldBar = GameObject.Find("EnergyShieldBar");
    }

    public static void SetSize(float health, float energy, float energyShield)
    {
        healthBar.transform.localScale = new Vector3(health, 1f);
        energyBar.transform.localScale = new Vector3(energy, 1f);
        energyShieldBar.transform.localScale = new Vector3(energyShield, 1f);
    }
}
