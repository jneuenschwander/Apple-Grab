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
    [SerializeField]public float xOffsetleft;
    [SerializeField]public float xOffsetright; 
    private Rigidbody2D _rigidbody2D;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();  // En caso de que quiera probar movimiento por fuerza
    }
    void Update()
    {
        Moverse(); //movimiento
        var position = transform.position;
        position =new Vector3(Mathf.Clamp(position.x, xOffsetleft, xOffsetright), position.y , position.z);
        transform.position = position;
        
    }

    public void Moverse()
    {
        if (this.transform.position.x >= -6.65 || this.transform.position.x <= 6.65)
        {
            if (Input.GetKey(leftControl))
            {
                transform.Translate(velocity, 0f, 0f);
            }
            else if (Input.GetKey(rightControl))
            {
                transform.Translate(-velocity, 0f, 0f);
            }
        }
    }


}
