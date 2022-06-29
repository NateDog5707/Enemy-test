using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyOnePrefab;
    [SerializeField] private GameObject enemyTwoPrefab;

    [SerializeField] private float enemyOneInterval = 0.5f;
    [SerializeField] private float enemyTwoInterval = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        spawnEnemy(enemyOneInterval, enemyOnePrefab);
        spawnEnemy(enemyTwoInterval, enemyTwoPrefab);
    }


    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-1f,1f), Random.Range(-1f, 1f), 0), Quaternion.identity);
    }


}
