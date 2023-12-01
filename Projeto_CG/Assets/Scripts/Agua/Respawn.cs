using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public static bool respawn = false;
    public Vector3 checkpoint = new Vector3(-37.5600014f, 1.48000002f, 5.8499999f);

    void FixedUpdate()
    {
        if (respawn)
        {
            transform.position = checkpoint;
            respawn = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Water"))
        {
            transform.position = checkpoint;
        }

        if (other.transform.CompareTag("Void"))
        {

            transform.position = checkpoint;
        }

        if (other.transform.CompareTag("CheckPoint"))
        {
            checkpoint = new Vector3(113, 9, -310);
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.CompareTag("Water"))
        {
            transform.position = checkpoint;
        }

        if (other.transform.CompareTag("Void"))
        {
            transform.position = checkpoint;
        }
    }



}
