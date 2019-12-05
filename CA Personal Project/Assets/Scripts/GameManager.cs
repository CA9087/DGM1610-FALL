using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] astroidPrefabs;
    private float spawnRange = 50.0f;
    public int rockCount;
    // Start is called before the first frame update
    void Start()
    {
        SpawnMap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);  

        return randomPos;
    }

    //This will create the map at the beginning of the game (and potentially for every level if we get there)
    void SpawnMap()
    {
       
        for (rockCount = 0; rockCount < 20; rockCount ++)
        {
        int astroidIndex = Random.Range(0, astroidPrefabs.Length);
        Instantiate (astroidPrefabs[astroidIndex], GenerateSpawnPosition(), astroidPrefabs[astroidIndex].transform.rotation);        
        }
    }
}