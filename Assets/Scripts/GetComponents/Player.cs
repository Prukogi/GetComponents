using UnityEngine;
using System;

public class Player : MonoBehaviour
{
	public float headForce = 100f;
    private Body body;
    private Head head;

	

	
	
	void Start()
    {
        body = GetComponentInChildren<Body>(true);
		head = GetComponentInChildren<Head>(true);
		head.GetComponent<Rigidbody>();

		body.gameObject.SetActive(true);
		head.gameObject.SetActive(true);
	}

    
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space))
			head.AddForce(500);
		

		body.transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 5, 0, Input.GetAxis("Vertical") * Time.deltaTime * 5);
    }

	private void FixedUpdate()
	{
		Vector3 headDirection = body.transform.position - head.transform.position;
		head.myRigidbody.AddForce(headDirection * headForce);
	}
		




}
