using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour
{
    [SerializeField] public static float energy;
    [SerializeField] private float energyShield;
    [SerializeField] private float health;
    [SerializeField] private float maxEnergy;
    [SerializeField] private float maxEnergyShield;
    [SerializeField] private float maxHealth;
    [SerializeField] private float energyRegeneration;
    [SerializeField] private float energyShieldRegeneration;
    [SerializeField] private float sensitivity = 1;
    [SerializeField] public static float ScrollWheel = 0;
    [SerializeField] public static float shipAcceleration = 0;

    private void Start()
    {
        health = maxHealth;
    }

    private void Update()
    {
        energy = Regeneration(energy, maxEnergy, energyRegeneration, false);
        energyShield = Regeneration(energyShield, maxEnergyShield, energyShieldRegeneration, true);

        ScrollWheel += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        shipAcceleration = ScrollWheel;
    }

    private float Regeneration(float n, float max, float reg, bool minusEnergie)
    {
        float dif;
        dif = 0;
        if (n != max)
        {
            if (n + reg * Time.deltaTime > max)
            {
                dif = max - n;
            }
            else
            {
                dif = reg * Time.deltaTime;
            }
        }
        n = n + dif;
        return n;
    }

    public static float LeftEnergy()
    {        
        return energy;
    }
    public static void AddEnergy(float e) {
        energy += e;
    }
}
