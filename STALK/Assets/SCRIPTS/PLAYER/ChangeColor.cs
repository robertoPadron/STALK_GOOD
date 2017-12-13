using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {
    public bool Inside = false;
    public bool Press = false;
    public static bool DoOne = false;
    public static int ChanceLimit = 3;
    public static int NumChance;
    

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
   
    }
    
    void OnTriggerStay(Collider other)
    {
        Renderer CharacterMaterial = other.gameObject.GetComponent<Renderer>();
        Renderer PlatformMaterial = this.gameObject.GetComponent<Renderer>();

        if (Input.GetButtonDown("Fire1") & other.tag == "Character" & NumChance < ChanceLimit & CharacterMaterial.sharedMaterial != PlatformMaterial.sharedMaterial)
        {
            Press = true;
            //print("Pressed");
            DoOne = true;
        }

        if (other.tag == "Character")
        {
            Inside = true;
            //print("In");


            if (Inside & Press & DoOne == true) 
            {
   
                //print("Now you can");
                CharacterMaterial.material = PlatformMaterial.material;
                NumChance = NumChance + 1;
                print(NumChance);
                DoOne = false;


            }
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        Press = false;
        Inside = false;
        //print("Out");
        
    }
}
