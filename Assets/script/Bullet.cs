using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 20;
    private Vector2 direction;
    private int totalDamage = 0;
    public int hasar;
    public void SetDirection(Vector2 dir)
    {
        direction = dir.normalized;
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Hasar: " + totalDamage / 2);  
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("Player"))
        {

            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                bullett bullett_ = collision.GetComponent<bullett>();

                
                totalDamage = 0; 

                switch (bullett_.uzuv)
                {
                    case bullett.mermi.head:
                        totalDamage += hasar*2;

                        break;

                    case bullett.mermi.torso:
                        totalDamage += hasar;
                        break;

                    case bullett.mermi.leg:
                        totalDamage += hasar/2;
                        break;
                }

                
                playerHealth.TakeDamage(totalDamage, "bullet");
                Debug.Log("Hasar: " + totalDamage);  
            }
        }

        
        Destroy(gameObject);
    }
}