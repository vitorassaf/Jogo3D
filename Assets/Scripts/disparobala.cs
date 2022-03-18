using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparobala : MonoBehaviour
{
    Rigidbody forca;
    public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        forca = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        forca.AddForce(transform.forward * velocidade, ForceMode.Impulse);
    }
}
