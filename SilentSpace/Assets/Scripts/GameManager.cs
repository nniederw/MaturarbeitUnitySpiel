using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private static GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Time.timeScale = 1;

        if (KeyManager.GoQuit())
        {
            Application.Quit();
        }

        if (KeyManager.GoReplay())
        {
            DoReplay();
            Time.timeScale = 1;

        }

    }

    public static void  DoGameOver() {
        gameOver.SetActive(true);        
   }
    public static void DoReplay() 
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      
    }

}
