using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontuacao : MonoBehaviour
{
    private int quantidade = 0;
    
    void Start()
    {

    }

    
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "tesouro")
        {
            quantidade++;
            Destroy(other.gameObject);
            print("quantidade de itens: " + quantidade);
        }
    }
}
