using System.Collections;
using UnityEngine;

public class RoundController : MonoBehaviour
{
    public GameObject enemyPrefab; // 적 프리팹
    public Transform spawnPoint; // 적이 생성될 스폰 지점
    public float timeBetweenEnemies = 2f; // 각 적이 생성되는 시간 간격
    public int numberOfEnemies = 10; // 라운드당 적의 수
    public float timeBetweenRounds = 10f; // 라운드 간 시간 간격
    private int enemiesSpawned = 0; // 생성된 적의 수
    private bool isSpawning = false; // 적 생성 여부를 확인하는 변수

    void StartRound()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        isSpawning = true;

        while (enemiesSpawned < numberOfEnemies)
        {
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            enemiesSpawned++;

            yield return new WaitForSeconds(timeBetweenEnemies);
        }

        yield return new WaitForSeconds(timeBetweenRounds);
        enemiesSpawned = 0;
        isSpawning = false;
    }

    void Update()
    {
        if (!isSpawning)
        {
            StartRound();
        }
    }
}
