using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Movement : MonoBehaviour {

    bool In = false;

    public Collider Character;

    [SerializeField]
    float MovementSpeed;

    [SerializeField]
    Vector3 StartPosition;

    [SerializeField]
    Vector3 EndPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    public void PlatformMovement()
    {
        if (In == true)
        {
            this.transform.Translate(Vector3.up * MovementSpeed);
        }
        if (this.transform.position == EndPosition)
        {
            
        }

    }
    public void OnTriggerStay(Collider other)
    {
        if (other == Character)
        {
            In = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other == Character)
        {
            In = false;
        }
    }
}
