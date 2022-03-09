using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentobola : MonoBehaviour
{
    public float movX;
    public float movZ;
    public float movy;
    public float velocidade;
    public float PuloVelocidade;
    Rigidbody fisica;
    public bool CheckBoost;
    public float tempo;
    public Transform destino;

    public KeyCode ParaFrente;
    public KeyCode ParaTras;
    public KeyCode esquerda;
    public KeyCode direita;
    public KeyCode pulo;

    bool podePular = false;
    
    void Start()
    {
        fisica = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        #region 1 maneira de pegar o valor do jogador
        //movX = Input.GetAxis("Horizontal");
        //movZ = Input.GetAxis("Vertical");
        #endregion

        #region 2 maneira de pegar o valor do jogador
        if(Input.GetKey(ParaFrente))
        {
            movZ = 1;
        }
        if (Input.GetKey(ParaTras))
        {
            movZ = -1;
        }
        if (Input.GetKey(esquerda))
        {
            movX = -1;
        }
        if (Input.GetKey(direita))
        {
            movX = 1;
        }
        
        #endregion

        Vector3 move = new Vector3(movX * Time.deltaTime,0,movZ * Time.deltaTime);
        #region 1 forma de movimento
        //transform.Translate(move * velocidade);
        #endregion

        #region 2 forma de movimento
        fisica.AddForce(move * velocidade);
        if(CheckBoost)
        {
            tempo -= Time.deltaTime;
            Debug.Log(tempo);
            fisica.AddForce(move * velocidade * 10);
            if (tempo <= 0)
            {
                fisica.AddForce(move * velocidade);
                tempo = 0;
                CheckBoost = false;
            }

        }
        else if(!CheckBoost)
        {
            if(tempo <= 0)
            {
                tempo = 10;
            }
        }

        #endregion

        #region 3 forma de movimento
        //fisica.velocity = move * velocidade;
        #endregion

        #region pulo da bolinha
        if (Input.GetKeyDown(pulo) && podePular)
        {
            fisica.AddForce(Vector3.up * PuloVelocidade, ForceMode.Impulse);
        }
        #endregion

    
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Chao")
        {
            podePular = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Chao")
        {
            podePular = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PortalA")
        {
            transform.position = destino.transform.position;
        }
        if (other.tag == "boost")
        {
            CheckBoost = true;
        }

        
    }

   
}
