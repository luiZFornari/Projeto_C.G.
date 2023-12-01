using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PegaMoeda : MonoBehaviour
{
    public int Coin = 0;

    public TextMeshProUGUI MoedaTXT;


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin")
        {
            Coin++;
            MoedaTXT.text = "Coin: " + Coin.ToString();
            Destroy(other.gameObject);
        }


    }




}
