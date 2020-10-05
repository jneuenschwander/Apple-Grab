using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIChanges : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI progresoText;
    [SerializeField] private TextMeshProUGUI  vidaText;
    // Start is called before the first frame update
    void Start()
    {
        progresoText.text = "Progreso: " + GameController.Instance.jugador.Puntuacion + "/" +
                            GameController.Instance.PuntosGanar;
        vidaText.text = "Vida: " + GameController.Instance.jugador.Vida;

    }

    // Update is called once per frame
    void Update()
    {
        progresoText.text = "Progreso: " + GameController.Instance.jugador.Puntuacion + "/" +
                                           GameController.Instance.PuntosGanar;
        vidaText.text = "Vida: " + GameController.Instance.jugador.Vida;
    }
}
