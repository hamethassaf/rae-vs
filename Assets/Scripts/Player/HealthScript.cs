using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public Sprite[] vidas;
    // Start is called before the first frame update
    void Start()
    {
        cambioVida(3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cambioVida(int pos)
    {
        this.GetComponent<Image>().sprite = vidas[pos];
    }
}
