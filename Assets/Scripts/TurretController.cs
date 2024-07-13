using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    public GameObject ball;
    private Vector3 fixedShootPosition = new Vector3(0, 0.845f, 43.525f);
    private Quaternion fixedShootRotation = Quaternion.Euler(0, 0, 0);
    private float shootForce;
    private float interval;
    private float angle = 0.11f;
    private Vector3[] directions;

    void Start()
    {
        directions = new Vector3[]
        {
            new Vector3(0, 0, 1), // Center
            new Vector3(0, angle, 1), // Top
            new Vector3(0, -angle, 1), // Bottom            
            new Vector3(-angle, 0, 1), // Left
            new Vector3(angle, 0, 1), // Right
            new Vector3(-angle, angle, 1), // Top-Left
            new Vector3(angle, angle, 1), // Top-Right
            new Vector3(-angle, -angle, 1), // Bottom-Left
            new Vector3(angle, -angle, 1) // Bottom-Right
        };

        // Optionally normalize the directions if they are unit vectors
        for (int i = 0; i < directions.Length; i++)
        {
            directions[i] = directions[i].normalized;
        }
    }

    public void SetShootingParameters(float interval, float shootForce)
    {
        this.interval = interval;
        this.shootForce = shootForce;
    }

    public IEnumerator ShootAndCheckRoutine()
    {
        MoveBallToPoint();
        yield return new WaitForSeconds(1f);
        ball.transform.position = fixedShootPosition;
        ball.transform.rotation = fixedShootRotation;
        yield return new WaitForFixedUpdate();
        FireBall();
    }

    private void MoveBallToPoint()
    {
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.isKinematic = true;
        ball.transform.position = fixedShootPosition;
        ball.transform.rotation = fixedShootRotation;  
        rb.isKinematic = false;      
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        Debug.Log("Ball moved to shoot point: " + ball.transform.position);
    }

    private void FireBall()
    {
        Vector3 shootDirection = directions[Random.Range(0, directions.Length)];
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.AddForce(shootDirection * shootForce, ForceMode.Impulse);
        Debug.Log("Shooting ball from position: " + ball.transform.position + " in direction: " + shootDirection);
    }
}