using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVEMENT : MonoBehaviour {
    public float MovementSpeed;
    public float Rotation;
    public bool Arrived = false;
    public float Cooldown = 20f;
    public float RightPosition; // antes estaba a 7 
    public float LeftPosition; // antes estaba a -8
    public bool Detected;
    public float Charge;
    float SecondCharge;
    public Transform PlayerPosition;
    public GameObject Bullet;
    public GameObject Character;
    public bool Axis = false;


    // Use this for initialization
    void Start () {
      
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMovement();
        Detection();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Character")
        {
            Destroy(Character.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Character")
        {
            Detected = true;
        }
    }











    void Detection()
    {
        if (Detected == true)
        {
             transform.LookAt(PlayerPosition);
        }
    }
    void EnemyMovement()
    {
       
            this.transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);
       

        if (this.transform.position.x >= RightPosition & Arrived == false & Axis == false)
        {
            Rotation = 20f;
            this.transform.Rotate(Vector3.up * Rotation * Time.deltaTime);
            Cooldown = Cooldown - 1 * Time.deltaTime;
            MovementSpeed = 0;
            if (Cooldown <= 0)
            {
                Cooldown = 9f;
                MovementSpeed = 3f;
                Arrived = true;
                Rotation = 0f;
            }
        }
        if (this.transform.position.x <= LeftPosition & Arrived == true & Axis == false)
        {
            MovementSpeed = 0;
            Rotation = 20f;
            this.transform.Rotate(Vector3.up * Rotation * Time.deltaTime);
            Cooldown = Cooldown - 1 * Time.deltaTime;
            if (Cooldown <= 0)
            {
                Rotation = 0;
                MovementSpeed = 3f;
                Cooldown = 9f;
                Arrived = false;
            }

        }


        if (this.transform.position.z >= RightPosition & Arrived == false & Axis == true)
        {
            Rotation = 20f;
            this.transform.Rotate(Vector3.up * Rotation * Time.deltaTime);
            Cooldown = Cooldown - 1 * Time.deltaTime;
            MovementSpeed = 0;
            if (Cooldown <= 0)
            {
                Cooldown = 9f;
                MovementSpeed = 3f;
                Arrived = true;
                Rotation = 0f;
            }
        }
        if (this.transform.position.z <= LeftPosition & Arrived == true & Axis == true)
        {
            MovementSpeed = 0;
            Rotation = 20f;
            this.transform.Rotate(Vector3.up * Rotation * Time.deltaTime);
            Cooldown = Cooldown - 1 * Time.deltaTime;
            if (Cooldown <= 0)
            {
                Rotation = 0;
                MovementSpeed = 3f;
                Cooldown = 9f;
                Arrived = false;
            }

        }
    }
}


