using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour
{
    public static float energy = 500;
    [SerializeField] float currentEnergy = 500;
    [SerializeField] private float energyShield = 500;
    [SerializeField] private float health = 1000;
    [SerializeField] private float maxEnergy = 1000;
    [SerializeField] private float maxEnergyShield = 1000;
    [SerializeField] private float maxHealth = 1000;
    [SerializeField] private float energyRegeneration = 100;
    [SerializeField] private float energyShieldRegeneration = 50;
    [SerializeField] private float sensitivity = 1;
    public static float ScrollWheel = 0;
    public static float shipAcceleration = 0;

    private float temp;


    private void Start()
    {
        health = maxHealth;
    }

    private void Update()
    {
        currentEnergy = energy;

        energy = Regeneration(energy, maxEnergy, energyRegeneration, false);
        temp = Regeneration(energyShield, maxEnergyShield, energyShieldRegeneration, true) - energyShield;
        if (variables.LeftEnergy() >= temp)
        {
            variables.AddEnergy(temp * -1);
            energyShield += temp;
        }


        ScrollWheel += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        shipAcceleration = ScrollWheel;

        Bars.SetSize(health / maxHealth, energy / maxEnergy, energyShield / maxEnergyShield);
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
    public static void AddEnergy(float e)
    {
        energy += e;
    }
}
