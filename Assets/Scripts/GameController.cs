using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class GameController : MonoBehaviour, IGameLogic
{
    public static GameController Instance;
    [SerializeField] private GameObject gameOverText;
    [SerializeField] private GameObject ProgresoText;
    [SerializeField] private GameObject VidaText;
    public int minutos; 
    public Jugador jugador = new Jugador();
    private Timer tiempo = new Timer();
    [SerializeField]private int puntosGanar = 100;
    [SerializeField] private int cantidadManzanas;
    public bool isDead = false;
    
    public Timer Tiempo
    {
        get => tiempo;
        set => tiempo = value;
    }

    public int CantidadManzanas
    {
        get => cantidadManzanas;
        set => cantidadManzanas = value;
    }



    private void Awake()
    {
        minutos =UnityEngine.Random.Range(180000, 300000);
        
        if (GameController.Instance == null) // control donde nos aseguramos que solo exista un instacia singleton
        {
            GameController.Instance = this; 
        }else if (GameController.Instance != this)
        {
            Destroy(gameObject);
            Debug.LogWarning("GameController a sido instanciado por segunda vez, evento ilegal.");
        }
        
    }



    // Start is called before the first frame update
    void Start()
    {
        //tiempo.Interval = minutos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Ganar()
    {
        if (jugador.Puntuacion >= puntosGanar)
        {
            isDead = true;
            Debug.Log("Haz ganado!!");
            
        }
    }

    public void Perder()
    {
        if (jugador.Vida <= 0)
        {
            isDead = true;
        }
    }
}
