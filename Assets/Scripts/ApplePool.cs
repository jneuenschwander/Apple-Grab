using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ApplePool : MonoBehaviour, ISpawn
{
    
    public GameObject manzanaPrefab; 
    public GameObject manzanaDoradaPrefab;
    public GameObject manzanaPordridaPrefab;
    private GameObject[] manzanas;
    private float timeSinceLastSpawned;
    private int currentApple;
    public float spawnYposition = 8f;
    [SerializeField]public float spawnRate;
    [SerializeField]private Vector2 objectPoolPosition = new Vector2(8,8);
    
    void Start()
    {
        
        GenerarColeccionObj();
    }

    
    void Update()
    {
        
        if (!GameController.Instance.isDead)
        {
            Aparecer();
        }
        else
        {
            manzanas = null;
            GC.Collect();
        }
            
    }

    public void Aparecer()
    {
        //TODO 
        // Revisar stackoverflow de objetos
        
      
        timeSinceLastSpawned += Time.deltaTime; // diferencia entre el comienzo del juego y el momento actual desde el comienzo de ejecucion
        
        if (GameController.Instance.isDead == false && timeSinceLastSpawned >= spawnRate)// mientras el juego este activo y el tiempo sea mayor a la ultima vez que se creo una columna
        {
            timeSinceLastSpawned = 0; // ponemos 0 para evitar ejecutar la condicion mas de una vez
            float spawnXposition = UnityEngine.Random.Range(-6f, 6f);
            manzanas[currentApple].transform.position = new Vector2(spawnXposition, spawnYposition);
            currentApple++; 
            if (currentApple >= GameController.Instance.CantidadManzanas)
            {
                currentApple = 0;// si es mayor al numero de la coleccion reseamos el contador
            }
        }
    }

    public void GenerarColeccionObj()
    {
        int probabilidad;
        int n = GameController.Instance.CantidadManzanas;
        timeSinceLastSpawned = 0f;
        manzanas = new GameObject[n]; // se asigna la coleccion en memoria
        for (int i = 0; i < n; i++) //iteramos dentro de la coleccion
        {
            probabilidad = Random.Range(0, 100);
            if (probabilidad > 45)
            {
                manzanas[i] = (GameObject) Instantiate(manzanaPrefab, objectPoolPosition, Quaternion.identity);
            }
            else if (probabilidad <= 10)
            {
                manzanas[i] = (GameObject) Instantiate(manzanaPordridaPrefab, objectPoolPosition, Quaternion.identity);
            }else if (probabilidad <= 30)
            {
                manzanas[i] = (GameObject) Instantiate(manzanaDoradaPrefab, objectPoolPosition, Quaternion.identity);
            }
                
        
        
            
        }
    }
}
