using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMERA1 : MonoBehaviour
{

    public List<Camera> Cam;
    int cameraIndex = 0;
    Camera currentCamera;

    public float cameraRange = 15f;

    // Use this for initialization
    void Start()
    {
        currentCamera = Cam[cameraIndex];
    }

    // Update is called once per frame
    void Update()
    {

        //Saco camaras en rango
        List<Camera> camerasInRange = new List<Camera>();
        foreach (Camera c in Cam)
        {
            if (Vector3.Distance(c.transform.position, transform.position) < cameraRange)
            {
                camerasInRange.Add(c);
            }
        }

        //Si la camara actual no esta en rango, cojo la mas cercana y la hago actual
        if (!camerasInRange.Contains(currentCamera))
        {
            currentCamera.enabled = false;
            float dist = float.MaxValue;
            foreach (Camera c in camerasInRange)
            {
                if (Vector3.Distance(c.transform.position, transform.position) < dist)
                {
                    dist = Vector3.Distance(c.transform.position, transform.position);
                    currentCamera = c;
                }
            }
        }
        currentCamera.enabled = true;
        cameraIndex = camerasInRange.IndexOf(currentCamera);


        if (Input.GetKeyDown(KeyCode.Q))
        {
            currentCamera.enabled = false;
            cameraIndex--;
            if (cameraIndex < 0)
                cameraIndex = camerasInRange.Count - 1;
            currentCamera = camerasInRange[cameraIndex];
            currentCamera.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            currentCamera.enabled = false;
            cameraIndex++;
            if (cameraIndex >= camerasInRange.Count)
                cameraIndex = 0;
            currentCamera = camerasInRange[cameraIndex];
            currentCamera.enabled = true;
        }
    }
}
