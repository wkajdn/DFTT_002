using UnityEngine;

public class ComboTowerManager : MonoBehaviour
{
    public GameObject towerPrefab; // 포탑 프리팹
    public Transform[] towerSpawnPoints; // 포탑이 설치될 위치 배열

    private int comboCount = 0; // 콤보 수

    // 콤보를 증가시키는 함수
    public void IncreaseCombo()
    {
        comboCount++;
        // 콤보 수에 따라 포탑 설치 함수 호출
        BuildTowers();
    }

    // 포탑을 설치하는 함수
    void BuildTowers()
    {
        Debug.Log("Combo Count: " + comboCount); // 디버그 문 추가
                                                 // 콤보가 1 이상일 때 포탑 설치
        if (comboCount > 0 && comboCount <= towerSpawnPoints.Length)
        {
            // 콤보 수에 따라 해당 위치에 포탑을 생성
            Instantiate(towerPrefab, towerSpawnPoints[comboCount - 1].position, Quaternion.identity);
        }
    }

}
