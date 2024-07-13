using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalDetectorr : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int goalCount = 0; // Counter for the goals
    private Vector3 ballInitialPosition; // Initial position of the ball
    private Rigidbody ballRigidbody;
    private Coroutine resetCoroutine;

    void Start()
    {
        // Find the ball object and store its initial position and Rigidbody
        GameObject ball = GameObject.FindGameObjectWithTag("Ball");
        if (ball != null)
        {
            ballInitialPosition = ball.transform.position;
            ballRigidbody = ball.GetComponent<Rigidbody>();
            StartResetCoroutine();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the ball
        if (other.CompareTag("Ball"))
        {
            // Increment the goal count
            goalCount++;
            Debug.Log("Goal! Total Goals: " + goalCount);
            UpdateScoreText();

            // Reset the ball's position and restart the coroutine
            ResetBallPosition(other.gameObject);
            StartResetCoroutine();
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Goals: " + goalCount;
    }

    void ResetBallPosition(GameObject ball)
    {
        // Reset the ball's position and stop its movement
        ball.transform.position = ballInitialPosition;
        if (ballRigidbody != null)
        {
            ballRigidbody.velocity = Vector3.zero;
            ballRigidbody.angularVelocity = Vector3.zero;
        }
    }

    void StartResetCoroutine()
    {
        // Stop the previous coroutine if it exists
        if (resetCoroutine != null)
        {
            StopCoroutine(resetCoroutine);
        }
        // Start a new coroutine to reset the ball every 10 seconds
        resetCoroutine = StartCoroutine(ResetBallEvery10Seconds());
    }

    IEnumerator ResetBallEvery10Seconds()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            GameObject ball = GameObject.FindGameObjectWithTag("Ball");
            if (ball != null)
            {
                ResetBallPosition(ball);
            }
        }
    }
}
