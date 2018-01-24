using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {

    public Transform Canvas;

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }
    public void Pause()
        {
                if (Canvas.gameObject.activeInHierarchy == false)
                {
                    Canvas.gameObject.SetActive(true);
                }
            else
                {
                    Canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
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