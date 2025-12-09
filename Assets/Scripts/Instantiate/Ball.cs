using UnityEngine;
using System;

public class Ball : MonoBehaviour
{
	[System.NonSerialized]
    public Rigidbody myRigidbody;

	public DataKPI kpiData;
	private void Awake()
	{
		myRigidbody = GetComponent<Rigidbody>();
	}
		

	private void OnCollisionEnter(Collision collision)
	{
		if(kpiData != null)
			kpiData.SendData();
	}
}
    
        
	

	

	
   
    

	

	
	
