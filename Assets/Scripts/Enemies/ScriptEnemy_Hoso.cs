using System;
using UnityEngine;

public class ScriptEnemy_Hoso : MonoBehaviour
{
    private string[] word;
    private int index;
    private float movement;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
         {
             rb = GetComponent<Rigidbody2D>();
             word = new String[] {"o", "s", "o"};
             index = 0;
             movement = -2f;
         }
     
         // Update is called once per frame
         void Update()
         {
             rb.velocity = new Vector2(movement,rb.velocity.y);
             // Check if any key is pressed
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
     
         private void OnCollisionEnter2D(Collision2D other)
         {
             Destroy(gameObject);
         }
}
