using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TiroController : MonoBehaviour
{
    [SerializeField]
    private GameObject CanoDaArma;
    [SerializeField]
    private GameObject bala;

    public Text Municao;

    [Header("Munição")]
    public GameObject SacoDeMunicao;
    private int QuantidadeDeBalas = 10;



    private AudioSource Som;
    public AudioClip Tiro;
    public AudioClip Recarregar;
    void Start()
    {
        Som = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (QuantidadeDeBalas >= 1)
            {
                var b = Instantiate(bala, CanoDaArma.transform.position, CanoDaArma.transform.rotation);

                Destroy(b, 5);


                Som.clip = Tiro;
                Som.PlayOneShot(Tiro);

                QuantidadeDeBalas--;
            }

        }

        Municao.text = "Munição: " + QuantidadeDeBalas;

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == SacoDeMunicao)
        {
            QuantidadeDeBalas += 10;
            Destroy(SacoDeMunicao);
            Som.clip = Recarregar;
            Som.PlayOneShot(Recarregar);
        }
    }
}