using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JA_SpawnManager : MonoBehaviour
{
    private JA_PlayerController JA_playerControllerScript;

    public GameObject[] objectPrefabs;
    private float spawnX = 3f;
    private float startDelay = 2f;
    private float repeatRate = 2f;
    private float randomY;
    private int randomIndex;

    void Start()
    {
        JA_playerControllerScript = FindObjectOfType<JA_PlayerController>();

        InvokeRepeating("spawnObstacle", startDelay, repeatRate);
    }

    public Vector3 RandomSpawnPosition()
    {
        randomY = Random.Range(-4, 4);
        return new Vector3(spawnX, randomY, 0);
    }

    private void spawnObstacle()
    {
        randomIndex = Random.Range(0, objectPrefabs.Length);
        if (!JA_playerControllerScript.gameOver)
        {
            Instantiate(objectPrefabs[randomIndex], RandomSpawnPosition(), objectPrefabs[randomIndex].transform.rotation);
        }
    }
}