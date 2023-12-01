using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPause : MonoBehaviour
{
    // Start is called before the first frame update

    public Canvas canvas = null;
    private bool paused = false;

    void Start()
    {
        pause(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            pause(!paused);
    }


    public void pause(bool estado)
    {
        if (canvas == null)
            return;

        if (estado == true)
        {
            Cursor.lockState = CursorLockMode.None;
            paused = true;
            canvas.rootCanvas.enabled = true;
            Time.timeScale = 0f;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            paused = false;
            canvas.rootCanvas.enabled = false;
            Time.timeScale = 1f;
        }
    }
    public void OnBtnContinuar()
    {
        pause(false);
    }

    public void OnBtnMenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }

    public void OnBtnSair()
    {
        Application.Quit();
    }
}
