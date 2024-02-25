using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class TextTriggerScript : MonoBehaviour
{
    public GameObject uiObject;

    void Start()
    {
        uiObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Is this even being triggered?");
        if (collision.tag == "Player")
        {
            uiObject.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        uiObject.SetActive(false);
    }

}
