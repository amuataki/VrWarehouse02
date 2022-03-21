using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    //public GameObject Belt;
    public Transform endpoint;
    public float speed;

    void OnTriggerStay(Collider other)
    {
        GameObject obj = other.gameObject;
        if (obj.tag == "belt1")
        {
            other.transform.position = Vector3.MoveTowards(other.transform.position, endpoint.position, speed * Time.deltaTime);
        }
    }

}
