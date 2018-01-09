using System.Collections;
using UnityEngine;

public class Scene : MonoBehaviour {

    public void LoadScene(int level)
    {
       UnityEngine.SceneManagement.SceneManager.LoadScene(level);
    }
}