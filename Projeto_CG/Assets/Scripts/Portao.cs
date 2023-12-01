using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portao : MonoBehaviour
{
    public Player PlayerJ;
    public Animator _animator;

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
        if (PlayerJ.chave > 0)
        {
            _animator.SetTrigger("Abrir");
            PlayerJ.chave--;
        }
    }
}
