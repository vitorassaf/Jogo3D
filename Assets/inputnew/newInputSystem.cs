using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class newInputSystem : MonoBehaviour
{

    public Vector2 ValorInput;
    public float valorPulo;

    InputSystemManager Manual;

    private void Awake()
    {
        Manual = new InputSystemManager();
    }

    private void OnEnable()
    {
        Manual.Enable();
    }

    private void OnDisable()
    {
        Manual.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Manual.Jogador.Jump.ReadValue<float>();
    }
    public void mover(CallbackContext context)
    {
        //Debug.Log("apertou a tecla" + context.control.displayName);
        ValorInput = context.ReadValue<Vector2>();
        if(context.started)
        {
            Debug.Log("Started: " + context.control.displayName);
        }
        if (context.performed)
        {
            Debug.Log("Perfomed: " + context.control.displayName);
        }
        if (context.canceled)
        {
            Debug.Log("Canceled: " + context.control.displayName);
        }
    }
    
    public void pulo(CallbackContext context)
    {
        Debug.Log("pulou");
        valorPulo = context.ReadValue<float>();
    }
}
