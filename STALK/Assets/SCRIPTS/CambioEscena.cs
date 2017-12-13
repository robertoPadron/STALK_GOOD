﻿using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour {

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Character")
        {
            SceneManager.LoadScene("MENU");
        }
    }
}