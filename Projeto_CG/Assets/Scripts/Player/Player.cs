using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator _animator;
    public int life = 3;// Start is called before the first frame update

    public int chave = 0;

    public void TomaDano(int dano)
    {
        life -= dano;

        if (life == 0)
        {
            Respawn.respawn = true;
            life = 3;
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            _animator.SetTrigger("Atack");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Chave")
        {
            chave++;
            Destroy(other.gameObject);
        }
    }




}
