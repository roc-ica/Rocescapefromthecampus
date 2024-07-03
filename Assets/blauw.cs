using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blauw : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "blokjeblauw")
        {
            Destroy(gameObject);
        }
    }
}