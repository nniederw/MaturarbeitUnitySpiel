using UnityEngine;
public class Asteroid : MonoBehaviour
{
    private bool b = true;
    [SerializeField] private GameObject player;

    [SerializeField] private GameObject destroyedAstroid;
    [SerializeField] private float health = 1000;
    [SerializeField] private GameObject parAsteroid;
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Shot")
        {
            health -= 334;
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Player")
        {
            health = 0;
            player.GetComponent<Variables>().health -= 200;
        }
    }
    void Start() {
        player = GameObject.Find("player");
    }
    void Update()
    {
        if ((health <= 0) & b)
        {
            GameObject dast;
            dast = Instantiate(destroyedAstroid, parAsteroid.transform);
            dast.transform.position = transform.position;
            dast.transform.rotation = transform.rotation;
            dast.transform.localScale = transform.localScale;

            player.GetComponent<Variables>().score += 1;
            
            Destroy(gameObject);           
        }
    }
}