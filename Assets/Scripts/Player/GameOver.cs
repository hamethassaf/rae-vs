using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverText;

    public static GameObject GameOverStatic;
    // Start is called before the first frame update
    void Start()
    {
        GameOver.GameOverStatic = GameOverText;
        GameOver.GameOverStatic.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void show()
    {
        GameOver.GameOverStatic.gameObject.SetActive(true);
    }
}
