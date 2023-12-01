using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PGiga : MonoBehaviour
{

    // Start is called before the first frame update


    public Player PlayerJ;
    public Animator _animator;
    public PegaMoeda moedas;

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
        if (PlayerJ.chave > 0 && moedas.Coin > 20)
        {
            _animator.SetTrigger("Abrir");
            PlayerJ.chave--;
        }
    }
}
