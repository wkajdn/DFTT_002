using UnityEngine;
using UnityEngine.UI;

public class Combo : MonoBehaviour
{
    private int score = 0; // 초기 스코어 값

    // Inspector 창에서 직접 연결할 UI Text 변수
    public Text scoreText;

    void Start()
    {
        // 초기 스코어를 표시
        scoreText.text = score.ToString();
    }

    // 블록 삭제 시 호출되는 함수
    public void UpdateScore()
    {
        score++; // 스코어를 1 증가
        scoreText.text = score.ToString(); // UI Text에 스코어 표시
    }
}
