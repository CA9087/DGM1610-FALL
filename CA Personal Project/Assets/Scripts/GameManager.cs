using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    public GameObject[] astroidPrefabs;
    public GameObject enemyPrefab;
    public GameObject playerPrefab;
    private float spawnRange = 75.0f;
    private int rockCount;
    private int enemyCount;
    public int waveNumber = 1;
    public GameObject titleScreen;
    public GameObject gameOverScreen;
    public Camera startCamera;
    public bool isGameActive;
    private int playerCount;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerCount = GameObject.FindGameObjectsWithTag("Player").Length;

       
        if (isGameActive == true)
        {
            if (playerCount == 0)
        {
            GameOver();
        }
            enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
            if (enemyCount == 0) 
            {
                waveNumber++;
                SpawnWave(waveNumber);
            }        
        }
    
    }

    public void StartGame()
    {
        titleScreen.gameObject.SetActive(false);
        SpawnMap();
        waveNumber = 1;
        SpawnWave(waveNumber);
        startCamera.enabled = false;
        Instantiate(playerPrefab, new Vector3(0,0, -77), playerPrefab.transform.rotation);
        isGameActive = true;
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
        for (rockCount = 0; rockCount < 50; rockCount ++)
        {
        int astroidIndex = Random.Range(0, astroidPrefabs.Length);
        Instantiate(astroidPrefabs[astroidIndex], GenerateSpawnPosition(), astroidPrefabs[astroidIndex].transform.rotation);        
        }
    }

    void SpawnWave(int enemiesToSpawn)
    {
    for (int i = 0; i < enemiesToSpawn; i++)
    {
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
    }
    }

    public void GameOver()
    {
        gameOverScreen.gameObject.SetActive(true);
        isGameActive = false;
        startCamera.enabled = false;
    }

}