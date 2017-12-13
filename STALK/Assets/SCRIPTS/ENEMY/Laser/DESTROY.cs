using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DESTROY : MonoBehaviour {
    public GameObject Player;
    public float MovementSpeed;
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 5);
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime); 
	}
    void OnTriggerEnter(Collider col)
    {
      
        if (col.gameObject.tag == "Character")
        {
            
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
        
    }
}
