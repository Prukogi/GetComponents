using UnityEngine;
using System;

public enum KPIType 
{ 
	CollisionKPI = 0,
	SpawnedBallKPI = 1,
	ExplosionsKPI = 2
}

public class DataKPI : MonoBehaviour
{
	public KPIType customKPI;

	private DataController dataController;
	private void Awake()
	{
		dataController = FindFirstObjectByType<DataController>();
	}
	public void SendData() 
	{
		Debug.Log("Sending data " + customKPI);
		dataController.SendData(customKPI);
	}
}

	

	

	

	
   
