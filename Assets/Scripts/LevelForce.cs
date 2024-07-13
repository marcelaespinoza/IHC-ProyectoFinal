using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class LevelForce: MonoBehaviour
{
    public enum Difficulty
    {
        Low,
        Medium,
        Hard
    }

    public Difficulty currentDifficulty = Difficulty.Low;
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
            case Difficulty.Low:
                currentDifficulty = Difficulty.Medium;
                break;
            case Difficulty.Medium:
                currentDifficulty = Difficulty.Hard;
                break;
            case Difficulty.Hard:
                currentDifficulty = Difficulty.Low;
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