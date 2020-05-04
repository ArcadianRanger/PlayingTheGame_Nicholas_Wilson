using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerUpPrefab;
    private GameObject player;
    private const float randRange = 9;
    public int waveNumber = 1;
    private int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        
        //SpawnEnemyWave(3);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if(enemyCount == 0)
        {
            SpawnEnemyWave(waveNumber++);
            Instantiate(powerUpPrefab, 
                GenSpawnPos(), 
                powerUpPrefab.transform.rotation);
        }
    }

    private Vector3 GenSpawnPos()
    {
        float spawnX = Random.Range(-randRange, randRange);
        float spawnZ = Random.Range(-randRange, randRange);
        Vector3 pos = new Vector3(spawnX, 0, spawnZ);

        return pos;
    }

    private void SpawnEnemyWave(int numEnemies)
    {
        for(int en = 0; en < numEnemies; en++)
        {
            Instantiate(enemyPrefab,
                GenSpawnPos(),
                enemyPrefab.transform.rotation);
        }
    }
}
