using UnityEngine;

public class EnemyCounter : MonoBehaviour
{
    void Update()
    {
        // "Enemy" �±׸� ���� ��� ���� ������Ʈ�� �迭�� �����մϴ�.
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        // ���� ���� 20 �̻��̸� ���� ������ �����մϴ�.
        if (enemies.Length >= 20)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        // ���� ���� ������ ���⿡ �߰��ϼ���.
        Debug.Log("���� ����!"); // ���� ���� �޽����� ����մϴ�.
        // ���� ���� ȭ���� �����ְų� �ٸ� ���� ���� ������ �߰��ϼ���.
    }
}
