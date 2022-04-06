using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public Text VelocidadeHelicetxt;
    public Text VelocidadeAviao;

    [Header("Combustivel")]
    public float gasolina;
    private bool QueimaCombustivel;
    private Rigidbody rig;
    public GameObject jogador;
    public Text gasolinatxt;
    public Scrollbar scrollbar;

    [Header("Alvo")]
    public int Pontuacao = 6;
    public Text alvotxt;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        gasolinatxt.text = "Gasolina: "       + gasolina;
        VelocidadeAviao.text = "velocidade: " + velocidade;
        VelocidadeHelicetxt.text = "Helice: " + velocidadeInicialHelice;
        alvotxt.text = "Alvos: " + Pontuacao + "/6";

        if(ligado)
        {
            if (giraHelice())
            {
                movimento();
            }
        }

        if(QueimaCombustivel)
        {
            Motorativado();
        }
        
        if(gasolina <= 0)
        {
            rig.useGravity = true;
            gasolina = 0;

        }
    }

    private void Motorativado()
    {
        gasolina--;
        scrollbar.size -= 0.001f;
        
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

            QueimaCombustivel = true;
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

  

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == jogador)
        {
            Debug.Log("entrou");
            jogador.SetActive(false);
            ligado = true;
            rig.isKinematic = false;
        }
        if (other.gameObject.tag == "Alvo")
        {
            Destroy(other.gameObject);
            Pontuacao--;

        }

    }
}
