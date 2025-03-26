using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class moveEnemy1 : MonoBehaviour
{
    public float moveSpeed =1f; // Tốc độ di chuyển của đối tượng

    private Transform player; // Tham chiếu đến đối tượng Player

    float inttranform;

    void Start()
    {
        inttranform = Random.Range(0.1f, 0.5f);
        transform.localScale=new Vector3(inttranform, inttranform, inttranform);

        // Tìm đối tượng Player dựa trên tag
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null)
        {
            player = playerObject.transform;
        }
        else
        {
            Debug.LogError("Không tìm thấy đối tượng Player với tag 'Player'");
        }
    }

    void Update()
    {
        if (player != null)
        {
            // Tính toán hướng di chuyển
            Vector2 direction = (player.position - transform.position).normalized;
            // Di chuyển đối tượng theo hướng đó
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Enemy"|| collision.gameObject.tag == "Player")
        {
              Destroy(this.gameObject);
        }
    }
}
