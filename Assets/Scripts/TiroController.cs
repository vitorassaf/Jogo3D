using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroController : MonoBehaviour
{
    [SerializeField]
    private GameObject CanoDaArma;
    [SerializeField]
    private GameObject bala;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
           var b = Instantiate(bala, CanoDaArma.transform.position, CanoDaArma.transform.rotation);

            Destroy(b, 5);
        }
        
    }
}
