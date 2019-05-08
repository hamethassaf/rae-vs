using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject objeto;

    // Start is called before the first frame update
   
    public void CambiarEscena(string nombre) {
        
        SceneManager.LoadScene(nombre);
    }

    public void Salir() {
        Application.Quit();

    }
}

