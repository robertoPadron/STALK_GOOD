using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLICKERING : MonoBehaviour {

    Light blueLight;
    public float minWaitTime;
    public float maxWaitTime;

    void Start()
    {
        blueLight = GetComponent<Light>();
        StartCoroutine(Flashing());
    }

    IEnumerator Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minWaitTime,maxWaitTime));
            blueLight.enabled = ! blueLight.enabled;
        }
    }
}