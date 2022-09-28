using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject Obstaculo; 
    

    void Start()
    {
        StartCoroutine(SpawnObstacle());
    }
    private IEnumerator SpawnObstacle()
    {
        while (true)
        {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(Obstaculo, spawnPoints[randomIndex].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(2.5f);

        }
    }
}
