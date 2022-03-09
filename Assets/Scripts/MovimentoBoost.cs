using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoBoost : MonoBehaviour
{
    public Vector3 Rotacao;
    void Start()
    {

    }


    void Update()
    {
        transform.Rotate(Rotacao);
    }
}
