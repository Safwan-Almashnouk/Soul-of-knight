using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour

{
    [SerializeField]
    private GameObject enemy;
    [SerializeField]
    private float enemyInterval;


    void Start()
    {
        StartCoroutine(spawnEnemy(enemyInterval, enemy));

    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(0, 5), Random.Range(1, 1), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
        
    } 
}

