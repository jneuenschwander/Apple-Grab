using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
/// <summary>
/// Esta clase se encarga de manejar la logica del juego y las propiedades  
/// </summary>
public class GameController : MonoBehaviour, IGameLogic
{
    public static GameController Instance;
    [SerializeField] private GameObject gameOverText;
    [SerializeField] private GameObject gameWinText;
    public int minutos; 
    public Jugador jugador = new Jugador();
    public float timeRemaining;
    [SerializeField]private int puntosGanar = 100;

    public int PuntosGanar
    {
        get => puntosGanar;
        set => puntosGanar = value;
    }

    [SerializeField] private int cantidadManzanas;
    public bool isDead = false;
    


    public int CantidadManzanas
    {
        get => cantidadManzanas;
        set => cantidadManzanas = value;
    }



    private void Awake()
    {
        
        timeRemaining=UnityEngine.Random.Range(180000, 300000);
        if (GameController.Instance == null) // control donde nos aseguramos que solo exista un instacia singleton
        {
            GameController.Instance = this; 
        }else if (GameController.Instance != this)
        {
            Destroy(gameObject);
            Debug.LogWarning("GameController a sido instanciado por segunda vez, evento ilegal.");
        }
        
    }
    

    // Update is called once per frame
    void Update()
    {
        Ganar();
        Perder();
        /*if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            isDead = true;
        }*/
        if (isDead && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // control para reiniciar el juego
        }
        
    }

    public void Ganar()
    {
        
        if (jugador.Puntuacion >= puntosGanar)
        {
            isDead = true;
            gameWinText.SetActive(enabled);
            if (isDead && Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name); // control para reiniciar el juego
            }
        }
    }

    public void Perder()
    {
        if (jugador.Vida <= 0)
        {
            isDead = true;
            gameOverText.SetActive(enabled);
            if (isDead && Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name); // control para reiniciar el juego
            }
        }
    }
}
