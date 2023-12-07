using UnityEngine;
using UnityEngine.UI;

public class Combo : MonoBehaviour
{
    private int score = 0; // �ʱ� ���ھ� ��

    // Inspector â���� ���� ������ UI Text ����
    public Text scoreText;

    void Start()
    {
        // �ʱ� ���ھ ǥ��
        scoreText.text = score.ToString();
    }

    // ��� ���� �� ȣ��Ǵ� �Լ�
    public void UpdateScore()
    {
        score++; // ���ھ 1 ����
        scoreText.text = score.ToString(); // UI Text�� ���ھ� ǥ��
    }
}
