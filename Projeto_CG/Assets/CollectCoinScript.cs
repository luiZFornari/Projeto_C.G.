using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoinScript : MonoBehaviour
{
    public GameObject coinPrefab;

    void Start (){

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other){
        if(other.name =="NestedParentArmature")
        {
            //Add 1 to points.
            Destroy(gameObject);
        }
    }
}
