using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    //public GameObject Belt;
    public Transform endpoint;
    public float speed;
    public float stepsize = .2f;

    void OnTriggerStay(Collider other)
    {
        GameObject obj = other.gameObject;
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (transform.position.x >= stepsize)
        {
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }
        if (obj.tag == "belt1")
        {
            other.transform.position = Vector3.MoveTowards(other.transform.position, endpoint.position, speed * Time.deltaTime);
        }
    }

}
