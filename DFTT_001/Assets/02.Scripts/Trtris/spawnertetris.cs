using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnertetris : MonoBehaviour
{
    public GameObject[] TetrisPrefabs; // Tetris 블록 프리팹 배열
    public Text comboText;
    private int comboCount = 0;
    public float comboResetTime = 3f; // 콤보 초기화 시간
    private float comboTimer = 0f; // 타이머
    private bool isComboActive = false; // 콤보 활성화 여부

    // Start is called before the first frame update
    void Start()
    {
        NewTetris(); // 게임 시작 시 블록 생성
    }

    public void IncreaseCombo()
    {
        if (!isComboActive) // 콤보가 활성화되지 않았을 때
        {
            isComboActive = true; // 콤보 활성화
            comboTimer = 0f; // 타이머 초기화
        }

        comboCount++;
        UpdateComboText();
    }

    public void ResetCombo()
    {
        isComboActive = false; // 콤보 비활성화
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
            // 랜덤한 Tetris 블록 생성
            GameObject randomTetrisPrefab = TetrisPrefabs[Random.Range(0, TetrisPrefabs.Length)];
            Instantiate(randomTetrisPrefab, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("TetrisPrefabs 배열에 할당된 Tetris 블록 프리팹이 없습니다!");
        }
    }

}
