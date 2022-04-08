using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAviaoController : MonoBehaviour
{
    public GameObject CameraPrimeiraPessoa;
    public GameObject CameraTerceiraPessoa;
    public GameObject CameraRetrovisor;
    public GameObject Minimapa;
    public KeyCode mapa;
    public AviaoController aviao;
    public KeyCode PrimeiraPessoa;
    bool Habilita1P = false;
    bool habilitaRetro = false;
    public KeyCode Retrovisor;
    public float tempoMapa;
    private bool tempo;
    
   
    void Start()
    {
        
    }

    void Update()
    {
        if(aviao.ligado)
        {
            CameraPrimeiraPessoa.SetActive(true);
            CameraTerceiraPessoa.SetActive(true);
            CameraRetrovisor.SetActive(true);
        }
        else
        {
            CameraPrimeiraPessoa.SetActive(false);
            CameraTerceiraPessoa.SetActive(false);
            CameraRetrovisor.SetActive(false);
        }
        trocaCamera();
        mostraRetrovisor();
        HabilitaMapa();
    }

  
    private void mostraRetrovisor()
    {
        if(Input.GetKeyDown(Retrovisor))
        {
            habilitaRetro = !habilitaRetro;

            if(habilitaRetro)
            {
                CameraRetrovisor.GetComponent<Camera>().depth = 2;
            }
            else
            {
                CameraRetrovisor.GetComponent<Camera>().depth = 0;
            }
        }
    }
    void trocaCamera()
    {
        if (Input.GetKeyDown(PrimeiraPessoa))
        {
            Habilita1P = !Habilita1P;
            if(Habilita1P)
            {
                CameraTerceiraPessoa.GetComponent<Camera>().depth = 0;
                CameraPrimeiraPessoa.GetComponent<Camera>().depth = 1;
                
            }
            else
            {
                CameraTerceiraPessoa.GetComponent<Camera>().depth = 1;
                CameraPrimeiraPessoa.GetComponent<Camera>().depth = 0;
            }
        }
    }

    void HabilitaMapa()
    {
        if(Input.GetKeyDown(mapa))
        {
            Minimapa.SetActive(true);
            tempo = true;

        }

        if(tempo)
        {
            tempoMapa += Time.deltaTime;
        }

        if(tempoMapa >= 5f)
        {
            Minimapa.SetActive(false);
            tempoMapa = 0;
            tempo = false;
        }
    }
}
