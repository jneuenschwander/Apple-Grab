using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePool : MonoBehaviour, ISpawn
{
    private Manzana manzana = new Manzana();   
    private Podrida manzanaPodrida = new Podrida(new Manzana());
    private Podrida manzanaDorada = new Podrida(new Manzana());
    public GameObject manzanaPrefab;
    private GameObject[] columns;
    private float timeSinceLastSpawned;
    public Vector2 objectPoolPosition = new Vector2(0, 0);
    private int currentColumn;
    
    //TODO
    //Declarar las variable para al posicion
    
    void Start()
    {
        GenerarColeccionObj();
    }

    
    void Update()
    {
        Aparecer();
    }

    public void Aparecer()
    {
        //TODO
        //programar la logica 
        timeSinceLastSpawned += Time.deltaTime; // diferencia entre el comienzo del juego y el momento actual desde el comienzo de ejecucion
        /*
        if (GameController.instance.GameOver == false && timeSinceLastSpawned >= spawnRate)// mientras el juego este activo y el tiempo sea mayor a la ultima vez que se creo una columna
        {
            
            timeSinceLastSpawned = 0; // ponemos 0 para evitar ejecutar la condicion mas de una vez
            
            float spawnYposition = Random.Range(columnMin, columnMax);// creamos una nueva posicion en y para spawnear
            
            columns[currentColumn].transform.position = new Vector2(spawnXposition, spawnYposition);// colocamos la columna en ese lugar
            
            currentColumn++; // cambiamos el indice para la proxima columna
            if (currentColumn >= columnPoolSize)
            {
                currentColumn = 0;// si es mayor al numero de la coleccion reseamos el contador
                
            }
        }*/
    }

    public void GenerarColeccionObj()
    {   
        //TODO
        //programar la logica 
        
        /*
        timeSinceLastSpawned = 0f;
        columns = new GameObject[columnPoolSize]; // se asigna la coleccion en memoria
        for (int i = 0; i < columnPoolSize; i++) //iteramos dentro de la coleccion
        { 
            columns[i] = (GameObject)Instantiate(columnPrefab, objectPoolPosition,Quaternion.identity); 
            // aqui se instancia los prefabs dentro del pull de columnas
            
        }*/
    }
}
