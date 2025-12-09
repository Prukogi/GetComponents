using Mono.Cecil;
using System;
using System.IO;
using System.Runtime.Serialization.Json;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.WSA;

public class DataController : MonoBehaviour
{
	//struct
	[System.Serializable]
	public struct DataBucket
	{
		public int explosionCount;
		public int spawnCount;
		public int collisionCount;

		public void Save(String path) // Metodo para guardar el struct en un archivo
		{
			string jsonString = JsonUtility.ToJson(this); // Convierte el struct a JSON
			File.WriteAllText(path, jsonString); // Escribe el JSON en un archivo
		}
	}
	//Attributes
	public DataBucket bucket;
	
	//Methods
	void Start()
	{
		bucket.explosionCount = 0;
		bucket.spawnCount = 0;
		bucket.collisionCount = 0;
	}

	private void OnDestroy() 
	{
		// Carpeta Assets/Data dentro del proyecto
		string folder = Path.Combine(UnityEngine.Application.dataPath, "Data");

		// Si no existe, la creamos
		if (!Directory.Exists(folder))
			Directory.CreateDirectory(folder);

		// Ruta final del archivo
		string path = Path.Combine(folder, "data.txt");

		// Guardar
		bucket.Save(path);

		Debug.Log("Archivo guardado en: " + path);
	}
	public void SendData(KPIType dataType)
	{
		switch (dataType)
		{
			case KPIType.CollisionKPI:
				bucket.collisionCount++;
				break;
			case KPIType.SpawnedBallKPI:
				bucket.spawnCount++;
				break;
			case KPIType.ExplosionsKPI:
				bucket.explosionCount++;
				break;
		}
	}
}










