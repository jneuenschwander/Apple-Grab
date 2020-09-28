using System.Collections;
using System.Collections.Generic;
using Interfaces;
using UnityEngine;
/// <summary>
///  This class is only for moving de basket alone the x axis
/// </summary>
public class BasketMovement : MonoBehaviour , IAxisMovement
{
    [Header("Velocity in unity units")]
    [SerializeField]private float velocity = 5f;
    [Header("Controles para el game pad:")]
    [SerializeField] private KeyCode rightControl = KeyCode.A;
    [SerializeField] private KeyCode leftControl = KeyCode.D;
    void Start()
    {
    }
    void Update()
    {
        Moverse();
    }

    public void Moverse()
    {
        if (Input.GetKey(leftControl))
        {
            transform.Translate(velocity, 0f, 0f);
        } else if (Input.GetKey(rightControl))
        {
            transform.Translate(-velocity, 0f, 0f);
        }
    }


}
