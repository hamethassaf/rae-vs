using System;
using System.Collections;
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEditorInternal.VersionControl;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public HealthScript vidaCanvas;

    public int numVida;

    public AudioSource audio;

    public Boolean atack;

    private Animator anim;

    private Boolean state;

    public AudioClip UhSound;

    public AudioClip AttackSound;

    AudioSource fuenteAudio;
    
    
    // Start is called before the first frame update
    void Start()
    {
        numVida = 3;
        audio = FindObjectOfType<AudioSource>();
        vidaCanvas = FindObjectOfType<HealthScript>();
        anim = GetComponent<Animator>();
        state = true;

        fuenteAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (numVida == 0)
        {
            GameOver.show();
            Debug.Log("Game over");
            state = false;
            anim.SetBool("dead",true);
            
        }

        if (numVida == 1)
        {
            anim.SetBool("tired",true);
        }

        if (Input.anyKey)
        {
            anim.SetBool("atack",true);
            fuenteAudio.clip = AttackSound;
            fuenteAudio.Play();
            StartCoroutine(goBack());
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy") && state)
        {
            fuenteAudio.clip = UhSound;
            fuenteAudio.Play();
            numVida--;
            vidaCanvas.cambioVida(numVida);
            Destroy(other.gameObject);
            Debug.Log("Enemigo");
        }
    }

    IEnumerator goBack()
    {
        yield return new WaitForSeconds(0.5f);
        anim.SetBool("atack",false);
    }
}
