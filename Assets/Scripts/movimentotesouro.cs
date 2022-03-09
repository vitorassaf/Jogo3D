using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentotesouro : MonoBehaviour
{
    public Vector3 girar;
    void Start()
    {
        
    }

  
    void Update()
    {
        transform.Rotate(girar);
    }
}
