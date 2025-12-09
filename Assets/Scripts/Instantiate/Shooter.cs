using UnityEngine;
using System;

public class Shooter : MonoBehaviour
{
	[Header("Movement")]
	public float SpeedRotation = 100;

	[Header("Shoot")]
	public Ball ballPrefab;
	public Transform spawnPoint;
	public float shootForce = 1000;


	private Quaternion initialRotation;
	private void Awake()
	{
		initialRotation = transform.rotation;
	}
	private void Start()
	{
		Invoke(nameof(InitialConfiguration), 0.1f);
		Cursor.lockState = CursorLockMode.Confined; //Lock cursor to game window
		Cursor.lockState = CursorLockMode.Locked; // Lock cursor to center of game window
	}


	void Update()
	{
		//Movement
		transform.Rotate(Input.GetAxis("Mouse Y") * Time.deltaTime * SpeedRotation * Vector3.left);
		transform.Rotate(Input.GetAxis("Mouse X") * Time.deltaTime * SpeedRotation * Vector3.up);
		transform.localRotation = Quaternion.Euler(transform.localRotation.eulerAngles.x, transform.localRotation.eulerAngles.y, 0); //Clamp Rotation Z to 0

		//Spawn & AddForce
		if (Input.GetMouseButtonUp(0))
		{
			Ball ball = Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
			ball.myRigidbody.AddForce(transform.forward * shootForce);
		}
	}
	void InitialConfiguration()
	{
		transform.rotation = initialRotation;
	}
}



















