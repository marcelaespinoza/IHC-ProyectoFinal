using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalDetector : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private BlockManager blockManager;

    void Start()
    {
        blockManager = FindObjectOfType<BlockManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the ball
        if (other.CompareTag("Ball"))
        {
            blockManager.ScoreGoal();
        }
    }
}
