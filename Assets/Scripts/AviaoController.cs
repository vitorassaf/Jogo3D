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
   

    public Text VelocidadeHelicetxt2;
    public Text VelocidadeAviao2;

    [Header("Combustivel")]
    public float gasolina;
    private bool QueimaCombustivel;
    private Rigidbody rig;
    public GameObject jogador;
    public Text gasolinatxt;
    public Slider Slider;

    public Text gasolinatxt2;
    public Slider Slider2;

    [Header("Alvo")]
    public int Pontuacao = 6;
    public Text alvotxt;
    public Text alvotxt2;

    [Header("som")]
    public AudioSource somaviao;
    public AudioSource somaviao2;
    public AudioClip iniciando;
   

    

    void Start()
    {
        rig = GetComponent<Rigidbody>();
        
    }

    
    void Update()
    {
        gasolinatxt.text = gasolina.ToString("F1");
        VelocidadeAviao.text = "velocidade: " + velocidade.ToString("F2");
        VelocidadeHelicetxt.text = "Helice: " + velocidadeInicialHelice;
        alvotxt.text = "Alvos: " + Pontuacao + "/6";

        gasolinatxt2.text = gasolina.ToString("F1");
        VelocidadeAviao2.text = "velocidade: " + velocidade.ToString("F2");
        VelocidadeHelicetxt2.text = "Helice: " + velocidadeInicialHelice;
        alvotxt2.text = "Alvos: " + Pontuacao + "/6";

        if (ligado)
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
            velocidadeInicialHelice = 100;
                

        }
    }

    private void Motorativado()
    {
        gasolina -= Time.deltaTime;
        Slider.value -= Time.deltaTime/30;
        Slider2.value -= Time.deltaTime / 30;

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
            somaviao.PlayOneShot(iniciando);

        }
        if (other.gameObject.tag == "Alvo")
        {
            Destroy(other.gameObject);
            Pontuacao--;

        }

        if (other.gameObject.tag == "Gasolina")
        {
            gasolina = 30;
            Destroy(other.gameObject);
            Slider.value = 1;
        }

    }
}
