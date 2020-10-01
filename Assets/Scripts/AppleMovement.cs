using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using Interfaces;
using UnityEngine;
/// <summary>
///   This class is for vertical movement funcionality
/// </summary>
public class AppleMovement : MonoBehaviour , IDownMovement
{
    [Header("Velocity in unity units")]
   
    private float velocity;
    [SerializeField]public float yOffsetsup;
    [SerializeField]public float yOffsetinf;
    
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        velocity=UnityEngine.Random.Range(1f,5f); 
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

   

    
    void Update()
    {
        MovimientoVertical();
        var position = transform.position;
        position =new Vector3(position.x, Mathf.Clamp(position.y, yOffsetinf, yOffsetsup) , position.z);
        transform.position = position;
    }
    
    public void MovimientoVertical()
    {
        transform.position += Vector3.down * (velocity * Time.deltaTime);
    }
}
