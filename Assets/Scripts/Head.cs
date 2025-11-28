using UnityEngine;
using System;

[RequireComponent(typeof(Rigidbody))]
public class Head : MonoBehaviour
{
	[System.NonSerialized]
	public Rigidbody myRigidbody;

	private void Awake()
	{
		myRigidbody = GetComponent<Rigidbody>();
	}

	void Start()
	{
		print("hello " + name);
	}
	public void AddForce(float force) 
    {
        GetComponent<Rigidbody>().AddForce(0, 500, 0);
    }


}

    

	

	
	
	

	

	
   
