using UnityEngine;
public class Variables : MonoBehaviour
{
    public static float energy = 500;
    public float score = 0; 
    [SerializeField] float currentEnergy = 500;
    [SerializeField] private float energyShield = 500;
    [SerializeField] public float health = 1000;
    [SerializeField] private float maxEnergy = 1000;
    [SerializeField] private float maxEnergyShield = 1000;
    [SerializeField] private float maxHealth = 1000;
    [SerializeField] private float energyRegeneration = 100;
    [SerializeField] private float energyShieldRegeneration = 50;
    [SerializeField] private float sensitivity = 2;
    public static float inputAcceleration = 0;
    public static float shipAcceleration = 0;

    private Shot shot;
    [SerializeField] private GameObject gameOver;

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
        if (Variables.LeftEnergy() >= temp)
        {
            Variables.AddEnergy(temp * -1);
            energyShield += temp;
        }

        if (KeyManager.IncreaseSpeed()) { inputAcceleration += 1 * sensitivity; }
        else if(KeyManager.DecreaseSpeed()){ inputAcceleration -= 1*sensitivity; }
        //inputAcceleration += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        shipAcceleration = inputAcceleration;

        Bars.SetSize(health / maxHealth, energy / maxEnergy, energyShield / maxEnergyShield);



        if(health<=0){
            gameOver.SetActive(true);
            Time.timeScale = 0;
        }

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

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Shot")
        {
            shot = col.gameObject.GetComponent<Shot>();
            if (shot.damagePlayer) 
            {
                health -= shot.damage;
                Destroy(col.gameObject);
            }
        }
        if (col.gameObject.tag == "Planet")
        {
                health = 0;
        }
    }
}