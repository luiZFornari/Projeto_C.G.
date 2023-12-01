using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string cena2; // Name of the scene to load
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MudaCena();
        }
    }

    public void MudaCena()
    {
        SceneManager.LoadScene(cena2);
    }
}
