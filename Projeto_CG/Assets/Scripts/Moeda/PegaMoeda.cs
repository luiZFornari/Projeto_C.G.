using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PegaMoeda : MonoBehaviour
{
    private int Coin = 0;
    
    public TextMeshProUGUI MoedaTXT;


    private void OnTriggerEnter(Collider other){
        if(other.transform.tag=="Coin"){
            Coin++;
            Debug.Log(Coin);
            MoedaTXT.text = "Coin: "+ Coin.ToString();
            Destroy(other.gameObject);
        }
    }


}
