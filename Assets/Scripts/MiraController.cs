using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiraController : MonoBehaviour
{
    [Header("Laser")]
    public GameObject MiraLaser;
    public KeyCode HabilitaLaser;
    [Header("Lanterna")]
    public GameObject Lanterna;
    public KeyCode HabilitaLanterna;
    [Header("Luneta")]
    public Camera CameraLuneta;
    
    [Header("Entrar no Heli")]
    public GameObject Heli;
    public GameObject Heli2;
    public GameObject Heli3;
    public GameObject Heli4;
    public KeyCode EnterHeli;

    bool LanternaHabilitado = false;
    bool LaserHabilitado = false;
    bool HeliHabilitado = false;
    bool LunetaHabilitado = false;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(HabilitaLaser))
        {
            LaserHabilitado = !LaserHabilitado;
            if(LaserHabilitado)
            {
                MiraLaser.SetActive(true);
            }
            else
            {
                MiraLaser.SetActive(false);
            }
        }

        if (Input.GetKeyDown(HabilitaLanterna))
        {
            LanternaHabilitado = !LanternaHabilitado;
            if (LanternaHabilitado)
            {
                Lanterna.SetActive(true);
            }
            else
            {
                Lanterna.SetActive(false);
            }
        }

        if (Input.GetKeyDown(EnterHeli))
        {
            HeliHabilitado = !HeliHabilitado;
            if (HeliHabilitado)
            {
                Heli.SetActive(true);
                Heli2.SetActive(true);
                Heli3.SetActive(true);
                Heli4.SetActive(false);
            }
            else
            {
                Heli.SetActive(false);
            }
        }

       
        if(Input.GetMouseButtonDown(1))
        {
            LunetaHabilitado = !LunetaHabilitado;
            if(LunetaHabilitado)
            {
                CameraLuneta.depth = 2;
            }
            else
            {
                CameraLuneta.depth = 0;
            }
            
        }
    }
}
