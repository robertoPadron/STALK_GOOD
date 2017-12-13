using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour {


    public float moveSpeed = 3.0f;
    public float rotationSpeed = 90.0f;

	
	// Update is called once per frame
	void Update () {

        float rotateTank = Input.GetAxis("Horizontal");
        float moveTank = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().velocity = transform.forward * moveSpeed * moveTank;

        transform.Rotate(Vector3.up * rotationSpeed * rotateTank * Time.deltaTime);
    }
}
