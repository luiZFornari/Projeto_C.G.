using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaAbrir : MonoBehaviour
{
    public Animator _animator;

    private bool _colidindo;

    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _colidindo)
        {
                _animator.SetTrigger("Abrir");
            
        }
    }


    void OnTriggerEnter(Collider _col)
    {
        if (_col.gameObject.CompareTag("Player"))
        {
            _colidindo = true;
        }
    }

   
}
