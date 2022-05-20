using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixerSom : MonoBehaviour
{
    public float somDirab;
    public float somVitor;

    public AudioMixer AudioMixer;

    void Start()
    {
        
    }

   
    void Update()
    {
        //AudioMixer.GetFloat("VolumeDirab", out somDirab);
        //AudioMixer.GetFloat("VolumeVitor", out somVitor);
        AudioMixer.SetFloat("VolumeDirab", somDirab);
        AudioMixer.SetFloat("VolumeVitor", somVitor);
    }
}
