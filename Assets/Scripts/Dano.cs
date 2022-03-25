using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dano : MonoBehaviour
{
    public int dano = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dano >= 3)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "bullet")
        {
            dano++;
            

        }
    }
}
