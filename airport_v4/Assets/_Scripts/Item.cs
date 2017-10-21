using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public int speed = 5;
    public int id;
    public bool banned = false;
    public bool inMotion = false;
  
 
    private Rigidbody rb; 

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        
    }

    void toggleMove()
    {
        if (!inMotion)
        {
            inMotion = true;
        }
            

    }
}
