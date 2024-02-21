using UnityEngine;

public class PointsSpawn : MonoBehaviour
{
    private float randomTimer;
    [SerializeField] private GameObject[] points;

    void Awake()
    {
        randomTimer = Random.Range(0.3f, 1.3f);
    }

    void Update()
    {
        randomTimer -= Time.deltaTime;

        if (randomTimer <= 0)
        {
            Instantiate(points[Random.Range(0, 2)], gameObject.transform);
            randomTimer = Random.Range(0.3f, 1.3f);
        }
    }
}
