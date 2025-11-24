using UnityEngine;

public class Tester : MonoBehaviour
{
    Pathfinding pathfinding;

    public float interval;
    float timer;

    private void Start()
    {
        pathfinding = GetComponent<Pathfinding>();
        timer = interval;
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if( timer <= 0 )
        {
            Vector2Int newObstacle = new Vector2Int(Random.Range(0, pathfinding.height - 1), Random.Range(0, pathfinding.width - 1));

            pathfinding.AddObstacle(newObstacle);
            Debug.Log($"Added an obstacle at {newObstacle}");
            timer = interval;
        }
    }
}
