using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour
{

    [SerializeField] private float energy;
    [SerializeField] private float energyShield;
    [SerializeField] private float health;
    [SerializeField] private float maxEnergy;
    [SerializeField] private float maxEnergyShield;
    [SerializeField] private float maxHealth;
    [SerializeField] private float energyRegeneration;
    [SerializeField] private float energyShieldRegeneration;


    private void Update()
    {
        energy = Regeneration(energy, maxEnergy, energyRegeneration, false);
        energyShield = Regeneration(energyShield, maxEnergyShield, energyShieldRegeneration, true);





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
}
