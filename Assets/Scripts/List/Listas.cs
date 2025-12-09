using UnityEngine;
using System;
using System.Collections.Generic;

public class Listas : MonoBehaviour
{
	public int limitObjects = 20;
	public List<GameObject> objectList = new List<GameObject>();
	public GameObject explosionPrefab;
	public DataKPI kpiExplosionData;
	public DataKPI kpiSpawnData;

	public void AddObject(GameObject ball)
	{
		//Añadimos el objeto a la lista
		objectList.Add(ball);

		//Control de explosiones
		if (objectList.Count > limitObjects) 
		{
			ExplosionAll();
		}
		//Data
		if (kpiSpawnData != null)
			kpiSpawnData.SendData();
	}
		
		

	private void ExplosionAll()
	{
		//for generico para recorrer listas
		for (int i = 0; i < objectList.Count; i++)
		{
			Destroy(objectList[i]);
			Instantiate(explosionPrefab, objectList[i].transform.position, Quaternion.identity);
			
		}
		//Vaciamos la lista
		objectList.Clear();
		//Data
		if (kpiExplosionData != null)
			kpiExplosionData.SendData();

	}

}

	











