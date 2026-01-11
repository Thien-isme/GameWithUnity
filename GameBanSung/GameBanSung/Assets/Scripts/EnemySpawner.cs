using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 2.0f;
    public float spawnRadius = 6f;
    private float spawnTimer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnRate)
        {
            SpawnEnemy();
            spawnTimer = 0f;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, spawnRadius);
    }

    void SpawnEnemy()
    {
        // Điểm ngẫu nhiên TRÊN mép hình tròn bán kính spawnRadius
        Vector2 edgePos = Random.insideUnitCircle.normalized * spawnRadius;

        // Game 2D: mặt phẳng X–Y
        Vector3 spawnPos = new Vector3(edgePos.x, edgePos.y, 0f) + transform.position;

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }



}
