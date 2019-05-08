using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWord : MonoBehaviour
{
    public EnemyObject myEnemy;

    private string[] word;
    private Sprite[] sprites;
    private float speed;

    private SpriteRenderer sr;
    private int i;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        word = myEnemy.word;
        sprites = myEnemy.sprites;
        speed = myEnemy.speed;
        sr = GetComponent<SpriteRenderer>();
        StartCoroutine(animate());
        i = 0;
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (Input.anyKeyDown)
        {
            // Check if the next key in the code is pressed
            if (Input.GetKeyDown(word[index]))
            {
                // Add 1 to index to check the next key in the code
                index++;
            }
            // Wrong key entered, we reset code typing
            else
            {
                index = 0;
            }
     
            // If index reaches the length of the cheatCode string, 
            // the entire code was correctly entered
            if (index == word.Length)
            {
                // Cheat code successfully inputted!
                Destroy(gameObject);
            }
        }
    }

    IEnumerator animate()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            sr.sprite = sprites[i];
            i++;
            if (i > sprites.Length-1)
            {
                i = 0;
            }    
        }
    }
}
