using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    public GameObject winScreen;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "End")
        {
            winScreen.SetActive(true);
        }
    }
}