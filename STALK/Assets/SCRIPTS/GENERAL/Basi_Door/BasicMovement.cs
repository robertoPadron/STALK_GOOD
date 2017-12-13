using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour {
    public float MovementSpeed;
    public bool Arrived;
    public float Cooldown;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
	}


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Character")
        {
            Arrived = true;
        }
    }

    void Movement()
    {

        if (Arrived == true)
        {
            this.transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);
            Cooldown = Cooldown - 1 * Time.deltaTime;
            if (Cooldown <= 0)
            {
                Arrived = false;
            }
        }
    }
}
