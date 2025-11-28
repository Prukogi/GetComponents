using UnityEngine;
using System;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(Rigidbody))]

public class GetComponents : MonoBehaviour
{
    public Color color;

	

	
	void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Return))
                GetComponent<MeshRenderer>().material.color = color;
		if (Input.GetKeyUp(KeyCode.Space))
		{ 
			GetComponentInChildren<Head>().transform.Translate(1, 0, 0);
			GetComponent<Rigidbody>().AddForce(0, 500, 0);
			GetComponentInChildren<Head>().AddForce(500);
			//GetComponentInChildren<MeshRenderer>().enabled = false;
			Camera.main.fieldOfView *= 2;
			Camera.main.transform.Translate(0, 0, 5);
		}


	}
	

	

	
   
}
