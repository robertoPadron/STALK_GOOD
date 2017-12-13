using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROTATION : MonoBehaviour {
    public  float RotateSpeed;
    public  float Timer = 20f;
    public  float SecondTimer;
    public Collider Player;
    public bool Detected;
    public Transform PlayerPosition;
    public GameObject Bullet;
    public float Charge = 5f;
    float SecondCharge;

    // Use this for initialization
    void Start () {
        SecondTimer = Timer;
        SecondCharge = Charge;
	}
	
	// Update is called once per frame
	void Update () {
        DetectionRotation();


	}

    void OnTriggerEnter(Collider col)
    {
        if (col == Player)
        {
            Detected = true;
 
 
          
        }
    }

    void OnTriggerExit(Collider col)
    {
        Detected = false;
        Charge = SecondCharge;
    }



    void DetectionRotation()
    {
        if (Detected == false || Player == null) {
            this.transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
            Timer = Timer - 1 * Time.deltaTime;
        }

        if (Timer <= 0)
        {
            RotateSpeed = -RotateSpeed;
            Timer = SecondTimer;
        }

        if (Detected == true )
        {
            transform.LookAt(PlayerPosition);
            Charge = Charge - 1 * Time.deltaTime;

            if (Charge <= 0)
            {
                Instantiate(Bullet, transform.position, transform.rotation);
                Charge = SecondCharge;
            }

        }
    }

}
