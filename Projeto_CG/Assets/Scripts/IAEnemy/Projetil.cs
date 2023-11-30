using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Projetil : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {

        Destroy(gameObject);

        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Player>().TomaDano(1);
        }


    }

}
