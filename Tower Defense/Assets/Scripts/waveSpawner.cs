using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

	

public class waveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public float timeBetweenWave = 5f;
    public float countdown = 5f;
    private int waveIndex = 1;
    public Transform EnemySpawnPoint;
    public float WaitTime = 0.5f;
    public Text CountDownTimer;

    public void Update()
    {
        if(countdown < 0)
        {
           StartCoroutine(SpawnWave());
            countdown = timeBetweenWave;
        }

        countdown -= Time.deltaTime;

        CountDownTimer.text = Mathf.Round(countdown).ToString();
    }

  IEnumerator SpawnWave()
    {
        waveIndex++;

        for (int i = 0; i < waveIndex; i++)
        {
            EnemySpawn();
            yield return new WaitForSeconds(WaitTime);
            
        }
        
        Debug.Log("wave spawn"); 
    }

    public void EnemySpawn()
    {
        Instantiate(enemyPrefab, EnemySpawnPoint.position, EnemySpawnPoint.rotation);
    }


}
