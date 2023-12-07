using System.Collections;
using UnityEngine;

public class RoundController : MonoBehaviour
{
    public GameObject enemyPrefab; // �� ������
    public Transform spawnPoint; // ���� ������ ���� ����
    public float timeBetweenEnemies = 2f; // �� ���� �����Ǵ� �ð� ����
    public int numberOfEnemies = 10; // ����� ���� ��
    public float timeBetweenRounds = 10f; // ���� �� �ð� ����
    private int enemiesSpawned = 0; // ������ ���� ��
    private bool isSpawning = false; // �� ���� ���θ� Ȯ���ϴ� ����

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
