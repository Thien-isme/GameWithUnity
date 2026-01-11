using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    private Transform playerTranform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player == null)
        {
            player = FindObjectOfType<GameObject>();
        }

        if (player != null)
        {
            playerTranform = player.transform;
        }
        else
        {
            Debug.LogError("Player object not found in the scene.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTranform != null)
        {
            Vector3 direction = (playerTranform.position - transform.position).normalized;
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.gameObject.SetActive(false);
        }

        if (collision.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            collision.gameObject.SetActive(false);
        }

    }
}
