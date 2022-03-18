using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenarioController : MonoBehaviour
{
    public Transform agua;
    public Transform jogador;
    public Color cordaAgua;
    public Color CorDoCeu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(jogador.position.y < agua.position.y)
        {
            RenderSettings.fogDensity = 0.1f;
            RenderSettings.fogColor = cordaAgua;
        }
        else
        {
            RenderSettings.fogDensity = 0.02f;
            RenderSettings.fogColor = CorDoCeu;
        }
    }
}
