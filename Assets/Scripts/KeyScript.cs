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

            this.gameObject.SetActive(false);
        }
    }
}
