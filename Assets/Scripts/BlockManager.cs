using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlockManager : MonoBehaviour
{
    public TurretController turretController;
    public TextMeshProUGUI scoreText;
    public float interval = 2.0f;
    public float shootForce = 10f;

    private int goalCount = 0;
    private int blockCount = 0;
    private float countdown;
    private bool goalScored = false;  

    void Start()
    {
        countdown = interval - 0.1f;
        turretController.SetShootingParameters(interval, shootForce);
        StartCoroutine(ShootRoutine());
    }

    IEnumerator ShootRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(interval);
            countdown = interval - 0.1f;
            goalScored = false;
            
            yield return StartCoroutine(turretController.ShootAndCheckRoutine());
        }
    }

    public void ScoreGoal()
    {
        goalScored = true;
        goalCount++;
        UpdateScoreText();
    }

    public void BlockPenalty()
    {
        blockCount++;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Goals: " + goalCount + " Blocks: " + blockCount;
    }
}