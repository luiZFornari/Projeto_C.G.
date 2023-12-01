using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Life : MonoBehaviour
{
    public TextMeshProUGUI LifeTxt;
    public Player PlayerTxt;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        LifeTxt.text = "Life: " + PlayerTxt.life;
    }
}
