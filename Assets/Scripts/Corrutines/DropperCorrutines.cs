using UnityEngine;
using System;
using System.Collections;

public class DropperCorrutines : MonoBehaviour
{
	public GameObject ballPrefab;
	public float minRange = 0;
	public float maxRange = 2;
	
	
	private MyArray myArray;
	private Listas myListas;

	private void Awake()
	{
		myArray = GetComponent<MyArray>();
		myListas = GetComponent<Listas>();
	
	}
	void Start()
	{
		float repeatRate = UnityEngine.Random.Range(minRange, maxRange);
		StartCoroutine(Drop(repeatRate));
	}

	IEnumerator Drop(float rateTime)
	{
		//Espera de un frame
		//yield return null;

		while (true)
		{
			yield return new WaitForSeconds(rateTime);
			//Solo el 33% de las veces se intancian.
			float probability = UnityEngine.Random.Range(0, 3);
			if (probability == 0)
			{ 
				GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);
				//Si el componente existe
				if (myArray != null)
					myArray.AddObject(ball);
				if (myListas != null)
					myListas.AddObject(ball);
			}
		}
	}
}


















