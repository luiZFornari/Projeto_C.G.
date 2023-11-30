using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool respawn = false;
    public float threshold;

    // Update is called once per frame


    void FixedUpdate()
    {
        if (respawn)
        {
            transform.position = new Vector3(0f, 3.0f, 0f);
            respawn = false;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Water")
        {
            respawn = true;
        }

        if (other.transform.tag == "Void")
        {
            respawn = true;
        }
    }




}
