using UnityEngine;

public class EnemyCounter : MonoBehaviour
{
    void Update()
    {
        // "Enemy" 태그를 가진 모든 게임 오브젝트를 배열에 저장합니다.
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        // 적의 수가 20 이상이면 게임 오버를 실행합니다.
        if (enemies.Length >= 20)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        // 게임 오버 로직을 여기에 추가하세요.
        Debug.Log("게임 오버!"); // 게임 오버 메시지를 출력합니다.
        // 게임 오버 화면을 보여주거나 다른 게임 종료 로직을 추가하세요.
    }
}
