using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // This code will execute when another 2D collider enters this trigger
        Debug.Log("Trigger entered by: " + other.gameObject.name);

        // You can use 'other' to access the GameObject that entered the trigger
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the trigger!");
            // Perform actions specific to the player entering
        }
        Destroy(gameObject);
    }    
}
