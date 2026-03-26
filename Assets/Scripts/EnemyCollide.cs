using UnityEngine;

public class EnemyCollide : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Test");
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player touched the enemy.");
        }
    }
}
