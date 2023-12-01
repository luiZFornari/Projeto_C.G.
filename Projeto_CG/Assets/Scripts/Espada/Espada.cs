using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "EnemyMago")
        {
            IAMago iA = other.GetComponent<IAMago>();
            iA.TakeDamage(1);
        }

        if (other.gameObject.tag == "EnemySlime")
        {
            IASlime iA = other.GetComponent<IASlime>();
            iA.TakeDamage(1);
        }
    }

}
