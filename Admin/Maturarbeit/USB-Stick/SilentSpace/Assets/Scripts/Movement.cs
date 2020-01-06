using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] public static float velocity = 10;
    [SerializeField] private float sidewaysForce = 500;
    [SerializeField] private float accelerationEnergyCost = 10;

    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.AddForce(Variables.shipAcceleration * transform.forward);

        if (KeyManager.GoUp())
        {
            rb.AddTorque(transform.right * -sidewaysForce * 60 * Time.deltaTime);
        }
        if (KeyManager.GoLeft())
        {
            rb.AddTorque(transform.up * -sidewaysForce * 60 * Time.deltaTime);
        }
        if (KeyManager.GoDown())
        {
            rb.AddTorque(transform.right * sidewaysForce * 60 * Time.deltaTime);
        }
        if (KeyManager.GoRight())
        {
            rb.AddTorque(transform.up * sidewaysForce * 60 * Time.deltaTime);
        }

        if (velocity + Variables.shipAcceleration >= 0)
        {
            if (Variables.LeftEnergy() >= Variables.shipAcceleration)
            {
                Variables.AddEnergy(accelerationEnergyCost * Mathf.Abs(Variables.shipAcceleration) * -1);
                velocity += Variables.shipAcceleration;
                Variables.ScrollWheel -= Variables.shipAcceleration * 0.2f;
            }
            else
            {
                Variables.ScrollWheel -= Variables.shipAcceleration * 0.2f;
            }
        }
        else
        {
            velocity = 0;
        }
        rb.velocity = velocity * transform.forward;
    }
}
