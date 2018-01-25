using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{

    public Transform canvas;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canvas.gameObject.activeInHierarchy == false)
            {
                canvas.gameObject.SetActive(true);
            }
            else
            {
                canvas.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }
    public void LoadScene(int level)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(level);
    }
    public void doquit()
    {
        Debug.Log("SALIR");
        Application.Quit();
    }
}