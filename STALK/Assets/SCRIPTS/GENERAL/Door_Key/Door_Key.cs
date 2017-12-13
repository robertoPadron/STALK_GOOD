using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Key : MonoBehaviour {
    public float MovementSpeed;
    public bool Arrived;
    public float Cooldown;
    public bool Key;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement2();
        if (Key == true)
        {
            print("TRUE");
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Character")
        {
            Arrived = true;
        }
    }

    void Movement2()
    {

        if (Arrived == true && Key == true)
        {
            this.transform.Translate(Vector3.up * MovementSpeed * Time.deltaTime);
            Cooldown = Cooldown - 1 * Time.deltaTime;
            if (Cooldown <= 0)
            {
                Arrived = false;
            }
        }
    }
}
