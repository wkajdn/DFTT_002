using UnityEngine;

public class ComboTowerManager : MonoBehaviour
{
    public GameObject towerPrefab; // ��ž ������
    public Transform[] towerSpawnPoints; // ��ž�� ��ġ�� ��ġ �迭

    private int comboCount = 0; // �޺� ��

    // �޺��� ������Ű�� �Լ�
    public void IncreaseCombo()
    {
        comboCount++;
        // �޺� ���� ���� ��ž ��ġ �Լ� ȣ��
        BuildTowers();
    }

    // ��ž�� ��ġ�ϴ� �Լ�
    void BuildTowers()
    {
        Debug.Log("Combo Count: " + comboCount); // ����� �� �߰�
                                                 // �޺��� 1 �̻��� �� ��ž ��ġ
        if (comboCount > 0 && comboCount <= towerSpawnPoints.Length)
        {
            // �޺� ���� ���� �ش� ��ġ�� ��ž�� ����
            Instantiate(towerPrefab, towerSpawnPoints[comboCount - 1].position, Quaternion.identity);
        }
    }

}
