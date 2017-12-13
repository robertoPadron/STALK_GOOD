using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour {
    bool Contact = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
        Rotation();
        if (Contact == true)
        {
            Timer();
        }
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == true)
        {
            MovementSpeed = 0;
            RotationSpeed = 18;
            CauntDown = 10;
            Contact = true;
        }
    }



    public float RotationSpeed = 18;
    void Rotation()
    {
        this.transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
    }



    public float CauntDown = 10;
    void Timer()
    {
        CauntDown = CauntDown - Time.deltaTime;
        if (CauntDown <= 0)
        {
            Contact = false;
            RotationSpeed = 0;
            MovementSpeed = 5;
        }
    }





    public float MovementSpeed = 5;
    void Movement()
    {
        this.transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);
        
    }
}
