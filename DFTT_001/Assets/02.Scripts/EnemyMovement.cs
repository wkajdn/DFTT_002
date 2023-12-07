using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] waypoints;
    public float moveSpeed = 5f;
    private int currentWaypointIndex = 0;

    void Update()
    {
        MoveOnWaypoints();
    }

    void MoveOnWaypoints()
    {
        if (waypoints.Length == 0)
        {
            return;
        }

        Vector3 targetPosition = waypoints[currentWaypointIndex].position;
        float movementStep = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, movementStep);

        if (transform.position == targetPosition)
        {
            currentWaypointIndex++;

            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
    }
}
