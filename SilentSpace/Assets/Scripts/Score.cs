using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Variables varablesPlayer;
    [SerializeField] private GameObject player;
    [SerializeField] private Text scoreText;
    void Start() 
    {
        varablesPlayer = player.GetComponent<Variables>();
    }

    void Update()
    {
        scoreText.text = varablesPlayer.score.ToString();
    }
}
