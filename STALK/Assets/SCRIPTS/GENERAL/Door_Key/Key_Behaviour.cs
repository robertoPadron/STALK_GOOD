using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Behaviour : MonoBehaviour {
    public GameObject DOOR;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Character")
        {
            DOOR.gameObject.GetComponent<Door_Key>().Key = true;
            Destroy(this.gameObject);
        }
    }
}
