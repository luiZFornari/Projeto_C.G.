using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    public string cena2; // Name of the scene to load

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ChangeScene();
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(cena2);
    }
}