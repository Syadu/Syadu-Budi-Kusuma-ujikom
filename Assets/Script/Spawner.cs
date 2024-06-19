using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnerPoint;
    [SerializeField] private GameObject[] enemy;
    private float spawnInterval = 2f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            SpawnerWork();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    public void SpawnerWork()
    {
        int randomEnemy = Random.Range(0, enemy.Length);
        int randomPoint = Random.Range(0, spawnerPoint.Length);

        Vector3 spawnPosition = new Vector3(spawnerPoint[randomPoint].transform.position.x, spawnerPoint[randomPoint].transform.position.y, spawnerPoint[randomPoint].transform.position.z);
        Instantiate(enemy[randomEnemy], spawnPosition, Quaternion.identity);
    }
}
