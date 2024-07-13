using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    // Variables que deseas compartir entre escenas
    public float intervalValue;
    public float difficultyValue;

    private void Awake()
    {
        // Singleton pattern to ensure only one instance of DataManager exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetValuesFromTexts(TMP_Text intervalText, TMP_Text difficultyText)
    {
        intervalValue = ParseTextToFloat(intervalText.text);
        difficultyValue = ParseTextToFloat(difficultyText.text);
    }

    private float ParseTextToFloat(string text)
    {
        switch (text)
        {
            case "Low":
                return 6f;
            case "Medium":
                return 9f;
            case "Hard":
                return 12f;
            case "Slow":
                return 6f;
            case "Normal":
                return 4.5f;
            case "Fast":
                return 3f;
            default:
                Debug.LogWarning("Unrecognized text: " + text);
                return 0f;
        }
    }
}
