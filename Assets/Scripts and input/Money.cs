using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "Player")
        {
            Destroy(gameObject);

        }


    }
}
