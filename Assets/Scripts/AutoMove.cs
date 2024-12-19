using NUnit.Framework;
using UnityEngine;

public class CharacterFollowWaypoints : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 2f;
    private int currentIndex = 0;

    void Start()
    {
        this.speed = Random.Range(1.8f, 2.6f);
    }

    void Update()
    {
        // float randomWalkSpeed = Random.Range(5f, 7f);
        if (waypoints == null || waypoints.Length == 0)
            return;

        // Move towards the current waypoint
        Transform target = waypoints[currentIndex];
        Vector3 direction = target.position - transform.position;

        // If character is close enough to the current waypoint, switch to the next one
        if (direction.magnitude < 0.1f)
        {
            if (currentIndex == waypoints.Length - 1) {
                Destroy(gameObject);
            }
            currentIndex = (currentIndex + 1) % waypoints.Length;
            transform.rotation = target.rotation;
        }
        else
        {
            // Move character along direction
            transform.position += direction.normalized * speed * Time.deltaTime;
        }
    }
}
