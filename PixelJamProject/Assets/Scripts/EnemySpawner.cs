using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [System.Serializable]
    public class Wave
    { 
        public string waveName;
        public List<EnemyGroup> enemyGroups;
        public int waveQuota;
        public float interval;
        public int spawnCount;
    }


    [System.Serializable]
    public class EnemyGroup
    {
        public string enemyName;
        public int enemyCount;
        public int spawnCount;
        public GameObject enemyPrefab;
    }

    public List<Wave> waves;
    public int currentWaveCount;

    [Header("Spawner Attributes")]
    float timer;
    public float waveInterval;

        IEnumerator BeginNextWave()
    {
        yield return WaitForSeconds(waveInterval);

        if(currentWaveCount < waves.Count - 1)
        {
            currentWaveCount++;
            CalculateWaveQuota();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        CalculateWaveQuota();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CalculateWaveQuota()
    {
        int currentQuota = 0;
        foreach(var enemyGroup in waves[currentWaveCount].enemyGroups)
        {
            currentQuota += enemyGroup.enemyCount;
        }
        waves[currentWaveCount].waveQuota = currentQuota;
    }

    void SpawnEnemies()
    {
        if (waves[currentWaveCount].spawnCount < waves[currentWaveCount].waveQuota) { 
        
            foreach (var enemyGroup in waves[currentWaveCount].enemyGroups)
            {
                if(enemyGroup.spawnCount < enemyGroup.enemyCount) {
                    Vector2 spawnposition = new Vector2(Random.Range(-10f, 10f), Random.Range(-10f, 10f));
                    Instantiate(enemyGroup.enemyPrefab, spawnposition, Quaternion.identity);
                    enemyGroup.spawnCount++;
                    waves[currentWaveCount].spawnCount++;
                }
            }
        }
    }
}
