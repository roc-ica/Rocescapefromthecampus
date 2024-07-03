using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geel : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "blokjegeel")
        {
            Destroy(gameObject);
        }
    }
}