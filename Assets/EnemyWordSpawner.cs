using System.Collections;
using UnityEngine;

public class EnemyWordSpawner : MonoBehaviour
{

    public EnemyObject[] enemies;

    public GameObject word;

    public float randomTime;

    private int randomEnemy;

    private Vector3 scale;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnNewWord());
    }

    private IEnumerator spawnNewWord()
    {
        while (true)
        {
            yield return new WaitForSeconds(randomTime);
            randomEnemy = Random.Range(0,enemies.Length);
            var newWord = Instantiate(word, transform.position, Quaternion.identity);
            newWord.GetComponent<EnemyWord>().myEnemy = enemies[randomEnemy];
            newWord.GetComponent<Transform>().localScale = new Vector3(3f,3f,3f);
        }
    }
}
