using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class LevelVelocity: MonoBehaviour
{
    public enum Difficulty
    {
        Slow,
        Normal,
        Fast
    }

    public Difficulty currentDifficulty = Difficulty.Slow;
    public GameObject difficultyTextObject;

    private TMP_Text difficultyText;

    void Start()
    {
        if (difficultyTextObject != null)
        {
            difficultyText = difficultyTextObject.GetComponent<TMP_Text>();
            UpdateDifficultyText();
        }
        else
        {
            Debug.LogError("Difficulty Text Object is not assigned.");
        }
    }

    // Este método se llamará cuando se presione el botón
    public void OnButtonPressed()
    {
        // Cambia al siguiente valor de dificultad
        switch (currentDifficulty)
        {
            case Difficulty.Slow:
                currentDifficulty = Difficulty.Normal;
                break;
            case Difficulty.Normal:
                currentDifficulty = Difficulty.Fast;
                break;
            case Difficulty.Fast:
                currentDifficulty = Difficulty.Slow;
                break;
        }

        // Actualiza el texto visual
        UpdateDifficultyText();
    }

    private void UpdateDifficultyText()
    {
        if (difficultyText != null)
        {
            difficultyText.text = currentDifficulty.ToString();
        }
    }
}