using UnityEngine;
using System;

public class Dropper : MonoBehaviour
{
    public float repeatRate = 1;
    public GameObject ballPrefab;

	
	void Start()
    {
        InvokeRepeating(nameof(Drop),0, repeatRate);
    }

    void Drop() 
    {
		//Instanciamos el objeto original ballPrefab en la posicion dada, con rotacion 0.
		//Guardamos la bola instanciada en ball, aunque no hagamos nada con ella.
		GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);
	}
}

    
   
	

	
	
	

	

	
   
