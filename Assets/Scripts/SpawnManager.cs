using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private GameObject player;
    private const float randRange = 9;

    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.Find("Player");
        Instantiate(enemyPrefab,
            player.transform.position + GenSpawnPos(), 
            enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GenSpawnPos()
    {
        float spawnX = Random.Range(-randRange, randRange);
        float spawnZ = Random.Range(-randRange, randRange);
        Vector3 pos = new Vector3(spawnX, 0, spawnZ);

        return pos;
    }
}
