using UnityEngine;
using System;

public class MyArray : MonoBehaviour
{

	public string[] daysArray =
	{
		"Lunes",
		"martes",
		"miercoles",
		"etc"
	};

	public GameObject[] objectArray = new GameObject[5];
	public GameObject[] objectArrayInspector; 

	private int index = 0;
	private int indexInspector = 0;
	public void AddObject(GameObject newObject)
	{
		// Control de errores, para evitar insertar un elemento fuera del tamaño del array
		if (index < objectArray.Length)
		{
			objectArray[index] = newObject;
			index++;
		}
		// Control de errores, para evitar insertar un elemento fuera del tamaño del array
		if (indexInspector < objectArray.Length)
		{
			objectArrayInspector[indexInspector] = newObject;
			indexInspector++;
		}
	}
}


    

	


	


	

	
   
