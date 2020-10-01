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
    public int minutos = UnityEngine.Random.Range(180000, 300000);
    public Jugador jugador = new Jugador();
    private Timer tiempo = new Timer();
    private int puntosGanar = 100;
    private int cantidadManzanas = 20;
    
    
    public Timer Tiempo
    {
        get => tiempo;
        set => tiempo = value;
    }
    private void Awake()
    {
        
        
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
        tiempo.Interval = minutos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Ganar()
    {
        //TODO
        throw new System.NotImplementedException();
    }

    public void Perder()
    {
        //TODO
        throw new System.NotImplementedException();
    }
}
