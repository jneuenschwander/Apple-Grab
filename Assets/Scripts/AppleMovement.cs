using System.Collections;
using System.Collections.Generic;
using Interfaces;
using UnityEngine;
/// <summary>
///   This class is for vertical movement funcionality
/// </summary>
public class AppleMovement : MonoBehaviour , IDownMovement
{
    [Header("Velocity in unity units")]
    //TODO
    //Speed must be randomize
    //
    [SerializeField]private float velocity = 5f;
    private Rigidbody2D _rigidbody2D;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        MovimientoVertical();
    }

    
    void Update()
    {
    }
    
    public void MovimientoVertical()
    {
        if (!_rigidbody2D.Equals(null))
            _rigidbody2D.AddForce(Vector2.down * velocity, ForceMode2D.Force);
        else
        {
            Debug.LogWarning("El objeto no tiene rigidbody!!!");
        }
    }
}
