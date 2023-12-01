using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnBtnIniciar()
    {
        SceneManager.LoadScene(1);
    }

    public void OnBtnSair()
    {
        Application.Quit();
    }
}
