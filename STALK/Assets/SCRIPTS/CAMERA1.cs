using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMERA1 : MonoBehaviour {

    public List<Camera> Cam;
    int cameraIndex = 0;


    // Use this for initialization
    void Start ()
    {
        Cam[cameraIndex].enabled = true;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Cam[cameraIndex].enabled = false;
            cameraIndex--;
            if (cameraIndex < 0)
                cameraIndex = Cam.Count - 1;
            Cam[cameraIndex].enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Cam[cameraIndex].enabled = false;
            cameraIndex++;
            if (cameraIndex >= Cam.Count)
                cameraIndex = 0;
            Cam[cameraIndex].enabled = true;
        }
    }
    }
