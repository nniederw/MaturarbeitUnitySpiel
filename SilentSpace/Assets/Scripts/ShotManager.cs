using UnityEngine;

public class ShotManager : MonoBehaviour
{
    [SerializeField] private GameObject shot;
    private Vector3 offset0 = new Vector3(3.51f, 1.02f, 3.76f);
    private Vector3 offset1 = new Vector3(-3.51f, 1.02f, 3.76f);
    private double timer = 0;
    [SerializeField] private double delay = 0.2;
    [SerializeField] private float energyCost = 50;
    [SerializeField] private float shotDamage = 300;

    private Shot scriptShot;
    private GameObject instantiateShot;
    
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (KeyManager.Shoot() & (timer >= delay) & (Variables.LeftEnergy() >= energyCost))
        {
            Variables.AddEnergy(energyCost * -1);

            doShoting(shot,transform.position + transform.rotation * offset0, transform.rotation,shotDamage,false,rb.velocity);
            doShoting(shot, transform.position + transform.rotation * offset1, transform.rotation, shotDamage, false, rb.velocity);
            timer = 0;
        }
    }

    void doShoting(GameObject _shot, Vector3 _position, Quaternion _rotation, float _damage, bool _damagePlayer, Vector3 _SummonVelocity) {

        instantiateShot = Instantiate(_shot, _position, _rotation);
        scriptShot = instantiateShot.gameObject.GetComponent<Shot>();

        scriptShot.SummonVelocity = _SummonVelocity;
        scriptShot.damage = _damage;
        scriptShot.damagePlayer = _damagePlayer;

        }
}
