using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnertetris : MonoBehaviour
{
    public GameObject[] TetrisPrefabs; // Tetris ��� ������ �迭
    public Text comboText;
    private int comboCount = 0;
    public float comboResetTime = 3f; // �޺� �ʱ�ȭ �ð�
    private float comboTimer = 0f; // Ÿ�̸�
    private bool isComboActive = false; // �޺� Ȱ��ȭ ����

    // Start is called before the first frame update
    void Start()
    {
        NewTetris(); // ���� ���� �� ��� ����
    }

    public void IncreaseCombo()
    {
        if (!isComboActive) // �޺��� Ȱ��ȭ���� �ʾ��� ��
        {
            isComboActive = true; // �޺� Ȱ��ȭ
            comboTimer = 0f; // Ÿ�̸� �ʱ�ȭ
        }

        comboCount++;
        UpdateComboText();
    }

    public void ResetCombo()
    {
        isComboActive = false; // �޺� ��Ȱ��ȭ
        comboCount = 0;
        UpdateComboText();
    }

    void UpdateComboText()
    {
        if (comboText != null)
        {
            comboText.text = "Combo: " + comboCount.ToString();
        }
    }

    void Update()
    {
        if (isComboActive)
        {
            comboTimer += Time.deltaTime;

            if (comboTimer >= comboResetTime)
            {
                ResetCombo();
            }
        }
    }

    public void NewTetris()
    {
        if (TetrisPrefabs.Length > 0)
        {
            // ������ Tetris ��� ����
            GameObject randomTetrisPrefab = TetrisPrefabs[Random.Range(0, TetrisPrefabs.Length)];
            Instantiate(randomTetrisPrefab, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("TetrisPrefabs �迭�� �Ҵ�� Tetris ��� �������� �����ϴ�!");
        }
    }

}
