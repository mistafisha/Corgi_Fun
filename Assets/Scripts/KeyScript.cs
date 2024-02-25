using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public GameObject gateCollider;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {   
            //disabling 2D Box Collider on invisible gate
            Debug.Log("Suit Picked Up");
            gateCollider.GetComponent<BoxCollider2D>().enabled = false;

            Destroy(gameObject);
            DestroyDude();
        }
    }

    void DestroyDude()
    {
        // Find the GameObject named "dude"
        GameObject dude = GameObject.Find("Dude");

        // Check if the GameObject exists
        if (dude != null)
        {
            // Destroy the GameObject named "dude"
            Destroy(dude);
        }
        else
        {
            // Optional: Log a message if "dude" was not found
            Debug.Log("GameObject named 'dude' was not found in the scene.");
        }
    }
}
