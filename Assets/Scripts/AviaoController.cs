using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AviaoController : MonoBehaviour
{

    [Header("Hélice")]
    public Transform helice;
    public float velocidadeheliceMaxima;
    public float velocidadeInicialHelice = 1;

    [Header("Input avião")]
    public KeyCode Acelerar;
    public KeyCode Frear;
    public KeyCode ParaCima;
    public KeyCode ParaBaixo;
    public KeyCode esquerda;
    public KeyCode direita;
    public bool ligado;
    public float velocidade;
    public float fatorGiro;


    void Start()
    {
        
    }

    
    void Update()
    {

        if(ligado)
        {
            if (giraHelice())
            {
                movimento();
            }
        }

        
        
    }

    private void movimento()
    {

        float movZ = 0;
        float movX = 0;
        #region aceleração
        if (Input.GetKey(Acelerar))
        {
            velocidade += 0.005f;
            velocidadeheliceMaxima++;
        }
        if (Input.GetKey(Frear))
        {
            velocidade-= 0.010f;
            if (velocidade < 0)
            {
                velocidade = 0;
                velocidadeInicialHelice--;
            }
        }

        #endregion

        
        
        if(velocidadeInicialHelice >= 1000)
        {
            if (Input.GetKey(esquerda))
            {
                movZ = 1;
            }
            if (Input.GetKey(direita))
            {
                movZ = -1;
            }
            if (Input.GetKey(ParaCima))
            {
                movX = 1;
            }
            if (Input.GetKey(ParaBaixo))
            {
                movX = -1;
            }
        }
        

        transform.Rotate(new Vector3(movX * fatorGiro, 0, movZ * fatorGiro));

        transform.Translate(Vector3.forward * velocidade);
        
    }

    public bool giraHelice()
    {


        if(velocidadeInicialHelice <= velocidadeheliceMaxima)
        {
            velocidadeInicialHelice++;
        }
        helice.Rotate(new Vector3(0, 1 * velocidadeInicialHelice * Time.deltaTime,0));

        if (velocidadeInicialHelice > 500)
            return true;
        else
            return false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name =="Jogador")
        {
            collision.gameObject.SetActive(false);
            ligado = true;
        }
    }
}
